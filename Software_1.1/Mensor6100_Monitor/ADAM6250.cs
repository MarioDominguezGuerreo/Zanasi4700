//Mario A. Dominguez Guerrero 
//Septiembre - 2020

#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
#endregion

#region Project Libreries
using EasyModbus;
#endregion


namespace Zanasi4700
{
    class ADAM6250
    {
        #region Variables

        #region Modbus TCP: Communications
        //IP
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
        //Port
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
        private static bool[] parameters = new bool[4] { false, false, false, false };
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
        //ADAM-6250 as slave — Data addressing
        //Read Inputs: Address, Quantity
        public const int InputAddr = 0;
        public const int InputSize = 12;
        //Read / Write Outputs: Address, Quantity
        public const int OutputAddr = 16;
        public const int OutputSize = 6;

        //Modbus TCP Digital IO
        #region Inputs
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
        #endregion

        #region Outputs
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

        #endregion

        #endregion

        #region Callbacks

        #endregion

        #region Objects
        // IP and PORT: 502 for ADAM-6250 Modbus TCP
        ModbusClient modbusClient = new ModbusClient(iP, port);
        #endregion

        #region Functions
        //Conect to the Modbus TCP Module
        private bool Connect()
        {
            try
            {
                //Open the connection
                modbusClient.Connect(IP, port);
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[0] = modbusClient.Connected;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Disconnect to the Modbus TCP Module
        private bool Disconnect()
        {
            try
            {
                //Close the connection   
                modbusClient.Disconnect();
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[0] = modbusClient.Connected;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Scan Digital Inputs
        private void DigitalInputs()
        {
            //Device Connected
            if (parameters[0])
            {
                //Read Inputs
                inputs = modbusClient.ReadDiscreteInputs(InputAddr, InputSize);
            }
        }
        //Scan Digital Ouputs
        private void DigitalOutputs()
        {
            //Device Connected
            if (parameters[0])
            {
                //Manual Mode
                if (!parameters[1])
                {
                    //Write Output 
                    modbusClient.WriteMultipleCoils(OutputAddr, outputs);
                }
                else
                {
                    //Read Output 
                    outputs = modbusClient.ReadCoils(OutputAddr, OutputSize);
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

        #region Threads
        //Open the communication
        public bool Open_Communication()
        {
            if (!parameters[2])
            {
                if (Connect())
                {
                    parameters[2] = true;
                    //Active the communication process
                    Thread Tick = new Thread(new ThreadStart(() => Communication()));
                    Tick.Start();
                    return true;
                }
                else
                {
                    parameters[2] = false;
                    return false;
                }

            }
            else
                return false;
        }
        //Scan process for Digital IO
        private void Communication()
        {
            while (parameters[2])
            {
                //Scanning digital Inputs
                DigitalInputs();
                //Scanning digital Outputs
                DigitalOutputs();
            }
        }
        //Close the communication
        public bool Close_Communication()
        {
            if (parameters[2])
            {
                parameters[2] = false;
                Thread.Sleep(100);
                Disconnect();
                return true;
            }
            else
            {
                parameters[2] = false;
                return false;
            }
        }
        #endregion
    }
}
