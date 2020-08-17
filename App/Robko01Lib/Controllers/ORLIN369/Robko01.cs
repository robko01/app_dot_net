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

using Robko01Lib.Adapters;
using Robko01Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robko01Lib.Controllers.ORLIN369
{
    public class Robko01 : RobotDevice
    {
        #region Constants

        private const string TERMIN = "\n";

        private const byte SENTINEL = 0xAA;

        #endregion

        #region Variables

        /// <summary>
        /// Delimiting characters.
        /// </summary>
        private char[] delimiterChars = { '\n' };

        private int[] steps = new int[6];

        private Adapter adapter;

        #endregion

        #region Constructor / Destructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="portName">Communication port.</param>
        public Robko01(Adapter adapter)
        {
            this.adapter = adapter;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Robko01()
        {
        }

        #endregion

        private string SendRequest()
        {
            List<byte> cammand = new List<byte>();

            //string command = String.Format("{0}{1}{2}{3:D1}{4:D4}{5:D4}",
            //SENTINEL,
            //(byte)FrameType.Request,
            //(byte)FunctionCodes.Enable, 0, 0, 0, 0);
            //this.adapter.SendRequest(command);
            return "";
        }

        #region Public Overrider Methods

        /// <summary>
        /// Enables the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Enable(JointName joint)
        {
        }

        /// <summary>
        /// Disable the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Disable(JointName joint)
        {

        }

        /// <summary>
        /// Start the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Start(JointName joint)
        {

        }

        /// <summary>
        /// Stop the motor.
        /// </summary>
        /// <param name="joint">Index of the motor.</param>
        public override void Stop(JointName joint)
        {

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
                string command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)JointName.Elbow, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)JointName.Gripper, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Pitch)
            {
                string direction = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)JointName.LD, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)JointName.RD, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else if (joint == JointName.Roll)
            {
                string ldDir = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string rdDir = (steps < 0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)JointName.LD, ldDir, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
                Thread.Sleep(50);
                command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)JointName.RD, rdDir, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }
            else
            {
                string direction = (steps >= 0) ? JointDirection.CW : JointDirection.CCW;
                string command = String.Format("?M{0}{1}{2:D4}:{3:D4}", (int)joint, direction, absSteps, delay) + TERMIN;
                this.adapter.SendRequest(command);
            }

            this.Busy(Math.Abs(absSteps * delay * 2.5f));
        }

        #endregion
    }
}
