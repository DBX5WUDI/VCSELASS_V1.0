namespace WindowsFormsApplication1
{
    partial class NMRG_VCSEL
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NMRG_VCSEL));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.srlboBox = new System.Windows.Forms.ComboBox();
            this.srllabel = new System.Windows.Forms.Label();
            this.srlbtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ShakeHandsbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SetVcselBiasTxtBox = new System.Windows.Forms.TextBox();
            this.SetVcselBiasBtn = new System.Windows.Forms.Button();
            this.SetVcselSinep2pTxtBox = new System.Windows.Forms.TextBox();
            this.SetVcselSinefreTxtBox = new System.Windows.Forms.TextBox();
            this.SetVcselSinep2pBtn = new System.Windows.Forms.Button();
            this.SetVcselSinefreBtn = new System.Windows.Forms.Button();
            this.rcvtxtBox = new System.Windows.Forms.TextBox();
            this.SendBuftxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SetVcselBiasTo0 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SetVcselSinep2pTxtBoxCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SetVcselBiasTxtBoxCurrent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ReadPDTxtBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReadPDRBtn = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // srlboBox
            // 
            this.srlboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srlboBox.FormattingEnabled = true;
            this.srlboBox.Location = new System.Drawing.Point(17, 64);
            this.srlboBox.Name = "srlboBox";
            this.srlboBox.Size = new System.Drawing.Size(103, 26);
            this.srlboBox.TabIndex = 2;
            // 
            // srllabel
            // 
            this.srllabel.BackColor = System.Drawing.Color.Transparent;
            this.srllabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srllabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srllabel.Location = new System.Drawing.Point(17, 19);
            this.srllabel.Name = "srllabel";
            this.srllabel.Size = new System.Drawing.Size(103, 26);
            this.srllabel.TabIndex = 4;
            this.srllabel.Text = "串口号";
            this.srllabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srlbtn
            // 
            this.srlbtn.BackColor = System.Drawing.Color.Transparent;
            this.srlbtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srlbtn.Location = new System.Drawing.Point(17, 117);
            this.srlbtn.Name = "srlbtn";
            this.srlbtn.Size = new System.Drawing.Size(103, 26);
            this.srlbtn.TabIndex = 6;
            this.srlbtn.Text = "打开串口";
            this.srlbtn.UseVisualStyleBackColor = true;
            this.srlbtn.Click += new System.EventHandler(this.srlbtn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ShakeHandsbtn
            // 
            this.ShakeHandsbtn.BackColor = System.Drawing.SystemColors.Control;
            this.ShakeHandsbtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShakeHandsbtn.Location = new System.Drawing.Point(17, 166);
            this.ShakeHandsbtn.Name = "ShakeHandsbtn";
            this.ShakeHandsbtn.Size = new System.Drawing.Size(103, 26);
            this.ShakeHandsbtn.TabIndex = 8;
            this.ShakeHandsbtn.Text = "连接设备";
            this.ShakeHandsbtn.UseVisualStyleBackColor = true;
            this.ShakeHandsbtn.Click += new System.EventHandler(this.ShakeHandsbtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("黑体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(78, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(790, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "核磁共振陀螺VCSEL闭环数字控制系统上位机";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselBiasTxtBox
            // 
            this.SetVcselBiasTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselBiasTxtBox.Location = new System.Drawing.Point(41, 51);
            this.SetVcselBiasTxtBox.Name = "SetVcselBiasTxtBox";
            this.SetVcselBiasTxtBox.ReadOnly = true;
            this.SetVcselBiasTxtBox.Size = new System.Drawing.Size(113, 26);
            this.SetVcselBiasTxtBox.TabIndex = 18;
            // 
            // SetVcselBiasBtn
            // 
            this.SetVcselBiasBtn.BackColor = System.Drawing.Color.Transparent;
            this.SetVcselBiasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SetVcselBiasBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SetVcselBiasBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselBiasBtn.Location = new System.Drawing.Point(219, 22);
            this.SetVcselBiasBtn.Name = "SetVcselBiasBtn";
            this.SetVcselBiasBtn.Size = new System.Drawing.Size(103, 54);
            this.SetVcselBiasBtn.TabIndex = 19;
            this.SetVcselBiasBtn.Text = "直流偏置";
            this.SetVcselBiasBtn.UseVisualStyleBackColor = false;
            // 
            // SetVcselSinep2pTxtBox
            // 
            this.SetVcselSinep2pTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselSinep2pTxtBox.Location = new System.Drawing.Point(41, 136);
            this.SetVcselSinep2pTxtBox.Name = "SetVcselSinep2pTxtBox";
            this.SetVcselSinep2pTxtBox.Size = new System.Drawing.Size(113, 26);
            this.SetVcselSinep2pTxtBox.TabIndex = 20;
            this.SetVcselSinep2pTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetVcselSinep2pTxtBox_KeyPress);
            this.SetVcselSinep2pTxtBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SetVcselSinep2pTxtBox_PreviewKeyDown);
            // 
            // SetVcselSinefreTxtBox
            // 
            this.SetVcselSinefreTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselSinefreTxtBox.Location = new System.Drawing.Point(41, 194);
            this.SetVcselSinefreTxtBox.Name = "SetVcselSinefreTxtBox";
            this.SetVcselSinefreTxtBox.Size = new System.Drawing.Size(113, 26);
            this.SetVcselSinefreTxtBox.TabIndex = 21;
            this.SetVcselSinefreTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetVcselSinefreTxtBox_KeyPress);
            this.SetVcselSinefreTxtBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SetVcselSinefreTxtBox_PreviewKeyDown);
            // 
            // SetVcselSinep2pBtn
            // 
            this.SetVcselSinep2pBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselSinep2pBtn.Location = new System.Drawing.Point(219, 105);
            this.SetVcselSinep2pBtn.Name = "SetVcselSinep2pBtn";
            this.SetVcselSinep2pBtn.Size = new System.Drawing.Size(103, 57);
            this.SetVcselSinep2pBtn.TabIndex = 22;
            this.SetVcselSinep2pBtn.Text = "调制幅值";
            this.SetVcselSinep2pBtn.UseVisualStyleBackColor = true;
            this.SetVcselSinep2pBtn.Click += new System.EventHandler(this.SetVcselSinep2pBtn_Click);
            // 
            // SetVcselSinefreBtn
            // 
            this.SetVcselSinefreBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselSinefreBtn.Location = new System.Drawing.Point(219, 194);
            this.SetVcselSinefreBtn.Name = "SetVcselSinefreBtn";
            this.SetVcselSinefreBtn.Size = new System.Drawing.Size(103, 26);
            this.SetVcselSinefreBtn.TabIndex = 23;
            this.SetVcselSinefreBtn.Text = "调制频率";
            this.SetVcselSinefreBtn.UseVisualStyleBackColor = true;
            this.SetVcselSinefreBtn.Click += new System.EventHandler(this.SetVcselSinefreBtn_Click);
            // 
            // rcvtxtBox
            // 
            this.rcvtxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.rcvtxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcvtxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rcvtxtBox.Enabled = false;
            this.rcvtxtBox.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcvtxtBox.Location = new System.Drawing.Point(947, 92);
            this.rcvtxtBox.Multiline = true;
            this.rcvtxtBox.Name = "rcvtxtBox";
            this.rcvtxtBox.ReadOnly = true;
            this.rcvtxtBox.Size = new System.Drawing.Size(30, 368);
            this.rcvtxtBox.TabIndex = 1;
            this.rcvtxtBox.WordWrap = false;
            // 
            // SendBuftxtBox
            // 
            this.SendBuftxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.SendBuftxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendBuftxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SendBuftxtBox.Enabled = false;
            this.SendBuftxtBox.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBuftxtBox.Location = new System.Drawing.Point(918, 92);
            this.SendBuftxtBox.Multiline = true;
            this.SendBuftxtBox.Name = "SendBuftxtBox";
            this.SendBuftxtBox.ReadOnly = true;
            this.SendBuftxtBox.Size = new System.Drawing.Size(30, 368);
            this.SendBuftxtBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(921, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "发";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.srlboBox);
            this.panel3.Controls.Add(this.ShakeHandsbtn);
            this.panel3.Controls.Add(this.srllabel);
            this.panel3.Controls.Add(this.srlbtn);
            this.panel3.Location = new System.Drawing.Point(772, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 220);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SetVcselBiasTo0);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.SetVcselSinep2pTxtBoxCurrent);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.SetVcselBiasTxtBoxCurrent);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SetVcselSinefreBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.SetVcselSinep2pBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SetVcselBiasBtn);
            this.panel2.Controls.Add(this.SetVcselSinefreTxtBox);
            this.panel2.Controls.Add(this.SetVcselBiasTxtBox);
            this.panel2.Controls.Add(this.SetVcselSinep2pTxtBox);
            this.panel2.Location = new System.Drawing.Point(43, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 248);
            this.panel2.TabIndex = 27;
            // 
            // SetVcselBiasTo0
            // 
            this.SetVcselBiasTo0.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselBiasTo0.Location = new System.Drawing.Point(363, 187);
            this.SetVcselBiasTo0.Name = "SetVcselBiasTo0";
            this.SetVcselBiasTo0.Size = new System.Drawing.Size(273, 33);
            this.SetVcselBiasTo0.TabIndex = 32;
            this.SetVcselBiasTo0.Text = "复位激光器";
            this.SetVcselBiasTo0.UseVisualStyleBackColor = true;
            this.SetVcselBiasTo0.Click += new System.EventHandler(this.SetVcselBiasTo0_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "(mA)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselSinep2pTxtBoxCurrent
            // 
            this.SetVcselSinep2pTxtBoxCurrent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselSinep2pTxtBoxCurrent.Location = new System.Drawing.Point(41, 105);
            this.SetVcselSinep2pTxtBoxCurrent.Name = "SetVcselSinep2pTxtBoxCurrent";
            this.SetVcselSinep2pTxtBoxCurrent.ReadOnly = true;
            this.SetVcselSinep2pTxtBoxCurrent.Size = new System.Drawing.Size(113, 26);
            this.SetVcselSinep2pTxtBoxCurrent.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(516, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "精调旋钮";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "(mA)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselBiasTxtBoxCurrent
            // 
            this.SetVcselBiasTxtBoxCurrent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselBiasTxtBoxCurrent.Location = new System.Drawing.Point(41, 22);
            this.SetVcselBiasTxtBoxCurrent.Name = "SetVcselBiasTxtBoxCurrent";
            this.SetVcselBiasTxtBoxCurrent.ReadOnly = true;
            this.SetVcselBiasTxtBoxCurrent.Size = new System.Drawing.Size(113, 26);
            this.SetVcselBiasTxtBoxCurrent.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "(Hz)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(363, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "粗调旋钮";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "(V)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "(V)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(516, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(954, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "收";
            // 
            // ReadPDTxtBox
            // 
            this.ReadPDTxtBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadPDTxtBox.Location = new System.Drawing.Point(772, 484);
            this.ReadPDTxtBox.Name = "ReadPDTxtBox";
            this.ReadPDTxtBox.ReadOnly = true;
            this.ReadPDTxtBox.Size = new System.Drawing.Size(87, 21);
            this.ReadPDTxtBox.TabIndex = 35;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Snow;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = null;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(34, 92);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(875, 386);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseUp);
            this.chart1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseWheel);
            // 
            // ReadPDRBtn
            // 
            this.ReadPDRBtn.AutoSize = true;
            this.ReadPDRBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadPDRBtn.Location = new System.Drawing.Point(865, 484);
            this.ReadPDRBtn.Name = "ReadPDRBtn";
            this.ReadPDRBtn.Size = new System.Drawing.Size(46, 22);
            this.ReadPDRBtn.TabIndex = 37;
            this.ReadPDRBtn.TabStop = true;
            this.ReadPDRBtn.Text = "PD";
            this.ReadPDRBtn.UseVisualStyleBackColor = true;
            this.ReadPDRBtn.Click += new System.EventHandler(this.ReadPDRBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "清除数据";
            this.toolStripMenuItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItem1_MouseDown);
            // 
            // NMRG_VCSEL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1037, 774);
            this.Controls.Add(this.ReadPDRBtn);
            this.Controls.Add(this.ReadPDTxtBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SendBuftxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rcvtxtBox);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NMRG_VCSEL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NMRG_VCSEL";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label srllabel;
        private System.Windows.Forms.Button srlbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ShakeHandsbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SetVcselBiasTxtBox;
        private System.Windows.Forms.Button SetVcselBiasBtn;
        private System.Windows.Forms.TextBox SetVcselSinep2pTxtBox;
        private System.Windows.Forms.TextBox SetVcselSinefreTxtBox;
        private System.Windows.Forms.Button SetVcselSinep2pBtn;
        private System.Windows.Forms.Button SetVcselSinefreBtn;
        private System.Windows.Forms.TextBox rcvtxtBox;
        private System.Windows.Forms.TextBox SendBuftxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SetVcselBiasTxtBoxCurrent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SetVcselBiasTo0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SetVcselSinep2pTxtBoxCurrent;
        private System.Windows.Forms.ComboBox srlboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ReadPDTxtBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton ReadPDRBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

