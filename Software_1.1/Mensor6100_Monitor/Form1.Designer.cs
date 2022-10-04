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
            this.btn_Scan = new System.Windows.Forms.Button();
            this.cntr_Comm = new System.Windows.Forms.GroupBox();
            this.cbx_Ports = new System.Windows.Forms.ComboBox();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Zanasi4700 = new System.Windows.Forms.TabPage();
            this.tab_ODBC = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnl_ServoControl = new System.Windows.Forms.GroupBox();
            this.btn_CMMO_SelectRecord_5 = new System.Windows.Forms.RadioButton();
            this.btn_CMMO_SelectRecord_1 = new System.Windows.Forms.RadioButton();
            this.btn_CMMO_SelectRecord_2 = new System.Windows.Forms.RadioButton();
            this.btn_CMMO_Start = new System.Windows.Forms.CheckBox();
            this.btn_CMMO_Stop = new System.Windows.Forms.CheckBox();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.txt_CMMO_RecSelected = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_CMMO_Position = new System.Windows.Forms.Label();
            this.txt_CMMOConnStatus = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.btn_CMMO_Remote = new MetroFramework.Controls.MetroToggle();
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
            this.tbl_BuidZanasiCmd = new System.Windows.Forms.DataGridView();
            this.btn_BuildZanasiCmd = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_ReadData = new System.Windows.Forms.RichTextBox();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.cntr_Comm.SuspendLayout();
            this.cntr_Cmd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MsgIndex)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Limits)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Zanasi4700.SuspendLayout();
            this.tab_ODBC.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnl_ServoControl.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnl_CMMO_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BuidZanasiCmd)).BeginInit();
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
            this.Header.Size = new System.Drawing.Size(771, 28);
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
            this.Footer.Location = new System.Drawing.Point(0, 700);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.Footer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Footer.Size = new System.Drawing.Size(771, 25);
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
            // btn_Scan
            // 
            this.btn_Scan.Location = new System.Drawing.Point(8, 28);
            this.btn_Scan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(120, 31);
            this.btn_Scan.TabIndex = 2;
            this.btn_Scan.Text = "<1> COM Port";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
            // 
            // cntr_Comm
            // 
            this.cntr_Comm.Controls.Add(this.cbx_Ports);
            this.cntr_Comm.Controls.Add(this.btn_Disconnect);
            this.cntr_Comm.Controls.Add(this.btn_Connect);
            this.cntr_Comm.Controls.Add(this.btn_Scan);
            this.cntr_Comm.Location = new System.Drawing.Point(16, 46);
            this.cntr_Comm.Margin = new System.Windows.Forms.Padding(4);
            this.cntr_Comm.Name = "cntr_Comm";
            this.cntr_Comm.Padding = new System.Windows.Forms.Padding(4);
            this.cntr_Comm.Size = new System.Drawing.Size(271, 110);
            this.cntr_Comm.TabIndex = 3;
            this.cntr_Comm.TabStop = false;
            this.cntr_Comm.Text = "Serial Communication | RS232";
            // 
            // cbx_Ports
            // 
            this.cbx_Ports.FormattingEnabled = true;
            this.cbx_Ports.Location = new System.Drawing.Point(136, 32);
            this.cbx_Ports.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Ports.Name = "cbx_Ports";
            this.cbx_Ports.Size = new System.Drawing.Size(120, 24);
            this.cbx_Ports.TabIndex = 5;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(136, 66);
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
            this.btn_Connect.Location = new System.Drawing.Point(8, 66);
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
            this.cntr_Cmd.Location = new System.Drawing.Point(7, 8);
            this.cntr_Cmd.Margin = new System.Windows.Forms.Padding(4);
            this.cntr_Cmd.Name = "cntr_Cmd";
            this.cntr_Cmd.Padding = new System.Windows.Forms.Padding(4);
            this.cntr_Cmd.Size = new System.Drawing.Size(449, 330);
            this.cntr_Cmd.TabIndex = 4;
            this.cntr_Cmd.TabStop = false;
            this.cntr_Cmd.Text = "Zanasi 4700 Messages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Size";
            // 
            // txt_CustomSend_Size
            // 
            this.txt_CustomSend_Size.AutoSize = true;
            this.txt_CustomSend_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomSend_Size.Location = new System.Drawing.Point(392, 30);
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
            this.txt_CustomSend.Location = new System.Drawing.Point(148, 30);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
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
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select message index";
            // 
            // txt_MsgIndex
            // 
            this.txt_MsgIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MsgIndex.Location = new System.Drawing.Point(173, 65);
            this.txt_MsgIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MsgIndex.Name = "txt_MsgIndex";
            this.txt_MsgIndex.Size = new System.Drawing.Size(64, 30);
            this.txt_MsgIndex.TabIndex = 17;
            // 
            // btn_SendData
            // 
            this.btn_SendData.Location = new System.Drawing.Point(20, 28);
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
            this.groupBox3.Size = new System.Drawing.Size(452, 418);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pallet | Prepare Data Structure";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Zanasi4700);
            this.tabControl1.Controls.Add(this.tab_ODBC);
            this.tabControl1.Location = new System.Drawing.Point(294, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 651);
            this.tabControl1.TabIndex = 35;
            // 
            // tab_Zanasi4700
            // 
            this.tab_Zanasi4700.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Zanasi4700.Controls.Add(this.btn_Clear);
            this.tab_Zanasi4700.Controls.Add(this.txt_ReadData);
            this.tab_Zanasi4700.Controls.Add(this.cntr_Cmd);
            this.tab_Zanasi4700.Location = new System.Drawing.Point(4, 25);
            this.tab_Zanasi4700.Name = "tab_Zanasi4700";
            this.tab_Zanasi4700.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Zanasi4700.Size = new System.Drawing.Size(464, 613);
            this.tab_Zanasi4700.TabIndex = 0;
            this.tab_Zanasi4700.Text = "Zanasi 4700 Printer Inkjet";
            // 
            // tab_ODBC
            // 
            this.tab_ODBC.BackColor = System.Drawing.SystemColors.Control;
            this.tab_ODBC.Controls.Add(this.groupBox2);
            this.tab_ODBC.Controls.Add(this.groupBox3);
            this.tab_ODBC.Location = new System.Drawing.Point(4, 25);
            this.tab_ODBC.Name = "tab_ODBC";
            this.tab_ODBC.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ODBC.Size = new System.Drawing.Size(464, 622);
            this.tab_ODBC.TabIndex = 1;
            this.tab_ODBC.Text = "ODBC Database";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnl_ServoControl);
            this.groupBox4.Controls.Add(this.label96);
            this.groupBox4.Controls.Add(this.label95);
            this.groupBox4.Controls.Add(this.txt_CMMO_RecSelected);
            this.groupBox4.Controls.Add(this.label103);
            this.groupBox4.Controls.Add(this.txt_CMMO_Position);
            this.groupBox4.Controls.Add(this.txt_CMMOConnStatus);
            this.groupBox4.Controls.Add(this.label67);
            this.groupBox4.Controls.Add(this.btn_CMMO_Remote);
            this.groupBox4.Location = new System.Drawing.Point(16, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 234);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FESTO Servo motor";
            // 
            // pnl_ServoControl
            // 
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_SelectRecord_5);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_SelectRecord_1);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_SelectRecord_2);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_Start);
            this.pnl_ServoControl.Controls.Add(this.btn_CMMO_Stop);
            this.pnl_ServoControl.Location = new System.Drawing.Point(11, 116);
            this.pnl_ServoControl.Name = "pnl_ServoControl";
            this.pnl_ServoControl.Size = new System.Drawing.Size(248, 110);
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
            this.btn_CMMO_SelectRecord_5.Location = new System.Drawing.Point(8, 72);
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
            this.btn_CMMO_SelectRecord_1.Location = new System.Drawing.Point(120, 72);
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
            this.btn_CMMO_SelectRecord_2.Location = new System.Drawing.Point(177, 71);
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
            this.btn_CMMO_Stop.Location = new System.Drawing.Point(120, 28);
            this.btn_CMMO_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CMMO_Stop.Name = "btn_CMMO_Stop";
            this.btn_CMMO_Stop.Size = new System.Drawing.Size(118, 39);
            this.btn_CMMO_Stop.TabIndex = 553;
            this.btn_CMMO_Stop.Text = "Stop";
            this.btn_CMMO_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CMMO_Stop.UseVisualStyleBackColor = true;
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
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(16, 402);
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
            // tbl_BuidZanasiCmd
            // 
            this.tbl_BuidZanasiCmd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbl_BuidZanasiCmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_BuidZanasiCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_BuidZanasiCmd.Location = new System.Drawing.Point(8, 86);
            this.tbl_BuidZanasiCmd.Name = "tbl_BuidZanasiCmd";
            this.tbl_BuidZanasiCmd.RowHeadersVisible = false;
            this.tbl_BuidZanasiCmd.RowTemplate.Height = 24;
            this.tbl_BuidZanasiCmd.Size = new System.Drawing.Size(438, 329);
            this.tbl_BuidZanasiCmd.TabIndex = 34;
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
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(7, 578);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 31);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear Log Data";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // txt_ReadData
            // 
            this.txt_ReadData.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ReadData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReadData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ReadData.EnableAutoDragDrop = true;
            this.txt_ReadData.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadData.Location = new System.Drawing.Point(7, 342);
            this.txt_ReadData.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReadData.Name = "txt_ReadData";
            this.txt_ReadData.ReadOnly = true;
            this.txt_ReadData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txt_ReadData.ShowSelectionMargin = true;
            this.txt_ReadData.Size = new System.Drawing.Size(449, 267);
            this.txt_ReadData.TabIndex = 11;
            this.txt_ReadData.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 725);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cntr_Comm);
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
            this.cntr_Cmd.ResumeLayout(false);
            this.cntr_Cmd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MsgIndex)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Limits)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_Zanasi4700.ResumeLayout(false);
            this.tab_ODBC.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnl_ServoControl.ResumeLayout(false);
            this.pnl_ServoControl.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnl_CMMO_Control.ResumeLayout(false);
            this.pnl_CMMO_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BuidZanasiCmd)).EndInit();
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
        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.GroupBox cntr_Comm;
        private System.Windows.Forms.ComboBox cbx_Ports;
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
    }
}

