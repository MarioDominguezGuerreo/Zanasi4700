//Mario A. Dominguez Guerrero 
//August - 2021

#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
#endregion

#region Project Libraries
using EasyModbus;
#endregion

namespace Zanasi4700
{
    class CMMO_ST_LKP
    {
        #region Variables

        #region Modbus TCP: Communications
        //Modbus TCP parameters
        //IP 192.168.1.16
        private static string iP;
        public string IP
        {
            get
            {
                return iP;
            }
            set
            {
                iP = value;
            }
        }
        //Port 502
        private static int port;
        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }
        ///Communicacion parameters[#]
        /// 0 = Communication Status (Disconnected = 0, Connected = 1)
        /// 1 = Read / Write Coils, (Read = 0, Write = 1)
        /// 2 = Control (Disable = 0 / Enable = 1)
        private const int MAX_COMM_PARAM = 4;
        private static bool[] parameters = new bool[MAX_COMM_PARAM] { false, false, false, false };
        public bool[] Parameters
        {
            get
            {
                return parameters;
            }

            set
            {
                parameters = value;
            }
        }
        #endregion

        #region Modbus TCP: IO
        //The following operations(Modbus transactions) are supported:
        //Read Holding Registers        (0x03)
        //Read Exception Status         (0x07)
        //Write Multiple Registers      (0x10)
        //Read/Write Multiple Registers (0x17)
        //Read Device Identification    (0x2B)
        //The start address is always “0”; the byte sequence is always “Big endian”.

        //Read Holding Registers        (0x03)
        public const int ReadHoldingRegister_Addr = 0;
        public const int ReadHoldingRegister__size = 8;
        public int[] ReadHoldingRegister = new int[ReadHoldingRegister__size];
        //Write Multiple Registers      (0x10)
        public const int WMultipleRegisters_Addr = 0;
        public const int WMultipleRegisters_size = 8;
        public int[] WMultipleRegisters = new int[WMultipleRegisters_size];

        //Modbus TCP Digital IO
        #region Inputs
        //
        private static bool[] inputs = new bool[32] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public bool[] Inputs
        {
            get
            {
                return inputs;
            }

            set
            {
                inputs = value;
            }
        }
        //Lock Pop up messages
        #region Locks
        private static bool[] pressLock = new bool[32] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public bool[] PressLock
        {
            get
            {
                return pressLock;
            }

            set
            {
                pressLock = value;
            }
        }
        #endregion
        //Lock Pop up messages
        #region Locks
        private static bool[] safetyLock = new bool[32] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public bool[] SafetyLock
        {
            get
            {
                return safetyLock;
            }

            set
            {
                safetyLock = value;
            }
        }
        #endregion
        #endregion

        #region Outputs
        //
        private static bool[] outputs = new bool[32] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public bool[] Outputs
        {
            get
            {
                return outputs;
            }

            set
            {
                outputs = value;
            }
        }

        #endregion

        #region CMMO -> PC
        static bool[] reg0 = new bool[32];
        public bool[] Reg0
        {
            get
            {
                return reg0;
            }

            set
            {
                reg0 = value;
            }
        }
        #endregion

        #region PC -> CMMO
        static bool[] reg1 = new bool[32];
        public bool[] Reg1
        {
            get
            {
                return reg1;
            }

            set
            {
                reg1 = value;
            }
        }
        #endregion

        //Stepper Motor Position
        static double position;
        public double Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
        //Selection of the position (Record Selection)
        static int recordSelect = 0;
        public int RecordSelect
        {
            get
            {
                return recordSelect;
            }

            set
            {
                recordSelect = value;
            }
        }
        #endregion

        #region Limits
        static int pressDelay;
        public int PressDelay
        {
            get
            {
                return pressDelay;
            }

            set
            {
                pressDelay = value;
            }
        }
        #endregion

        #endregion

        #region Callbacks

        #endregion

        #region Objects

        // IP: 192.168.1.16 and PORT: 502 for FESTO Modbus TCP gateway module (CMMO-ST-LKP)
        ModbusClient modbusClient = new ModbusClient(iP, port);
        #endregion

        #region Controls

        #endregion

        #region Information

        #endregion

        #region Functions

        #region Public

        #endregion

        #region Private
        //Conect to the Modbus TCP Module
        private bool Connect()
        {
            try
            {
                //Open the connection
                modbusClient.Connect(iP, port);
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)PLC_Comm.CommStatus] = modbusClient.Connected;
                //Press delay to stay down
                pressDelay = 7000;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        //Disconnect to the Modbus TCP Module
        private bool Disconnect()
        {
            try
            {
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)PLC_Comm.Control] = false;
                //Close the connection   
                modbusClient.Disconnect();
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)PLC_Comm.CommStatus] = modbusClient.Connected;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        //Read Holding Registers        (0x03)
        private void _ReadHoldingRegister()
        {
            //Device Connected
            if (modbusClient.Connected)
            {
                try
                {
                    ReadHoldingRegister = modbusClient.ReadHoldingRegisters(ReadHoldingRegister_Addr, ReadHoldingRegister__size);
                    //Register 0 to bit Array (2 bytes)
                    reg0 = DINTtoBitArray(ReadHoldingRegister[0]);
                    Position = Convert.ToDouble(ReadHoldingRegister[3] * 0.001);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        //Write Multiple Registers      (0x10)
        private void _WMultipleRegisters()
        {
            //Device Connected
            if (modbusClient.Connected)
            {
                try
                {
                    //CCON-CPOS Control
                    WMultipleRegisters[0] = BooleanArrayToDINT(reg1);
                    //Record Selction
                    WMultipleRegisters[1] = recordSelect;
                    modbusClient.WriteMultipleRegisters(WMultipleRegisters_Addr, WMultipleRegisters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        #region Conversions DINT / Boolean
        //Integer to Boolean Array
        public bool[] DINTtoBitArray(int Value)
        {
            bool[] Inputs = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

            BitArray ba = new BitArray(new int[] { Value });
            for (int i = 0; i < ba.Length; i++)
            {
                Inputs[i] = ba[i];
            }
            return Inputs;
        }
        //Boolean Array to Integer
        public int BooleanArrayToDINT(bool[] Outputs)
        {
            int resultado = 0;

            for (int i = 0; i < Outputs.Length; i++)
            {
                if (Outputs[i])
                {
                    // Usamos la potencia de 2, según la posición
                    resultado += (int)Math.Pow(2, i);
                }
            }
            return resultado;
        }
        //Boolean Array to Integer 16 bits
        public Int16 BooleanArrayToDINT16(bool[] Outputs)
        {
            Int16 resultado = 0;

            for (int i = 0; i < Outputs.Length; i++)
            {
                if (Outputs[i])
                {
                    // Usamos la potencia de 2, según la posición
                    resultado += (short)Math.Pow(2, i);
                }
            }
            return resultado;
        }
        #endregion

        #endregion

        #endregion

        #region Threads
        //Open the communication
        public bool Open_Communication()
        {
            if (!parameters[(int)PLC_Comm.Control])
            {
                if (Connect())
                {
                    parameters[(int)PLC_Comm.Control] = true;
                    //Active the communication process
                    Thread Tick = new Thread(new ThreadStart(() => Communication()));
                    Tick.Start();
                    return true;
                }
                else
                {
                    parameters[(int)PLC_Comm.Control] = false;
                    return false;
                }

            }
            else
                return false;
        }
        //Scan process for Digital IO
        private void Communication()
        {
            while (parameters[(int)PLC_Comm.Control])
            {
                //Read Holding Registers        (0x03)
                _ReadHoldingRegister();
                //Write Multiple Registers      (0x10)
                _WMultipleRegisters();

                Thread.Sleep(50);
            }
        }
        //Close the communication
        public bool Close_Communication()
        {
            if (parameters[(int)PLC_Comm.Control])
            {
                parameters[(int)PLC_Comm.Control] = false;
                Disconnect();
                return true;
            }
            else
            {
                parameters[(int)PLC_Comm.Control] = false;
                return false;
            }
        }
        #endregion
    }
}

