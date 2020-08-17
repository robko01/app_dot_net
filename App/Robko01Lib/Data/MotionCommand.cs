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

namespace Robko01Lib.Data
{
    [Serializable]
    public class MotionCommand : EventArgs
    {

        #region Variables

        /// <summary>
        /// Axis index.
        /// </summary>
        public JointName Axis;

        /// <summary>
        /// Delay
        /// </summary>
        /// <remarks>
        /// TODO: Change from delay to RPM
        /// </remarks>
        public int Delay = 0;

        /// <summary>
        /// Steps
        /// </summary>
        public int Steps = 0;

        #endregion

        #region Constructor

        public MotionCommand()
        {

        }

        public MotionCommand(JointName axis, int delay, int steps)
        {
            this.Axis = axis;
            this.Delay = delay;
            this.Steps = steps;
        }

        #endregion

        #region Public

        /// <summary>
        /// Calculate motion time.
        /// </summary>
        /// <returns>Consumed motion time.</returns>
        public float WaitTime()
        {
            return Math.Abs(((float)this.Steps * ((float)Delay * 2.5f)));
        }

        /// <summary>
        /// Generate string description.
        /// </summary>
        /// <returns>Text</returns>
        public override string ToString()
        {
            string direction = "";

            if (this.Steps > 0)
            {
                direction = "CW";
            }
            else
            {
                direction = "CCW";
            }

            return String.Format("Axis: {0}; Steps: {1}{2}; Delay: {3}", ((JointName)this.Axis).ToString(), direction, Math.Abs(this.Steps), this.Delay);
        }

        #endregion

    }
}
