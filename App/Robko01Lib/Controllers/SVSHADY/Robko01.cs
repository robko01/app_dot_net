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
using System;
using System.Threading;

namespace Robko01Lib.Controllers.SVSHADY
{
    public class Robko01 : RobotDevice
    {

        #region Variables

        /// <summary>
        /// Communication adapter.
        /// </summary>
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

        #region Private Methods

        private void DriveMotor(byte motor, int steps)
        {
            byte[] buf = { 0xAA, 0x07, (byte)0x03, motor, (byte)((0xFF00 & steps) >> 8), (byte)(0xFF & steps), 0x55 };
            string command = System.Text.Encoding.Default.GetString(buf);
            this.adapter.SendRequest(command);

            if (motor == 3)
            {
                Thread.CurrentThread.Join(20);
                buf[3] = 0x06;
                buf[4] = (byte)((0xFF00 & -steps) >> 8);
                buf[5] = (byte)(0xFF & -steps);
                command = System.Text.Encoding.Default.GetString(buf);
                this.adapter.SendRequest(command);
            }
        }

        #endregion

        // TODO: Implement the virtual methods.

    }
}
