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

namespace Robko01RemoteControl.Events
{
    [Serializable]
    public class MotionCommandEventArg : EventArgs
    {

        #region Properties

        public ushort BaseSteps { get; set; }

        public ushort ShoulderSteps { get; set; }

        public ushort ElbowSteps { get; set; }

        public ushort PichSteps { get; set; }

        public ushort RollSteps { get; set; }

        public ushort GripperSteps { get; set; }

        public ushort BaseDelay { get; set; }

        public ushort ShoulderDelay { get; set; }

        public ushort ElbowDelay { get; set; }

        public ushort PichDelay { get; set; }

        public ushort RollDelay { get; set; }

        public ushort GripperDelay { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MotionCommandEventArg()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}", 
                this.BaseSteps,
                this.ShoulderSteps,
                this.ElbowSteps,
                this.PichSteps,
                this.RollSteps,
                this.GripperSteps,
                this.BaseDelay,
                this.ShoulderDelay,
                this.ElbowDelay,
                this.PichDelay,
                this.RollDelay,
                this.GripperDelay);
        }

        #endregion

    }
}
