//Mario A. Dominguez Guerrero, 05/Nov/2022

#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
#endregion

#region Project Libraries

#endregion

namespace Zanasi4700
{
    class Client_TcpIp
    {
        #region Variables

        #region Communicacion Parameters[#]
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

        #region TCP/IP Client Settings
        private static string iP = "127.0.0.1";
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
        private static int port = 9999;
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
        public static Socket PC_Client;
        //Message
        public const int MAX_COMMAND_SIZE = 3000;
        #endregion

        #endregion

        #region Functions
        //Conect to the Zanasi 4700 (Server)
        private bool Connect()
        {
            bool bSucc = false;
            try
            {
                //Open the connection
                //Configuracion del Servidor
                PC_Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ServidorDireccion = new IPEndPoint(IPAddress.Parse(iP), port);
                PC_Client.Connect(ServidorDireccion);

                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)Scanner_Comm.CommStatus] = true;
                bSucc = true;
            }
            catch (Exception e)
            {
                //Message
                //HMI.OForm.SystemMessages("Connection Error\n", "Error");
                Console.WriteLine(e);
            }
            return bSucc;
        }
        //Disconnect to the Zanasi 4700 (Server)
        private bool Disconnect()
        {
            bool bSucc = false;
            try
            {
                //Close the connection   
                PC_Client.Disconnect(false);
                //Status of the Connection (Connected = 1, Disconnected = 0)
                parameters[(int)Scanner_Comm.CommStatus] = false;
                bSucc = true;
            }
            catch (Exception e)
            {
                //Message
                //HMI.OForm.SystemMessages("Disconnection Error\n", "Error");
                Console.WriteLine(e);
            }
            return bSucc;
        }
        //Read data from the Zanasi 4700 (Server)
        private void ReadMessage()
        {
            //Connection is Open
            if (parameters[(int)Scanner_Comm.CommStatus])
            {
                //Get the message
                byte[] Msg = new byte[MAX_COMMAND_SIZE];
                //Get the message length         
                int Size = PC_Client.Receive(Msg);
                
            }
        }
        //Send data from the Zanasi 4700 (Server)
        public void SendCommand(string Command)
        {
            if (parameters[(int)Scanner_Comm.CommStatus])
                PC_Client.Send(System.Text.Encoding.Default.GetBytes(Command), 0, Command.Length, SocketFlags.None);
        }

        #endregion

        #region Threads
        //Open the communication
        public bool Open_Communication()
        {
            bool bSucc = false;
            if (!parameters[(int)Scanner_Comm.Control])
            {
                if (Connect())
                {
                    parameters[(int)Scanner_Comm.Control] = true;
                    //Active the communication process
                    Thread Tick = new Thread(new ThreadStart(() => Communication()));
                    Tick.Start();
                    bSucc = true;
                }
                else
                    parameters[(int)Scanner_Comm.Control] = false;
            }

            return bSucc;
        }
        //Communication Proccess
        private void Communication()
        {
            while (parameters[(int)Scanner_Comm.CommStatus])
            {
                //Reading the Zanasi 4700  Messages
                ReadMessage();
            }
        }
        //Close the communication
        public bool Close_Communication()
        {
            bool bSucc = false;
            if (parameters[(int)Scanner_Comm.Control])
            {
                Disconnect();
                parameters[(int)Scanner_Comm.Control] = false;
                bSucc = true;
            }
            else
                parameters[(int)Scanner_Comm.Control] = false;

            return bSucc;
        }
        #endregion
    }
}
