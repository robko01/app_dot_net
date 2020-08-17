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

using Robko01Lib.Data;
using Robko01Lib.Adapters;

namespace Robko01Lib.Controllers.VALNIKO
{
    /// <summary>
    /// Robko01 controller.
    /// </summary>
    public class Robko01 : RobotDevice
    {

        #region Constants

        private const string TERMIN = "\r\n";

        private const int DEFAULT_ROBOT_ADDRESS = 1;

        private const string OK_CMD = "ОК\r\n";

        #endregion

        #region Variables

        /// <summary>
        /// Delimiting characters.
        /// </summary>
        private char[] delimiterChars = { '\n' };

        /// <summary>
        /// 
        /// </summary>
        private int[] steps = new int[6];

        /// <summary>
        /// Robot controller address.
        /// </summary>
        private int controllerAddress;

        private int[] delays = new int[6];

        private Adapter adapter;

        #endregion

        #region Constructor / Destructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="port">Communication port.</param>
        public Robko01(Adapter adapter)
        {
            this.adapter = adapter;
            // Save the controller address.
            this.controllerAddress = DEFAULT_ROBOT_ADDRESS;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Robko01()
        {
        }

        #endregion

        #region Public Overrider Methods

        /// <summary>
        /// Shutdown all the motors.
        /// </summary>
        public override void Disable(JointName joint)
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                this.controllerAddress, (byte)FunctionRegisters.ShutdownAll, 0, 0, 0, 0);
            this.adapter.SendRequest(command);
        }

        /// <summary>
        /// Read inputs on port A.
        /// </summary>
        public override void ReadInputs()
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                this.controllerAddress, (byte)FunctionRegisters.ReadInpust, 0, 0, 0, 0);
            this.adapter.SendRequest(command);
        }

        public override void WriteOutputs(int value)
        {
            int b0 = ((value & 0x01) != 0) ? 1 : 0;
            int b1 = ((value & 0x02) != 0) ? 1 : 0;
            int b2 = ((value & 0x04) != 0) ? 1 : 0;
            int b3 = ((value & 0x08) != 0) ? 1 : 0;
            int b4 = ((value & 0x10) != 0) ? 1 : 0;
            int b5 = ((value & 0x20) != 0) ? 1 : 0;
            int b6 = ((value & 0x40) != 0) ? 1 : 0;
            int b7 = ((value & 0x80) != 0) ? 1 : 0;

            string command = String.Format(":{0:D2}{1:D2}00{2:D1}{3:D1}{4:D1}{5:D1}{6:D1}{7:D1}{8:D1}{9:D1}",
                this.controllerAddress, (byte)FunctionRegisters.WriteOutputs, b0, b1, b2, b3, b4, b5, b6, b7);

            this.adapter.SendRequest(command);
        }

        /// <summary>
        /// Read the output state of port A.
        /// </summary>
        public override void ReadOutputs()
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                this.controllerAddress, (byte)FunctionRegisters.ReadOutpusts, 0, 0, 0, 0);
            this.adapter.SendRequest(command);
        }

        public override void SetJoint(JointName joint, int delay, int steps)
        {
            if ((int)joint <= 5 && joint >= 0)
            {
                JointDirection direction = (steps > 0) ? JointDirection.CW : JointDirection.CCW;
                steps = Math.Abs(steps);

                string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D1}{6:D3}",
                    this.controllerAddress, (byte)FunctionRegisters.MoveJoint, joint, (int)direction, steps, (int)StepMode.FullStep, delay);

                this.adapter.SendRequest(command);
            }
        }

        public override void GetJoint(JointName joint)
        {
            this.ReadJoint((int)joint);
        }

        public override void Delay(JointName joint, int delay)
        {
            this.delays[(int)joint] = delay;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="joint">Index of the joint.</param>
        /// <param name="direction">Direction of the motor.</param>
        /// <param name="stepMode">Stepper motor direction.</param>
        /// <param name="delay">Delay between the steps.</param>
        public void RunJoint(int joint, JointDirection direction, StepMode stepMode, int delay = 10)
        {
            if (joint <= 5 && joint >= 0)
            {
                string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                    this.controllerAddress, (byte)FunctionRegisters.RunJoint, joint, (int)direction, stepMode, delay);
                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Home all the joints.
        /// </summary>
        public void HomeJoints(int configurationIndex = 0)
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}{6:D4}",
                this.controllerAddress, (byte)FunctionRegisters.HomeJoints, 0, 0, 0, 0, configurationIndex);
            this.adapter.SendRequest(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="joint">Index of the joint.</param>
        public void ReadJoint(int joint, int sign = 0)
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                this.controllerAddress, (byte)FunctionRegisters.ReadJoint, joint, 0, 0, 0);
            this.adapter.SendRequest(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stepMode">Stepper step mode.</param>
        /// <param name="action">Joints state.</param>
        /// <param name="delay">Delay between the steps.</param>
        public void MultipleJoint(StepMode stepMode, int action, int delay)
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                this.controllerAddress, (byte)FunctionRegisters.MultipleJoint, stepMode, 0, action, delay);
            this.adapter.SendRequest(command);
        }

        /// <summary>
        /// Load joint set point.
        /// </summary>
        /// <param name="joint">Index of the joint.</param>
        /// <param name="steps">Steps to do.</param>
        public void LoadJointSetpoint(int joint, int steps)
        {
            if (joint <= 5 && joint >= 0)
            {
                JointDirection direction = (steps > 0) ? JointDirection.CW : JointDirection.CCW;
                steps = Math.Abs(steps);

                string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                    this.controllerAddress, (byte)FunctionRegisters.LoadJointSetpoint, joint, direction, steps, 0);

                this.adapter.SendRequest(command);
            }
        }

        /// <summary>
        /// Run to the set point.
        /// </summary>
        public void RunToSetpoint()
        {
            string command = String.Format(":{0:D2}{1:D2}{2:D1}{3:D1}{4:D4}{5:D4}",
                this.controllerAddress, (byte)FunctionRegisters.RunToSetpoint, 0, 0, 0, 0);
            this.adapter.SendRequest(command);
        }

        /// <summary>
        /// Converts bit signals to a integer that will be send to the controller.
        /// </summary>
        /// <param name="states"></param>
        /// <returns></returns>
        public static int JointAction(bool[] states)
        {
            int result = 0;

            for (int index = 0; index < states.Length; index++)
            {
                int weight = (states[index]) ? (int)Math.Pow(2, states.Length - index - 1) : 0;
                result += weight;
            }

            return result;
        }

        #endregion

    }
}
