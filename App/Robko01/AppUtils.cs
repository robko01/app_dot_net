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

namespace Robko01
{
    /// <summary>
    /// Application util methods.
    /// </summary>
    public static class AppUtils
    {

        /// <summary>
        /// Create program name.
        /// </summary>
        /// <returns></returns>
        public static string CreateProgramName()
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "yyMMddHHmmss";   // Use this format.
            return "Robko01_" + time.ToString(format);
        }

        /// <summary>
        /// Validate delay value.
        /// </summary>
        /// <param name="value">Delay value.</param>
        /// <returns>Validated delay value.</returns>
        public static int ValidateDelay(string value)
        {
            int delay = 0;
            bool valid = Int32.TryParse(value, out delay);

            if (!valid)
            {
                delay = 0;
            }

            if (delay < 0)
            {
                delay = 0;
            }

            return delay;
        }

        /// <summary>
        /// Validate steps.
        /// </summary>
        /// <param name="value">Steps value.</param>
        /// <returns>Valid steps value.</returns>
        public static int ValidateSteps(string value)
        {
            int steps = 0;
            bool valid = int.TryParse(value, out steps);

            if (!valid)
            {
                steps = 0;
            }

            return steps;
        }

    }
}
