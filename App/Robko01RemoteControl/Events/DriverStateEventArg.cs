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
    public class DriverStateEventArg : EventArgs
    {

        #region Properties

        public ushort Base { get; set; }

        public ushort Shoulder { get; set; }

        public ushort Elbow { get; set; }

        public ushort Pitch { get; set; }

        public ushort Roll { get; set; }

        public ushort Gripper { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return String.Format("Base:{0}; Shoulder: {1}; Elbow: {2}; Pitch: {3}; Roll: {4}; Gripper: {5}",
                this.Base,
                this.Shoulder,
                this.Elbow,
                this.Pitch,
                this.Roll,
                this.Gripper);
        }

        #endregion

    }
}
