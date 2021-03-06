﻿/*

Copyright (c) [2016] [Orlin Dimitrov]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

using System;
using System.IO.Ports;
using System.Threading;

using Robko01Lib.Events;

namespace Robko01Lib.Adapters
{
    /// <summary>
    /// Serial port communicator. 
    /// </summary>
    public class SerialAdapter : Adapter
    {

        #region Variables

        /// <summary>
        /// Communication port.
        /// </summary>
        private SerialPort serialPort;

        /// <summary>
        /// Communication lock object.
        /// </summary>
        private Object requestLock = new Object();

        /// <summary>
        /// When is connected to the robot.
        /// </summary>
        private bool isConnected = false;

        /// <summary>
        /// 
        /// </summary>
        private int timeOut;

        #endregion

        #region Properties

        /// <summary>
        /// If the board is correctly connected.
        /// </summary>
        public override bool IsConnected
        {
            get
            {
                return this.isConnected;
            }

            protected set
            {

            }
        }

        /// <summary>
        /// Maximum timeout.
        /// </summary>
        public override int MaxTimeout { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// Received command message.
        /// </summary>
        public override event EventHandler<EventArgsString> OnMessage;

        /// <summary>
        /// On connection established.
        /// </summary>
        public override event EventHandler<EventArgs> OnConnect;

        #endregion

        #region Constructor / Destructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="port">Communication port.</param>
        public SerialAdapter(SerialPort serialPort)
        {
            // Save the port name.
            this.serialPort = serialPort;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~SerialAdapter()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public override void Dispose()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Add resources for disposing.
            }

            this.Disconnect();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Data receiver handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // Wait ...
            Thread.Sleep(550);

            if (sender != null)
            {
                // Make serial port to get data from.
                SerialPort serialPort = (SerialPort)sender;

                try
                {
                    string inData = serialPort.ReadExisting();

                    this.OnMessage?.Invoke(this, new EventArgsString(inData));

                    // Discard the duffer.
                    serialPort.DiscardInBuffer();
                }
                catch
                { }
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Connect to the serial port.
        /// </summary>
        public override void Connect()
        {
            try
            {
                if (!this.isConnected)
                {
                    this.serialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
                    this.serialPort.Open();

                    this.isConnected = true;
                }
            }
            catch
            {
                this.timeOut += 1000;
                Thread.Sleep(timeOut);
                this.isConnected = false;
            }
            finally
            {
                if (this.timeOut > this.MaxTimeout)
                {
                    throw new InvalidOperationException("Could not connect to the robot.");
                }
            }
        }

        /// <summary>
        /// Disconnect
        /// </summary>
        public override void Disconnect()
        {
            if (this.isConnected)
            {
                this.serialPort.Close();
                this.isConnected = false;
            }
        }

        /// <summary>
        /// Reset the Robot.
        /// </summary>
        public override void Reset()
        {
            if (this.IsConnected && this.serialPort.IsOpen)
            {
                this.serialPort.DtrEnable = true;
                Thread.Sleep(200);
                this.serialPort.DtrEnable = false;
            }
        }

        /// <summary>
        /// Send request to the device.
        /// </summary>
        /// <param name="command"></param>
        public override void SendRequest(string command)
        {
            lock (this.requestLock)
            {
                try
                {
                    if (this.isConnected)
                    {
                        this.serialPort.Write(command);
                    }
                }
                catch
                {
                    this.isConnected = false;
                    // Reconnect.
                    this.Connect();
                }
            }
        }

        #endregion

    }
}
