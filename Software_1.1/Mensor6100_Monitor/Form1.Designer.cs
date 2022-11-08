namespace Zanasi4700
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Header = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TransInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Footer = new System.Windows.Forms.StatusStrip();
            this.lb_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_Fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.LocalClock = new System.Windows.Forms.Timer(this.components);
            this.cntr_Comm = new System.Windows.Forms.GroupBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cntr_Cmd = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CustomSend_Size = new System.Windows.Forms.Label();
            this.txt_CustomSend = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ExtDataAutoSeq = new System.Windows.Forms.Button();
            this.txt_ExtData_Index0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ExtData_Index0 = new System.Windows.Forms.Button();
            this.txt_ExtData_Index2_Size = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ExtData_Index2 = new System.Windows.Forms.Button();
            this.txt_ExtData_Index1_Size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ExtData_Index1 = new System.Windows.Forms.Button();
            this.txt_ExtData_Index2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ExtData_Index1 = new System.Windows.Forms.TextBox();
            this.txt_ExtData_Index0_Size = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MsgIndex = new System.Windows.Forms.NumericUpDown();
            this.btn_SendData = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RS232Scan = new System.Windows.Forms.Timer(this.components);
            this.MachineScan = new System.Windows.Forms.Timer(this.components);
            this.btn_DeviceID = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_PrintLines = new System.Windows.Forms.Button();
            this.cbx_DeviceID = new System.Windows.Forms.ComboBox();
            this.tbl_Limits = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_BuildZanasiCmd = new System.Windows.Forms.Button();
            this.tbl_BuidZanasiCmd = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Zanasi4700 = new System.Windows.Forms.TabPage();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_ReadData = new System.Windows.Forms.RichTextBox();
            this.tab_ODBC = new System.Windows.Forms.TabPage();
            this.tab_RemoteIO = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_ADAM6250_Port = new System.Windows.Forms.TextBox();
            this.txt_ADAM6250_IP = new System.Windows.Forms.TextBox();
            this.btn_RemoteIODisconnect = new System.Windows.Forms.Button();
            this.btn_RemoteIOConnect = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DI11 = new MetroFramework.Controls.MetroCheckBox();
            this.DI10 = new MetroFramework.Controls.MetroCheckBox();
            this.DI9 = new MetroFramework.Controls.MetroCheckBox();
            this.DI8 = new MetroFramework.Controls.MetroCheckBox();
            this.DI7 = new MetroFramework.Controls.MetroCheckBox();
            this.DI6 = new MetroFramework.Controls.MetroCheckBox();
            this.DI5 = new MetroFramework.Controls.MetroCheckBox();
            this.DI4 = new MetroFramework.Controls.MetroCheckBox();
            this.DI3 = new MetroFramework.Controls.MetroCheckBox();
            this.DI2 = new MetroFramework.Controls.MetroCheckBox();
            this.DI1 = new MetroFramework.Controls.MetroCheckBox();
            this.DI0 = new MetroFramework.Controls.MetroCheckBox();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.btn_ForceOutputs = new MetroFramework.Controls.MetroCheckBox();
            this.pnl_Outputs = new System.Windows.Forms.Panel();
            this.DO0 = new MetroFramework.Controls.MetroCheckBox();
            this.DO1 = new MetroFramework.Controls.MetroCheckBox();
            this.DO5 = new MetroFramework.Controls.MetroCheckBox();
            this.DO2 = new MetroFramework.Controls.MetroCheckBox();
            this.DO4 = new MetroFramework.Controls.MetroCheckBox();
            this.DO3 = new MetroFramework.Controls.MetroCheckBox();
            this.tab_Servo = new System.Windows.Forms.TabPage();
            this.pnl_ServoControl = new System.Windows.Forms.GroupBox();
            this.btn_CMMO_SelectRecord_5 = new System.Windows.Forms.RadioButton();
            this.btn_CMMO_SelectRecord_1 = new System.Windows.Forms.RadioButton();
            this.btn_CMMO_SelectRecord_2 = new System.Windows.Forms.RadioButton();
            this.btn_CMMO_Start = new System.Windows.Forms.CheckBox();
            this.btn_CMMO_Stop = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label91 = new System.Windows.Forms.Label();
            this.cbx_Bit0 = new MetroFramework.Controls.MetroCheckBox();
            this.label93 = new System.Windows.Forms.Label();
            this.cbx_Bit1 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit15 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit14 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit3 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit13 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit4 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit12 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit5 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit11 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit6 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit10 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit7 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit9 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Bit8 = new MetroFramework.Controls.MetroCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnl_CMMO_Control = new System.Windows.Forms.Panel();
            this.label105 = new System.Windows.Forms.Label();
            this.cbx_Reg1Bit8 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit0 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit9 = new MetroFramework.Controls.MetroCheckBox();
            this.label106 = new System.Windows.Forms.Label();
            this.cbx_Reg1Bit7 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit1 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit10 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit15 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit6 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit11 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit14 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit5 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit3 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit12 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit13 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Reg1Bit4 = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ServoDisconnect = new System.Windows.Forms.Button();
            this.btn_ServoConnect = new System.Windows.Forms.Button();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.txt_CMMO_RecSelected = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_CMMO_Position = new System.Windows.Forms.Label();
            this.txt_CMMOConnStatus = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.btn_CMMO_Remote = new MetroFramework.Controls.MetroToggle();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Zanasi4700_Port = new System.Windows.Forms.Label();
            this.txt_Zanasi4700_IP = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.cntr_Comm.SuspendLayout();
            this.cntr_Cmd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MsgIndex)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Limits)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BuidZanasiCmd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_Zanasi4700.SuspendLayout();
            this.tab_ODBC.SuspendLayout();
            this.tab_RemoteIO.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tab4.SuspendLayout();
            this.pnl_Outputs.SuspendLayout();
            this.tab_Servo.SuspendLayout();
            this.pnl_ServoControl.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnl_CMMO_Control.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Header.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Header.Size = new System.Drawing.Size(492, 28);
            this.Header.TabIndex = 0;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareInfoToolStripMenuItem,
            this.btn_TransInfo});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // softwareInfoToolStripMenuItem
            // 
            this.softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            this.softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.softwareInfoToolStripMenuItem.Text = "Software Info";
            this.softwareInfoToolStripMenuItem.Click += new System.EventHandler(this.SoftwareInfoToolStripMenuItem_Click);
            // 
            // btn_TransInfo
            // 
            this.btn_TransInfo.Name = "btn_TransInfo";
            this.btn_TransInfo.Size = new System.Drawing.Size(185, 26);
            this.btn_TransInfo.Text = "Transducer Info";
            this.btn_TransInfo.Click += new System.EventHandler(this.Btn_TransInfo_Click);
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Footer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Hora,
            this.lb_Fecha});
            this.Footer.Location = new System.Drawing.Point(0, 766);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.Footer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Footer.Size = new System.Drawing.Size(492, 25);
            this.Footer.TabIndex = 1;
            // 
            // lb_Hora
            // 
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(51, 20);
            this.lb_Hora.Text = "--:--:--";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(69, 20);
            this.lb_Fecha.Text = "--/--/----";
            // 
            // LocalClock
            // 
            this.LocalClock.Interval = 1000;
            this.LocalClock.Tick += new System.EventHandler(this.LocalClock_Tick);
            // 
            // cntr_Comm
            // 
            this.cntr_Comm.Controls.Add(this.txt_Zanasi4700_IP);
            this.cntr_Comm.Controls.Add(this.txt_Zanasi4700_Port);
            this.cntr_Comm.Controls.Add(this.label9);
            this.cntr_Comm.Controls.Add(this.label8);
            this.cntr_Comm.Controls.Add(this.btn_Disconnect);
            this.cntr_Comm.Controls.Add(this.btn_Connect);
            this.cntr_Comm.Location = new System.Drawing.Point(7, 23);
            this.cntr_Comm.Margin = new System.Windows.Forms.Padding(4);
            this.cntr_Comm.Name = "cntr_Comm";
            this.cntr_Comm.Padding = new System.Windows.Forms.Padding(4);
            this.cntr_Comm.Size = new System.Drawing.Size(448, 110);
            this.cntr_Comm.TabIndex = 3;
            this.cntr_Comm.TabStop = false;
            this.cntr_Comm.Text = "Ethernet Communication | TCP/IP";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(308, 66);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(120, 31);
            this.btn_Disconnect.TabIndex = 4;
            this.btn_Disconnect.Text = "<9> Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(308, 27);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(120, 31);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "<3> Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // cntr_Cmd
            // 
            this.cntr_Cmd.Controls.Add(this.label6);
            this.cntr_Cmd.Controls.Add(this.txt_CustomSend_Size);
            this.cntr_Cmd.Controls.Add(this.txt_CustomSend);
            this.cntr_Cmd.Controls.Add(this.groupBox1);
            this.cntr_Cmd.Controls.Add(this.label2);
            this.cntr_Cmd.Controls.Add(this.txt_MsgIndex);
            this.cntr_Cmd.Controls.Add(this.btn_SendData);
            this.cntr_Cmd.Location = new System.Drawing.Point(7, 152);
            this.cntr_Cmd.Margin = new System.Windows.Forms.Padding(4);
            this.cntr_Cmd.Name = "cntr_Cmd";
            this.cntr_Cmd.Padding = new System.Windows.Forms.Padding(4);
            this.cntr_Cmd.Size = new System.Drawing.Size(449, 332);
            this.cntr_Cmd.TabIndex = 4;
            this.cntr_Cmd.TabStop = false;
            this.cntr_Cmd.Text = "Zanasi 4700 Messages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Size";
            // 
            // txt_CustomSend_Size
            // 
            this.txt_CustomSend_Size.AutoSize = true;
            this.txt_CustomSend_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomSend_Size.Location = new System.Drawing.Point(396, 38);
            this.txt_CustomSend_Size.Name = "txt_CustomSend_Size";
            this.txt_CustomSend_Size.Size = new System.Drawing.Size(34, 25);
            this.txt_CustomSend_Size.TabIndex = 30;
            this.txt_CustomSend_Size.Text = "00";
            this.txt_CustomSend_Size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CustomSend
            // 
            this.txt_CustomSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_CustomSend.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomSend.Location = new System.Drawing.Point(152, 38);
            this.txt_CustomSend.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CustomSend.MaxLength = 100;
            this.txt_CustomSend.Name = "txt_CustomSend";
            this.txt_CustomSend.Size = new System.Drawing.Size(195, 27);
            this.txt_CustomSend.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ExtDataAutoSeq);
            this.groupBox1.Controls.Add(this.txt_ExtData_Index0);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ExtData_Index0);
            this.groupBox1.Controls.Add(this.txt_ExtData_Index2_Size);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_ExtData_Index2);
            this.groupBox1.Controls.Add(this.txt_ExtData_Index1_Size);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_ExtData_Index1);
            this.groupBox1.Controls.Add(this.txt_ExtData_Index2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ExtData_Index1);
            this.groupBox1.Controls.Add(this.txt_ExtData_Index0_Size);
            this.groupBox1.Location = new System.Drawing.Point(16, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(425, 209);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "External Data";
            // 
            // btn_ExtDataAutoSeq
            // 
            this.btn_ExtDataAutoSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExtDataAutoSeq.Location = new System.Drawing.Point(8, 163);
            this.btn_ExtDataAutoSeq.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExtDataAutoSeq.Name = "btn_ExtDataAutoSeq";
            this.btn_ExtDataAutoSeq.Size = new System.Drawing.Size(406, 39);
            this.btn_ExtDataAutoSeq.TabIndex = 29;
            this.btn_ExtDataAutoSeq.Text = "<8> Start Sequence";
            this.btn_ExtDataAutoSeq.UseVisualStyleBackColor = true;
            this.btn_ExtDataAutoSeq.Click += new System.EventHandler(this.btn_ExtDataAutoSeq_Click);
            // 
            // txt_ExtData_Index0
            // 
            this.txt_ExtData_Index0.BackColor = System.Drawing.Color.Thistle;
            this.txt_ExtData_Index0.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExtData_Index0.ForeColor = System.Drawing.Color.Blue;
            this.txt_ExtData_Index0.Location = new System.Drawing.Point(136, 63);
            this.txt_ExtData_Index0.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExtData_Index0.MaxLength = 12;
            this.txt_ExtData_Index0.Name = "txt_ExtData_Index0";
            this.txt_ExtData_Index0.Size = new System.Drawing.Size(195, 27);
            this.txt_ExtData_Index0.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Index";
            // 
            // btn_ExtData_Index0
            // 
            this.btn_ExtData_Index0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExtData_Index0.Location = new System.Drawing.Point(8, 63);
            this.btn_ExtData_Index0.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExtData_Index0.Name = "btn_ExtData_Index0";
            this.btn_ExtData_Index0.Size = new System.Drawing.Size(120, 27);
            this.btn_ExtData_Index0.TabIndex = 13;
            this.btn_ExtData_Index0.Text = "Write Line 1";
            this.btn_ExtData_Index0.UseVisualStyleBackColor = true;
            this.btn_ExtData_Index0.Click += new System.EventHandler(this.btn_ExtData_Index0_Click);
            // 
            // txt_ExtData_Index2_Size
            // 
            this.txt_ExtData_Index2_Size.AutoSize = true;
            this.txt_ExtData_Index2_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExtData_Index2_Size.Location = new System.Drawing.Point(380, 129);
            this.txt_ExtData_Index2_Size.Name = "txt_ExtData_Index2_Size";
            this.txt_ExtData_Index2_Size.Size = new System.Drawing.Size(34, 25);
            this.txt_ExtData_Index2_Size.TabIndex = 26;
            this.txt_ExtData_Index2_Size.Text = "00";
            this.txt_ExtData_Index2_Size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Size";
            // 
            // btn_ExtData_Index2
            // 
            this.btn_ExtData_Index2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExtData_Index2.Location = new System.Drawing.Point(8, 128);
            this.btn_ExtData_Index2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExtData_Index2.Name = "btn_ExtData_Index2";
            this.btn_ExtData_Index2.Size = new System.Drawing.Size(120, 27);
            this.btn_ExtData_Index2.TabIndex = 11;
            this.btn_ExtData_Index2.Text = "Write Line 3";
            this.btn_ExtData_Index2.UseVisualStyleBackColor = true;
            this.btn_ExtData_Index2.Click += new System.EventHandler(this.btn_ExtData_Index2_Click);
            // 
            // txt_ExtData_Index1_Size
            // 
            this.txt_ExtData_Index1_Size.AutoSize = true;
            this.txt_ExtData_Index1_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExtData_Index1_Size.Location = new System.Drawing.Point(380, 97);
            this.txt_ExtData_Index1_Size.Name = "txt_ExtData_Index1_Size";
            this.txt_ExtData_Index1_Size.Size = new System.Drawing.Size(34, 25);
            this.txt_ExtData_Index1_Size.TabIndex = 24;
            this.txt_ExtData_Index1_Size.Text = "00";
            this.txt_ExtData_Index1_Size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Size";
            // 
            // btn_ExtData_Index1
            // 
            this.btn_ExtData_Index1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExtData_Index1.Location = new System.Drawing.Point(8, 95);
            this.btn_ExtData_Index1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExtData_Index1.Name = "btn_ExtData_Index1";
            this.btn_ExtData_Index1.Size = new System.Drawing.Size(120, 27);
            this.btn_ExtData_Index1.TabIndex = 14;
            this.btn_ExtData_Index1.Text = "Write Line 2";
            this.btn_ExtData_Index1.UseVisualStyleBackColor = true;
            this.btn_ExtData_Index1.Click += new System.EventHandler(this.btn_ExtData_Index1_Click_1);
            // 
            // txt_ExtData_Index2
            // 
            this.txt_ExtData_Index2.BackColor = System.Drawing.Color.Thistle;
            this.txt_ExtData_Index2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExtData_Index2.ForeColor = System.Drawing.Color.Blue;
            this.txt_ExtData_Index2.Location = new System.Drawing.Point(136, 128);
            this.txt_ExtData_Index2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExtData_Index2.MaxLength = 12;
            this.txt_ExtData_Index2.Name = "txt_ExtData_Index2";
            this.txt_ExtData_Index2.Size = new System.Drawing.Size(195, 27);
            this.txt_ExtData_Index2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Message (max. 12 characters)";
            // 
            // txt_ExtData_Index1
            // 
            this.txt_ExtData_Index1.BackColor = System.Drawing.Color.Thistle;
            this.txt_ExtData_Index1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExtData_Index1.ForeColor = System.Drawing.Color.Blue;
            this.txt_ExtData_Index1.Location = new System.Drawing.Point(136, 96);
            this.txt_ExtData_Index1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExtData_Index1.MaxLength = 12;
            this.txt_ExtData_Index1.Name = "txt_ExtData_Index1";
            this.txt_ExtData_Index1.Size = new System.Drawing.Size(195, 27);
            this.txt_ExtData_Index1.TabIndex = 21;
            // 
            // txt_ExtData_Index0_Size
            // 
            this.txt_ExtData_Index0_Size.AutoSize = true;
            this.txt_ExtData_Index0_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExtData_Index0_Size.Location = new System.Drawing.Point(380, 64);
            this.txt_ExtData_Index0_Size.Name = "txt_ExtData_Index0_Size";
            this.txt_ExtData_Index0_Size.Size = new System.Drawing.Size(34, 25);
            this.txt_ExtData_Index0_Size.TabIndex = 20;
            this.txt_ExtData_Index0_Size.Text = "00";
            this.txt_ExtData_Index0_Size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select message index";
            // 
            // txt_MsgIndex
            // 
            this.txt_MsgIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MsgIndex.Location = new System.Drawing.Point(177, 73);
            this.txt_MsgIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MsgIndex.Name = "txt_MsgIndex";
            this.txt_MsgIndex.Size = new System.Drawing.Size(64, 30);
            this.txt_MsgIndex.TabIndex = 17;
            // 
            // btn_SendData
            // 
            this.btn_SendData.Location = new System.Drawing.Point(24, 36);
            this.btn_SendData.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendData.Name = "btn_SendData";
            this.btn_SendData.Size = new System.Drawing.Size(120, 31);
            this.btn_SendData.TabIndex = 6;
            this.btn_SendData.Text = "Custom Send";
            this.btn_SendData.UseVisualStyleBackColor = true;
            this.btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click);
            // 
            // RS232Scan
            // 
            this.RS232Scan.Interval = 150;
            this.RS232Scan.Tick += new System.EventHandler(this.IntervalScan_Tick);
            // 
            // MachineScan
            // 
            this.MachineScan.Interval = 150;
            this.MachineScan.Tick += new System.EventHandler(this.MachineScan_Tick);
            // 
            // btn_DeviceID
            // 
            this.btn_DeviceID.Location = new System.Drawing.Point(8, 29);
            this.btn_DeviceID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeviceID.Name = "btn_DeviceID";
            this.btn_DeviceID.Size = new System.Drawing.Size(120, 31);
            this.btn_DeviceID.TabIndex = 32;
            this.btn_DeviceID.Text = "<4> Device ID";
            this.btn_DeviceID.UseVisualStyleBackColor = true;
            this.btn_DeviceID.Click += new System.EventHandler(this.btn_DeviceID_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_PrintLines);
            this.groupBox2.Controls.Add(this.cbx_DeviceID);
            this.groupBox2.Controls.Add(this.tbl_Limits);
            this.groupBox2.Controls.Add(this.btn_DeviceID);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 188);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database | ODBC";
            // 
            // btn_PrintLines
            // 
            this.btn_PrintLines.Location = new System.Drawing.Point(8, 68);
            this.btn_PrintLines.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PrintLines.Name = "btn_PrintLines";
            this.btn_PrintLines.Size = new System.Drawing.Size(248, 31);
            this.btn_PrintLines.TabIndex = 35;
            this.btn_PrintLines.Text = "<6> Get Message Lines";
            this.btn_PrintLines.UseVisualStyleBackColor = true;
            this.btn_PrintLines.Click += new System.EventHandler(this.btn_PrintLines_Click);
            // 
            // cbx_DeviceID
            // 
            this.cbx_DeviceID.FormattingEnabled = true;
            this.cbx_DeviceID.Location = new System.Drawing.Point(136, 33);
            this.cbx_DeviceID.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_DeviceID.Name = "cbx_DeviceID";
            this.cbx_DeviceID.Size = new System.Drawing.Size(120, 24);
            this.cbx_DeviceID.TabIndex = 34;
            // 
            // tbl_Limits
            // 
            this.tbl_Limits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbl_Limits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Limits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Limits.Location = new System.Drawing.Point(8, 110);
            this.tbl_Limits.Name = "tbl_Limits";
            this.tbl_Limits.RowHeadersVisible = false;
            this.tbl_Limits.RowTemplate.Height = 24;
            this.tbl_Limits.Size = new System.Drawing.Size(438, 71);
            this.tbl_Limits.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_BuildZanasiCmd);
            this.groupBox3.Controls.Add(this.tbl_BuidZanasiCmd);
            this.groupBox3.Location = new System.Drawing.Point(6, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 481);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pallet | Prepare Data Structure";
            // 
            // btn_BuildZanasiCmd
            // 
            this.btn_BuildZanasiCmd.Location = new System.Drawing.Point(8, 48);
            this.btn_BuildZanasiCmd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuildZanasiCmd.Name = "btn_BuildZanasiCmd";
            this.btn_BuildZanasiCmd.Size = new System.Drawing.Size(248, 31);
            this.btn_BuildZanasiCmd.TabIndex = 36;
            this.btn_BuildZanasiCmd.Text = "<8> Build Zanasi Command";
            this.btn_BuildZanasiCmd.UseVisualStyleBackColor = true;
            this.btn_BuildZanasiCmd.Click += new System.EventHandler(this.btn_BuildZanasiCmd_Click);
            // 
            // tbl_BuidZanasiCmd
            // 
            this.tbl_BuidZanasiCmd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbl_BuidZanasiCmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_BuidZanasiCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_BuidZanasiCmd.Location = new System.Drawing.Point(8, 86);
            this.tbl_BuidZanasiCmd.Name = "tbl_BuidZanasiCmd";
            this.tbl_BuidZanasiCmd.RowHeadersVisible = false;
            this.tbl_BuidZanasiCmd.RowTemplate.Height = 24;
            this.tbl_BuidZanasiCmd.Size = new System.Drawing.Size(438, 389);
            this.tbl_BuidZanasiCmd.TabIndex = 34;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Zanasi4700);
            this.tabControl1.Controls.Add(this.tab_ODBC);
            this.tabControl1.Controls.Add(this.tab_RemoteIO);
            this.tabControl1.Controls.Add(this.tab_Servo);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 717);
            this.tabControl1.TabIndex = 35;
            // 
            // tab_Zanasi4700
            // 
            this.tab_Zanasi4700.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Zanasi4700.Controls.Add(this.btn_Clear);
            this.tab_Zanasi4700.Controls.Add(this.txt_ReadData);
            this.tab_Zanasi4700.Controls.Add(this.cntr_Cmd);
            this.tab_Zanasi4700.Controls.Add(this.cntr_Comm);
            this.tab_Zanasi4700.Location = new System.Drawing.Point(4, 25);
            this.tab_Zanasi4700.Name = "tab_Zanasi4700";
            this.tab_Zanasi4700.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Zanasi4700.Size = new System.Drawing.Size(464, 688);
            this.tab_Zanasi4700.TabIndex = 0;
            this.tab_Zanasi4700.Text = "Zanasi 4700 Printer Inkjet";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(6, 650);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 31);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear Log Data";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // txt_ReadData
            // 
            this.txt_ReadData.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ReadData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReadData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ReadData.EnableAutoDragDrop = true;
            this.txt_ReadData.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadData.Location = new System.Drawing.Point(6, 492);
            this.txt_ReadData.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReadData.Name = "txt_ReadData";
            this.txt_ReadData.ReadOnly = true;
            this.txt_ReadData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txt_ReadData.ShowSelectionMargin = true;
            this.txt_ReadData.Size = new System.Drawing.Size(449, 189);
            this.txt_ReadData.TabIndex = 11;
            this.txt_ReadData.Text = "";
            // 
            // tab_ODBC
            // 
            this.tab_ODBC.BackColor = System.Drawing.SystemColors.Control;
            this.tab_ODBC.Controls.Add(this.groupBox2);
            this.tab_ODBC.Controls.Add(this.groupBox3);
            this.tab_ODBC.Location = new System.Drawing.Point(4, 25);
            this.tab_ODBC.Name = "tab_ODBC";
            this.tab_ODBC.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ODBC.Size = new System.Drawing.Size(464, 688);
            this.tab_ODBC.TabIndex = 1;
            this.tab_ODBC.Text = "ODBC Database";
            // 
            // tab_RemoteIO
            // 
            this.tab_RemoteIO.BackColor = System.Drawing.SystemColors.Control;
            this.tab_RemoteIO.Controls.Add(this.groupBox5);
            this.tab_RemoteIO.Controls.Add(this.tabControl3);
            this.tab_RemoteIO.Location = new System.Drawing.Point(4, 25);
            this.tab_RemoteIO.Name = "tab_RemoteIO";
            this.tab_RemoteIO.Size = new System.Drawing.Size(464, 688);
            this.tab_RemoteIO.TabIndex = 2;
            this.tab_RemoteIO.Text = "RemoteIO";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_ADAM6250_Port);
            this.groupBox5.Controls.Add(this.txt_ADAM6250_IP);
            this.groupBox5.Controls.Add(this.btn_RemoteIODisconnect);
            this.groupBox5.Controls.Add(this.btn_RemoteIOConnect);
            this.groupBox5.Location = new System.Drawing.Point(75, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(270, 96);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modbus TCP Communication";
            // 
            // txt_ADAM6250_Port
            // 
            this.txt_ADAM6250_Port.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ADAM6250_Port.Enabled = false;
            this.txt_ADAM6250_Port.Location = new System.Drawing.Point(136, 27);
            this.txt_ADAM6250_Port.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ADAM6250_Port.Name = "txt_ADAM6250_Port";
            this.txt_ADAM6250_Port.Size = new System.Drawing.Size(120, 22);
            this.txt_ADAM6250_Port.TabIndex = 9;
            // 
            // txt_ADAM6250_IP
            // 
            this.txt_ADAM6250_IP.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ADAM6250_IP.Enabled = false;
            this.txt_ADAM6250_IP.Location = new System.Drawing.Point(8, 27);
            this.txt_ADAM6250_IP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ADAM6250_IP.Name = "txt_ADAM6250_IP";
            this.txt_ADAM6250_IP.Size = new System.Drawing.Size(120, 22);
            this.txt_ADAM6250_IP.TabIndex = 8;
            // 
            // btn_RemoteIODisconnect
            // 
            this.btn_RemoteIODisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_RemoteIODisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoteIODisconnect.Location = new System.Drawing.Point(136, 57);
            this.btn_RemoteIODisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoteIODisconnect.Name = "btn_RemoteIODisconnect";
            this.btn_RemoteIODisconnect.Size = new System.Drawing.Size(120, 31);
            this.btn_RemoteIODisconnect.TabIndex = 4;
            this.btn_RemoteIODisconnect.Text = "Disconnect";
            this.btn_RemoteIODisconnect.UseVisualStyleBackColor = true;
            this.btn_RemoteIODisconnect.Click += new System.EventHandler(this.btn_RemoteIODisconnect_Click);
            // 
            // btn_RemoteIOConnect
            // 
            this.btn_RemoteIOConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_RemoteIOConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoteIOConnect.Location = new System.Drawing.Point(8, 57);
            this.btn_RemoteIOConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoteIOConnect.Name = "btn_RemoteIOConnect";
            this.btn_RemoteIOConnect.Size = new System.Drawing.Size(120, 31);
            this.btn_RemoteIOConnect.TabIndex = 3;
            this.btn_RemoteIOConnect.Text = "Connect";
            this.btn_RemoteIOConnect.UseVisualStyleBackColor = true;
            this.btn_RemoteIOConnect.Click += new System.EventHandler(this.btn_RemoteIOConnect_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tab4);
            this.tabControl3.Location = new System.Drawing.Point(75, 235);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(270, 330);
            this.tabControl3.TabIndex = 33;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.DI11);
            this.tabPage3.Controls.Add(this.DI10);
            this.tabPage3.Controls.Add(this.DI9);
            this.tabPage3.Controls.Add(this.DI8);
            this.tabPage3.Controls.Add(this.DI7);
            this.tabPage3.Controls.Add(this.DI6);
            this.tabPage3.Controls.Add(this.DI5);
            this.tabPage3.Controls.Add(this.DI4);
            this.tabPage3.Controls.Add(this.DI3);
            this.tabPage3.Controls.Add(this.DI2);
            this.tabPage3.Controls.Add(this.DI1);
            this.tabPage3.Controls.Add(this.DI0);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(262, 301);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Inputs";
            // 
            // DI11
            // 
            this.DI11.AutoSize = true;
            this.DI11.BackColor = System.Drawing.SystemColors.Control;
            this.DI11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI11.CustomBackground = true;
            this.DI11.CustomForeColor = true;
            this.DI11.Enabled = false;
            this.DI11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI11.ForeColor = System.Drawing.Color.Gray;
            this.DI11.Location = new System.Drawing.Point(10, 258);
            this.DI11.Name = "DI11";
            this.DI11.Size = new System.Drawing.Size(54, 17);
            this.DI11.Style = MetroFramework.MetroColorStyle.Green;
            this.DI11.TabIndex = 30;
            this.DI11.Text = "DI 11";
            this.DI11.UseStyleColors = true;
            this.DI11.UseVisualStyleBackColor = false;
            // 
            // DI10
            // 
            this.DI10.AutoSize = true;
            this.DI10.BackColor = System.Drawing.SystemColors.Control;
            this.DI10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI10.CustomBackground = true;
            this.DI10.CustomForeColor = true;
            this.DI10.Enabled = false;
            this.DI10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI10.ForeColor = System.Drawing.Color.Gray;
            this.DI10.Location = new System.Drawing.Point(10, 235);
            this.DI10.Name = "DI10";
            this.DI10.Size = new System.Drawing.Size(54, 17);
            this.DI10.Style = MetroFramework.MetroColorStyle.Green;
            this.DI10.TabIndex = 29;
            this.DI10.Text = "DI 10";
            this.DI10.UseStyleColors = true;
            this.DI10.UseVisualStyleBackColor = false;
            // 
            // DI9
            // 
            this.DI9.AutoSize = true;
            this.DI9.BackColor = System.Drawing.SystemColors.Control;
            this.DI9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI9.CustomBackground = true;
            this.DI9.CustomForeColor = true;
            this.DI9.Enabled = false;
            this.DI9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI9.ForeColor = System.Drawing.Color.Gray;
            this.DI9.Location = new System.Drawing.Point(10, 212);
            this.DI9.Name = "DI9";
            this.DI9.Size = new System.Drawing.Size(47, 17);
            this.DI9.Style = MetroFramework.MetroColorStyle.Green;
            this.DI9.TabIndex = 28;
            this.DI9.Text = "DI 9";
            this.DI9.UseStyleColors = true;
            this.DI9.UseVisualStyleBackColor = false;
            // 
            // DI8
            // 
            this.DI8.AutoSize = true;
            this.DI8.BackColor = System.Drawing.SystemColors.Control;
            this.DI8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI8.CustomBackground = true;
            this.DI8.CustomForeColor = true;
            this.DI8.Enabled = false;
            this.DI8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI8.ForeColor = System.Drawing.Color.Gray;
            this.DI8.Location = new System.Drawing.Point(10, 189);
            this.DI8.Name = "DI8";
            this.DI8.Size = new System.Drawing.Size(47, 17);
            this.DI8.Style = MetroFramework.MetroColorStyle.Green;
            this.DI8.TabIndex = 27;
            this.DI8.Text = "DI 8";
            this.DI8.UseStyleColors = true;
            this.DI8.UseVisualStyleBackColor = false;
            // 
            // DI7
            // 
            this.DI7.AutoSize = true;
            this.DI7.BackColor = System.Drawing.SystemColors.Control;
            this.DI7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI7.CustomBackground = true;
            this.DI7.CustomForeColor = true;
            this.DI7.Enabled = false;
            this.DI7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI7.ForeColor = System.Drawing.Color.Gray;
            this.DI7.Location = new System.Drawing.Point(10, 166);
            this.DI7.Name = "DI7";
            this.DI7.Size = new System.Drawing.Size(47, 17);
            this.DI7.Style = MetroFramework.MetroColorStyle.Green;
            this.DI7.TabIndex = 26;
            this.DI7.Text = "DI 7";
            this.DI7.UseStyleColors = true;
            this.DI7.UseVisualStyleBackColor = false;
            // 
            // DI6
            // 
            this.DI6.AutoSize = true;
            this.DI6.BackColor = System.Drawing.SystemColors.Control;
            this.DI6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI6.CustomBackground = true;
            this.DI6.CustomForeColor = true;
            this.DI6.Enabled = false;
            this.DI6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI6.ForeColor = System.Drawing.Color.Gray;
            this.DI6.Location = new System.Drawing.Point(10, 143);
            this.DI6.Name = "DI6";
            this.DI6.Size = new System.Drawing.Size(51, 17);
            this.DI6.Style = MetroFramework.MetroColorStyle.Green;
            this.DI6.TabIndex = 25;
            this.DI6.Text = "DI 6 ";
            this.DI6.UseStyleColors = true;
            this.DI6.UseVisualStyleBackColor = false;
            // 
            // DI5
            // 
            this.DI5.AutoSize = true;
            this.DI5.BackColor = System.Drawing.SystemColors.Control;
            this.DI5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI5.CustomBackground = true;
            this.DI5.CustomForeColor = true;
            this.DI5.Enabled = false;
            this.DI5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI5.ForeColor = System.Drawing.Color.Gray;
            this.DI5.Location = new System.Drawing.Point(10, 120);
            this.DI5.Name = "DI5";
            this.DI5.Size = new System.Drawing.Size(47, 17);
            this.DI5.Style = MetroFramework.MetroColorStyle.Green;
            this.DI5.TabIndex = 24;
            this.DI5.Text = "DI 5";
            this.DI5.UseStyleColors = true;
            this.DI5.UseVisualStyleBackColor = false;
            // 
            // DI4
            // 
            this.DI4.AutoSize = true;
            this.DI4.BackColor = System.Drawing.SystemColors.Control;
            this.DI4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI4.CustomBackground = true;
            this.DI4.CustomForeColor = true;
            this.DI4.Enabled = false;
            this.DI4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI4.ForeColor = System.Drawing.Color.Gray;
            this.DI4.Location = new System.Drawing.Point(10, 97);
            this.DI4.Name = "DI4";
            this.DI4.Size = new System.Drawing.Size(47, 17);
            this.DI4.Style = MetroFramework.MetroColorStyle.Green;
            this.DI4.TabIndex = 23;
            this.DI4.Text = "DI 4";
            this.DI4.UseStyleColors = true;
            this.DI4.UseVisualStyleBackColor = false;
            // 
            // DI3
            // 
            this.DI3.AutoSize = true;
            this.DI3.BackColor = System.Drawing.SystemColors.Control;
            this.DI3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI3.CustomBackground = true;
            this.DI3.CustomForeColor = true;
            this.DI3.Enabled = false;
            this.DI3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI3.ForeColor = System.Drawing.Color.Gray;
            this.DI3.Location = new System.Drawing.Point(10, 74);
            this.DI3.Name = "DI3";
            this.DI3.Size = new System.Drawing.Size(51, 17);
            this.DI3.Style = MetroFramework.MetroColorStyle.Green;
            this.DI3.TabIndex = 22;
            this.DI3.Text = "DI 3 ";
            this.DI3.UseStyleColors = true;
            this.DI3.UseVisualStyleBackColor = false;
            // 
            // DI2
            // 
            this.DI2.AutoSize = true;
            this.DI2.BackColor = System.Drawing.SystemColors.Control;
            this.DI2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI2.CustomBackground = true;
            this.DI2.CustomForeColor = true;
            this.DI2.Enabled = false;
            this.DI2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI2.ForeColor = System.Drawing.Color.Gray;
            this.DI2.Location = new System.Drawing.Point(10, 51);
            this.DI2.Name = "DI2";
            this.DI2.Size = new System.Drawing.Size(47, 17);
            this.DI2.Style = MetroFramework.MetroColorStyle.Green;
            this.DI2.TabIndex = 21;
            this.DI2.Text = "DI 2";
            this.DI2.UseStyleColors = true;
            this.DI2.UseVisualStyleBackColor = false;
            // 
            // DI1
            // 
            this.DI1.AutoSize = true;
            this.DI1.BackColor = System.Drawing.SystemColors.Control;
            this.DI1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI1.CustomBackground = true;
            this.DI1.CustomForeColor = true;
            this.DI1.Enabled = false;
            this.DI1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI1.ForeColor = System.Drawing.Color.Gray;
            this.DI1.Location = new System.Drawing.Point(10, 28);
            this.DI1.Name = "DI1";
            this.DI1.Size = new System.Drawing.Size(47, 17);
            this.DI1.Style = MetroFramework.MetroColorStyle.Green;
            this.DI1.TabIndex = 20;
            this.DI1.Text = "DI 1";
            this.DI1.UseStyleColors = true;
            this.DI1.UseVisualStyleBackColor = false;
            // 
            // DI0
            // 
            this.DI0.AutoSize = true;
            this.DI0.BackColor = System.Drawing.SystemColors.Control;
            this.DI0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DI0.CustomBackground = true;
            this.DI0.CustomForeColor = true;
            this.DI0.Enabled = false;
            this.DI0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DI0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DI0.ForeColor = System.Drawing.Color.Gray;
            this.DI0.Location = new System.Drawing.Point(10, 5);
            this.DI0.Name = "DI0";
            this.DI0.Size = new System.Drawing.Size(47, 17);
            this.DI0.Style = MetroFramework.MetroColorStyle.Green;
            this.DI0.TabIndex = 19;
            this.DI0.Text = "DI 0";
            this.DI0.UseStyleColors = true;
            this.DI0.UseVisualStyleBackColor = false;
            // 
            // tab4
            // 
            this.tab4.BackColor = System.Drawing.SystemColors.Control;
            this.tab4.Controls.Add(this.btn_ForceOutputs);
            this.tab4.Controls.Add(this.pnl_Outputs);
            this.tab4.Location = new System.Drawing.Point(4, 25);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(262, 301);
            this.tab4.TabIndex = 1;
            this.tab4.Text = "Outputs";
            // 
            // btn_ForceOutputs
            // 
            this.btn_ForceOutputs.AutoSize = true;
            this.btn_ForceOutputs.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ForceOutputs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ForceOutputs.CustomBackground = true;
            this.btn_ForceOutputs.CustomForeColor = true;
            this.btn_ForceOutputs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ForceOutputs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btn_ForceOutputs.ForeColor = System.Drawing.Color.Black;
            this.btn_ForceOutputs.Location = new System.Drawing.Point(144, 9);
            this.btn_ForceOutputs.Name = "btn_ForceOutputs";
            this.btn_ForceOutputs.Size = new System.Drawing.Size(56, 17);
            this.btn_ForceOutputs.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_ForceOutputs.TabIndex = 33;
            this.btn_ForceOutputs.Text = "Force";
            this.btn_ForceOutputs.UseStyleColors = true;
            this.btn_ForceOutputs.UseVisualStyleBackColor = false;
            // 
            // pnl_Outputs
            // 
            this.pnl_Outputs.Controls.Add(this.DO0);
            this.pnl_Outputs.Controls.Add(this.DO1);
            this.pnl_Outputs.Controls.Add(this.DO5);
            this.pnl_Outputs.Controls.Add(this.DO2);
            this.pnl_Outputs.Controls.Add(this.DO4);
            this.pnl_Outputs.Controls.Add(this.DO3);
            this.pnl_Outputs.Location = new System.Drawing.Point(6, 6);
            this.pnl_Outputs.Name = "pnl_Outputs";
            this.pnl_Outputs.Size = new System.Drawing.Size(132, 289);
            this.pnl_Outputs.TabIndex = 31;
            // 
            // DO0
            // 
            this.DO0.AutoSize = true;
            this.DO0.BackColor = System.Drawing.SystemColors.Control;
            this.DO0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DO0.CustomBackground = true;
            this.DO0.CustomForeColor = true;
            this.DO0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DO0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DO0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DO0.Location = new System.Drawing.Point(3, 3);
            this.DO0.Name = "DO0";
            this.DO0.Size = new System.Drawing.Size(92, 17);
            this.DO0.Style = MetroFramework.MetroColorStyle.Green;
            this.DO0.TabIndex = 26;
            this.DO0.Text = "DO 0 (Print)";
            this.DO0.UseStyleColors = true;
            this.DO0.UseVisualStyleBackColor = false;
            // 
            // DO1
            // 
            this.DO1.AutoSize = true;
            this.DO1.BackColor = System.Drawing.SystemColors.Control;
            this.DO1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DO1.CustomBackground = true;
            this.DO1.CustomForeColor = true;
            this.DO1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DO1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DO1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DO1.Location = new System.Drawing.Point(3, 26);
            this.DO1.Name = "DO1";
            this.DO1.Size = new System.Drawing.Size(54, 17);
            this.DO1.Style = MetroFramework.MetroColorStyle.Green;
            this.DO1.TabIndex = 27;
            this.DO1.Text = "DO 1";
            this.DO1.UseStyleColors = true;
            this.DO1.UseVisualStyleBackColor = false;
            // 
            // DO5
            // 
            this.DO5.AutoSize = true;
            this.DO5.BackColor = System.Drawing.SystemColors.Control;
            this.DO5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DO5.CustomBackground = true;
            this.DO5.CustomForeColor = true;
            this.DO5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DO5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DO5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DO5.Location = new System.Drawing.Point(3, 118);
            this.DO5.Name = "DO5";
            this.DO5.Size = new System.Drawing.Size(54, 17);
            this.DO5.Style = MetroFramework.MetroColorStyle.Green;
            this.DO5.TabIndex = 31;
            this.DO5.Text = "DO 5";
            this.DO5.UseStyleColors = true;
            this.DO5.UseVisualStyleBackColor = false;
            // 
            // DO2
            // 
            this.DO2.AutoSize = true;
            this.DO2.BackColor = System.Drawing.SystemColors.Control;
            this.DO2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DO2.CustomBackground = true;
            this.DO2.CustomForeColor = true;
            this.DO2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DO2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DO2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DO2.Location = new System.Drawing.Point(3, 49);
            this.DO2.Name = "DO2";
            this.DO2.Size = new System.Drawing.Size(54, 17);
            this.DO2.Style = MetroFramework.MetroColorStyle.Green;
            this.DO2.TabIndex = 28;
            this.DO2.Text = "DO 2";
            this.DO2.UseStyleColors = true;
            this.DO2.UseVisualStyleBackColor = false;
            // 
            // DO4
            // 
            this.DO4.AutoSize = true;
            this.DO4.BackColor = System.Drawing.SystemColors.Control;
            this.DO4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DO4.CustomBackground = true;
            this.DO4.CustomForeColor = true;
            this.DO4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DO4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DO4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DO4.Location = new System.Drawing.Point(3, 95);
            this.DO4.Name = "DO4";
            this.DO4.Size = new System.Drawing.Size(54, 17);
            this.DO4.Style = MetroFramework.MetroColorStyle.Green;
            this.DO4.TabIndex = 30;
            this.DO4.Text = "DO 4";
            this.DO4.UseStyleColors = true;
            this.DO4.UseVisualStyleBackColor = false;
            // 
            // DO3
            // 
            this.DO3.AutoSize = true;
            this.DO3.BackColor = System.Drawing.SystemColors.Control;
            this.DO3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DO3.CustomBackground = true;
            this.DO3.CustomForeColor = true;
            this.DO3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DO3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DO3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DO3.Location = new System.Drawing.Point(3, 72);
            this.DO3.Name = "DO3";
            this.DO3.Size = new System.Drawing.Size(54, 17);
            this.DO3.Style = MetroFramework.MetroColorStyle.Green;
            this.DO3.TabIndex = 29;
            this.DO3.Text = "DO 3";
            this.DO3.UseStyleColors = true;
            this.DO3.UseVisualStyleBackColor = false;
            // 
            // tab_Servo
            // 
            this.tab_Servo.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Servo.Controls.Add(this.pnl_ServoControl);
            this.tab_Servo.Controls.Add(this.tabControl2);
            this.tab_Servo.Controls.Add(this.groupBox4);
            this.tab_Servo.Location = new System.Drawing.Point(4, 25);
            this.tab_Servo.Name = "tab_Servo";
            this.tab_Servo.Size = new System.Drawing.Size(464, 688);
            this.tab_Servo.TabIndex = 3;
            this.tab_Servo.Text = "Servo";
            // 
            // pnl_ServoControl
            // 
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_SelectRecord_5);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_SelectRecord_1);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_SelectRecord_2);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_Start);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_Stop);
            this.pnl_ServoControl.Location = new System.Drawing.Point(95, 246);
            this.pnl_ServoControl.Name = "pnl_ServoControl";
            this.pnl_ServoControl.Size = new System.Drawing.Size(271, 110);
            this.pnl_ServoControl.TabIndex = 564;
            this.pnl_ServoControl.TabStop = false;
            this.pnl_ServoControl.Text = "Control manual";
            // 
            // btn_CMMO_SelectRecord_5
            // 
            this.btn_CMMO_SelectRecord_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_CMMO_SelectRecord_5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CMMO_SelectRecord_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CMMO_SelectRecord_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CMMO_SelectRecord_5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.btn_CMMO_SelectRecord_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CMMO_SelectRecord_5.Location = new System.Drawing.Point(10, 72);
            this.btn_CMMO_SelectRecord_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_SelectRecord_5.Name = "btn_CMMO_SelectRecord_5";
            this.btn_CMMO_SelectRecord_5.Size = new System.Drawing.Size(105, 29);
            this.btn_CMMO_SelectRecord_5.TabIndex = 561;
            this.btn_CMMO_SelectRecord_5.TabStop = true;
            this.btn_CMMO_SelectRecord_5.Text = "   Home   ";
            this.btn_CMMO_SelectRecord_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CMMO_SelectRecord_5.UseVisualStyleBackColor = false;
            // 
            // btn_CMMO_SelectRecord_1
            // 
            this.btn_CMMO_SelectRecord_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_CMMO_SelectRecord_1.AutoSize = true;
            this.btn_CMMO_SelectRecord_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CMMO_SelectRecord_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CMMO_SelectRecord_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CMMO_SelectRecord_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CMMO_SelectRecord_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CMMO_SelectRecord_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CMMO_SelectRecord_1.Location = new System.Drawing.Point(147, 72);
            this.btn_CMMO_SelectRecord_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_SelectRecord_1.Name = "btn_CMMO_SelectRecord_1";
            this.btn_CMMO_SelectRecord_1.Size = new System.Drawing.Size(49, 29);
            this.btn_CMMO_SelectRecord_1.TabIndex = 562;
            this.btn_CMMO_SelectRecord_1.TabStop = true;
            this.btn_CMMO_SelectRecord_1.Text = "Print";
            this.btn_CMMO_SelectRecord_1.UseVisualStyleBackColor = false;
            // 
            // btn_CMMO_SelectRecord_2
            // 
            this.btn_CMMO_SelectRecord_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_CMMO_SelectRecord_2.AutoSize = true;
            this.btn_CMMO_SelectRecord_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CMMO_SelectRecord_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CMMO_SelectRecord_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CMMO_SelectRecord_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CMMO_SelectRecord_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CMMO_SelectRecord_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CMMO_SelectRecord_2.Location = new System.Drawing.Point(204, 71);
            this.btn_CMMO_SelectRecord_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_SelectRecord_2.Name = "btn_CMMO_SelectRecord_2";
            this.btn_CMMO_SelectRecord_2.Size = new System.Drawing.Size(61, 29);
            this.btn_CMMO_SelectRecord_2.TabIndex = 563;
            this.btn_CMMO_SelectRecord_2.TabStop = true;
            this.btn_CMMO_SelectRecord_2.Text = "Ready";
            this.btn_CMMO_SelectRecord_2.UseVisualStyleBackColor = false;
            // 
            // btn_CMMO_Start
            // 
            this.btn_CMMO_Start.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_CMMO_Start.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CMMO_Start.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_CMMO_Start.FlatAppearance.BorderSize = 2;
            this.btn_CMMO_Start.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_CMMO_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CMMO_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CMMO_Start.Location = new System.Drawing.Point(9, 28);
            this.btn_CMMO_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_Start.Name = "btn_CMMO_Start";
            this.btn_CMMO_Start.Size = new System.Drawing.Size(105, 39);
            this.btn_CMMO_Start.TabIndex = 554;
            this.btn_CMMO_Start.Text = "Start";
            this.btn_CMMO_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CMMO_Start.UseVisualStyleBackColor = true;
            // 
            // btn_CMMO_Stop
            // 
            this.btn_CMMO_Stop.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_CMMO_Stop.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CMMO_Stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CMMO_Stop.FlatAppearance.BorderSize = 2;
            this.btn_CMMO_Stop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CMMO_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CMMO_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CMMO_Stop.Location = new System.Drawing.Point(147, 28);
            this.btn_CMMO_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_Stop.Name = "btn_CMMO_Stop";
            this.btn_CMMO_Stop.Size = new System.Drawing.Size(118, 39);
            this.btn_CMMO_Stop.TabIndex = 553;
            this.btn_CMMO_Stop.Text = "Stop";
            this.btn_CMMO_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CMMO_Stop.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(95, 361);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(271, 295);
            this.tabControl2.TabIndex = 539;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label91);
            this.tabPage1.Controls.Add(this.cbx_Bit0);
            this.tabPage1.Controls.Add(this.label93);
            this.tabPage1.Controls.Add(this.cbx_Bit1);
            this.tabPage1.Controls.Add(this.cbx_Bit15);
            this.tabPage1.Controls.Add(this.cbx_Bit2);
            this.tabPage1.Controls.Add(this.cbx_Bit14);
            this.tabPage1.Controls.Add(this.cbx_Bit3);
            this.tabPage1.Controls.Add(this.cbx_Bit13);
            this.tabPage1.Controls.Add(this.cbx_Bit4);
            this.tabPage1.Controls.Add(this.cbx_Bit12);
            this.tabPage1.Controls.Add(this.cbx_Bit5);
            this.tabPage1.Controls.Add(this.cbx_Bit11);
            this.tabPage1.Controls.Add(this.cbx_Bit6);
            this.tabPage1.Controls.Add(this.cbx_Bit10);
            this.tabPage1.Controls.Add(this.cbx_Bit7);
            this.tabPage1.Controls.Add(this.cbx_Bit9);
            this.tabPage1.Controls.Add(this.cbx_Bit8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(263, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CMMO->PC";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(35, 18);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(47, 17);
            this.label91.TabIndex = 554;
            this.label91.Text = "SCON";
            // 
            // cbx_Bit0
            // 
            this.cbx_Bit0.AutoSize = true;
            this.cbx_Bit0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit0.CustomBackground = true;
            this.cbx_Bit0.CustomForeColor = true;
            this.cbx_Bit0.Enabled = false;
            this.cbx_Bit0.Location = new System.Drawing.Point(151, 37);
            this.cbx_Bit0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit0.Name = "cbx_Bit0";
            this.cbx_Bit0.Size = new System.Drawing.Size(47, 17);
            this.cbx_Bit0.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit0.TabIndex = 537;
            this.cbx_Bit0.Text = "Halt";
            this.cbx_Bit0.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit0.UseVisualStyleBackColor = true;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(149, 18);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(46, 17);
            this.label93.TabIndex = 553;
            this.label93.Text = "SPOS";
            // 
            // cbx_Bit1
            // 
            this.cbx_Bit1.AutoSize = true;
            this.cbx_Bit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit1.CustomBackground = true;
            this.cbx_Bit1.CustomForeColor = true;
            this.cbx_Bit1.Enabled = false;
            this.cbx_Bit1.Location = new System.Drawing.Point(151, 64);
            this.cbx_Bit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit1.Name = "cbx_Bit1";
            this.cbx_Bit1.Size = new System.Drawing.Size(48, 17);
            this.cbx_Bit1.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit1.TabIndex = 538;
            this.cbx_Bit1.Text = "ACK";
            this.cbx_Bit1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit1.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit15
            // 
            this.cbx_Bit15.AutoSize = true;
            this.cbx_Bit15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit15.CustomBackground = true;
            this.cbx_Bit15.CustomForeColor = true;
            this.cbx_Bit15.Enabled = false;
            this.cbx_Bit15.Location = new System.Drawing.Point(38, 226);
            this.cbx_Bit15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit15.Name = "cbx_Bit15";
            this.cbx_Bit15.Size = new System.Drawing.Size(60, 17);
            this.cbx_Bit15.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit15.TabIndex = 552;
            this.cbx_Bit15.Text = "OPM2";
            this.cbx_Bit15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit15.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit2
            // 
            this.cbx_Bit2.AutoSize = true;
            this.cbx_Bit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit2.CustomBackground = true;
            this.cbx_Bit2.CustomForeColor = true;
            this.cbx_Bit2.Enabled = false;
            this.cbx_Bit2.Location = new System.Drawing.Point(151, 91);
            this.cbx_Bit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit2.Name = "cbx_Bit2";
            this.cbx_Bit2.Size = new System.Drawing.Size(44, 17);
            this.cbx_Bit2.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit2.TabIndex = 539;
            this.cbx_Bit2.Text = "MC";
            this.cbx_Bit2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit2.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit14
            // 
            this.cbx_Bit14.AutoSize = true;
            this.cbx_Bit14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit14.CustomBackground = true;
            this.cbx_Bit14.CustomForeColor = true;
            this.cbx_Bit14.Enabled = false;
            this.cbx_Bit14.Location = new System.Drawing.Point(38, 199);
            this.cbx_Bit14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit14.Name = "cbx_Bit14";
            this.cbx_Bit14.Size = new System.Drawing.Size(60, 17);
            this.cbx_Bit14.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit14.TabIndex = 551;
            this.cbx_Bit14.Text = "OPM1";
            this.cbx_Bit14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit14.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit3
            // 
            this.cbx_Bit3.AutoSize = true;
            this.cbx_Bit3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit3.CustomBackground = true;
            this.cbx_Bit3.CustomForeColor = true;
            this.cbx_Bit3.Enabled = false;
            this.cbx_Bit3.Location = new System.Drawing.Point(151, 118);
            this.cbx_Bit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit3.Name = "cbx_Bit3";
            this.cbx_Bit3.Size = new System.Drawing.Size(57, 17);
            this.cbx_Bit3.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit3.TabIndex = 540;
            this.cbx_Bit3.Text = "Teach";
            this.cbx_Bit3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit3.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit13
            // 
            this.cbx_Bit13.AutoSize = true;
            this.cbx_Bit13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit13.CustomBackground = true;
            this.cbx_Bit13.CustomForeColor = true;
            this.cbx_Bit13.Enabled = false;
            this.cbx_Bit13.Location = new System.Drawing.Point(38, 172);
            this.cbx_Bit13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit13.Name = "cbx_Bit13";
            this.cbx_Bit13.Size = new System.Drawing.Size(77, 17);
            this.cbx_Bit13.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit13.TabIndex = 550;
            this.cbx_Bit13.Text = "FCT/MMI";
            this.cbx_Bit13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit13.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit4
            // 
            this.cbx_Bit4.AutoSize = true;
            this.cbx_Bit4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit4.CustomBackground = true;
            this.cbx_Bit4.CustomForeColor = true;
            this.cbx_Bit4.Enabled = false;
            this.cbx_Bit4.Location = new System.Drawing.Point(151, 145);
            this.cbx_Bit4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit4.Name = "cbx_Bit4";
            this.cbx_Bit4.Size = new System.Drawing.Size(57, 17);
            this.cbx_Bit4.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit4.TabIndex = 541;
            this.cbx_Bit4.Text = "Move";
            this.cbx_Bit4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit4.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit12
            // 
            this.cbx_Bit12.AutoSize = true;
            this.cbx_Bit12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit12.CustomBackground = true;
            this.cbx_Bit12.CustomForeColor = true;
            this.cbx_Bit12.Enabled = false;
            this.cbx_Bit12.Location = new System.Drawing.Point(38, 145);
            this.cbx_Bit12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit12.Name = "cbx_Bit12";
            this.cbx_Bit12.Size = new System.Drawing.Size(61, 17);
            this.cbx_Bit12.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit12.TabIndex = 549;
            this.cbx_Bit12.Text = "VLoad";
            this.cbx_Bit12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit12.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit5
            // 
            this.cbx_Bit5.AutoSize = true;
            this.cbx_Bit5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit5.CustomBackground = true;
            this.cbx_Bit5.CustomForeColor = true;
            this.cbx_Bit5.Enabled = false;
            this.cbx_Bit5.Location = new System.Drawing.Point(151, 172);
            this.cbx_Bit5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit5.Name = "cbx_Bit5";
            this.cbx_Bit5.Size = new System.Drawing.Size(72, 17);
            this.cbx_Bit5.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit5.TabIndex = 542;
            this.cbx_Bit5.Text = "Fo Error";
            this.cbx_Bit5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit5.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit11
            // 
            this.cbx_Bit11.AutoSize = true;
            this.cbx_Bit11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit11.CustomBackground = true;
            this.cbx_Bit11.CustomForeColor = true;
            this.cbx_Bit11.Enabled = false;
            this.cbx_Bit11.Location = new System.Drawing.Point(38, 118);
            this.cbx_Bit11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit11.Name = "cbx_Bit11";
            this.cbx_Bit11.Size = new System.Drawing.Size(51, 17);
            this.cbx_Bit11.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit11.TabIndex = 548;
            this.cbx_Bit11.Text = "Fault";
            this.cbx_Bit11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit11.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit6
            // 
            this.cbx_Bit6.AutoSize = true;
            this.cbx_Bit6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit6.CustomBackground = true;
            this.cbx_Bit6.CustomForeColor = true;
            this.cbx_Bit6.Enabled = false;
            this.cbx_Bit6.Location = new System.Drawing.Point(151, 199);
            this.cbx_Bit6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit6.Name = "cbx_Bit6";
            this.cbx_Bit6.Size = new System.Drawing.Size(44, 17);
            this.cbx_Bit6.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit6.TabIndex = 543;
            this.cbx_Bit6.Text = "Still";
            this.cbx_Bit6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit6.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit10
            // 
            this.cbx_Bit10.AutoSize = true;
            this.cbx_Bit10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit10.CustomBackground = true;
            this.cbx_Bit10.CustomForeColor = true;
            this.cbx_Bit10.Enabled = false;
            this.cbx_Bit10.Location = new System.Drawing.Point(38, 91);
            this.cbx_Bit10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit10.Name = "cbx_Bit10";
            this.cbx_Bit10.Size = new System.Drawing.Size(72, 17);
            this.cbx_Bit10.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit10.TabIndex = 547;
            this.cbx_Bit10.Text = "Warning";
            this.cbx_Bit10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit10.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit7
            // 
            this.cbx_Bit7.AutoSize = true;
            this.cbx_Bit7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit7.CustomBackground = true;
            this.cbx_Bit7.CustomForeColor = true;
            this.cbx_Bit7.Enabled = false;
            this.cbx_Bit7.Location = new System.Drawing.Point(151, 226);
            this.cbx_Bit7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit7.Name = "cbx_Bit7";
            this.cbx_Bit7.Size = new System.Drawing.Size(43, 17);
            this.cbx_Bit7.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit7.TabIndex = 544;
            this.cbx_Bit7.Text = "Ref";
            this.cbx_Bit7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit7.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit9
            // 
            this.cbx_Bit9.AutoSize = true;
            this.cbx_Bit9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit9.CustomBackground = true;
            this.cbx_Bit9.CustomForeColor = true;
            this.cbx_Bit9.Enabled = false;
            this.cbx_Bit9.Location = new System.Drawing.Point(38, 64);
            this.cbx_Bit9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit9.Name = "cbx_Bit9";
            this.cbx_Bit9.Size = new System.Drawing.Size(56, 17);
            this.cbx_Bit9.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit9.TabIndex = 546;
            this.cbx_Bit9.Text = "Open";
            this.cbx_Bit9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit9.UseVisualStyleBackColor = true;
            // 
            // cbx_Bit8
            // 
            this.cbx_Bit8.AutoSize = true;
            this.cbx_Bit8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Bit8.CustomBackground = true;
            this.cbx_Bit8.CustomForeColor = true;
            this.cbx_Bit8.Enabled = false;
            this.cbx_Bit8.Location = new System.Drawing.Point(38, 37);
            this.cbx_Bit8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Bit8.Name = "cbx_Bit8";
            this.cbx_Bit8.Size = new System.Drawing.Size(71, 17);
            this.cbx_Bit8.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Bit8.TabIndex = 545;
            this.cbx_Bit8.Text = "Enabled";
            this.cbx_Bit8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Bit8.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.pnl_CMMO_Control);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(263, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PC->CMMO";
            // 
            // pnl_CMMO_Control
            // 
            this.pnl_CMMO_Control.Controls.Add(this.label105);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit8);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit0);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit9);
            this.pnl_CMMO_Control.Controls.Add(this.label106);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit7);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit1);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit10);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit15);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit6);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit2);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit11);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit14);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit5);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit3);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit12);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit13);
            this.pnl_CMMO_Control.Controls.Add(this.cbx_Reg1Bit4);
            this.pnl_CMMO_Control.Location = new System.Drawing.Point(26, 6);
            this.pnl_CMMO_Control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_CMMO_Control.Name = "pnl_CMMO_Control";
            this.pnl_CMMO_Control.Size = new System.Drawing.Size(223, 261);
            this.pnl_CMMO_Control.TabIndex = 549;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(9, 12);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(47, 17);
            this.label105.TabIndex = 590;
            this.label105.Text = "CCON";
            // 
            // cbx_Reg1Bit8
            // 
            this.cbx_Reg1Bit8.AutoSize = true;
            this.cbx_Reg1Bit8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit8.CustomBackground = true;
            this.cbx_Reg1Bit8.CustomForeColor = true;
            this.cbx_Reg1Bit8.Location = new System.Drawing.Point(12, 31);
            this.cbx_Reg1Bit8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit8.Name = "cbx_Reg1Bit8";
            this.cbx_Reg1Bit8.Size = new System.Drawing.Size(63, 17);
            this.cbx_Reg1Bit8.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit8.TabIndex = 581;
            this.cbx_Reg1Bit8.Text = "Enable";
            this.cbx_Reg1Bit8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit8.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit0
            // 
            this.cbx_Reg1Bit0.AutoSize = true;
            this.cbx_Reg1Bit0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit0.CustomBackground = true;
            this.cbx_Reg1Bit0.CustomForeColor = true;
            this.cbx_Reg1Bit0.Location = new System.Drawing.Point(125, 31);
            this.cbx_Reg1Bit0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit0.Name = "cbx_Reg1Bit0";
            this.cbx_Reg1Bit0.Size = new System.Drawing.Size(47, 17);
            this.cbx_Reg1Bit0.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit0.TabIndex = 573;
            this.cbx_Reg1Bit0.Text = "Halt";
            this.cbx_Reg1Bit0.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit0.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit9
            // 
            this.cbx_Reg1Bit9.AutoSize = true;
            this.cbx_Reg1Bit9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit9.CustomBackground = true;
            this.cbx_Reg1Bit9.CustomForeColor = true;
            this.cbx_Reg1Bit9.Enabled = false;
            this.cbx_Reg1Bit9.ForeColor = System.Drawing.Color.Silver;
            this.cbx_Reg1Bit9.Location = new System.Drawing.Point(12, 58);
            this.cbx_Reg1Bit9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit9.Name = "cbx_Reg1Bit9";
            this.cbx_Reg1Bit9.Size = new System.Drawing.Size(51, 17);
            this.cbx_Reg1Bit9.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit9.TabIndex = 582;
            this.cbx_Reg1Bit9.Text = "Stop";
            this.cbx_Reg1Bit9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit9.UseVisualStyleBackColor = true;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(123, 12);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(46, 17);
            this.label106.TabIndex = 589;
            this.label106.Text = "CPOS";
            // 
            // cbx_Reg1Bit7
            // 
            this.cbx_Reg1Bit7.AutoSize = true;
            this.cbx_Reg1Bit7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit7.CustomBackground = true;
            this.cbx_Reg1Bit7.CustomForeColor = true;
            this.cbx_Reg1Bit7.ForeColor = System.Drawing.Color.Silver;
            this.cbx_Reg1Bit7.Location = new System.Drawing.Point(125, 220);
            this.cbx_Reg1Bit7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit7.Name = "cbx_Reg1Bit7";
            this.cbx_Reg1Bit7.Size = new System.Drawing.Size(78, 17);
            this.cbx_Reg1Bit7.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit7.TabIndex = 580;
            this.cbx_Reg1Bit7.Text = "Reserved";
            this.cbx_Reg1Bit7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit7.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit1
            // 
            this.cbx_Reg1Bit1.AutoSize = true;
            this.cbx_Reg1Bit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit1.CustomBackground = true;
            this.cbx_Reg1Bit1.CustomForeColor = true;
            this.cbx_Reg1Bit1.Enabled = false;
            this.cbx_Reg1Bit1.ForeColor = System.Drawing.Color.Silver;
            this.cbx_Reg1Bit1.Location = new System.Drawing.Point(125, 58);
            this.cbx_Reg1Bit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit1.Name = "cbx_Reg1Bit1";
            this.cbx_Reg1Bit1.Size = new System.Drawing.Size(51, 17);
            this.cbx_Reg1Bit1.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit1.TabIndex = 574;
            this.cbx_Reg1Bit1.Text = "Start";
            this.cbx_Reg1Bit1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit1.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit10
            // 
            this.cbx_Reg1Bit10.AutoSize = true;
            this.cbx_Reg1Bit10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit10.CustomBackground = true;
            this.cbx_Reg1Bit10.CustomForeColor = true;
            this.cbx_Reg1Bit10.Location = new System.Drawing.Point(12, 85);
            this.cbx_Reg1Bit10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit10.Name = "cbx_Reg1Bit10";
            this.cbx_Reg1Bit10.Size = new System.Drawing.Size(56, 17);
            this.cbx_Reg1Bit10.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit10.TabIndex = 583;
            this.cbx_Reg1Bit10.Text = "Brake";
            this.cbx_Reg1Bit10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit10.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit15
            // 
            this.cbx_Reg1Bit15.AutoSize = true;
            this.cbx_Reg1Bit15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit15.CustomBackground = true;
            this.cbx_Reg1Bit15.CustomForeColor = true;
            this.cbx_Reg1Bit15.Location = new System.Drawing.Point(12, 220);
            this.cbx_Reg1Bit15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit15.Name = "cbx_Reg1Bit15";
            this.cbx_Reg1Bit15.Size = new System.Drawing.Size(60, 17);
            this.cbx_Reg1Bit15.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit15.TabIndex = 588;
            this.cbx_Reg1Bit15.Text = "OPM2";
            this.cbx_Reg1Bit15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit15.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit6
            // 
            this.cbx_Reg1Bit6.AutoSize = true;
            this.cbx_Reg1Bit6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit6.CustomBackground = true;
            this.cbx_Reg1Bit6.CustomForeColor = true;
            this.cbx_Reg1Bit6.Location = new System.Drawing.Point(125, 193);
            this.cbx_Reg1Bit6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit6.Name = "cbx_Reg1Bit6";
            this.cbx_Reg1Bit6.Size = new System.Drawing.Size(54, 17);
            this.cbx_Reg1Bit6.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit6.TabIndex = 579;
            this.cbx_Reg1Bit6.Text = "Clear";
            this.cbx_Reg1Bit6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit6.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit2
            // 
            this.cbx_Reg1Bit2.AutoSize = true;
            this.cbx_Reg1Bit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit2.CustomBackground = true;
            this.cbx_Reg1Bit2.CustomForeColor = true;
            this.cbx_Reg1Bit2.Location = new System.Drawing.Point(125, 85);
            this.cbx_Reg1Bit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit2.Name = "cbx_Reg1Bit2";
            this.cbx_Reg1Bit2.Size = new System.Drawing.Size(59, 17);
            this.cbx_Reg1Bit2.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit2.TabIndex = 575;
            this.cbx_Reg1Bit2.Text = "Home";
            this.cbx_Reg1Bit2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit2.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit11
            // 
            this.cbx_Reg1Bit11.AutoSize = true;
            this.cbx_Reg1Bit11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit11.CustomBackground = true;
            this.cbx_Reg1Bit11.CustomForeColor = true;
            this.cbx_Reg1Bit11.Location = new System.Drawing.Point(12, 112);
            this.cbx_Reg1Bit11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit11.Name = "cbx_Reg1Bit11";
            this.cbx_Reg1Bit11.Size = new System.Drawing.Size(56, 17);
            this.cbx_Reg1Bit11.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit11.TabIndex = 584;
            this.cbx_Reg1Bit11.Text = "Reset";
            this.cbx_Reg1Bit11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit11.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit14
            // 
            this.cbx_Reg1Bit14.AutoSize = true;
            this.cbx_Reg1Bit14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit14.CustomBackground = true;
            this.cbx_Reg1Bit14.CustomForeColor = true;
            this.cbx_Reg1Bit14.Location = new System.Drawing.Point(12, 193);
            this.cbx_Reg1Bit14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit14.Name = "cbx_Reg1Bit14";
            this.cbx_Reg1Bit14.Size = new System.Drawing.Size(60, 17);
            this.cbx_Reg1Bit14.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit14.TabIndex = 587;
            this.cbx_Reg1Bit14.Text = "OPM1";
            this.cbx_Reg1Bit14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit14.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit5
            // 
            this.cbx_Reg1Bit5.AutoSize = true;
            this.cbx_Reg1Bit5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit5.CustomBackground = true;
            this.cbx_Reg1Bit5.CustomForeColor = true;
            this.cbx_Reg1Bit5.Location = new System.Drawing.Point(125, 166);
            this.cbx_Reg1Bit5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit5.Name = "cbx_Reg1Bit5";
            this.cbx_Reg1Bit5.Size = new System.Drawing.Size(57, 17);
            this.cbx_Reg1Bit5.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit5.TabIndex = 578;
            this.cbx_Reg1Bit5.Text = "Teach";
            this.cbx_Reg1Bit5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit5.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit3
            // 
            this.cbx_Reg1Bit3.AutoSize = true;
            this.cbx_Reg1Bit3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit3.CustomBackground = true;
            this.cbx_Reg1Bit3.CustomForeColor = true;
            this.cbx_Reg1Bit3.Location = new System.Drawing.Point(125, 112);
            this.cbx_Reg1Bit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit3.Name = "cbx_Reg1Bit3";
            this.cbx_Reg1Bit3.Size = new System.Drawing.Size(58, 17);
            this.cbx_Reg1Bit3.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit3.TabIndex = 576;
            this.cbx_Reg1Bit3.Text = "Jog +";
            this.cbx_Reg1Bit3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit3.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit12
            // 
            this.cbx_Reg1Bit12.AutoSize = true;
            this.cbx_Reg1Bit12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit12.CustomBackground = true;
            this.cbx_Reg1Bit12.CustomForeColor = true;
            this.cbx_Reg1Bit12.ForeColor = System.Drawing.Color.Silver;
            this.cbx_Reg1Bit12.Location = new System.Drawing.Point(12, 139);
            this.cbx_Reg1Bit12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit12.Name = "cbx_Reg1Bit12";
            this.cbx_Reg1Bit12.Size = new System.Drawing.Size(78, 17);
            this.cbx_Reg1Bit12.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit12.TabIndex = 585;
            this.cbx_Reg1Bit12.Text = "Reserved";
            this.cbx_Reg1Bit12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit12.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit13
            // 
            this.cbx_Reg1Bit13.AutoSize = true;
            this.cbx_Reg1Bit13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit13.CustomBackground = true;
            this.cbx_Reg1Bit13.CustomForeColor = true;
            this.cbx_Reg1Bit13.Location = new System.Drawing.Point(12, 166);
            this.cbx_Reg1Bit13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit13.Name = "cbx_Reg1Bit13";
            this.cbx_Reg1Bit13.Size = new System.Drawing.Size(50, 17);
            this.cbx_Reg1Bit13.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit13.TabIndex = 586;
            this.cbx_Reg1Bit13.Text = "Lock";
            this.cbx_Reg1Bit13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit13.UseVisualStyleBackColor = true;
            // 
            // cbx_Reg1Bit4
            // 
            this.cbx_Reg1Bit4.AutoSize = true;
            this.cbx_Reg1Bit4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Reg1Bit4.CustomBackground = true;
            this.cbx_Reg1Bit4.CustomForeColor = true;
            this.cbx_Reg1Bit4.Location = new System.Drawing.Point(125, 139);
            this.cbx_Reg1Bit4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Reg1Bit4.Name = "cbx_Reg1Bit4";
            this.cbx_Reg1Bit4.Size = new System.Drawing.Size(54, 17);
            this.cbx_Reg1Bit4.Style = MetroFramework.MetroColorStyle.Green;
            this.cbx_Reg1Bit4.TabIndex = 577;
            this.cbx_Reg1Bit4.Text = "Jog -";
            this.cbx_Reg1Bit4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Reg1Bit4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ServoDisconnect);
            this.groupBox4.Controls.Add(this.btn_ServoConnect);
            this.groupBox4.Controls.Add(this.label96);
            this.groupBox4.Controls.Add(this.label95);
            this.groupBox4.Controls.Add(this.txt_CMMO_RecSelected);
            this.groupBox4.Controls.Add(this.label103);
            this.groupBox4.Controls.Add(this.txt_CMMO_Position);
            this.groupBox4.Controls.Add(this.txt_CMMOConnStatus);
            this.groupBox4.Controls.Add(this.label67);
            this.groupBox4.Controls.Add(this.btn_CMMO_Remote);
            this.groupBox4.Location = new System.Drawing.Point(95, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 167);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FESTO Servo motor";
            // 
            // ServoDisconnect
            // 
            this.ServoDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServoDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServoDisconnect.Location = new System.Drawing.Point(138, 125);
            this.ServoDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.ServoDisconnect.Name = "ServoDisconnect";
            this.ServoDisconnect.Size = new System.Drawing.Size(120, 31);
            this.ServoDisconnect.TabIndex = 562;
            this.ServoDisconnect.Text = "Disconnect";
            this.ServoDisconnect.UseVisualStyleBackColor = true;
            // 
            // btn_ServoConnect
            // 
            this.btn_ServoConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ServoConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ServoConnect.Location = new System.Drawing.Point(10, 125);
            this.btn_ServoConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ServoConnect.Name = "btn_ServoConnect";
            this.btn_ServoConnect.Size = new System.Drawing.Size(120, 31);
            this.btn_ServoConnect.TabIndex = 561;
            this.btn_ServoConnect.Text = "Connect";
            this.btn_ServoConnect.UseVisualStyleBackColor = true;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(195, 65);
            this.label96.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(30, 17);
            this.label96.TabIndex = 560;
            this.label96.Text = "mm";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(7, 86);
            this.label95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(117, 17);
            this.label95.TabIndex = 559;
            this.label95.Text = "Record Selected:";
            // 
            // txt_CMMO_RecSelected
            // 
            this.txt_CMMO_RecSelected.AutoSize = true;
            this.txt_CMMO_RecSelected.ForeColor = System.Drawing.Color.Blue;
            this.txt_CMMO_RecSelected.Location = new System.Drawing.Point(127, 86);
            this.txt_CMMO_RecSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_CMMO_RecSelected.Name = "txt_CMMO_RecSelected";
            this.txt_CMMO_RecSelected.Size = new System.Drawing.Size(60, 17);
            this.txt_CMMO_RecSelected.TabIndex = 558;
            this.txt_CMMO_RecSelected.Text = "000.000";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(7, 65);
            this.label103.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(112, 17);
            this.label103.TabIndex = 557;
            this.label103.Text = "Current position:";
            // 
            // txt_CMMO_Position
            // 
            this.txt_CMMO_Position.AutoSize = true;
            this.txt_CMMO_Position.ForeColor = System.Drawing.Color.Blue;
            this.txt_CMMO_Position.Location = new System.Drawing.Point(127, 65);
            this.txt_CMMO_Position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_CMMO_Position.Name = "txt_CMMO_Position";
            this.txt_CMMO_Position.Size = new System.Drawing.Size(60, 17);
            this.txt_CMMO_Position.TabIndex = 556;
            this.txt_CMMO_Position.Text = "000.000";
            // 
            // txt_CMMOConnStatus
            // 
            this.txt_CMMOConnStatus.AutoSize = true;
            this.txt_CMMOConnStatus.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_CMMOConnStatus.Location = new System.Drawing.Point(7, 33);
            this.txt_CMMOConnStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_CMMOConnStatus.Name = "txt_CMMOConnStatus";
            this.txt_CMMOConnStatus.Size = new System.Drawing.Size(91, 17);
            this.txt_CMMOConnStatus.TabIndex = 555;
            this.txt_CMMOConnStatus.Text = "Comm Status";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label67.Location = new System.Drawing.Point(106, 33);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(57, 17);
            this.label67.TabIndex = 552;
            this.label67.Text = "Remote";
            // 
            // btn_CMMO_Remote
            // 
            this.btn_CMMO_Remote.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CMMO_Remote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CMMO_Remote.CustomBackground = true;
            this.btn_CMMO_Remote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CMMO_Remote.Location = new System.Drawing.Point(168, 31);
            this.btn_CMMO_Remote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_Remote.Name = "btn_CMMO_Remote";
            this.btn_CMMO_Remote.Size = new System.Drawing.Size(72, 19);
            this.btn_CMMO_Remote.TabIndex = 551;
            this.btn_CMMO_Remote.Text = "Off";
            this.btn_CMMO_Remote.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_CMMO_Remote.UseStyleColors = true;
            this.btn_CMMO_Remote.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "IP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Port: ";
            // 
            // txt_Zanasi4700_Port
            // 
            this.txt_Zanasi4700_Port.AutoSize = true;
            this.txt_Zanasi4700_Port.Location = new System.Drawing.Point(69, 73);
            this.txt_Zanasi4700_Port.Name = "txt_Zanasi4700_Port";
            this.txt_Zanasi4700_Port.Size = new System.Drawing.Size(48, 17);
            this.txt_Zanasi4700_Port.TabIndex = 21;
            this.txt_Zanasi4700_Port.Text = "00000";
            // 
            // txt_Zanasi4700_IP
            // 
            this.txt_Zanasi4700_IP.AutoSize = true;
            this.txt_Zanasi4700_IP.Location = new System.Drawing.Point(69, 34);
            this.txt_Zanasi4700_IP.Name = "txt_Zanasi4700_IP";
            this.txt_Zanasi4700_IP.Size = new System.Drawing.Size(116, 17);
            this.txt_Zanasi4700_IP.TabIndex = 22;
            this.txt_Zanasi4700_IP.Text = "000.000.000.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 791);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Header;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensata Technologies Software | Zanasi Printer 4700 ";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.cntr_Comm.ResumeLayout(false);
            this.cntr_Comm.PerformLayout();
            this.cntr_Cmd.ResumeLayout(false);
            this.cntr_Cmd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MsgIndex)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Limits)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BuidZanasiCmd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_Zanasi4700.ResumeLayout(false);
            this.tab_ODBC.ResumeLayout(false);
            this.tab_RemoteIO.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tab4.ResumeLayout(false);
            this.tab4.PerformLayout();
            this.pnl_Outputs.ResumeLayout(false);
            this.pnl_Outputs.PerformLayout();
            this.tab_Servo.ResumeLayout(false);
            this.pnl_ServoControl.ResumeLayout(false);
            this.pnl_ServoControl.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnl_CMMO_Control.ResumeLayout(false);
            this.pnl_CMMO_Control.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Header;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInfoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Footer;
        private System.Windows.Forms.ToolStripStatusLabel lb_Hora;
        private System.Windows.Forms.ToolStripStatusLabel lb_Fecha;
        private System.Windows.Forms.Timer LocalClock;
        private System.Windows.Forms.GroupBox cntr_Comm;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.GroupBox cntr_Cmd;
        private System.Windows.Forms.Button btn_SendData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer RS232Scan;
        private System.Windows.Forms.ToolStripMenuItem btn_TransInfo;
        private System.Windows.Forms.Button btn_ExtData_Index2;
        private System.Windows.Forms.Button btn_ExtData_Index1;
        private System.Windows.Forms.Button btn_ExtData_Index0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_MsgIndex;
        private System.Windows.Forms.Label txt_ExtData_Index0_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer MachineScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_ExtData_Index2_Size;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_ExtData_Index1_Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ExtData_Index2;
        private System.Windows.Forms.TextBox txt_ExtData_Index1;
        private System.Windows.Forms.TextBox txt_CustomSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ExtData_Index0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_CustomSend_Size;
        private System.Windows.Forms.Button btn_ExtDataAutoSeq;
        private System.Windows.Forms.Button btn_DeviceID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbl_Limits;
        private System.Windows.Forms.Button btn_PrintLines;
        private System.Windows.Forms.ComboBox cbx_DeviceID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Zanasi4700;
        private System.Windows.Forms.TabPage tab_ODBC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label91;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit0;
        private System.Windows.Forms.Label label93;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit1;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit15;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit2;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit14;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit3;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit13;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit4;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit12;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit5;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit11;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit6;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit10;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit7;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit9;
        private MetroFramework.Controls.MetroCheckBox cbx_Bit8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnl_CMMO_Control;
        private System.Windows.Forms.Label label105;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit8;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit0;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit9;
        private System.Windows.Forms.Label label106;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit7;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit1;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit10;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit15;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit6;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit2;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit11;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit14;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit5;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit3;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit12;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit13;
        private MetroFramework.Controls.MetroCheckBox cbx_Reg1Bit4;
        private System.Windows.Forms.CheckBox btn_CMMO_Start;
        private System.Windows.Forms.CheckBox btn_CMMO_Stop;
        private System.Windows.Forms.Label label67;
        private MetroFramework.Controls.MetroToggle btn_CMMO_Remote;
        private System.Windows.Forms.Label txt_CMMOConnStatus;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label txt_CMMO_RecSelected;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label txt_CMMO_Position;
        private System.Windows.Forms.RadioButton btn_CMMO_SelectRecord_5;
        private System.Windows.Forms.RadioButton btn_CMMO_SelectRecord_1;
        private System.Windows.Forms.RadioButton btn_CMMO_SelectRecord_2;
        private System.Windows.Forms.GroupBox pnl_ServoControl;
        private System.Windows.Forms.DataGridView tbl_BuidZanasiCmd;
        private System.Windows.Forms.Button btn_BuildZanasiCmd;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.RichTextBox txt_ReadData;
        private System.Windows.Forms.TabPage tab_RemoteIO;
        private System.Windows.Forms.TabPage tab_Servo;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroCheckBox DI7;
        private MetroFramework.Controls.MetroCheckBox DI6;
        private MetroFramework.Controls.MetroCheckBox DI5;
        private MetroFramework.Controls.MetroCheckBox DI4;
        private MetroFramework.Controls.MetroCheckBox DI3;
        private MetroFramework.Controls.MetroCheckBox DI2;
        private MetroFramework.Controls.MetroCheckBox DI1;
        private MetroFramework.Controls.MetroCheckBox DI0;
        private System.Windows.Forms.TabPage tab4;
        private MetroFramework.Controls.MetroCheckBox btn_ForceOutputs;
        private System.Windows.Forms.Panel pnl_Outputs;
        private MetroFramework.Controls.MetroCheckBox DO0;
        private MetroFramework.Controls.MetroCheckBox DO1;
        private MetroFramework.Controls.MetroCheckBox DO5;
        private MetroFramework.Controls.MetroCheckBox DO2;
        private MetroFramework.Controls.MetroCheckBox DO4;
        private MetroFramework.Controls.MetroCheckBox DO3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_ADAM6250_Port;
        private System.Windows.Forms.TextBox txt_ADAM6250_IP;
        private System.Windows.Forms.Button btn_RemoteIODisconnect;
        private System.Windows.Forms.Button btn_RemoteIOConnect;
        private MetroFramework.Controls.MetroCheckBox DI11;
        private MetroFramework.Controls.MetroCheckBox DI10;
        private MetroFramework.Controls.MetroCheckBox DI9;
        private MetroFramework.Controls.MetroCheckBox DI8;
        private System.Windows.Forms.Button ServoDisconnect;
        private System.Windows.Forms.Button btn_ServoConnect;
        private System.Windows.Forms.Label txt_Zanasi4700_IP;
        private System.Windows.Forms.Label txt_Zanasi4700_Port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

