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
using System.Linq;

namespace Robko01RemoteControl.Data
{
    [Serializable]
    public class MotionMemory
    {

        #region Variables

        /// <summary>
        /// Base address of the structure.
        /// </summary>
        private ushort baseAddress;

        #endregion

        #region Properties

        public int BaseAddress
        {
            get
            {
                return this.baseAddress;
            }
        }

        public int SizeOfStruct
        {
            get
            {
                return (int)Enum.GetValues(typeof(MotionMemoryAddresses)).Cast<MotionMemoryAddresses>().Last() + 1;
            }
        }

        public int BaseSteps
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.BaseSteps; 
            }
        }

        public int ShoulderSteps
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.ShoulderSteps;
            }
        }

        public int ElbowSteps
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.ElbowSteps;
            }
        }

        public int PichSteps
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.PichSteps;
            }
        }

        public int RollSteps
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.RollSteps;
            }
        }

        public int GripperSteps
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.GripperSteps;
            }
        }

        public int BaseDelay
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.BASEDelay;
            }
        }

        public int ShoulderDelay
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.SHOULDERDelay;
            }
        }

        public int ElbowDelay
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.ELBOWDelay;
            }
        }

        public int PichDelay
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.PichDelay;
            }
        }

        public int RollDelay
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.RollDelay;
            }
        }
        
        public int GripperDelay
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.GripperDelay;
            }
        }

        public int BaseState
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.BaseState;
            }
        }

        public int ShoulderState
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.ShoulderState;
            }
        }

        public int ElbowState
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.ElbowState;
            }
        }

        public int PichState
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.PichState;
            }
        }

        public int RollState
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.RollState;
            }
        }

        public int GripperState
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.GripperState;
            }
        }

        public int Mode
        {
            get
            {
                return this.baseAddress + (ushort)MotionMemoryAddresses.Mode;
            }
        }

        #endregion

        #region Constructor

        public MotionMemory(ushort baseAddress)
        {
            this.baseAddress = baseAddress;
        }

        #endregion

    }
}
