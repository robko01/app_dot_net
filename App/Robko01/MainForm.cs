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
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Drawing;
using System.Diagnostics;
using System.IO.Ports;

using Robko01Lib;
using Robko01Lib.Data;
using Robko01Lib.Events;
using Robko01Lib.Controllers;
using Robko01Lib.Controllers.TUGAB;
using Robko01Lib.Adapters;
using Robko01.Settings;

//TODO: Delay of the motors must be done with track bars.
//TODO: Enable/Disable function of the motors must be done with check box.

namespace Robko01
{
    /// <summary>
    /// Main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Variables

        /// <summary>
        /// Serial port name.
        /// </summary>
        private string robotSerialPortName = String.Empty;

        /// <summary>
        /// Controller type.
        /// </summary>
        private ControllerTypes controllerType = ControllerTypes.None;

        /// <summary>
        /// Robot.
        /// </summary>
        private RobotDevice robot;

        /// <summary>
        /// Program name.
        /// </summary>
        private string programName = String.Empty;

        /// <summary>
        /// Program controller.
        /// </summary>
        private ProgramController programControl = new ProgramController();

        /// <summary>
        /// Kinematics model of the robot.
        /// </summary>
        private Kinematics kinematics = new Kinematics();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private

        private void SearchForPorts()
        {
            this.portsToolStripMenuItem.DropDown.Items.Clear();

            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string port in portNames)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Click += this.mItPorts_Click;
                item.Enabled = true;
                item.Checked = false;
                //item.Checked = false;
                item.Text = port.ToString();
                item.Name = port.ToString();
                item.Tag = port;

                if (this.robotSerialPortName == port)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }

                //store the each retrieved available port names into the MenuItems...
                this.portsToolStripMenuItem.DropDown.Items.Add(item);
            }
        }

        private void FillAxisCombo()
        {
            this.cmbAxis.Items.Clear();
            Array listOfValues = Enum.GetValues(typeof(JointName));
            this.cmbAxis.DataSource = listOfValues;
            if (listOfValues.Length > 0)
            {
                this.cmbAxis.Text = this.cmbAxis.Items[0].ToString();
            }
        }

        private void FillControllerTypes()
        {
            this.boardTypeToolStripMenuItem.DropDown.Items.Clear();

            Array types = Enum.GetValues(typeof(ControllerTypes));

            if (types.Length == 0)
            {
                return;
            }

            foreach (ControllerTypes type in types)
            {
                if (type == ControllerTypes.None)
                {
                    continue;
                }

                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Click += this.mItBoards_Click;
                item.Enabled = true;
                //item.Checked = false;
                item.Text = type.ToString();
                item.Name = type.ToString();
                item.Tag = type;

                if (this.controllerType == type)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }

                //store the each retrieved available port names into the MenuItems...
                this.boardTypeToolStripMenuItem.DropDown.Items.Add(item);
            }
        }


        private void SaveProgram()
        {
            // Create an instance of the open file dialog box.
            SaveFileDialog fileDialog = new SaveFileDialog();

            // Set filter options and filter index.
            fileDialog.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;

            if (this.programName == "")
            {
                this.programName = AppUtils.CreateProgramName();
            }

            fileDialog.FileName = this.programName;
            //fileDialog.Multiselect = false;

            // Show the dialog and get result.
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK && this.programControl.Commands.Count > 0) // Test result.
            {
                string path = fileDialog.FileName;
                CommandsStore.Save(this.programControl.Commands, path);
            }
        }

        private void LoadProgram()
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog fileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            fileDialog.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = false;

            // Show the dialog and get result.
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string path = fileDialog.FileName;
                MotionCommands commands = CommandsStore.Load(path);

                if (commands != null && commands.Count > 0)
                {

                    this.programControl.Commands = commands;

                    this.lstCommands.Items.Clear();
                    MotionCommand[] test = new MotionCommand[this.programControl.Commands.Count];
                    this.programControl.Commands.CopyTo(test, 0);
                    this.lstCommands.Items.AddRange(test);
                }

                this.programName = Path.GetFileNameWithoutExtension(path);

                this.lblProgramName.Text = String.Format("Program: {0}", this.programName);
            }
        }

        private void RunProgram()
        {
            if (!this.programControl.IsRuning)
            {
                this.robot.Enable(JointName.All);
                Thread.Sleep(1000);
                this.programControl.RunProgram();
            }
        }

        private void StopProgram()
        {
            if (this.programControl.IsRuning)
            {
                this.programControl.StopProgram();

                this.robot.Stop(JointName.All);
                Thread.Sleep(50);
                this.robot.Disable(JointName.All);
            }
        }

        private void ResumeProgram()
        {
            if (!this.programControl.IsRuning)
            {
                this.robot.Enable(JointName.All);
                this.programControl.ResumeProgram();
            }
        }


        private void LockCommandParameters()
        {
            if (this.cmbAxis.InvokeRequired)
            {
                this.cmbAxis.BeginInvoke((MethodInvoker)delegate()
                {
                    this.cmbAxis.Enabled = false;
                });
            }
            else
            {
                this.cmbAxis.Enabled = false;
            }

            if (this.tbSteps.InvokeRequired)
            {
                this.tbSteps.BeginInvoke((MethodInvoker)delegate()
                {
                    this.tbSteps.Enabled = false;
                });
            }
            else
            {
                this.tbSteps.Enabled = false;
            }

            if (this.tbDelay.InvokeRequired)
            {
                this.tbDelay.BeginInvoke((MethodInvoker)delegate()
                {
                    this.tbDelay.Enabled = false;
                });
            }
            else
            {
                this.tbDelay.Enabled = false;
            }

            if (this.btnAddCommand.InvokeRequired)
            {
                this.btnAddCommand.BeginInvoke((MethodInvoker)delegate()
                {
                    this.btnAddCommand.Enabled = false;
                });
            }
            else
            {
                this.btnAddCommand.Enabled = false;
            }

            if (this.btnClearCommands.InvokeRequired)
            {
                this.btnClearCommands.BeginInvoke((MethodInvoker)delegate()
                {
                    this.btnClearCommands.Enabled = false;
                });
            }
            else
            {
                this.btnClearCommands.Enabled = false;
            }
        }

        private void UnlockCommandParameters()
        {
            if (this.cmbAxis.InvokeRequired)
            {
                this.cmbAxis.BeginInvoke((MethodInvoker)delegate()
                {
                    this.cmbAxis.Enabled = true;
                });
            }
            else
            {
                this.cmbAxis.Enabled = true;
            }

            if (this.tbSteps.InvokeRequired)
            {
                this.tbSteps.BeginInvoke((MethodInvoker)delegate()
                {
                    this.tbSteps.Enabled = true;
                });
            }
            else
            {
                this.tbSteps.Enabled = true;
            }

            if (this.tbDelay.InvokeRequired)
            {
                this.tbDelay.BeginInvoke((MethodInvoker)delegate()
                {
                    this.tbDelay.Enabled = true;
                });
            }
            else
            {
                this.tbDelay.Enabled = true;
            }

            if (this.btnAddCommand.InvokeRequired)
            {
                this.btnAddCommand.BeginInvoke((MethodInvoker)delegate()
                {
                    this.btnAddCommand.Enabled = true;
                });
            }
            else
            {
                this.btnAddCommand.Enabled = true;
            }

            if (this.btnClearCommands.InvokeRequired)
            {
                this.btnClearCommands.BeginInvoke((MethodInvoker)delegate()
                {
                    this.btnClearCommands.Enabled = true;
                });
            }
            else
            {
                this.btnClearCommands.Enabled = true;
            }
        }

        private void SetMotionState(bool state)
        {
            //if (this.lblMotionState.InvokeRequired)
            //{
            //    this.lblMotionState.BeginInvoke((MethodInvoker)delegate()
            //    {
            //        if (state)
            //        {
            //            this.lblMotionState.Text = "Motion State: True";
            //            this.lblMotionState.BackColor = Color.Green;
            //        }
            //        else
            //        {
            //            this.lblMotionState.Text = "Motion State: False";
            //            this.lblMotionState.BackColor = Color.Red;
            //        }
            //    });
            //}
            //else
            {
                if (state)
                {
                    this.lblMotionState.Text = "Motion State: True";
                    //this.lblMotionState.BackColor = Color.Green;
                }
                else
                {
                    this.lblMotionState.Text = "Motion State: False";
                    //this.lblMotionState.BackColor = Color.Red;
                }
            }

        }

        private void SetProgramState(bool state)
        {
            //if (this.lblProgState.InvokeRequired)
            //{
            //    this.lblProgState.BeginInvoke((MethodInvoker)delegate()
            //    {
            //        if (state)
            //        {
            //            this.lblProgState.Text = "Program State: True";
            //            this.lblProgState.BackColor = Color.Green;
            //        }
            //        else
            //        {
            //            this.lblProgState.Text = "Program State: False";
            //            this.lblProgState.BackColor = Color.Red;
            //        }
            //    });
            //}
            //else
            {
                if (state)
                {
                    this.lblProgState.Text = "Program State: True";
                    //this.lblProgState.BackColor = Color.Green;
                }
                else
                {
                    this.lblProgState.Text = "Program State: False";
                    //this.lblProgState.BackColor = Color.Red;
                }
            }
        }

        private void SetBaseStatus(JointState state)
        {
            string textDirection = "";
            if (state.Direction == JointDirection.CW)
            {
                textDirection = "CW";
            }
            else if (state.Direction == JointDirection.CCW)
            {
                textDirection = "CCW";
            }

            // Make message.
            string message = String.Format("Enabled: {1}{0}Flag: {2}{0}Direction: {3}{0}Step Time: {4}{0}Step Number: {5}{0}Step: {6}{0}Timeout: {7}",
                Environment.NewLine,
                state.Enabled,
                state.MotorFlag,
                textDirection,
                state.StepTime,
                state.StepsNumber,
                state.Step,
                state.Timeout);

            if (this.lblBaseStatus.InvokeRequired)
            {
                this.lblBaseStatus.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblBaseStatus.Text = message;
                });
            }
            else
            {
                this.lblBaseStatus.Text = message;
            }
        }

        private void SetShoulderStatus(JointState state)
        {
            string textDirection = "";
            if (state.Direction == JointDirection.CW)
            {
                textDirection = "CW";
            }
            else if (state.Direction == JointDirection.CCW)
            {
                textDirection = "CCW";
            }

            // Make message.
            string message = String.Format("Enabled: {1}{0}Flag: {2}{0}Direction: {3}{0}Step Time: {4}{0}Step Number: {5}{0}Step: {6}{0}Timeout: {7}",
                Environment.NewLine,
                state.Enabled,
                state.MotorFlag,
                textDirection,
                state.StepTime,
                state.StepsNumber,
                state.Step,
                state.Timeout);

            if (this.lblShoulderStatus.InvokeRequired)
            {
                this.lblShoulderStatus.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblShoulderStatus.Text = message;
                });
            }
            else
            {
                this.lblShoulderStatus.Text = message;
            }
        }

        private void SetElbowStatus(JointState state)
        {
            string textDirection = "";
            if (state.Direction == JointDirection.CW)
            {
                textDirection = "CW";
            }
            else if (state.Direction == JointDirection.CCW)
            {
                textDirection = "CCW";
            }

            // Make message.
            string message = String.Format("Enabled: {1}{0}Flag: {2}{0}Direction: {3}{0}Step Time: {4}{0}Step Number: {5}{0}Step: {6}{0}Timeout: {7}",
                Environment.NewLine,
                state.Enabled,
                state.MotorFlag,
                textDirection,
                state.StepTime,
                state.StepsNumber,
                state.Step,
                state.Timeout);

            if (this.lblElbowStatus.InvokeRequired)
            {
                this.lblElbowStatus.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblElbowStatus.Text = message;
                });
            }
            else
            {
                this.lblElbowStatus.Text = message;
            }
        }

        private void SetLDStatus(JointState state)
        {
            string textDirection = "";
            if (state.Direction == JointDirection.CW)
            {
                textDirection = "CW";
            }
            else if (state.Direction == JointDirection.CCW)
            {
                textDirection = "CCW";
            }

            // Make message.
            string message = String.Format("Enabled: {1}{0}Flag: {2}{0}Direction: {3}{0}Step Time: {4}{0}Step Number: {5}{0}Step: {6}{0}Timeout: {7}",
                Environment.NewLine,
                state.Enabled,
                state.MotorFlag,
                textDirection,
                state.StepTime,
                state.StepsNumber,
                state.Step,
                state.Timeout);

            if (this.lblLeftDifferentStatus.InvokeRequired)
            {
                this.lblLeftDifferentStatus.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblLeftDifferentStatus.Text = message;
                });
            }
            else
            {
                this.lblLeftDifferentStatus.Text = message;
            }
        }

        private void SetRDStatus(JointState state)
        {
            string textDirection = "";
            if (state.Direction == JointDirection.CW)
            {
                textDirection = "CW";
            }
            else if (state.Direction == JointDirection.CCW)
            {
                textDirection = "CCW";
            }

            // Make message.
            string message = String.Format("Enabled: {1}{0}Flag: {2}{0}Direction: {3}{0}Step Time: {4}{0}Step Number: {5}{0}Step: {6}{0}Timeout: {7}",
                Environment.NewLine,
                state.Enabled,
                state.MotorFlag,
                textDirection,
                state.StepTime,
                state.StepsNumber,
                state.Step,
                state.Timeout);

            if (this.lblRightStatus.InvokeRequired)
            {
                this.lblRightStatus.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblRightStatus.Text = message;
                });
            }
            else
            {
                this.lblRightStatus.Text = message;
            }
        }

        private void SetGripperStatus(JointState state)
        {
            string textDirection = "";
            if (state.Direction == JointDirection.CW)
            {
                textDirection = "CW";
            }
            else if (state.Direction == JointDirection.CCW)
            {
                textDirection = "CCW";
            }

            // Make message.
            string message = String.Format("Enabled: {1}{0}Flag: {2}{0}Direction: {3}{0}Step Time: {4}{0}Step Number: {5}{0}Step: {6}{0}Timeout: {7}",
                Environment.NewLine,
                state.Enabled,
                state.MotorFlag,
                textDirection,
                state.StepTime,
                state.StepsNumber,
                state.Step,
                state.Timeout);

            if (this.lblGripperStatus.InvokeRequired)
            {
                this.lblGripperStatus.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lblGripperStatus.Text = message;
                });
            }
            else
            {
                this.lblGripperStatus.Text = message;
            }
        }


        private void AddLogRow(string message)
        {
            if (this.lstLog.InvokeRequired)
            {
                this.lstLog.BeginInvoke((MethodInvoker)delegate()
                {
                    this.lstLog.Items.Add(message);
                });
            }
            else
            {
                this.lstLog.Items.Add(message);
            }
        }


        private void CommandParser(string command)
        {
            // From response create state.
            JointState status = JointState.CreateState(command);

            // Show it on the screen.
            JointName drive = (JointName)status.Drive;

            switch (drive)
            {
                case JointName.Base:
                    this.SetBaseStatus(status);
                    break;

                case JointName.Shoulder:
                    this.SetShoulderStatus(status);
                    break;

                case JointName.Elbow:
                    this.SetElbowStatus(status);
                    break;

                case JointName.LD:
                    this.SetLDStatus(status);
                    break;

                case JointName.RD:
                    this.SetRDStatus(status);
                    break;

                case JointName.Gripper:
                    this.SetGripperStatus(status);
                    break;
            }
        }

        private void ConnectToRobotViaSerial(string portName)
        {
            try
            {
                if (controllerType == ControllerTypes.None)
                {
                    return;
                }

                this.programControl.OnFinish += this.programControl_OnFinish;
                this.programControl.OnRuning += this.programControl_OnRuning;
                this.programControl.OnExecutionIndexCanged += this.programControl_OnExecutionIndexChanged;

                SerialPort serialPort = new SerialPort(portName);
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                
                if (this.controllerType == ControllerTypes.TUGAB)
                {
                    this.robot = new Robko01Lib.Controllers.TUGAB.Robko01(new SerialAdapter(serialPort));
                }
                else if (this.controllerType == ControllerTypes.VALNIKO)
                {
                    this.robot = new Robko01Lib.Controllers.VALNIKO.Robko01(new SerialAdapter(serialPort));
                }
                else if (this.controllerType == ControllerTypes.SVSHADY)
                {
                    this.robot = new Robko01Lib.Controllers.SVSHADY.Robko01(new SerialAdapter(serialPort));
                }
                else if (this.controllerType == ControllerTypes.ORLIN369)
                {
                    serialPort.BaudRate = 115200;
                    this.robot = new Robko01Lib.Controllers.ORLIN369.Robko01(new SerialAdapter(serialPort));
                }

                this.robot.OnMoveing += this.myRobko_OnMoveing;
                this.robot.OnNotMoveing += this.myRobko_OnNotMoveing;
                this.robot.OnMessage += Robot_OnMessage;
                this.robot.Connect();
            }
            catch (Exception exception)
            {
                this.AddLogRow(exception.ToString());
            }
        }
        
        private void DisconnectFromRobot()
        {
            try
            {
                if (this.robot != null && this.robot.IsConnected)
                {
                    this.robot.Stop(JointName.All);
                    Thread.Sleep(50);
                    this.robot.Enable(JointName.All);
                    Thread.Sleep(50);
                    this.robot.Disconnect();
                }
            }
            catch (Exception exception)
            {
                this.AddLogRow(exception.ToString());
            }
        }

        #endregion

        #region Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.btnRCStop.Enabled = false;

            this.lstCommands.Items.Clear();
            this.lstLog.Items.Clear();
            this.FillAxisCombo();
            this.SearchForPorts();
            this.FillControllerTypes();

            JointState status = new JointState(-1, false, false, JointDirection.CW, 0, 0, 0, 0, false);
            this.SetBaseStatus(status);
            this.SetShoulderStatus(status);
            this.SetElbowStatus(status);
            this.SetLDStatus(status);
            this.SetRDStatus(status);
            this.SetGripperStatus(status);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.StopProgram();
            this.DisconnectFromRobot();
        }

        #endregion

        #region Buttons

        #region Manual Control

        #region Base

        private void btnEnableBase_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;
            robot.Enable((int)JointName.Base);
        }

        private void btnDisableBase_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;
            this.robot.Disable((int)JointName.Base);
        }

        private void btnCwBase_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;
            int delay = AppUtils.ValidateDelay(this.tbDelayBase.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleBase.Text);

            this.robot.SetJoint(JointName.Base, delay, steps);
        }

        private void btnCcwBase_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;
            int delay = AppUtils.ValidateDelay(this.tbDelayBase.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleBase.Text);

            this.robot.SetJoint(JointName.Base, delay, -steps);
        }

        #endregion

        #region Shoulder

        private void btnEnableShoulder_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;
            this.robot.Enable(JointName.Shoulder);
        }

        private void btnDisableShoulder_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;
            this.robot.Disable(JointName.Shoulder);
        }

        private void btnCwShoulder_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayShoulder.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleShoulder.Text);

            this.robot.SetJoint(JointName.Shoulder, delay, steps);
        }

        private void btnCcwShoulder_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayShoulder.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleShoulder.Text);

            this.robot.SetJoint(JointName.Shoulder, delay, -steps);
        }

        #endregion

        #region Elbow

        private void btnEnableElbow_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            this.robot.Enable(JointName.Elbow);
        }

        private void btnDisableElbow_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            this.robot.Disable(JointName.Elbow);
        }

        private void btnCwElbow_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayElbow.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleElbow.Text);

            this.robot.SetJoint(JointName.Elbow, delay, steps);
        }

        private void btnCcwElbow_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayElbow.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleElbow.Text);

            this.robot.SetJoint(JointName.Elbow, delay, -steps);
        }

        #endregion

        #region Gripper

        private void btnEnableGripper_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            this.robot.Enable(JointName.Gripper);
        }

        private void btnDisableGripper_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            this.robot.Disable(JointName.Gripper);
        }

        private void btnCwGripper_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayGripper.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleGripper.Text);

            this.robot.SetJoint(JointName.Gripper, delay, steps);
        }

        private void btnCcwGripper_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayGripper.Text);
            int steps = AppUtils.ValidateSteps(this.tbAngleGripper.Text);

            this.robot.SetJoint(JointName.Gripper, delay, -steps);
        }

        #endregion

        #region Pitch / Roll

        private void btnEnablePichRoll_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            this.robot.Enable(JointName.LD);
            this.robot.Enable(JointName.RD);
        }

        private void btnDisablePichRoll_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            this.robot.Disable(JointName.Roll);
        }

        private void btnCWPich_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayPichRoll.Text);
            int steps = AppUtils.ValidateSteps(this.tbAnglePichRoll.Text);

            this.robot.SetJoint(JointName.Pitch, delay, steps);
        }

        private void btnCCWPich_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayPichRoll.Text);
            int steps = AppUtils.ValidateSteps(this.tbAnglePichRoll.Text);

            this.robot.SetJoint(JointName.Pitch, delay, -steps);
        }

        private void btnCwRoll_Click(object sender, EventArgs e)
        {
            if (this.robot == null || this.robot.IsConnected == false || this.robot.IsRuning == true) return;

            int delay = AppUtils.ValidateDelay(this.tbDelayPichRoll.Text);
            int steps = AppUtils.ValidateSteps(this.tbAnglePichRoll.Text);

            this.robot.SetJoint(JointName.Roll, delay, steps);
        }

        private void btnCcwRoll_Click(object sender, EventArgs e)
        {
            int delay = AppUtils.ValidateDelay(this.tbDelayPichRoll.Text);
            int steps = AppUtils.ValidateSteps(this.tbAnglePichRoll.Text);
            this.robot.SetJoint(JointName.Roll, delay, -steps);
        }

        #endregion

        #endregion

        #region Automatic Control

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            this.RunProgram();
        }
        
        private void btnResumeProgram_Click(object sender, EventArgs e)
        {
            this.ResumeProgram();
        }

        private void btnStopProgram_Click(object sender, EventArgs e)
        {
            this.StopProgram();
        }

        private void btnClearCommands_Click(object sender, EventArgs e)
        {
            if (this.robot.IsConnected)
            {
                this.robot.Stop(JointName.All);
            }

            this.programControl.Commands.Clear();
            this.lstCommands.Items.Clear();
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            int delay = AppUtils.ValidateDelay(this.tbDelay.Text);
            int steps = AppUtils.ValidateSteps(this.tbSteps.Text);
            JointName axis = (JointName)this.cmbAxis.SelectedIndex;

            MotionCommand command = new MotionCommand(axis, delay, steps);

            this.programControl.Commands.Add(command);
            this.lstCommands.Items.Add(command.ToString());
        }

        #endregion

        #region Remote Control / MODBUS-TCP Server

        private void btnRCStart_Click(object sender, EventArgs e)
        {
            IPAddress address;
            int port;
            byte slaveAddress;
            ushort startAddress;

            bool isValidIP = IPAddress.TryParse(this.tbRCIPAddress.Text, out address);
            bool isValidPort = int.TryParse(this.tbRCIPPort.Text, out port);
            bool isValidSlaveAddress = byte.TryParse(this.tbRCSlaveAddress.Text, out slaveAddress);
            bool isValidStartAddress = ushort.TryParse(this.tbRCStartAddress.Text, out startAddress);

            if (!isValidIP)
            {
                this.tbRCIPAddress.BackColor = Color.Red;
            }

            if (!isValidPort)
            {
                this.tbRCIPPort.BackColor = Color.Red;
            }

            if (!isValidSlaveAddress)
            {
                this.tbRCSlaveAddress.BackColor = Color.Red;
            }

            if (!isValidStartAddress)
            {
                this.tbRCStartAddress.BackColor = Color.Red;
            }

            if (isValidIP && isValidPort)
            {
                this.btnRCStart.Enabled = false;
                this.btnRCStop.Enabled = true;

                this.tbRCIPAddress.Enabled = false;
                this.tbRCIPPort.Enabled = false;
                this.tbRCSlaveAddress.Enabled = false;
                this.tbRCStartAddress.Enabled = false;

                this.tbRCIPAddress.BackColor = Color.White;
                this.tbRCIPPort.BackColor = Color.White;
                this.tbRCSlaveAddress.BackColor = Color.White;
                this.tbRCStartAddress.BackColor = Color.White;
            }
        }

        private void btnRCStop_Click(object sender, EventArgs e)
        {
            this.btnRCStart.Enabled = true;
            this.btnRCStop.Enabled = false;

            this.tbRCIPAddress.Enabled = true;
            this.tbRCIPPort.Enabled = true;
            this.tbRCSlaveAddress.Enabled = true;
            this.tbRCStartAddress.Enabled = true;
        }

        #endregion

        #endregion

        #region lstCommands

        private void lstCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstCommands.Items.Count > 0)
            {
                int index = this.lstCommands.SelectedIndex;
                if (index > 0)
                {
                    string command = this.lstCommands.Items[index].ToString();
                    this.lblCommand.Text = String.Format("Command: {0}", command);
                    this.lblCommandIndex.Text = String.Format("Index: {0}/{1}", index + 1, this.programControl.Commands.Count);
                }
            }
        }

        private void lstCommands_DoubleClick(object sender, EventArgs e)
        {
            if (!this.robot.IsRuning && this.lstCommands.Items.Count > 0)
            {
                MotionCommand command = this.programControl.Commands[this.lstCommands.SelectedIndex];
                this.robot.SetJoint((JointName)command.Axis, command.Delay, command.Steps);
            }
        }

        #endregion

        #region lstLog

        private void lstLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lblMessage.InvokeRequired)
            {
                this.lblMessage.BeginInvoke((MethodInvoker)delegate()
                {
                    int index = this.lstLog.SelectedIndex;
                    string command = this.lstLog.Items[index].ToString();
                    this.lblMessage.Text = String.Format("Command:{0}{1}", Environment.NewLine, command);
                });
            }
            else
            {
                int index = this.lstLog.SelectedIndex;
                string command = this.lstLog.Items[index].ToString();
                this.lblMessage.Text = String.Format("Command:{0}{1}", Environment.NewLine, command);
            }
        }

        #endregion

        #region Menu

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm sf = new SettingsForm())
            {
                sf.ShowDialog();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadProgram();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveProgram();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RunProgram();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StopProgram();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResumeProgram();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // When you click to the menu, update ports.
            this.SearchForPorts();
            this.FillControllerTypes();
        }

        private void mItPorts_Click(object sender, EventArgs e)
        {
            if (controllerType == ControllerTypes.None)
            {
                MessageBox.Show("You should select first robot controller type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.robot != null)
            {
                if (this.robot.IsConnected && this.robot.IsRuning)
                {
                    return;
                }
            }

            this.DisconnectFromRobot();
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            this.robotSerialPortName = (string)item.Tag;
            this.ConnectToRobotViaSerial(this.robotSerialPortName);

            if (this.robot.IsConnected)
            {
                item.Checked = true;
                this.lblIsConnected.Text = String.Format("Connected@{0}", this.robotSerialPortName);
            }
            else
            {
                item.Checked = false;
                this.lblIsConnected.Text = "Not Connected";
            }
        }



        private void mItBoards_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            this.controllerType = (ControllerTypes)item.Tag;
            this.lblBoardType.Text = string.Format("Board Type: {0}", this.controllerType.ToString());
        }

        private void goToGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start("https://github.com/orlin369/Robko01");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is developed to control a Robko01 robot.\r\nIf you need help write to orlin369@abv.com", "About", MessageBoxButtons.OK);
        }
        
        #endregion

        #region Robot

        private void myRobko_OnNotMoveing(object sender, EventArgs e)
        {
            this.SetMotionState(false);
        }

        private void myRobko_OnMoveing(object sender, EventArgs e)
        {
            this.SetMotionState(true);
        }

        private void Robot_OnMessage(object sender, EventArgsString e)
        {
            this.CommandParser(e.Value);
            this.AddLogRow(e.Value);
        }

        #endregion

        #region Program Control

        private void programControl_OnFinish(object sender, EventArgs e)
        {
            this.UnlockCommandParameters();
            this.SetProgramState(false);
        }

        private void programControl_OnRuning(object sender, EventArgs e)
        {
            this.LockCommandParameters();
            this.SetProgramState(true);
        }
        
        private void programControl_OnExecutionIndexChanged(object sender, EventArgsInt e)
        {
            MotionCommand command =  this.programControl.Commands[e.Value];
            
            this.robot.SetJoint((JointName)command.Axis, command.Delay, command.Steps);

            if (this.lstCommands.InvokeRequired)
            {
                this.lstCommands.BeginInvoke((MethodInvoker)delegate()
                {
                    if (e.Value > 0 && e.Value < this.lstCommands.Items.Count)
                    {
                        // Select the program row.
                        this.lstCommands.SelectedIndex = e.Value;
                    }
                });
            }
            else
            {
                if (e.Value > 0 && e.Value < this.lstCommands.Items.Count)
                {
                    // Select the program row.
                    this.lstCommands.SelectedIndex = e.Value;
                }
            }
        }

        #endregion

        #region chkLoopProgram

        private void chkLoopProgram_CheckedChanged(object sender, EventArgs e)
        {
            this.programControl.LoopProgram = this.chkLoopProgram.Checked;
        }

        #endregion

        #region Test

        private void btnTest_Click(object sender, EventArgs e)
        {
            //this.testRobot.OnMesage += test_OnMesage;
            //this.testRobot.Connect();
            //this.test.ShutdownAll();
            //this.test.ReadInputs();
            //this.test.WriteOutputs(255);
            //this.test.ReadOutputs();
            //this.test.MoveJoint(0, 200);
            //this.test.HomeJoints();
            //this.test.ReadJoint(0);
        }

        private void btnCalcForward_Click(object sender, EventArgs e)
        {
            double pose = 0.0d;

            string value = this.tbTheta1.Text;
            bool valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Theta1 = pose;

            value = this.tbTheta2.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Theta2 = pose;

            value = this.tbTheta3.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Theta3 = pose;

            value = this.tbTheta4.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Theta4 = pose;

            value = this.tbTheta5.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Theta5 = pose;

            int[] steps = kinematics.GoForward();

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine("{0} {1}", index, steps[index]);
            }

            this.tbXmm.Text = this.kinematics.Xmm.ToString("F3");
            this.tbYmm.Text = this.kinematics.Ymm.ToString("F3");
            this.tbZmm.Text = this.kinematics.Zmm.ToString("F3");
            this.tbPdeg.Text = this.kinematics.Pdeg.ToString("F3");
            this.tbPdeg.Text = this.kinematics.Rdeg.ToString("F3");

            //string displayed = String.Format("X: {0:F3}{5}Y: {1:F3}{5}Z: {2:F3}{5}P: {3:F3}{5}R: {4:F3}", kinematics.Xmm, kinematics.Ymm, kinematics.Zmm, kinematics.Pdeg, kinematics.Rdeg, Environment.NewLine);

            //this.lblX.Text = displayed;
        }

        private void btnCalcInvers_Click(object sender, EventArgs e)
        {

            double pose = 0.0d;

            string value = this.tbXmm.Text;
            bool valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Xmm = pose;

            value = this.tbYmm.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Ymm = pose;

            value = this.tbZmm.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Zmm = pose;

            value = this.tbPdeg.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Pdeg = pose;

            value = this.tbRdeg.Text;
            valid = double.TryParse(value, out pose);
            if (!valid)
            {
                pose = 0;
            }
            kinematics.Rdeg = pose;

            int[] steps = kinematics.GoInverse();

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine("{0} {1}", index, steps[index]);
            }

            this.tbXmm.Text = this.kinematics.Xmm.ToString("F3");
            this.tbYmm.Text = this.kinematics.Ymm.ToString("F3");
            this.tbZmm.Text = this.kinematics.Zmm.ToString("F3");
            this.tbPdeg.Text = this.kinematics.Pdeg.ToString("F3");
            this.tbPdeg.Text = this.kinematics.Rdeg.ToString("F3");
        }

        #endregion
    }
}
