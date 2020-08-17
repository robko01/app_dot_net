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

namespace Robko01Lib.Controllers.TUGAB
{
    /// <summary>
    /// Describe the state of the joint.
    /// </summary>
    public class JointState
    {
        
        #region Variables

        /// <summary>
        /// Delimiting characters.
        /// </summary>
        private static char[] delimiterChars = { '\n' };

        #endregion

        #region Properties

        public int Drive { get; private set; }

        public bool Enabled { get; private set; }
        
        public bool MotorFlag { get; private set; }
        
        public string Direction { get; private set; }
        
        public int StepTime { get; private set; }

        public int StepsNumber { get; private set; }
        
        public int Step { get; private set; }

        public int Timeout { get; private set; }
        
        public bool Current { get; private set; }

        #endregion

        #region Constructor

        public JointState()
        {

        }

        public JointState(int drive, bool enable, bool motorFlag, string direction, int stepTime, int stepNumber, int step, int timeout, bool current)
        {
            this.Drive = drive;
            this.Enabled = enable;
            this.Direction = direction;
            this.MotorFlag = motorFlag;
            this.StepTime = stepTime;
            this.StepsNumber = stepNumber;
            this.Step = step;
            this.Timeout = timeout;
            this.Current = current;
        }

        #endregion

        #region Public Static

        /// <summary>
        /// Translate from string to command.
        /// </summary>
        /// <param name="command">Command from the robot.</param>
        /// <returns>Joint state.</returns>
        public static JointState CreateState(string command)
        {
            JointState state = new JointState();

            string[] tokens = command.Split(JointState.delimiterChars);

            int tokenIndex = 1;

            int drive = -1;
            bool enable = false;
            bool motorFlag = false;
            string direction = JointDirection.CW;
            int stepTime = 0;
            int stepNumber = 0;
            int timeout = 0;
            int currentStep = 0;

            foreach (string token in tokens)
            {
                string tmpToken = token.Replace("\r", "");

                #region Drive

                bool cDrive = tmpToken.Contains(ResponseKeys.Drive);
                if (cDrive)
                {
                    string strDrive = tmpToken.Replace(ResponseKeys.Drive, "").Trim();
                    drive = int.Parse(strDrive);
                }


                #endregion

                #region Enabled

                bool cEnableMotor = tmpToken.Contains(ResponseKeys.EnableMotor);
                bool cDisableMotor = tmpToken.Contains(ResponseKeys.DisableMotor);

                if (cDisableMotor)
                {
                    enable = false;
                }
                if (cEnableMotor)
                {
                    enable = true;
                }

                #endregion

                #region MotorFlag

                bool cMotorFlag = tmpToken.Contains(ResponseKeys.MotorFlag);
                if (cMotorFlag)
                {
                    string flag = tmpToken.Replace(ResponseKeys.MotorFlag, "").Trim();
                    if (flag == "1")
                    {
                        motorFlag = true;
                    }
                    if (flag == "0")
                    {
                        motorFlag = false;
                    }
                }
                #endregion

                #region Direction

                bool cDirection = tmpToken.Contains(ResponseKeys.Direction);
                if (cDirection)
                {
                    string dir = tmpToken.Replace(ResponseKeys.Direction, "").Trim();
                    if (dir == "1")
                    {
                        direction = JointDirection.CW;
                    }
                    if (dir == "0")
                    {
                        direction = JointDirection.CCW;
                    }
                }
                #endregion

                #region Step Time

                bool cStepTime = tmpToken.Contains(ResponseKeys.StepTime);
                if (cStepTime)
                {
                    string time = tmpToken.Replace(ResponseKeys.StepTime, "").Trim();
                    stepTime = int.Parse(time);
                }

                #endregion

                #region Step Number

                bool cStepsNumber = tmpToken.Contains(ResponseKeys.StepsNumber);
                if (cStepsNumber)
                {
                    string num = tmpToken.Replace(ResponseKeys.StepsNumber, "").Trim();
                    stepNumber = int.Parse(num);
                }

                #endregion

                #region Timeout

                bool cTimeout = tmpToken.Contains(ResponseKeys.CurrentTimeout);
                if (cTimeout)
                {
                    string num = tmpToken.Replace(ResponseKeys.CurrentTimeout, "").Trim();
                    timeout = int.Parse(num);
                }

                #endregion

                #region Current Step

                bool cCurrentStep = tmpToken.Contains(ResponseKeys.CurrentStep);
                if (cCurrentStep)
                {
                    string num = tmpToken.Replace(ResponseKeys.CurrentStep, "").Trim();
                    currentStep = int.Parse(num);
                }

                #endregion

                tokenIndex++;
            }

            state = new JointState(drive, enable, motorFlag, direction, stepTime, stepNumber, currentStep, timeout, enable);

            return state;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// To String.
        /// </summary>
        /// <returns>Discretion of the joint.</returns>
        public override string ToString()
        {
            return String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", this.Drive, this.Enabled, this.Current, this.Direction, this.MotorFlag, this.Timeout, this.StepTime, this.StepsNumber);
        }

        #endregion

    }
}
