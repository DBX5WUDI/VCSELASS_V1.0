//#define Console 
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace WindowsFormsApplication1
{
    public partial class NMRG_VCSEL : Form
    {
        private WMD wmd = new WMD();
        private Time t = new Time();
        private Key ky = new Key();
        private Vcsel vcsel = new Vcsel();
        private Photodetector PD = new Photodetector();
        private PID pid1 = new PID();

        private Single ControlBias;
        private Single GlobalAngle1 = 0;
        private Single GlobalAngle2 = 0;
        private BUTTON button;
        private WMD_STATE wmd_state;
        private MESSAGE_STATE message_state;
        private MESSAGE message;
        private bool MessageUpdateFlag;
        private bool rbcheck = false;
        private bool PClosedLoopFlag = false;
        private uint MessageCheckNum;
        private uint iGlobal = 0;
        private ushort ByteCount;
        private ushort MessageLength;
        private string[] s = new string[5];
        private System.Timers.Timer timer = new System.Timers.Timer(100);      //初始化定时器类

        public NMRG_VCSEL()             //构造函数
        {
            InitializeComponent();
            InitChart();
#if Console
            Console.ForegroundColor = ConsoleColor.Magenta;
#endif
            CheckForIllegalCrossThreadCalls = false;
            string[] ports = SerialPort.GetPortNames();             //初始化串口类
            Array.Sort(ports);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(theout); //到达时间的时候执行事件；
            timer.AutoReset = true;                                         //设置是执行一次（false）还是一直执行(true)；
            timer.Enabled = false;                                          //是否执行System.Timers.Timer.Elapsed事件；
            srlboBox.Items.Clear();
            srlboBox.Items.AddRange(ports);
            SetVcselSinep2pTxtBoxCurrent.Text = Convert.ToSingle(0.00).ToString("f6");
            SetVcselSinep2pTxtBox.Text = Convert.ToSingle(0.00).ToString("f6");
            SetVcselBiasTxtBox.Text = Convert.ToSingle(0.00).ToString("f6");
            SetVcselBiasTxtBoxCurrent.Text = Convert.ToSingle(0.00).ToString("f6");
            SetVcselSinefreTxtBox.Text = Convert.ToSingle(0.00).ToString("f6");
            message.data = new Byte[10];
        }
        private bool receiveFiniteStates(Byte data)
        {
            switch (message_state)
            {
                case MESSAGE_STATE.WAITING_FF1:
                    if (data == (Byte)0xff)
                    {
                        message_state = MESSAGE_STATE.WAITING_FF2;
                        MessageCheckNum = 0;
                        MessageLength = 0;
                        ByteCount = 0;
                        MessageCheckNum += data;
                    }
                    break;
                case MESSAGE_STATE.WAITING_FF2:
                    if (data == (Byte)0xff)
                    {
                        message_state = MESSAGE_STATE.SENDER_ID;
                        MessageCheckNum += data;
                    }
                    else
                        message_state = MESSAGE_STATE.WAITING_FF1;
                    break;
                case MESSAGE_STATE.SENDER_ID:
                    message.sender_id = data;
                    if (message.sender_id == (Byte)0x11)
                    {
                        message_state = MESSAGE_STATE.RECEIVER_ID;
                        MessageCheckNum += data;
                    }
                    else
                        message_state = MESSAGE_STATE.WAITING_FF1;
                    break;
                case MESSAGE_STATE.RECEIVER_ID:
                    message.receiver_id = data;
                    if (message.receiver_id == (Byte)0x01)
                    {
                        message_state = MESSAGE_STATE.RECEIVE_LEN_H;
                        MessageCheckNum += data;
                    }
                    else
                        message_state = MESSAGE_STATE.WAITING_FF1;
                    break;
                case MESSAGE_STATE.RECEIVE_LEN_H:
                    message_state = MESSAGE_STATE.RECEIVE_LEN_L;
                    MessageCheckNum += data;
                    MessageLength |= (ushort)(data << 8);
                    break;
                case MESSAGE_STATE.RECEIVE_LEN_L:
                    message_state = MESSAGE_STATE.RECEIVE_PACKAGE;
                    MessageCheckNum += data;
                    MessageLength |= (ushort)(data);
                    message.length = MessageLength;
                    if(MessageLength>20) message_state = MESSAGE_STATE.WAITING_FF1;//提高串口通讯稳定性，关键语句
                    break;
                case MESSAGE_STATE.RECEIVE_PACKAGE:
                    MessageCheckNum += data;
                    message.data[ByteCount++] = data;
                    if (ByteCount >= MessageLength)
                    {
                        message_state = MESSAGE_STATE.RECEIVE_CHECK;
                        MessageCheckNum = MessageCheckNum % 255;
                    }
                    break;
                case MESSAGE_STATE.RECEIVE_CHECK:
                    if (data == (Byte)MessageCheckNum)
                    {
                        message_state = MESSAGE_STATE.WAITING_FF1;
                        MessageCheckNum = 0;
                        return true;
                    }
                    else
                    {
                        message_state = MESSAGE_STATE.WAITING_FF1;
                    }
                    break;
                default:
                    message_state = MESSAGE_STATE.WAITING_FF1;
                    break;
            }
            return false;
        }
        private void srlbtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                srlbtn.Text = "打开";
            }
            else
            {
                if (srlboBox.Text == "")
                {
                    MessageBox.Show("无效的串口！");
                    return;
                }
                serialPort1.PortName = srlboBox.Text;
                serialPort1.BaudRate = 115200;
                try
                {
                    serialPort1.Open();
                    srlbtn.Text = "关闭";
                }
                catch (Exception e1)
                {
                    serialPort1 = new SerialPort();
                    MessageBox.Show(e1.Message);
                }
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                rcvtxtBox.Text = " ";
                Byte[] receivedData = new Byte[serialPort1.BytesToRead];        //创建接收字节数组  
                serialPort1.Read(receivedData, 0, receivedData.Length);         //读取数据                         
                serialPort1.DiscardInBuffer();                                  //清空SerialPort控件的Buffer  
                string strRcv = null;

                for (int i = 0; i < receivedData.Length; i++) //窗体显示  
                {
                    strRcv += receivedData[i].ToString("X2");  //16进制显示  
                    strRcv += "\r\n";
                    MessageUpdateFlag = receiveFiniteStates(receivedData[i]);
                    if (MessageUpdateFlag == true)
                    {
                        MessageUpdateFlag = false;
                        if (message.data[0] == (Byte)0x04)
                        {
                            PD.value1 = (ushort)((message.data[2] << 8) | (message.data[1]));
                            PD.voltage1 = (Single)(3.30 * PD.value1 / 4096);

                            if (PClosedLoopFlag)
                            {
                                pid1.ActualValue = PD.voltage1;
                                ControlBias = pid1.Calculate();
                                if (ControlBias > 0.05) ControlBias = 0.05F;
                                if (ControlBias < -0.05) ControlBias = -0.05F;
                                vcsel.voltage_biasundercontrol = ControlBias + vcsel.voltage_bias;
                                if (vcsel.voltage_biasundercontrol < 0) vcsel.voltage_biasundercontrol = 0;
                                SetVcselBiasTxtBox.Text = vcsel.voltage_biasundercontrol.ToString("f6");
                                SetVcselBiasTxtBoxCurrent.Text = (2 * vcsel.voltage_biasundercontrol).ToString("f6");
                                button = BUTTON.SET_VCSEL_BIAS;
                                robot_control();
                            }
                            this.chart1.Series[0].Points.AddXY(iGlobal + 1, PD.voltage1);
                            /*if (iGlobal % 50 == 0)
                            {
                                this.chart1.Series[0].Points.AddXY(iGlobal / 50 + 1, PD.voltage1);
#if Console

                                Console.WriteLine("{0}   {1}   {2}   {3}   {4}", (iGlobal/5+1).ToString("0000"), pid1.ExpectedValue.ToString("f6"), PD.voltage1.ToString("f6"), vcsel.voltage_bias.ToString("f6"), vcsel.voltage_biasundercontrol.ToString("f6"));
#endif
                            }*/
                            iGlobal++;

                        }
                        ReadPDTxtBox.Text = PD.voltage1.ToString("f6") + "|" + pid1.ExpectedValue.ToString("f6");
                    }
                }
                rcvtxtBox.Text = strRcv; //+ "\r\n";
                //this.rcvtxtBox.Focus();//
                //this.rcvtxtBox.Select(this.rcvtxtBox.TextLength, 0);//光标定位到文本最后
                //this.rcvtxtBox.ScrollToCaret();//滚动到光标处
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }
        private void serialPort1_sendStr(string sndtxt)
        {
            if (serialPort1.IsOpen)
            {
                string strSend = sndtxt;
                string sendnoNull = strSend.Trim();
                string sendNOComma = sendnoNull.Replace(',', ' ');
                sendNOComma.Replace("0x", "");
                sendNOComma.Replace("0X", "");
                string[] strArray = sendNOComma.Split(' ');
                int bytebufferLength = strArray.Length;

                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == "")
                    {
                        bytebufferLength--;
                    }
                }
                byte[] byteBuffer = new byte[bytebufferLength];

                int ii = 0;
                for (int i = 0; i < strArray.Length; i++)
                {
                    Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);
                    int decNum = 0;
                    if (strArray[i] == "")
                    {
                        continue;
                    }
                    else
                    {
                        decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                    }

                    try    //防止输错，使其只能输入一个字节的字符
                    {
                        byteBuffer[ii] = Convert.ToByte(decNum);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                        return;
                    }
                    ii++;
                }
                serialPort1.Write(byteBuffer, 0, byteBuffer.Length);
            }
            else
            {
                timer.Enabled = false;         //这两句的顺序一定不能对调！！！先关定时器，再跳出框，
                MessageBox.Show("请打开串口");   //跳出框后程序就停了，但定时器无法关闭
            }
        }
        private void robot_control()
        {
            string SendBuf = "";
            byte[][] bb = new byte[5][];
            int sum;

            switch (button)
            {
                case (BUTTON.SHAKING_HANDS):
                    SendBuf = "FF FF 01 11 00 0D 00 00 00 00 00 00 00 00 00 00 00 00 00 1F";
                    break;

                case (BUTTON.SET_VCSEL_BIAS):
                    string_deal(SetVcselBiasTxtBox.Text);             //这些TextBox的name不能太长
                    if (s.Length != 1)
                    {
                        MessageBox.Show("请输入正确的数据长度");
                        return;
                    }
                    //SetVcselBiasTxtBoxCurrent.Text = (2 * Convert.ToSingle(s[0])).ToString("f6");
                    sum = 1 + 17 + 5 + 1;
                    bb[0] = BitConverter.GetBytes(Convert.ToSingle(s[0]));
                    SendBuf = "FF FF 01 11 00 05 01 ";
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            SendBuf += bb[i][j].ToString("X2");  //16进制显示  
                            SendBuf += " ";
                            sum += bb[i][j];
                        }
                    }
                    SendBuf += (sum % 255).ToString("X2");
                    break;

                case (BUTTON.SET_VCSEL_SINEP2P):
                    string_deal(SetVcselSinep2pTxtBox.Text);             //这些TextBox的name不能太长
                    if (s.Length != 1)
                    {
                        MessageBox.Show("请输入正确的数据长度");
                        return;
                    }
                    SetVcselSinep2pTxtBoxCurrent.Text = (2 * Convert.ToSingle(s[0])).ToString("f6");
                    sum = 1 + 17 + 5 + 2;
                    bb[0] = BitConverter.GetBytes(Convert.ToSingle(s[0]));
                    SendBuf = "FF FF 01 11 00 05 02 ";
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            SendBuf += bb[i][j].ToString("X2");  //16进制显示  
                            SendBuf += " ";
                            sum += bb[i][j];
                        }
                    }
                    SendBuf += (sum % 255).ToString("X2");
                    break;
                case (BUTTON.SET_VCSEL_SINEFRE):
                    string_deal(SetVcselSinefreTxtBox.Text);             //这些TextBox的name不能太长
                    if (s.Length != 1)
                    {
                        MessageBox.Show("请输入正确的数据长度");
                        return;
                    }
                    sum = 1 + 17 + 5 + 3;
                    bb[0] = BitConverter.GetBytes(Convert.ToSingle(s[0]));
                    SendBuf = "FF FF 01 11 00 05 03 ";
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            SendBuf += bb[i][j].ToString("X2");  //16进制显示  
                            SendBuf += " ";
                            sum += bb[i][j];
                        }
                    }
                    SendBuf += (sum % 255).ToString("X2");
                    break;
                case (BUTTON.READ_PD):
                    SendBuf = "FF FF 01 11 00 01 04 17";
                    break;

            }
            Array.Clear(bb, 0, bb.Length);//清除数组中的内容
            Array.Clear(s, 0, s.Length);
            SendBuftxtBox.Text = SendBuf.Replace(" ", "\r\n");
            serialPort1_sendStr(SendBuf);
        }
        private void string_deal(string str)
        {
            str = new System.Text.RegularExpressions.Regex("[\\s]+").Replace(str, " ");
            if (str == "")
            {
                MessageBox.Show("请添入数据");
                return;
            }
            if (str.EndsWith(" "))
            {
                MessageBox.Show("请删除数据后的空格");
                return;
            }
            s = str.Split(' ');
        }
        private void ShakeHandsbtn_Click(object sender, EventArgs e)
        {
            button = BUTTON.SHAKING_HANDS;
            robot_control();
        }
        /*private void SetVcselBiasBtn_Click(object sender, EventArgs e)
        {
            button = BUTTON.SET_VCSEL_BIAS;
            robot_control();
        }*/
        private void SetVcselSinep2pBtn_Click(object sender, EventArgs e)
        {
            button = BUTTON.SET_VCSEL_SINEP2P;
            robot_control();
        }
        private void SetVcselSinefreBtn_Click(object sender, EventArgs e)
        {
            button = BUTTON.SET_VCSEL_SINEFRE;
            robot_control();
        }
        private void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            button = BUTTON.READ_PD;
            robot_control();
        }
        private void WMDUpdate()
        {
            vcsel.voltage_bias = GlobalAngle1 * Convert.ToSingle(0.004) + GlobalAngle2 * Convert.ToSingle(0.0002);
            SetVcselBiasTxtBox.Text = vcsel.voltage_bias.ToString("f6");
            SetVcselBiasTxtBoxCurrent.Text = (2 * vcsel.voltage_bias).ToString("f6");
            button = BUTTON.SET_VCSEL_BIAS;
            robot_control();
        }
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (wmd_state == WMD_STATE.FREE)
            {
                wmd_state = WMD_STATE.PICTURE1SPIN;
                if (serialPort1.IsOpen)
                {
                    Bitmap a = new Bitmap(pictureBox1.Image);
                    Rectangle rect = new Rectangle(0, 0, a.Width, a.Height);
                    Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                    Point p = e.Location;
                    double angleOfLine = Math.Atan2(-(p.Y - center.Y), (p.X - center.X)) * 180 / Math.PI;
                    if (angleOfLine < 0) angleOfLine = angleOfLine + 360;
                    while (GlobalAngle1 < angleOfLine)
                    {
                        a = new Bitmap(pictureBox1.Image);
                        pictureBox1.Image = wmd.Rotate(a, GlobalAngle1);
                        GlobalAngle1++;
                        WMDUpdate();
                        t.Delay_ms(50);
                    }
                    while (GlobalAngle1 > angleOfLine)
                    {
                        a = new Bitmap(pictureBox1.Image);
                        pictureBox1.Image = wmd.Rotate(a, GlobalAngle1);
                        GlobalAngle1--;
                        WMDUpdate();
                        t.Delay_ms(50);
                    }
                    a = new Bitmap(pictureBox1.Image);
                    pictureBox1.Image = wmd.Rotate(a, GlobalAngle1);
                    GlobalAngle1 = Convert.ToSingle(angleOfLine);
                    WMDUpdate();
                }
                else { MessageBox.Show("请打开串口"); }
                wmd_state = WMD_STATE.FREE;
            }


        }
        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (wmd_state == WMD_STATE.FREE)
            {
                wmd_state = WMD_STATE.PICTURE2SPIN;
                if (serialPort1.IsOpen)
                {
                    Bitmap a = new Bitmap(pictureBox2.Image);
                    Rectangle rect = new Rectangle(0, 0, a.Width, a.Height);
                    Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                    Point p = e.Location;
                    double angleOfLine = Math.Atan2(-(p.Y - center.Y), (p.X - center.X)) * 180 / Math.PI;
                    if (angleOfLine < 0) angleOfLine = angleOfLine + 360;
                    while (GlobalAngle2 < angleOfLine)
                    {
                        a = new Bitmap(pictureBox2.Image);
                        pictureBox2.Image = wmd.Rotate(a, GlobalAngle2);
                        GlobalAngle2++;
                        WMDUpdate();
                        t.Delay_ms(20);
                    }
                    while (GlobalAngle2 > angleOfLine)
                    {
                        a = new Bitmap(pictureBox2.Image);
                        pictureBox2.Image = wmd.Rotate(a, GlobalAngle2);
                        GlobalAngle2--;
                        WMDUpdate();
                        t.Delay_ms(20);
                    }
                    a = new Bitmap(pictureBox2.Image);
                    pictureBox2.Image = wmd.Rotate(a, GlobalAngle2);
                    GlobalAngle2 = Convert.ToSingle(angleOfLine);
                    WMDUpdate();
                }
                else { MessageBox.Show("请打开串口"); }
                wmd_state = WMD_STATE.FREE;
            }

        }
        private void SetVcselBiasTo0_Click(object sender, EventArgs e)
        {
            if (wmd_state == WMD_STATE.FREE)
            {
                if (serialPort1.IsOpen)
                {
                    wmd_state = WMD_STATE.PICTURE1SPIN;
                    Bitmap a = new Bitmap(pictureBox1.Image);
                    while (GlobalAngle1 > 1)
                    {
                        a = new Bitmap(pictureBox1.Image);
                        pictureBox1.Image = wmd.Rotate(a, GlobalAngle1);
                        GlobalAngle1--;
                        WMDUpdate();
                        t.Delay_ms(50);
                    }
                    a = new Bitmap(pictureBox1.Image);
                    pictureBox1.Image = wmd.Rotate(a, GlobalAngle1);
                    GlobalAngle1 = Convert.ToSingle(0);
                    WMDUpdate();

                    wmd_state = WMD_STATE.PICTURE2SPIN;
                    a = new Bitmap(pictureBox2.Image);
                    while (GlobalAngle2 > 1)
                    {
                        a = new Bitmap(pictureBox2.Image);
                        pictureBox2.Image = wmd.Rotate(a, GlobalAngle2);
                        GlobalAngle2--;
                        WMDUpdate();
                        t.Delay_ms(20);
                    }
                    a = new Bitmap(pictureBox2.Image);
                    pictureBox2.Image = wmd.Rotate(a, GlobalAngle2);
                    GlobalAngle2 = Convert.ToSingle(0);
                    WMDUpdate();

                }
                else { MessageBox.Show("请打开串口"); }
                wmd_state = WMD_STATE.FREE;
            }
        }
        /*private void SetVcselBiasTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ky.KeyConfineNum(sender, e);
            if (e.KeyChar == (char)13)
            {
                SetVcselBiasBtn_Click(sender, e);
            }
        }
        private void SetVcselBiasTxtBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ky.KeyUpDown(e, SetVcselBiasTxtBox);
        }*/
        private void SetVcselSinep2pTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ky.KeyConfineNum(sender, e);
            if (e.KeyChar == (char)13)
            {
                SetVcselSinep2pBtn_Click(sender, e);
            }
        }
        private void SetVcselSinep2pTxtBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ky.KeyUpDown(e, SetVcselSinep2pTxtBox);
        }
        private void SetVcselSinefreTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ky.KeyConfineNum(sender, e);
            if (e.KeyChar == 13)
            {
                SetVcselSinefreBtn_Click(sender, e);
            }
        }
        private void SetVcselSinefreTxtBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ky.KeyUpDown(e, SetVcselSinefreTxtBox);
        }
        private void PDBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcheck)
            {
                rbcheck = false;
                timer.Enabled = false;
            }
            else
            {
                rbcheck = true;
                timer.Enabled = true;
            }
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (PClosedLoopFlag)
            {
                PClosedLoopFlag = false;
                ControlBias = 0F;
                pid1.Reset();
                SetVcselBiasTxtBox.Text = vcsel.voltage_bias.ToString("f6");
                SetVcselBiasTxtBoxCurrent.Text = (2 * vcsel.voltage_bias).ToString("f6");
                button = BUTTON.SET_VCSEL_BIAS;
                robot_control();
            }
            else
            {
                PClosedLoopFlag = true;
                pid1.ExpectedValue = PD.voltage1;
            }
        }


    }
}
