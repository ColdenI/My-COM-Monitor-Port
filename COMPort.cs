using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace My_COM_Monitor_Port
{
    internal class COMPort : ICOMPort
    {
        private SerialPort SerialPort;

        private string _name;
        private string _port = "COM1";
        private int _speed = 9600;
        private string messageHistory;

        public string MessageHistory { get => messageHistory; }
        public string Name { get => _name; set => _name = value; }
        public string Port { get => _port; set => _port = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public bool IsConnected => SerialPort.IsOpen;

        public bool AddedTimeInHistoryMessage = false;
        public bool ReadLineOrReadExisting = true;
        public bool PauseDrawMessage = false;
        public bool Added_NL_writeSerial = false;


        public COMPort(string name) 
        {
            _name = name;
            init();       
        }
        public COMPort(string name, string port, int speed) : this (name)
        {
            _port = port;
            _speed = speed;   
        }
        public COMPort(string name, string port, int speed, bool addedTimeInHistoryMessage, bool readLineOrReadExisting, bool pauseDrawMessage, bool added_NL_writeSerial)
        : this (name, port, speed)
        {
            AddedTimeInHistoryMessage = addedTimeInHistoryMessage;
            ReadLineOrReadExisting = readLineOrReadExisting;
            PauseDrawMessage = pauseDrawMessage;
            Added_NL_writeSerial = added_NL_writeSerial;
        }
        public COMPort(COMPortData d) : this(d.Name, d.Port, d.Speed, d.AddedTimeInHistoryMessage, d.ReadLineOrReadExisting, d.PauseDrawMessage, d.Added_NL_writeSerial) { }


        protected void init()
        {
            SerialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            
            SerialPort.DataBits = 8;
            SerialPort.DiscardNull = false;
            SerialPort.DtrEnable = false;
            SerialPort.Handshake = Handshake.None;
            SerialPort.Parity = Parity.None;
            SerialPort.ParityReplace = 63;
            SerialPort.ReadBufferSize = 4096;
            SerialPort.ReadTimeout = -1;
            SerialPort.ReceivedBytesThreshold = 1;
            SerialPort.RtsEnable = false;
            SerialPort.StopBits = StopBits.One;
            SerialPort.WriteBufferSize = 2048;
            SerialPort.WriteTimeout = -1;
            
        }

        public void Dispose()
        {
            Disconnect();
            SerialPort.Dispose();
            if(SerialPort != null) SerialPort = null;
            messageHistory = null;
            _name = null;
            _port = null;
            GC.SuppressFinalize(this);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IsConnected)
            {
                string data = string.Empty;

                try
                {
                    data = ReadLineOrReadExisting ? SerialPort.ReadLine() : SerialPort.ReadExisting();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                if (AddedTimeInHistoryMessage)
                    messageHistory = System.DateTime.Now.ToString() + " -> " + data + "\n" + messageHistory;
                else
                    messageHistory = data + messageHistory;
            }
        }

        public void Connect()
        {
            SerialPort.BaudRate = _speed;
            SerialPort.PortName = _port;
            try
            {
                SerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Порт занят!");
            }
        }

        public void Disconnect()
        {
            if (!SerialPort.IsOpen) return;
            SerialPort.Close();
        }

        public bool SendCommsnd(string message)
        {
            if (!SerialPort.IsOpen)
            {
                MessageBox.Show("Порт закрыт!");
                return false;
            }
            SerialPort.Write(message);
            return true;
        }

        public void ClearHistory() => messageHistory = string.Empty;

        public COMPortData PackData()
        {
            COMPortData data = new COMPortData();
            data.Name = _name;
            data.Port = _port;
            data.Speed = _speed;
            data.PauseDrawMessage = PauseDrawMessage;
            data.AddedTimeInHistoryMessage = AddedTimeInHistoryMessage;
            data.Added_NL_writeSerial = Added_NL_writeSerial;
            data.ReadLineOrReadExisting = ReadLineOrReadExisting;
            return data;
        }
    }

    public class COMPortData
    {
        public string Name { get; set; }
        public string Port { get; set; }
        public int Speed { get; set; }
        public bool AddedTimeInHistoryMessage { get; set; }
        public bool ReadLineOrReadExisting { get; set; }
        public bool PauseDrawMessage { get; set; }
        public bool Added_NL_writeSerial { get; set; }
    }

    internal interface ICOMPort
    {
        string Name { get; set; }
        string Port { get; set; }
        int Speed { get; set; }
        bool IsConnected { get; }

        string MessageHistory { get; }

        void Connect();
        void Disconnect();
        bool SendCommsnd(string message);

        void ClearHistory();
    }

}
