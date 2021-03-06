﻿using System;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Threading;

namespace Termie
{
    /// <summary> CommPort class creates a singleton instance
    /// of SerialPort (System.IO.Ports) </summary>
    /// <remarks> When ready, you open the port.
    ///   <code>
    ///   CommPort com = CommPort.Instance;
    ///   com.StatusChanged += OnStatusChanged;
    ///   com.DataReceived += OnDataReceived;
    ///   com.Open();
    ///   </code>
    ///   Notice that delegates are used to handle status and data events.
    ///   When settings are changed, you close and reopen the port.
    ///   <code>
    ///   CommPort com = CommPort.Instance;
    ///   com.Close();
    ///   com.PortName = "COM4";
    ///   com.Open();
    ///   </code>
    /// </remarks>
    public sealed class CommPort
    {
        SerialPort _serialPort;
        Thread _readThread;
        volatile bool _keepReading;
        volatile bool _bRunning;

        //begin Singleton pattern
        static readonly CommPort instance = new CommPort();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static CommPort()
        {
        }

        CommPort()
        {
            _serialPort = new SerialPort();
            _readThread = null;
            _keepReading = false;
            _bRunning = false;
        }

        public static CommPort Instance
        {
            get
            {
                return instance;
            }
        }
        //end Singleton pattern

        //begin Observer pattern
        public delegate void EventHandler(string param);
        public EventHandler StatusChanged;
        public delegate void PacketEventHandler(RealPacket param);
        public PacketEventHandler DataReceived;
        //end Observer pattern

        private void StartReading()
        {
            if (!_keepReading)
            {
                _keepReading = true;
                _readThread = new Thread(ReadPort);
                _readThread.Start();
            }
        }

        private void StopReading()
        {
            if (_keepReading)
            {
                _keepReading = false;
                _readThread.Join();	//block until exits
                _readThread = null;
            }
        }

        /// <summary> Get the data and pass it on. </summary>
        /// 

        private const int REAL_PACKET_SIZE = 18;
        
        private void ReadPort()
        {
            int offSet = 0;
            int added = 0;
            int endIdx = 0;
            Packet SerialIn = new Packet();
            byte[] packetBytes = new byte[Packet.size];
            byte[] readBuffer = new byte[_serialPort.ReadBufferSize];

            while (_keepReading)
            {
                if (_serialPort.IsOpen && _bRunning)
                {
                    byte[] remainedBytes = new byte[_serialPort.ReadBufferSize];
                    try
                    {
                        RealPacket packet;
                        added = _serialPort.BytesToRead;
                        _serialPort.Read(readBuffer, offSet, added);
                        offSet += added;
                        
                        endIdx = SerialIn.getLastIdx(readBuffer, offSet);
                        if (endIdx == -1)
                            continue;
                        Array.Copy(readBuffer, endIdx + 1 - Packet.size, packetBytes, 0, Packet.size);
                        Array.Copy(readBuffer, endIdx + 1, remainedBytes, 0, offSet - endIdx - 1);
                        // If there are bytes available on the serial port,
                        // Read returns up to "count" bytes, but will not block (wait)
                        // for the remaining bytes. If there are no bytes available
                        // on the serial port, Read will block until at least one byte
                        // is available on the port, up until the ReadTimeout milliseconds
                        // have elapsed, at which time a TimeoutException will be thrown.
                        packet = SerialIn.SetData(packetBytes);
                        DataReceived(packet);
                        readBuffer = remainedBytes;
                        offSet = 0;
                    }
                    catch (TimeoutException)
                    {
                    }
                }
                else
                {
                    TimeSpan waitTime = new TimeSpan(0, 0, 0, 0, 50);
                    Thread.Sleep(waitTime);
                }
            }
        }

        /// <summary> Open the serial port with current settings. </summary>
        public void Open()
        {
            Close();

            try
            {
                _serialPort.PortName = Settings.Port.PortName;
                _serialPort.BaudRate = Settings.Port.BaudRate;
                _serialPort.Parity = Settings.Port.Parity;
                _serialPort.DataBits = Settings.Port.DataBits;
                _serialPort.StopBits = Settings.Port.StopBits;
                _serialPort.Handshake = Settings.Port.Handshake;

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 50;
                _serialPort.WriteTimeout = 50;

                _serialPort.Open();
                StartReading();
            }
            catch (IOException)
            {
                StatusChanged(String.Format("{0} does not exist", Settings.Port.PortName));
            }
            catch (UnauthorizedAccessException)
            {
                StatusChanged(String.Format("{0} already in use", Settings.Port.PortName));
            }
            catch (Exception ex)
            {
                string tmp = ex.ToString();
                StatusChanged(String.Format("{0}", ex.ToString()));
            }

            // Update the status
            if (_serialPort.IsOpen)
            {
                string p = _serialPort.Parity.ToString().Substring(0, 1);   //First char
                string h = _serialPort.Handshake.ToString();
                if (_serialPort.Handshake == Handshake.None)
                    h = "no handshake"; // more descriptive than "None"

                StatusChanged(String.Format("{0}: {1} bps, {2}{3}{4}, {5}",
                    _serialPort.PortName, _serialPort.BaudRate,
                    _serialPort.DataBits, p, (int)_serialPort.StopBits, h));
            }
            else
            {
                StatusChanged(String.Format("{0} already in use", Settings.Port.PortName));
            }
        }

        /// <summary> Close the serial port. </summary>
        public void Close()
        {
            StopReading();
            _serialPort.Close();
            StatusChanged("connection closed");
        }

        /// <summary> Get the status of the serial port. </summary>
        public bool IsOpen
        {
            get
            {
                return _serialPort.IsOpen;
            }
        }

        /// <summary> Get a list of the available ports. Already opened ports
        /// are not returend. </summary>
        public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>Send data to the serial port after appending line ending. </summary>
        /// <param name="data">An string containing the data to send. </param>
        public void Send(string data)
        {
            if (IsOpen)
            {
                string lineEnding = "";
                //switch (Settings.Option.AppendToSend)
                //{
                //    case Settings.Option.AppendType.AppendCR:
                //        lineEnding = "\r"; break;
                //    case Settings.Option.AppendType.AppendLF:
                //        lineEnding = "\n"; break;
                //    case Settings.Option.AppendType.AppendCRLF:
                //        lineEnding = "\r\n"; break;
                //}
                _serialPort.Write(data + lineEnding);
            }
        }

        public void SendByFloat(byte[] data)
        {
            if (IsOpen)
            {
                string lineEnding = "";
                //switch (Settings.Option.AppendToSend)
                //{
                //    case Settings.Option.AppendType.AppendCR:
                //        lineEnding = "\r"; break;
                //    case Settings.Option.AppendType.AppendLF:
                //        lineEnding = "\n"; break;
                //    case Settings.Option.AppendType.AppendCRLF:
                //        lineEnding = "\r\n"; break;
                //}
                _serialPort.Write(data + lineEnding);
            }
        }

        public void Button_Click()
        {
            _bRunning = !_bRunning;
        }

        public bool IsRunning()
        {
            return _bRunning;
        }
    }
}