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
            this.srlboBox = new System.Windows.Forms.ComboBox();
            this.srllabel = new System.Windows.Forms.Label();
            this.srlbtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.SetVcselSinep2pTxtBoxCurrent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SetVcselBiasTxtBoxCurrent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SetVcselBiasTo0 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // srlboBox
            // 
            this.srlboBox.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srlboBox.FormattingEnabled = true;
            this.srlboBox.Location = new System.Drawing.Point(19, 89);
            this.srlboBox.Name = "srlboBox";
            this.srlboBox.Size = new System.Drawing.Size(103, 31);
            this.srlboBox.TabIndex = 2;
            // 
            // srllabel
            // 
            this.srllabel.BackColor = System.Drawing.Color.Transparent;
            this.srllabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srllabel.Font = new System.Drawing.Font("黑体", 15F);
            this.srllabel.Location = new System.Drawing.Point(19, 25);
            this.srllabel.Name = "srllabel";
            this.srllabel.Size = new System.Drawing.Size(103, 34);
            this.srllabel.TabIndex = 4;
            this.srllabel.Text = "串口号";
            this.srllabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srlbtn
            // 
            this.srlbtn.BackColor = System.Drawing.Color.Transparent;
            this.srlbtn.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srlbtn.Location = new System.Drawing.Point(19, 150);
            this.srlbtn.Name = "srlbtn";
            this.srlbtn.Size = new System.Drawing.Size(103, 34);
            this.srlbtn.TabIndex = 6;
            this.srlbtn.Text = "打开串口";
            this.srlbtn.UseVisualStyleBackColor = true;
            this.srlbtn.Click += new System.EventHandler(this.srlbtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.Transparent;
            this.clrbtn.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clrbtn.Location = new System.Drawing.Point(752, 29);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(42, 219);
            this.clrbtn.TabIndex = 7;
            this.clrbtn.Text = "清\r\n\r\n除\r\n\r\n数\r\n\r\n据";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ShakeHandsbtn
            // 
            this.ShakeHandsbtn.BackColor = System.Drawing.SystemColors.Control;
            this.ShakeHandsbtn.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShakeHandsbtn.Location = new System.Drawing.Point(19, 214);
            this.ShakeHandsbtn.Name = "ShakeHandsbtn";
            this.ShakeHandsbtn.Size = new System.Drawing.Size(103, 34);
            this.ShakeHandsbtn.TabIndex = 8;
            this.ShakeHandsbtn.Text = "连接设备";
            this.ShakeHandsbtn.UseVisualStyleBackColor = true;
            this.ShakeHandsbtn.Click += new System.EventHandler(this.ShakeHandsbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 32F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1034, 43);
            this.label3.TabIndex = 17;
            this.label3.Text = "核磁共振陀螺VCSEL激光器闭环数字控制系统上位机";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselBiasTxtBox
            // 
            this.SetVcselBiasTxtBox.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselBiasTxtBox.Location = new System.Drawing.Point(204, 30);
            this.SetVcselBiasTxtBox.Name = "SetVcselBiasTxtBox";
            this.SetVcselBiasTxtBox.ReadOnly = true;
            this.SetVcselBiasTxtBox.Size = new System.Drawing.Size(113, 30);
            this.SetVcselBiasTxtBox.TabIndex = 18;
            this.SetVcselBiasTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetVcselBiasTxtBox_KeyPress);
            this.SetVcselBiasTxtBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SetVcselBiasTxtBox_PreviewKeyDown);
            // 
            // SetVcselBiasBtn
            // 
            this.SetVcselBiasBtn.BackColor = System.Drawing.Color.Transparent;
            this.SetVcselBiasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SetVcselBiasBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SetVcselBiasBtn.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselBiasBtn.Location = new System.Drawing.Point(382, 30);
            this.SetVcselBiasBtn.Name = "SetVcselBiasBtn";
            this.SetVcselBiasBtn.Size = new System.Drawing.Size(103, 30);
            this.SetVcselBiasBtn.TabIndex = 19;
            this.SetVcselBiasBtn.Text = "直流偏置";
            this.SetVcselBiasBtn.UseVisualStyleBackColor = false;
            this.SetVcselBiasBtn.Click += new System.EventHandler(this.SetVcselBiasBtn_Click);
            // 
            // SetVcselSinep2pTxtBox
            // 
            this.SetVcselSinep2pTxtBox.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselSinep2pTxtBox.Location = new System.Drawing.Point(204, 116);
            this.SetVcselSinep2pTxtBox.Name = "SetVcselSinep2pTxtBox";
            this.SetVcselSinep2pTxtBox.Size = new System.Drawing.Size(113, 30);
            this.SetVcselSinep2pTxtBox.TabIndex = 20;
            this.SetVcselSinep2pTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetVcselSinep2pTxtBox_KeyPress);
            this.SetVcselSinep2pTxtBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SetVcselSinep2pTxtBox_PreviewKeyDown);
            // 
            // SetVcselSinefreTxtBox
            // 
            this.SetVcselSinefreTxtBox.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselSinefreTxtBox.Location = new System.Drawing.Point(204, 202);
            this.SetVcselSinefreTxtBox.Name = "SetVcselSinefreTxtBox";
            this.SetVcselSinefreTxtBox.Size = new System.Drawing.Size(113, 30);
            this.SetVcselSinefreTxtBox.TabIndex = 21;
            this.SetVcselSinefreTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetVcselSinefreTxtBox_KeyPress);
            this.SetVcselSinefreTxtBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SetVcselSinefreTxtBox_PreviewKeyDown);
            // 
            // SetVcselSinep2pBtn
            // 
            this.SetVcselSinep2pBtn.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselSinep2pBtn.Location = new System.Drawing.Point(382, 116);
            this.SetVcselSinep2pBtn.Name = "SetVcselSinep2pBtn";
            this.SetVcselSinep2pBtn.Size = new System.Drawing.Size(103, 30);
            this.SetVcselSinep2pBtn.TabIndex = 22;
            this.SetVcselSinep2pBtn.Text = "调制幅值";
            this.SetVcselSinep2pBtn.UseVisualStyleBackColor = true;
            this.SetVcselSinep2pBtn.Click += new System.EventHandler(this.SetVcselSinep2pBtn_Click);
            // 
            // SetVcselSinefreBtn
            // 
            this.SetVcselSinefreBtn.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselSinefreBtn.Location = new System.Drawing.Point(382, 202);
            this.SetVcselSinefreBtn.Name = "SetVcselSinefreBtn";
            this.SetVcselSinefreBtn.Size = new System.Drawing.Size(103, 30);
            this.SetVcselSinefreBtn.TabIndex = 23;
            this.SetVcselSinefreBtn.Text = "调制频率";
            this.SetVcselSinefreBtn.UseVisualStyleBackColor = true;
            this.SetVcselSinefreBtn.Click += new System.EventHandler(this.SetVcselSinefreBtn_Click);
            // 
            // rcvtxtBox
            // 
            this.rcvtxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.rcvtxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcvtxtBox.Location = new System.Drawing.Point(25, 77);
            this.rcvtxtBox.Multiline = true;
            this.rcvtxtBox.Name = "rcvtxtBox";
            this.rcvtxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rcvtxtBox.Size = new System.Drawing.Size(700, 171);
            this.rcvtxtBox.TabIndex = 1;
            this.rcvtxtBox.WordWrap = false;
            // 
            // SendBuftxtBox
            // 
            this.SendBuftxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.SendBuftxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBuftxtBox.Location = new System.Drawing.Point(25, 29);
            this.SendBuftxtBox.Name = "SendBuftxtBox";
            this.SendBuftxtBox.ReadOnly = true;
            this.SendBuftxtBox.Size = new System.Drawing.Size(683, 26);
            this.SendBuftxtBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clrbtn);
            this.panel1.Controls.Add(this.SendBuftxtBox);
            this.panel1.Controls.Add(this.rcvtxtBox);
            this.panel1.Location = new System.Drawing.Point(43, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 287);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(672, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "收";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(672, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
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
            this.panel3.Location = new System.Drawing.Point(863, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 287);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.SetVcselSinep2pTxtBoxCurrent);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.SetVcselBiasTxtBoxCurrent);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SetVcselSinefreBtn);
            this.panel2.Controls.Add(this.SetVcselSinep2pBtn);
            this.panel2.Controls.Add(this.SetVcselBiasBtn);
            this.panel2.Controls.Add(this.SetVcselSinefreTxtBox);
            this.panel2.Controls.Add(this.SetVcselBiasTxtBox);
            this.panel2.Controls.Add(this.SetVcselSinep2pTxtBox);
            this.panel2.Location = new System.Drawing.Point(500, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 255);
            this.panel2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(134, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 30);
            this.label10.TabIndex = 34;
            this.label10.Text = "(mA)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselSinep2pTxtBoxCurrent
            // 
            this.SetVcselSinep2pTxtBoxCurrent.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselSinep2pTxtBoxCurrent.Location = new System.Drawing.Point(24, 116);
            this.SetVcselSinep2pTxtBoxCurrent.Name = "SetVcselSinep2pTxtBoxCurrent";
            this.SetVcselSinep2pTxtBoxCurrent.ReadOnly = true;
            this.SetVcselSinep2pTxtBoxCurrent.Size = new System.Drawing.Size(113, 30);
            this.SetVcselSinep2pTxtBoxCurrent.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(134, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 30);
            this.label9.TabIndex = 32;
            this.label9.Text = "(mA)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselBiasTxtBoxCurrent
            // 
            this.SetVcselBiasTxtBoxCurrent.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetVcselBiasTxtBoxCurrent.Location = new System.Drawing.Point(24, 30);
            this.SetVcselBiasTxtBoxCurrent.Name = "SetVcselBiasTxtBoxCurrent";
            this.SetVcselBiasTxtBoxCurrent.ReadOnly = true;
            this.SetVcselBiasTxtBoxCurrent.Size = new System.Drawing.Size(113, 30);
            this.SetVcselBiasTxtBoxCurrent.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(312, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "(Hz)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(312, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "(V)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(312, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "(V)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, 441);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseClick);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(43, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "粗调旋钮";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(196, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "精调旋钮";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetVcselBiasTo0
            // 
            this.SetVcselBiasTo0.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetVcselBiasTo0.Location = new System.Drawing.Point(43, 606);
            this.SetVcselBiasTo0.Name = "SetVcselBiasTo0";
            this.SetVcselBiasTo0.Size = new System.Drawing.Size(273, 44);
            this.SetVcselBiasTo0.TabIndex = 32;
            this.SetVcselBiasTo0.Text = "复位激光器";
            this.SetVcselBiasTo0.UseVisualStyleBackColor = true;
            this.SetVcselBiasTo0.Click += new System.EventHandler(this.SetVcselBiasTo0_Click);
            // 
            // NMRG_VCSEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 733);
            this.Controls.Add(this.SetVcselBiasTo0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "NMRG_VCSEL";
            this.Text = "NMRG_VCSEL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label srllabel;
        private System.Windows.Forms.Button srlbtn;
        private System.Windows.Forms.Button clrbtn;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
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
    }
}

