
#region System Libraries
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
#endregion

#region Project Libraries
using PCdatetime;
using PCMessages;
#endregion

namespace Zanasi4700
{
    public partial class Form1 : Form
    {
        #region Variables
        //RS232 Communication
        public String LeerDatos;

        #region Zanasi 4700
        //Zanasi 4700 Commands
        public string CMDHeader = "#";

        const int Fixture_SIZE = 12;   //Fixtures
        const int Lines_SIZE = 3;      //Lines per Fixture
        const int MsgMaxSize = 12;     //12 characters

        public const Byte Head          = 0x23;
        public const Byte SetQuery      = 0xA3;
        public const Byte LineIndex0    = 0x00; //Line Index    = 0
        public const Byte LineIndex1    = 0x01; //Line Index    = 1
        public const Byte LineIndex2    = 0x02; //Line Index    = 2
        public const Byte MsgIndex      = 0x00; //Message Index = 0
        public const Byte MsgSize       = 0x0C; //12 characters

        public const Byte Space         = 0x20; //Empty 
        enum ZanasiCMD
        {
            Head,
            SetQuery,
            LineIndex,
            MsgIndex,
            MsgSize
        }

        // Line 1 Hex:       [0x23] [0xA3]  [0x00]  [0x00]  [0x12]  Message converted to Bytes
        // Line positiona:   [0]    [1]     [2]     [3]     [4]     [5-16]
        static Byte[] msgWrapped = new Byte[17];
        public byte[] MsgWrapped
        {
            get
            {
                return msgWrapped;
            }

            set
            {
                msgWrapped = value;
            }
        }
        #endregion

        #region ODBC Datasource x64 bits
        //DSN Name
        private static string oDBC_Name = "ZanasiDB";
        public string ODBC_Name
        {
            get
            {
                return oDBC_Name;
            }

            set
            {
                oDBC_Name = value;
            }
        }

        //Queries
        string DeviceIDList_Query = "SELECT * FROM ZanasiTable";
        string PrintLines_Query = "SELECT * FROM ZanasiTable WHERE DeviceID =";

        public string[] ODBCLimits = new string[3];

        enum eODBCLimits
        {
            Line1,
            Line2,
            Line3
        }
        #endregion

        #endregion

        #region Objects
        //Time form the system (PC desktop) PCdatetime.DLL
        FechaHora Tiempo = new FechaHora();
        //Messages Manager PCMessages.DLL
        Messages Mensaje = new Messages();

        //Limits
        DataTable tblLimits = new DataTable();
        DataTable tbBuildZanasiCmd = new DataTable();

        //FESTO Controller CMMO ST -LKP
        CMMO_ST_LKP OCMMO = new CMMO_ST_LKP();
        //ADAM-6250 Remote IO
        ADAM6250 _ADAM6250 = new ADAM6250();
        #endregion

        public Form1()
        {
            InitializeComponent();
            LocalClock.Enabled = true;
            cntr_Cmd.Enabled = false;
            btn_Disconnect.Enabled = false;
            RS232Scan.Enabled = false;
            MachineScan.Enabled = true;
            //ODBC Limits
            Limits();
            //Build Zanasi Command
            mZanasiCommand();
            //ADAM-6250 IP
            _ADAM6250.IP = "192.168.1.21";
            _ADAM6250.Port = 502;
        }

        private void LocalClock_Tick(object sender, EventArgs e)
        {
            lb_Fecha.Text = Tiempo.PCFecha();
            lb_Hora.Text = Tiempo.PCHora();
        }

        #region Serial Communication: RS232
        //Scan RS232 port available
        private void Btn_Scan_Click(object sender, EventArgs e)
        {
            //Search a Serial COM port enable
            cbx_Ports.Items.Clear();
            foreach (String comports in System.IO.Ports.SerialPort.GetPortNames())
            {
                cbx_Ports.Items.Add(comports);
            }
        }
        //Connect
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                MessageBox.Show("The Serial " + serialPort1.PortName + " Port are being used");
            }
            else
            {
                if (cbx_Ports.SelectedItem == null)
                {
                    MessageBox.Show("Select a Serial COM Port");
                }
                else
                {
                    //Settings of the Serial COM port
                    serialPort1.PortName = cbx_Ports.SelectedItem.ToString();
                    serialPort1.BaudRate = 9600;                                    // 9600
                    serialPort1.Parity = System.IO.Ports.Parity.None;               // None   
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;            // 1
                    serialPort1.DataBits = 8;                                       // 8
                    serialPort1.Encoding = Encoding.Default;
                    //Open Serial COM Port selected
                    serialPort1.Open();
                    txt_ReadData.SelectionColor = Mensaje.msgSystem();
                    txt_ReadData.AppendText("Connected to "+ serialPort1.PortName + "\n");
                    MessageBox.Show("Serial " + serialPort1.PortName + " Port has been Connected");
                    btn_Disconnect.Enabled = true;
                    btn_Connect.Enabled = false;
                    cbx_Ports.Enabled = false;
                    btn_Scan.Enabled = false;
                    RS232Scan.Enabled = true;
                    cntr_Cmd.Enabled = true;
                }
            }
        }
        //Disconnect
        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            txt_ReadData.SelectionColor = Mensaje.msgSystem();
            txt_ReadData.AppendText("Disconnected to " + serialPort1.PortName + "\n");
            RS232Scan.Enabled = false;
            MessageBox.Show("Serial " + serialPort1.PortName+" Port has been Disconnected");
            btn_Disconnect.Enabled = false;
            btn_Connect.Enabled = true;
            cbx_Ports.Enabled = true;
            cntr_Cmd.Enabled = false;
            btn_Scan.Enabled = true;
        }
        //Send
        private void Btn_SendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
            }
        }
        //Receive
        private void IntervalScan_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LeerDatos = serialPort1.ReadExisting();
                if (LeerDatos.Length > 0)
                {
                    byte[] RXbuffer = System.Text.Encoding.Default.GetBytes(LeerDatos);
                    LeerDatos = BitConverter.ToString(RXbuffer);
                    txt_ReadData.SelectionColor = Mensaje.msgMeasure();
                    txt_ReadData.AppendText(LeerDatos+"\n");
                }
            }
        }
        #endregion

        //Machine Scan
        private void MachineScan_Tick(object sender, EventArgs e)
        {
            //Custom Send
            txt_CustomSend_Size.Text = txt_CustomSend.TextLength.ToString();
            //Line 1: Index 0
            txt_ExtData_Index0_Size.Text = txt_ExtData_Index0.TextLength.ToString();
            //Line 1: Index 1
            txt_ExtData_Index1_Size.Text = txt_ExtData_Index1.TextLength.ToString();
            //Line 1: Index 2
            txt_ExtData_Index2_Size.Text = txt_ExtData_Index2.TextLength.ToString();

            #region Servo Press: Festo Controller CMMO ST LKP

            #region Connection
            if (OCMMO.Parameters[(int)PLC_Comm.CommStatus])
            {
                txt_CMMOConnStatus.Text = "Connected";
                txt_CMMOConnStatus.ForeColor = Color.Green;
            }
            else
            {
                txt_CMMOConnStatus.Text = "Disconnected";
                txt_CMMOConnStatus.ForeColor = Color.Black;
            }
            #endregion

            //Remote Control panel Enable
            if (!btn_CMMO_Remote.Checked && OCMMO.Parameters[(int)PLC_Comm.CommStatus])
            {
                pnl_CMMO_Control.Enabled = true;
                pnl_ServoControl.Enabled = true;
            }
            else
            {
                pnl_CMMO_Control.Enabled = false;
                pnl_ServoControl.Enabled = false;
            }

            #region Registers
            //Record Selected
            txt_CMMO_RecSelected.Text = OCMMO.RecordSelect.ToString();
            //Current Position
            txt_CMMO_Position.Text = OCMMO.Position.ToString("000.000");

            #region CMMO Status
            cbx_Bit0.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Halt];
            cbx_Bit1.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.ACK];
            cbx_Bit2.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.MC];
            cbx_Bit3.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Teach];
            cbx_Bit4.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Move];
            cbx_Bit5.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.FoError];
            cbx_Bit6.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Still];
            cbx_Bit7.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Ref];

            cbx_Bit8.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Enable];
            cbx_Bit9.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Open];
            cbx_Bit10.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Warning];
            cbx_Bit11.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.Fault];
            cbx_Bit12.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.VLoad];
            cbx_Bit13.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.FCTMMI];
            cbx_Bit14.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.OPM1];
            cbx_Bit15.Checked = OCMMO.Reg0[(int)Servo_SCON_SPOS.OPM2];
            #endregion

            //Start - Stop Enables
            btn_CMMO_Start.Enabled = !btn_CMMO_Remote.Checked;
            btn_CMMO_Stop.Enabled = !btn_CMMO_Remote.Checked;

            //If the Machine is on Manual Mode, the selection can be effective
            if (!btn_CMMO_Remote.Checked)
            {
                #region CMMO Control
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Halt] = cbx_Reg1Bit0.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Start] = btn_CMMO_Start.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Home] = cbx_Reg1Bit2.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.JogUp] = cbx_Reg1Bit3.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.JogDown] = cbx_Reg1Bit4.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Teach] = cbx_Reg1Bit5.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Clear] = cbx_Reg1Bit6.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Reserved1] = cbx_Reg1Bit7.Checked;

                OCMMO.Reg1[(int)Servo_CCON_CPOS.Enable] = cbx_Reg1Bit8.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Stop] = btn_CMMO_Stop.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Brake] = cbx_Reg1Bit10.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Reset] = cbx_Reg1Bit11.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Reserved2] = cbx_Reg1Bit12.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Lock] = cbx_Reg1Bit13.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.OPM1] = cbx_Reg1Bit14.Checked;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.OPM2] = cbx_Reg1Bit15.Checked;
                #endregion

                #region Manual Mode: Record Selection
                if (btn_CMMO_SelectRecord_1.Checked) OCMMO.RecordSelect = (int)ServoPos.Pos1;
                if (btn_CMMO_SelectRecord_2.Checked) OCMMO.RecordSelect = (int)ServoPos.Pos2;
                if (btn_CMMO_SelectRecord_5.Checked) OCMMO.RecordSelect = (int)ServoPos.Home;
                #endregion
            }
            else
            {
                #region CMMO Control (read Only)
                cbx_Reg1Bit0.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Halt];
                btn_CMMO_Start.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Start];
                cbx_Reg1Bit2.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Home];
                cbx_Reg1Bit3.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.JogUp];
                cbx_Reg1Bit4.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.JogDown];
                cbx_Reg1Bit5.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Teach];
                cbx_Reg1Bit6.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Clear];
                cbx_Reg1Bit7.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Reserved1];

                cbx_Reg1Bit8.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Enable];
                btn_CMMO_Stop.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Stop];
                cbx_Reg1Bit10.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Brake];
                cbx_Reg1Bit11.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Reset];
                cbx_Reg1Bit12.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Reserved2];
                cbx_Reg1Bit13.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.Lock];
                cbx_Reg1Bit14.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.OPM1];
                cbx_Reg1Bit15.Checked = OCMMO.Reg1[(int)Servo_CCON_CPOS.OPM2];
                #endregion

                #region Remote Mode: Record Selection
                /* if (OCMMO.RecordSelect == (int)ServoPos.Pos1) ;
                 if (OCMMO.RecordSelect == (int)ServoPos.Pos2) ;
                 if (OCMMO.RecordSelect == (int)ServoPos.Pos3) ;
                 if (OCMMO.RecordSelect == (int)ServoPos.Pos4) ;
                 if (OCMMO.RecordSelect == (int)ServoPos.Home) ;*/
                #endregion
            }
            #endregion

            #endregion

            #region ADAM-6250 IO scan
            //Inputs
            DI0.Checked = _ADAM6250.Inputs[0];
            DI1.Checked = _ADAM6250.Inputs[1];
            DI2.Checked = _ADAM6250.Inputs[2];
            DI3.Checked = _ADAM6250.Inputs[3];
            DI4.Checked = _ADAM6250.Inputs[4];
            DI5.Checked = _ADAM6250.Inputs[5];
            DI6.Checked = _ADAM6250.Inputs[6];
            DI7.Checked = _ADAM6250.Inputs[7];
            DI8.Checked = _ADAM6250.Inputs[8];
            DI9.Checked = _ADAM6250.Inputs[9];
            DI10.Checked = _ADAM6250.Inputs[10];
            DI11.Checked = _ADAM6250.Inputs[11];

            //Outputs: Manual mode the outputs can be forced

            if (btn_ForceOutputs.Checked)
            {
                //Write Permission
                pnl_Outputs.Enabled = true;
                _ADAM6250.Parameters[1] = false;

                _ADAM6250.Outputs[0] = DO0.Checked;
                _ADAM6250.Outputs[1] = DO1.Checked;
                _ADAM6250.Outputs[2] = DO2.Checked;
                _ADAM6250.Outputs[3] = DO3.Checked;
                _ADAM6250.Outputs[4] = DO4.Checked;
                _ADAM6250.Outputs[5] = DO5.Checked;
            }
            else
            {
                //Write Permission
                pnl_Outputs.Enabled = false;
                _ADAM6250.Parameters[1] = false;

                DO0.Checked = _ADAM6250.Outputs[0];
                DO1.Checked = _ADAM6250.Outputs[1];
                DO2.Checked = _ADAM6250.Outputs[2];
                DO3.Checked = _ADAM6250.Outputs[3];
                DO4.Checked = _ADAM6250.Outputs[4];
                DO5.Checked = _ADAM6250.Outputs[5];
            }
            #endregion
        }
        //Clear Log
        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            txt_ReadData.Text = "";
            txt_ExtData_Index0.Text = "";
            txt_ExtData_Index1.Text = "";
            txt_ExtData_Index2.Text = "";
            //txt_SendData.Text = "*";
        }

        #region External Data: Control
        private void btn_ExtData_Index0_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ExtData_Index0();
            }
        }
        private void btn_ExtData_Index1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ExtData_Index1();
            }
        }
        private void btn_ExtData_Index2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ExtData_Index2();
            }
        }
        #endregion

        #region External Data: Custom Functions
        // Format:       #      [163]   [Line Index]    [Message Index]     [Message Length]    Message
        // Line 1 Hex:   [0x23] [0xA3]  [0x00]          [0x00]              [0x06]              Message
        // Line 1 ASCII: #      [£]     [NULL]          [NULL]              [ACK]               Message
        bool ExtData_Index0()
        {
            bool bSucc = false;

            //string Line1_Command = CMDHeader + "[163][" + txt_MsgIndex.Value + "][0][" + txt_ExtData_Index0_Size.Text + "]"+ txt_ExtData_Index0.Text +"\r\n";

            char[] Line1_Command;
            string Line1_cmd = "";
            //Command position:  [0]   [1]   [2]   [3]   [4]   [5]   [6]   [7]   [8]   [9]   [10]
            Byte[] _ZanasiCMD = { 0x23, 0xA3, 0x00, 0x00, 0x0C, 0x54, 0x45, 0x53, 0x54, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x38 };

            //Description of the Command:
            //[0] Header                        Const = 0x23
            //[1] Command to Set Information    Const = 0xA3
            //[2] External Command Index        Const = 0x00, 0x01, 0x02
            //[3] Message Index                 Const = 0x00 
            //[4] Message Lenght
            //Message
            //[5]-[Size_Message] 
            //Message: ASCII
            Line1_Command = System.Text.Encoding.Default.GetChars(_ZanasiCMD);

            #region Info: Command Structure
            for (int i = 0; i < Line1_Command.Length; i++) { Line1_cmd += Line1_Command[i].ToString(); }
            txt_ReadData.AppendText("Line 1, ASCII: " + Line1_cmd);
            txt_ReadData.AppendText("\n");
            #endregion

            //Send to Serial Port
            serialPort1.Write(Line1_Command, 0, Line1_Command.Length);

            #region Info: Command Structure
            //serialPort1.Write(Line1_cmd); 
            txt_ReadData.SelectionColor = Mensaje.msgProcess();
            //Message: Decimal
            Line1_cmd = "";
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                Line1_cmd += _ZanasiCMD[i].ToString() + " ";

            }
            txt_ReadData.AppendText("Line 1, Dec: " + Line1_cmd);
            txt_ReadData.AppendText("\n");
            //Message: Hexadecimal
            Line1_cmd = BitConverter.ToString(_ZanasiCMD);
            /*
            Line1_cmd = "";
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                Line1_cmd += _ZanasiCMD[i].ToString("X") + " ";
            }
            */
            txt_ReadData.SelectionColor = Mensaje.msgProcess();
            txt_ReadData.AppendText("Line 1, Hex: " + Line1_cmd);
            txt_ReadData.AppendText("\n");
            #endregion

            return bSucc;
        }
        // Format:       #      [163]   [Line Index]    [Message Index]     [Message Length]    Message
        // Line 2 Hex:   [0x23] [0xA3]  [0x01]          [NULL]              [0x06]              Message
        // Line 2 ASCII: #      [£]     [SOH]           [NULL]              [ACK]               Message
        bool ExtData_Index1()
        {
            bool bSucc = false;

            //string Line2_Command = CMDHeader + "[163][" + txt_MsgIndex.Value + "][1][" + txt_ExtData_Index0_Size.Text + "]" + txt_ExtData_Index0.Text + "\r\n";

            char[] Line2_Command;
            string Line2_cmd = "";
            //Command position:  [0]   [1]   [2]   [3]   [4]   [5]   [6]   [7]   [8]   [9]   [10]
            Byte[] _ZanasiCMD = { 0x23, 0xA3, 0x01, 0x00, 0x06, 0x54, 0x45, 0x53, 0x54, 0x20, 0x32 };
            //Description of the Command:
            //[0] Header
            //[1] Command to Set Information
            //[2] External Command Index
            //[3] Message Index
            //[4] Message Lenght
            //Message
            //[5]-[Size_Message] 
            //Message: ASCII
            Line2_Command = System.Text.Encoding.Default.GetChars(_ZanasiCMD);
            serialPort1.Write(Line2_Command, 0, Line2_Command.Length);
            //Send to Serial Port
            txt_ReadData.SelectionColor = Mensaje.msgProcess();
            //Message ASCII
            Line2_cmd = "";
            char[] cZanasiCMD = new char[100];
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                cZanasiCMD[i] = Convert.ToChar(_ZanasiCMD[i]);
                Line2_cmd += cZanasiCMD[i];
            }
            txt_ReadData.AppendText("Line 2, ASCII: " + Line2_cmd);
            txt_ReadData.AppendText("\n");
            //Message: Decimal
            Line2_cmd = "";
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                Line2_cmd += _ZanasiCMD[i].ToString() + " ";
            }
            txt_ReadData.AppendText("Line 2, Dec: " + Line2_cmd);
            txt_ReadData.AppendText("\n");
            //Message: Hexadecimal
            Line2_cmd = "";
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                Line2_cmd += _ZanasiCMD[i].ToString("X") + " ";
            }
            txt_ReadData.SelectionColor = Mensaje.msgProcess();
            txt_ReadData.AppendText("Line 2, Hex: " + Line2_cmd);
            txt_ReadData.AppendText("\n");

            return bSucc;
        }
        // Format:       #      [163]   [Line Index]    [Message Index]     [Message Length]    Message
        // Line 3 Hex:   [0x23] [0xA3]  [SOH]           [NULL]              [0x06]              Message
        // Line 3 ASCII: #      [£]     [STX]           [NULL]              [ACK]               Message
        bool ExtData_Index2()
        {
            bool bSucc = false;

            //string Line3_Command = CMDHeader + "[163][" + txt_MsgIndex.Value + "][2][" + txt_ExtData_Index0_Size.Text + "]"+ txt_ExtData_Index0.Text + "\r\n";

            char[] Line3_Command;
            string Line3_cmd = "";
            //Command position:  [0]   [1]   [2]   [3]   [4]   [5]   [6]   [7]   [8]   [9]   [10]
            Byte[] _ZanasiCMD = { 0x23, 0xA3, 0x02, 0x00, 0x06, 0x54, 0x45, 0x53, 0x54, 0x20, 0x33 };
            //Description of the Command:
            //[0] Header
            //[1] Command to Set Information
            //[2] External Command Index
            //[3] Message Index
            //[4] Message Lenght
            //Message
            //[5]-[Size_Message] 
            //Message: ASCII
            Line3_Command = System.Text.Encoding.Default.GetChars(_ZanasiCMD);
            //Send to Serial Port
            serialPort1.Write(Line3_Command, 0, Line3_Command.Length);
            txt_ReadData.SelectionColor = Mensaje.msgProcess();
            //Message ASCII
            Line3_cmd = "";
            char[] cZanasiCMD = new char[100];
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                cZanasiCMD[i] = Convert.ToChar(_ZanasiCMD[i]);
                Line3_cmd += cZanasiCMD[i];
            }
            txt_ReadData.AppendText("Line 3, ASCII: " + Line3_cmd);
            txt_ReadData.AppendText("\n");
            //Message: Decimal
            Line3_cmd = "";
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                Line3_cmd += _ZanasiCMD[i].ToString() + " ";

            }
            txt_ReadData.AppendText("Line 3, Dec: " + Line3_cmd);
            txt_ReadData.AppendText("\n");
            //Message: Hexadecimal
            Line3_cmd = "";
            for (int i = 0; i < _ZanasiCMD.Length; i++)
            {
                Line3_cmd += _ZanasiCMD[i].ToString("X") + " ";
            }
            txt_ReadData.SelectionColor = Mensaje.msgProcess();
            txt_ReadData.AppendText("Line 3, Hex: " + Line3_cmd);
            txt_ReadData.AppendText("\n");

            return bSucc;
        }
        #endregion

        //Automatic Printing Sequence: Control
        private void btn_ExtDataAutoSeq_Click(object sender, EventArgs e)
        {
            ThreeLinesSequence();
        }
        //Automatic Printing Sequence: Functions
        bool AutomaticSequence()
        {
            bool bSucc = false;

            if (serialPort1.IsOpen)
            {
                //Move Forwad the Servo to Position 1 and return to Position 2
                tskServo_Print();
                //Build the Zanasi Command
                BuildZanasiCommand();
                //Servo Press safety conditions
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Enable] = false;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Stop] = false;
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Halt] = false;
            }

            return bSucc;
        }

        void ThreeLinesSequence()
        {
            //Send to Serial Port
            ExtData_Index0();
            Thread.Sleep(500);
            //ADAM-6050
            _ADAM6250.Outputs[0] = true;
            Thread.Sleep(500);
            _ADAM6250.Outputs[0] = false;
            //Send to Serial Port
            ExtData_Index1();
            Thread.Sleep(500);
            //ADAM-6050
            _ADAM6250.Outputs[0] = true;
            Thread.Sleep(500);
            _ADAM6250.Outputs[0] = false;
            //Send to Serial Port
            ExtData_Index2();
            //ADAM-6050
            _ADAM6250.Outputs[0] = true;
            Thread.Sleep(500);
            _ADAM6250.Outputs[0] = false;
        }
        //Manual Mode: Build Zanasi Command
        private void btn_BuildZanasiCmd_Click(object sender, EventArgs e)
        {
            BuildZanasiCommand();
        }
        //Build the Zanasi Command
        void BuildZanasiCommand()
        {
            char[] Line1_Command;
            string[,] Package_cmd = new string[Fixture_SIZE,Lines_SIZE];
            //Clear Table
            tbBuildZanasiCmd.Rows.Clear();
            //Printing Sequence
            //Fixture
            for (int i = 0; i < Fixture_SIZE; i++)
            {
                //Lines
                for (int k = 0; k < Lines_SIZE; k++)
                {
                    txt_ReadData.AppendText("Send info to Printer Line [" + k + "]");
                    txt_ReadData.AppendText("\n");
                    Line1_Command = SendInfoToPrinter(k);
                    for (int j = 0; j < Line1_Command.Length; j++) { Package_cmd[i,k] += Line1_Command[j].ToString(); }

                    //Send to Serial Port
                    serialPort1.Write(Line1_Command, 0, Line1_Command.Length);
                    Thread.Sleep(500);
                }
                txt_ReadData.AppendText("Trigger to Printer: Fixture [" + i + "]");
                //ADAM-6050
                _ADAM6250.Outputs[0] = true;
                Thread.Sleep(500);
                _ADAM6250.Outputs[0] = false;

                txt_ReadData.AppendText("\n");
                //Add limits to Table
                tbBuildZanasiCmd.Rows.Add
                (
                    i,
                    Package_cmd[i, (int)eODBCLimits.Line1],
                    Package_cmd[i, (int)eODBCLimits.Line2],
                    Package_cmd[i, (int)eODBCLimits.Line3]
                );
            }
        }
        //Send the Zanasi Command to Printer
        char[] SendInfoToPrinter(int Line)
        {
            //Generate and Set Serial number, line 3 in this case
            Random SerialNumber = new Random();
            ODBCLimits[(int)eODBCLimits.Line3] = SerialNumber.Next().ToString();
            //Set and Wrap message to Zanasi Command
            Byte[] _ZanasiCMD = WrapMsgLine_To_ZanasiCommand(ODBCLimits[Line], Line);
            //Send to Printer
            char[]  Line1_Command = System.Text.Encoding.Default.GetChars(_ZanasiCMD);

            return Line1_Command;
        }
        //Convert the message to Zanasi Command
        Byte[] WrapMsgLine_To_ZanasiCommand(string msg, int Line)
        {
            //Select Line Index
            Byte mLine = 0x00;
            switch (Line)
            {
                case 0:
                    mLine = LineIndex0; break;
                case 1:
                    mLine = LineIndex1; break;
                case 2:
                    mLine = LineIndex2; break;
                default:
                    mLine = LineIndex0; break;
            }
            //Conversion Message to Char[]
            char[] charMessage = msg.ToCharArray();
            //Conversion Char[] to Byte[]
            byte[] byteMessage = new byte[MsgMaxSize];
            for (int i = 0; i < charMessage.Length; i++)
            {
                byteMessage[i] = Convert.ToByte(charMessage[i]);
            }

            #region Wrapping
            //Control Bytes (0-4)
            msgWrapped[(int)ZanasiCMD.Head]         = Head;
            msgWrapped[(int)ZanasiCMD.SetQuery]     = SetQuery;
            msgWrapped[(int)ZanasiCMD.LineIndex]    = mLine;
            msgWrapped[(int)ZanasiCMD.MsgIndex]     = MsgIndex;
            msgWrapped[(int)ZanasiCMD.MsgSize]      = MsgSize;
            //Message Bytes (5-16)
            for (int i = 0; i < MsgMaxSize; i++)
            {
                msgWrapped[i+5] = byteMessage[i];
            }
            #endregion

            return MsgWrapped;
        }
        //Table to display the Zanasi Command
        void mZanasiCommand()
        {
            //Defines of the Columns
            tbBuildZanasiCmd.Columns.Add("Fixture", typeof(string));
            tbBuildZanasiCmd.Columns.Add("Line 1", typeof(string));
            tbBuildZanasiCmd.Columns.Add("Line 2", typeof(string));
            tbBuildZanasiCmd.Columns.Add("Line 3", typeof(string));
            
            //Bind the Table to Data Grid Viewer
            tbl_BuidZanasiCmd.DataSource = tbBuildZanasiCmd;
        }

        #region ODBC Communication
        public bool LimitsDB()
        {
            bool bSucc = false;

            //Connection to ODBC Datasource
            using (OdbcConnection AccessDB_Conn = new OdbcConnection("DSN=" + oDBC_Name))
            {
                //Clear Table
                tblLimits.Rows.Clear();
                //Open Connection
                AccessDB_Conn.Open();
                txt_ReadData.AppendText("Connection OK\n");

                try
                {
                    //Select from the table "ZanasiDB" the device ID's and Print Lines
                    using (OdbcCommand SQLCommand = new OdbcCommand(PrintLines_Query +"'"+ cbx_DeviceID.SelectedItem.ToString()+"'", AccessDB_Conn))
                    {
                        using (OdbcDataReader reader = SQLCommand.ExecuteReader())
                        {
                            // while there is another record present
                            while (reader.Read())
                            {
                                //Store Limits
                                ODBCLimits[(int)eODBCLimits.Line1] = reader[1].ToString();
                                ODBCLimits[(int)eODBCLimits.Line2] = reader[2].ToString();
                                ODBCLimits[(int)eODBCLimits.Line3] = reader[3].ToString();
                                //Add limits to the Table
                                tblLimits.Rows.Add
                                (
                                    ODBCLimits[(int)eODBCLimits.Line1],
                                    ODBCLimits[(int)eODBCLimits.Line2],
                                    ODBCLimits[(int)eODBCLimits.Line3]
                                );
                                
                            }
                        }
                    }
                    bSucc = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Connection Failed" + ex);
                    bSucc = false;
                }

                //Close Connection
                AccessDB_Conn.Close();
            }

            return bSucc;
        }
        void Limits()
        {
            //Defines of the Columns
            tblLimits.Columns.Add("Line 1", typeof(string));
            tblLimits.Columns.Add("Line 2", typeof(string));
            tblLimits.Columns.Add("Line 3", typeof(string));
            //Bind the Table to Data Grid Viewer
            tbl_Limits.DataSource = tblLimits;
        }

        public bool GetDeviceIDs()
        {
            bool bSucc = false;

            //Connection to ODBC Datasource
            using (OdbcConnection AccessDB_Conn = new OdbcConnection("DSN=" + oDBC_Name))
            {
                //Clear Table
                cbx_DeviceID.Items.Clear();
                //Open Connection
                AccessDB_Conn.Open();
                txt_ReadData.AppendText("Connection OK\n");

                try
                {
                    //Select from the table "ZanasiDB" the device ID's and Print Lines
                    using (OdbcCommand SQLCommand = new OdbcCommand(DeviceIDList_Query, AccessDB_Conn))
                    {
                        using (OdbcDataReader reader = SQLCommand.ExecuteReader())
                        {
                            // while there is another record present
                            while (reader.Read())
                            {
                                //Search the Device IDs availables
                                cbx_DeviceID.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                    bSucc = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Connection Failed" + ex);
                    bSucc = false;
                }

                //Close Connection
                AccessDB_Conn.Close();
            }

            return bSucc;
        }

        //Get Device ID List available
        private void btn_DeviceID_Click(object sender, EventArgs e)
        {
            GetDeviceIDs();
        }
        //Get Limits: Print Lines
        private void btn_PrintLines_Click(object sender, EventArgs e)
        {
            LimitsDB();
        }
        #endregion

        #region Servo Press: Festo Controller CMMO ST LKP
        //Servo Press
        async Task tskServo_Print()
        {
            await Task.Run(() => Servo_Print());
        }
        bool Servo_Print()
        {
            bool bSucc = false;
            int sequence = 1;
            //Enable the Stepper Motor
            OCMMO.Reg1[(int)Servo_CCON_CPOS.Stop] = true;
            //HMI.OForm.ProdMessages("Servo press has began: Positions 1,2\n", "PLC");

            while (sequence < 3 )
            {
                if (OCMMO.Reg0[(int)Servo_SCON_SPOS.MC] && !OCMMO.Reg1[(int)Servo_CCON_CPOS.Start])
                {
                    switch (sequence)
                    {
                        case 1:
                            //Select position = 1
                            OCMMO.RecordSelect = (int)ServoPos.Pos1;
                            Thread.Sleep(200);
                            OCMMO.Reg1[(int)Servo_CCON_CPOS.Start] = true;
                            Thread.Sleep(1000);
                            break;
                        case 2:
                            //Select position = 2
                            OCMMO.RecordSelect = (int)ServoPos.Pos2;
                            Thread.Sleep(200);
                            OCMMO.Reg1[(int)Servo_CCON_CPOS.Start] = true;
                            Thread.Sleep(3000);
                            break;
                        default:
                            break;
                    }
                    sequence++;
                }
                OCMMO.Reg1[(int)Servo_CCON_CPOS.Start] = false;
            }
            //There were any Alarm?
            if (!OCMMO.Reg0[(int)Servo_SCON_SPOS.FoError] || !OCMMO.Reg0[(int)Servo_SCON_SPOS.Fault])
            {
                bSucc = true;
            }

            //Disable the Stepper Motor
            OCMMO.Reg1[(int)Servo_CCON_CPOS.Stop] = false;
            //HMI.OForm.ProdMessages("Servo press has finished\n", "PLC");
            return bSucc;
        }
        #endregion

        #region Remote IO: ADAM-6050
        void ADAM6050_Connect()
        {
            if (_ADAM6250.Open_Communication())
            {
                txt_ReadData.AppendText("Remote IO Connected\n");
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
                txt_ADAM6250_IP.Text = _ADAM6250.IP;
                txt_ADAM6250_Port.Text = _ADAM6250.Port.ToString();
            }
            else
            {
                btn_Connect.Enabled = true;
            }
        }

        void ADAM6050_Disconnect()
        {
            if (_ADAM6250.Close_Communication())
            {
                txt_ReadData.AppendText("Remote IO Disconnected\n");
                btn_Connect.Enabled = true;
                btn_Disconnect.Enabled = false;
                txt_ADAM6250_IP.Text = "";
                txt_ADAM6250_Port.Text = "";
            }
            else
            {
                btn_Disconnect.Enabled = true;
            }
        }
        private void btn_RemoteIOConnect_Click(object sender, EventArgs e)
        {
            ADAM6050_Connect();
        }

        private void btn_RemoteIODisconnect_Click(object sender, EventArgs e)
        {
            ADAM6050_Disconnect();
        }
        #endregion

        #region Information
        //Software Information
        private void SoftwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Software Info Form
            SoftInfo SoftInfopage = new SoftInfo();
            SoftInfopage.Show();

        }
        //Device Info
        private void Btn_TransInfo_Click(object sender, EventArgs e)
        {
            //Transducer Info Form
            TransducerInfo TransducerInfoPage = new TransducerInfo();
            TransducerInfoPage.Show();
        }



        #endregion

        
    }
}
