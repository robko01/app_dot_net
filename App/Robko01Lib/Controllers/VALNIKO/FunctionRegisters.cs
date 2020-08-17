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

namespace Robko01Lib.Controllers.VALNIKO
{
    /// <summary>
    /// Register description
    /// </summary>
    enum FunctionRegisters : byte
    {
        /// <summary>
        /// Shut down all the joints.
        /// </summary>
        ShutdownAll = 0,

        /// <summary>
        /// Run joint until its stops.
        /// </summary>
        RunJoint = 1,
        
        /// <summary>
        /// Read inputs.
        /// </summary>
        ReadInpust = 2,

        /// <summary>
        /// Write to outputs.
        /// </summary>
        WriteOutputs = 4,

        /// <summary>
        /// Read outputs
        /// </summary>
        ReadOutpusts = 5,
        
        /// <summary>
        /// Move joints to coordinate.
        /// </summary>
        MoveJoint = 6,

        /// <summary>
        /// Reset all joints.
        /// </summary>
        HomeJoints = 7,

        /// <summary>
        /// Read joint state.
        /// </summary>
        ReadJoint = 8,

        /// <summary>
        /// Controls all the joints.
        /// </summary>
        MultipleJoint = 9,

        /// <summary>
        /// Load set point for one single joint.
        /// </summary>
        LoadJointSetpoint = 10,

        /// <summary>
        /// Run the joints to the set point.
        /// </summary>
        RunToSetpoint = 11
    }
}
