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
using System.Threading;

using Robko01Lib.Data;
using Robko01Lib.Adapters;
using Robko01Lib.Events;

namespace Robko01Lib.Controllers.TUGAB
{

    /// <summary>
    /// Robko01 controller.
    /// </summary>
    public class Robko01 : RobotDevice
    {

        #region Constants

        private const string TERMIN = "\n";
        
        #endregion

        #region Variables

        /// <summary>
        /// Delimiting characters.
        /// </summary>
        private char[] delimiterChars = { '\n' };

        private int[] steps = new int[6];

        private Adapter adapter;

        #endregion

        #region Properties

        public override bool IsConnected
        {
            get
            {
                if (this.adapter == null) return false;
                return this.adapter.IsConnected;
            }
        }

        #endregion

        #region Constructor / Destructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="port">Communication port.</param>
        public Robko01(Adapter adapter)
        {
            this.adapter = adapter;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Robko01()
        {
            //base.Dispose(false);
        }
        
        #endregion

        #region Public Overrider Methods

        /// <summary>
        /// Connect to the Robot.
        /// </summary>
        public override void Connect()
        {
            this.Disconnect();
            this.adapter.Connect();
            // TODO: add the event
            //this.adapter.OnMessage += Adapter_OnMessage;
        }

        /// <summary>
        /// Disconnect
        /// </summary>
        public override void Disconnect()
        {
            if (this.adapter == null || !this.adapter.IsConnected) return;

            this.adapter.Disconnect();
        }

        /// <summary>
        /// Enables the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Enable(JointName joint)
        {
            if (joint == JointName.All)
            {
                string command = "?EA";
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Elbow)
            {
                string command = String.Format("?E{0}", (int)JointName.Elbow) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?E{0}", (int)JointName.Gripper) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Roll)
            {
                string command = String.Format("?E{0}", (int)JointName.Elbow) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?E{0}", (int)JointName.Gripper) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else
            {
                string command = String.Format("?E{0}", (int)joint) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Disable the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Disable(JointName joint)
        {
            if (joint == JointName.All)
            {
                string command = "?NA";
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Elbow)
            {
                string command = String.Format("?N{0}", (int)JointName.Elbow) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?N{0}", (int)JointName.Gripper) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Pitch|| joint == JointName.Roll)
            {
                string command = String.Format("?N{0}", (int)JointName.LD) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?N{0}", (int)JointName.RD) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else
            {
                string command = String.Format("?N{0}", (int)joint) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Start the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Start(JointName joint)
        {
            if (joint == JointName.All)
            {
                string command = "?SA";
                this.adapter.SendRequest(command);
            }
            else
            {
                string command = String.Format("?S{0}", (int)joint) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Stop the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Stop(JointName joint)
        {
            if (joint == JointName.All)
            {
                string command = "?PA";
                this.adapter.SendRequest(command);
            }
            else
            {
                string command = String.Format("?P{0}", (int)joint) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Read the motor state.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void GetJoint(JointName joint)
        {
            if (joint == JointName.All)
            {
                string command = "?RA";
                this.adapter.SendRequest(command);
            }
            else
            {
                string command = String.Format("?R{0}", (int)joint) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Move relative single motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        /// <param name="direction">Direction of the movement.</param>
        /// <param name="delay">Delay between steps.</param>
        /// <param name="steps">Steps count.</param>
        public override void SetJoint(JointName joint, int delay, int steps)
        {
            int absSteps = Math.Abs(steps);

            if (joint == JointName.Elbow)
            {
                string direction = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)JointName.Elbow, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)JointName.Gripper, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Pitch)
            {
                string direction = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)JointName.LD, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)JointName.RD, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Roll)
            {
                string ldDir = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string rdDir = (steps <  0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)JointName.LD, ldDir, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)JointName.RD, rdDir, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else
            {
                string direction = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?F{0}:{1}{2:D4}:{3:D4}", (int)joint, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }

            this.Busy(Math.Abs(absSteps * delay * 2.5f));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Start the motor marked with index 1 or true.
        /// Else not starting.
        /// </summary>
        /// <param name="states">Array of start states.</param>
        public void Start(bool[] states)
        {
            if (states.Length >= 6)
            {
                string indexes = "";
                for (int index = 0; index < states.Length; index++)
                {
                    string state = states[index] ? "1" : "0";
                    indexes += state;
                }

                string command = "?SD" + indexes;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Set the delay between two steps.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        /// <param name="delay">Delay of steps.</param>
        public void Delay(int joint, int delay)
        {
            // TODO: set
            if (joint <= 5 && joint >= 0)
            {
                string command = String.Format("?T{0}:{1:D4}", joint, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Set the delay between two steps.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        /// <param name="steps">Steps count.</param>
        public void Step(int joint, int steps)
        {
            // TODO: set 
            if (joint <= 5 && joint >= 0)
            {
                string command = String.Format("?A{0}:{1:D4}", joint, steps) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Set clock wise direction of the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public void SetCW(int joint)
        {
            // TODO: set
            if (joint <= 5 && joint >= 0)
            {
                string command = String.Format("?D{0}:{1}", joint, JointDirection.CW) + TERMIN;
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Set contra clock wise direction of the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public void SetCCW(int joint)
        {
            // TODO: set
            {
                if (joint <= 5 && joint >= 0)
                {
                    string command = String.Format("?D{0}:{1}", joint, JointDirection.CCW) + TERMIN;
                    this.adapter.SendRequest(command);
                }
            }
        }

        #endregion

    }
}
