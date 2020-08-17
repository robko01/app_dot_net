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

using System.Xml.Serialization;
using System.IO;

namespace Robko01Lib.Data
{
    /// <summary>
    /// Serialize command lists and store it to the files.
    /// </summary>
    public static class CommandsStore
    {

        #region Public Methods

        /// <summary>
        /// Save commands to XML.
        /// </summary>
        /// <remarks>
        /// @"C:\Temp\SerializationOverview.xml"
        /// </remarks>
        /// <param name="commands">Commands</param>
        /// <param name="path">File</param>
        public static void Save(MotionCommands commands, string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(MotionCommands));
            using (StreamWriter file = new System.IO.StreamWriter(path))
            {
                writer.Serialize(file, commands);
            }
        }

        /// <summary>
        /// Read commands from XML.
        /// </summary>
        /// <remarks>@"C:\Temp\SerializationOverview.xml"</remarks>
        /// <param name="path">File</param>
        /// <returns>Commands</returns>
        public static MotionCommands Load(string path)
        {
            MotionCommands commands = new MotionCommands();

            XmlSerializer reader = new XmlSerializer(typeof(MotionCommands));
            using (StreamReader file = new StreamReader(path))
            {
                commands = (MotionCommands)reader.Deserialize(file);
            }
            
            return commands;
        }

        #endregion

    }
}
