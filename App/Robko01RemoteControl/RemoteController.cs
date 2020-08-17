/*

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
using System.Net;
using System.Net.Sockets;
using System.Threading;

using Modbus.Data;
using Modbus.Device;

using Robko01RemoteControl.Data;
using Robko01RemoteControl.Events;

namespace Robko01RemoteControl
{
    public class RemoteController : IDisposable
    {

        #region Variables

        private byte slaveAddress;
        private IPEndPoint endPoint;
        private ModbusTcpSlave mbSlave;
        private TcpListener listener;
        private Thread slaveThread;

        #endregion

        #region Properties

        public ushort StartAddress { get; set; }

        #endregion

        #region Events

        public event EventHandler<MotionCommandEventArg> MotionHandler;

        public event EventHandler<DriverStateEventArg> DriverState;

        #endregion

        #region Constructor / Destructor

        public RemoteController(IPEndPoint endPoint, byte slaveAddress)
        {
            this.endPoint = endPoint;
            this.slaveAddress = slaveAddress;
            this.StartAddress = 0;
        }

        ~RemoteController()
        {
            this.Dispose();
        }

        #endregion

        #region Connect / Disconnect

        public void Connect()
        {
            this.listener = new TcpListener(this.endPoint);

            this.mbSlave = ModbusTcpSlave.CreateTcp(this.slaveAddress, this.listener);
            this.mbSlave.DataStore = DataStoreFactory.CreateDefaultDataStore();
            this.mbSlave.DataStore.DataStoreWrittenTo += DataStore_DataStoreWrittenTo;
            
            this.slaveThread = new Thread(mbSlave.Listen);
            this.slaveThread.Start();
        }

        public void Disconnect()
        {
            //this.listener.Stop();
            this.slaveThread.Abort();

            this.mbSlave.DataStore.DataStoreWrittenTo -= DataStore_DataStoreWrittenTo;
            this.mbSlave.Dispose();

            if (this.listener != null)
            {
                this.listener.Stop();
                this.listener = null;
            }
        }

        #endregion

        #region DataStore Event

        private void DataStore_DataStoreWrittenTo(object sender, DataStoreEventArgs e)
        {
            if (e.Data.B != null)
            {
                MotionMemory mapping = new MotionMemory(this.StartAddress);
                MotionCommandEventArg holder = new MotionCommandEventArg();
                DriverStateEventArg state = new DriverStateEventArg();

                ushort mode = this.mbSlave.DataStore.HoldingRegisters[mapping.Mode];

                //TODO: Write parser to different codes.
                if (mode == 1)
                {
                    if (this.MotionHandler != null)
                    {
                        holder.BaseSteps = this.mbSlave.DataStore.HoldingRegisters[mapping.BaseSteps];
                        holder.ShoulderSteps = this.mbSlave.DataStore.HoldingRegisters[mapping.ShoulderSteps];
                        holder.ElbowSteps = this.mbSlave.DataStore.HoldingRegisters[mapping.ElbowSteps];
                        holder.PichSteps = this.mbSlave.DataStore.HoldingRegisters[mapping.PichSteps];
                        holder.RollSteps = this.mbSlave.DataStore.HoldingRegisters[mapping.RollSteps];
                        holder.GripperSteps = this.mbSlave.DataStore.HoldingRegisters[mapping.GripperSteps];
                        holder.BaseDelay = this.mbSlave.DataStore.HoldingRegisters[mapping.BaseDelay];
                        holder.ShoulderDelay = this.mbSlave.DataStore.HoldingRegisters[mapping.ShoulderDelay];
                        holder.ElbowDelay = this.mbSlave.DataStore.HoldingRegisters[mapping.ElbowDelay];
                        holder.PichDelay = this.mbSlave.DataStore.HoldingRegisters[mapping.PichDelay];
                        holder.RollDelay = this.mbSlave.DataStore.HoldingRegisters[mapping.RollDelay];
                        holder.GripperDelay = this.mbSlave.DataStore.HoldingRegisters[mapping.GripperDelay];

                        this.MotionHandler(this, holder);
                    }
                }
                else if (mode == 2)
                {
                    if (this.DriverState != null)
                    {
                        state.Base = this.mbSlave.DataStore.HoldingRegisters[mapping.BaseState];
                        state.Shoulder = this.mbSlave.DataStore.HoldingRegisters[mapping.ShoulderState];
                        state.Elbow = this.mbSlave.DataStore.HoldingRegisters[mapping.ElbowState];
                        state.Pitch = this.mbSlave.DataStore.HoldingRegisters[mapping.PichState];
                        state.Roll = this.mbSlave.DataStore.HoldingRegisters[mapping.RollState];
                        state.Gripper = this.mbSlave.DataStore.HoldingRegisters[mapping.GripperState];

                        this.DriverState(this, state);
                    }
                }
            }
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            this.Disconnect();
        }

        #endregion

    }
}