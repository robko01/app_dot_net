namespace Robko01
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbcModes = new System.Windows.Forms.TabControl();
            this.tpgManual = new System.Windows.Forms.TabPage();
            this.gpbKinematics = new System.Windows.Forms.GroupBox();
            this.btnCalcInvers = new System.Windows.Forms.Button();
            this.lblTheta5 = new System.Windows.Forms.Label();
            this.lblTheta4 = new System.Windows.Forms.Label();
            this.lblTheta3 = new System.Windows.Forms.Label();
            this.lblTheta2 = new System.Windows.Forms.Label();
            this.lblTheta1 = new System.Windows.Forms.Label();
            this.tbTheta5 = new System.Windows.Forms.TextBox();
            this.tbTheta4 = new System.Windows.Forms.TextBox();
            this.tbTheta3 = new System.Windows.Forms.TextBox();
            this.tbTheta2 = new System.Windows.Forms.TextBox();
            this.tbTheta1 = new System.Windows.Forms.TextBox();
            this.lblRdeg = new System.Windows.Forms.Label();
            this.lblPdeg = new System.Windows.Forms.Label();
            this.lblZmm = new System.Windows.Forms.Label();
            this.lblYmm = new System.Windows.Forms.Label();
            this.lblXmm = new System.Windows.Forms.Label();
            this.tbRdeg = new System.Windows.Forms.TextBox();
            this.tbPdeg = new System.Windows.Forms.TextBox();
            this.tbZmm = new System.Windows.Forms.TextBox();
            this.tbYmm = new System.Windows.Forms.TextBox();
            this.tbXmm = new System.Windows.Forms.TextBox();
            this.btnCalcForward = new System.Windows.Forms.Button();
            this.gpbGripper = new System.Windows.Forms.GroupBox();
            this.lblStepsGripper = new System.Windows.Forms.Label();
            this.lblMSecGripper = new System.Windows.Forms.Label();
            this.lblGripperStatus = new System.Windows.Forms.Label();
            this.tbDelayGripper = new System.Windows.Forms.TextBox();
            this.tbAngleGripper = new System.Windows.Forms.TextBox();
            this.btnCcwGripper = new System.Windows.Forms.Button();
            this.btnCwGripper = new System.Windows.Forms.Button();
            this.btnDisableGripper = new System.Windows.Forms.Button();
            this.btnEnableGripper = new System.Windows.Forms.Button();
            this.gpbPichRoll = new System.Windows.Forms.GroupBox();
            this.lblStepsPichRoll = new System.Windows.Forms.Label();
            this.lblMSecPichRoll = new System.Windows.Forms.Label();
            this.lblRightStatus = new System.Windows.Forms.Label();
            this.lblLeftDifferentStatus = new System.Windows.Forms.Label();
            this.tbDelayPichRoll = new System.Windows.Forms.TextBox();
            this.btnCcwRoll = new System.Windows.Forms.Button();
            this.btnCwRoll = new System.Windows.Forms.Button();
            this.tbAnglePichRoll = new System.Windows.Forms.TextBox();
            this.btnCCWPich = new System.Windows.Forms.Button();
            this.btnCWPich = new System.Windows.Forms.Button();
            this.btnDisablePichRoll = new System.Windows.Forms.Button();
            this.btnEnablePichRoll = new System.Windows.Forms.Button();
            this.gpbElbow = new System.Windows.Forms.GroupBox();
            this.lblStepsElbow = new System.Windows.Forms.Label();
            this.lblMSecElbow = new System.Windows.Forms.Label();
            this.lblElbowStatus = new System.Windows.Forms.Label();
            this.tbDelayElbow = new System.Windows.Forms.TextBox();
            this.tbAngleElbow = new System.Windows.Forms.TextBox();
            this.btnCcwElbow = new System.Windows.Forms.Button();
            this.btnCwElbow = new System.Windows.Forms.Button();
            this.btnDisableElbow = new System.Windows.Forms.Button();
            this.btnEnableElbow = new System.Windows.Forms.Button();
            this.gpbShoulder = new System.Windows.Forms.GroupBox();
            this.lblStepsShoulder = new System.Windows.Forms.Label();
            this.lblMSecShoulder = new System.Windows.Forms.Label();
            this.lblShoulderStatus = new System.Windows.Forms.Label();
            this.tbDelayShoulder = new System.Windows.Forms.TextBox();
            this.tbAngleShoulder = new System.Windows.Forms.TextBox();
            this.btnCcwShoulder = new System.Windows.Forms.Button();
            this.btnCwShoulder = new System.Windows.Forms.Button();
            this.btnDisableShoulder = new System.Windows.Forms.Button();
            this.btnEnableShoulder = new System.Windows.Forms.Button();
            this.gpbBase = new System.Windows.Forms.GroupBox();
            this.lblStepsBase = new System.Windows.Forms.Label();
            this.lblMSecBase = new System.Windows.Forms.Label();
            this.lblBaseStatus = new System.Windows.Forms.Label();
            this.tbDelayBase = new System.Windows.Forms.TextBox();
            this.tbAngleBase = new System.Windows.Forms.TextBox();
            this.btnCcwBase = new System.Windows.Forms.Button();
            this.btnCwBase = new System.Windows.Forms.Button();
            this.btnDisableBase = new System.Windows.Forms.Button();
            this.btnEnableBase = new System.Windows.Forms.Button();
            this.tpgAuto = new System.Windows.Forms.TabPage();
            this.lblJoint = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.chkLoopProgram = new System.Windows.Forms.CheckBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblCommandIndex = new System.Windows.Forms.Label();
            this.btnResumeProgram = new System.Windows.Forms.Button();
            this.btnStopProgram = new System.Windows.Forms.Button();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.btnClearCommands = new System.Windows.Forms.Button();
            this.cmbAxis = new System.Windows.Forms.ComboBox();
            this.tbSteps = new System.Windows.Forms.TextBox();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpbRemoteControl = new System.Windows.Forms.GroupBox();
            this.lblRCSlaveAddress = new System.Windows.Forms.Label();
            this.tbRCSlaveAddress = new System.Windows.Forms.TextBox();
            this.lblRCStartAddress = new System.Windows.Forms.Label();
            this.tbRCStartAddress = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblIPPort = new System.Windows.Forms.Label();
            this.tbRCIPPort = new System.Windows.Forms.TextBox();
            this.tbRCIPAddress = new System.Windows.Forms.TextBox();
            this.btnRCStop = new System.Windows.Forms.Button();
            this.btnRCStart = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblBoardType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIsConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMotionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTest = new System.Windows.Forms.Button();
            this.mQTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcModes.SuspendLayout();
            this.tpgManual.SuspendLayout();
            this.gpbKinematics.SuspendLayout();
            this.gpbGripper.SuspendLayout();
            this.gpbPichRoll.SuspendLayout();
            this.gpbElbow.SuspendLayout();
            this.gpbShoulder.SuspendLayout();
            this.gpbBase.SuspendLayout();
            this.tpgAuto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpbRemoteControl.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcModes
            // 
            this.tbcModes.Controls.Add(this.tpgManual);
            this.tbcModes.Controls.Add(this.tpgAuto);
            this.tbcModes.Controls.Add(this.tabPage1);
            this.tbcModes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcModes.Location = new System.Drawing.Point(0, 28);
            this.tbcModes.Margin = new System.Windows.Forms.Padding(4);
            this.tbcModes.Name = "tbcModes";
            this.tbcModes.SelectedIndex = 0;
            this.tbcModes.Size = new System.Drawing.Size(1360, 439);
            this.tbcModes.TabIndex = 16;
            // 
            // tpgManual
            // 
            this.tpgManual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpgManual.Controls.Add(this.gpbKinematics);
            this.tpgManual.Controls.Add(this.gpbGripper);
            this.tpgManual.Controls.Add(this.gpbPichRoll);
            this.tpgManual.Controls.Add(this.gpbElbow);
            this.tpgManual.Controls.Add(this.gpbShoulder);
            this.tpgManual.Controls.Add(this.gpbBase);
            this.tpgManual.Location = new System.Drawing.Point(4, 25);
            this.tpgManual.Margin = new System.Windows.Forms.Padding(4);
            this.tpgManual.Name = "tpgManual";
            this.tpgManual.Padding = new System.Windows.Forms.Padding(4);
            this.tpgManual.Size = new System.Drawing.Size(1352, 410);
            this.tpgManual.TabIndex = 0;
            this.tpgManual.Text = "Manual";
            // 
            // gpbKinematics
            // 
            this.gpbKinematics.Controls.Add(this.btnCalcInvers);
            this.gpbKinematics.Controls.Add(this.lblTheta5);
            this.gpbKinematics.Controls.Add(this.lblTheta4);
            this.gpbKinematics.Controls.Add(this.lblTheta3);
            this.gpbKinematics.Controls.Add(this.lblTheta2);
            this.gpbKinematics.Controls.Add(this.lblTheta1);
            this.gpbKinematics.Controls.Add(this.tbTheta5);
            this.gpbKinematics.Controls.Add(this.tbTheta4);
            this.gpbKinematics.Controls.Add(this.tbTheta3);
            this.gpbKinematics.Controls.Add(this.tbTheta2);
            this.gpbKinematics.Controls.Add(this.tbTheta1);
            this.gpbKinematics.Controls.Add(this.lblRdeg);
            this.gpbKinematics.Controls.Add(this.lblPdeg);
            this.gpbKinematics.Controls.Add(this.lblZmm);
            this.gpbKinematics.Controls.Add(this.lblYmm);
            this.gpbKinematics.Controls.Add(this.lblXmm);
            this.gpbKinematics.Controls.Add(this.tbRdeg);
            this.gpbKinematics.Controls.Add(this.tbPdeg);
            this.gpbKinematics.Controls.Add(this.tbZmm);
            this.gpbKinematics.Controls.Add(this.tbYmm);
            this.gpbKinematics.Controls.Add(this.tbXmm);
            this.gpbKinematics.Controls.Add(this.btnCalcForward);
            this.gpbKinematics.Location = new System.Drawing.Point(1112, 7);
            this.gpbKinematics.Margin = new System.Windows.Forms.Padding(4);
            this.gpbKinematics.Name = "gpbKinematics";
            this.gpbKinematics.Padding = new System.Windows.Forms.Padding(4);
            this.gpbKinematics.Size = new System.Drawing.Size(176, 388);
            this.gpbKinematics.TabIndex = 28;
            this.gpbKinematics.TabStop = false;
            this.gpbKinematics.Text = "Kinematics";
            // 
            // btnCalcInvers
            // 
            this.btnCalcInvers.Location = new System.Drawing.Point(104, 186);
            this.btnCalcInvers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcInvers.Name = "btnCalcInvers";
            this.btnCalcInvers.Size = new System.Drawing.Size(63, 28);
            this.btnCalcInvers.TabIndex = 50;
            this.btnCalcInvers.Text = "Inv";
            this.btnCalcInvers.UseVisualStyleBackColor = true;
            this.btnCalcInvers.Click += new System.EventHandler(this.btnCalcInvers_Click);
            // 
            // lblTheta5
            // 
            this.lblTheta5.AutoSize = true;
            this.lblTheta5.Location = new System.Drawing.Point(8, 362);
            this.lblTheta5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheta5.Name = "lblTheta5";
            this.lblTheta5.Size = new System.Drawing.Size(61, 17);
            this.lblTheta5.TabIndex = 49;
            this.lblTheta5.Text = "T5[deg]:";
            // 
            // lblTheta4
            // 
            this.lblTheta4.AutoSize = true;
            this.lblTheta4.Location = new System.Drawing.Point(8, 330);
            this.lblTheta4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheta4.Name = "lblTheta4";
            this.lblTheta4.Size = new System.Drawing.Size(61, 17);
            this.lblTheta4.TabIndex = 48;
            this.lblTheta4.Text = "T4[deg]:";
            // 
            // lblTheta3
            // 
            this.lblTheta3.AutoSize = true;
            this.lblTheta3.Location = new System.Drawing.Point(8, 298);
            this.lblTheta3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheta3.Name = "lblTheta3";
            this.lblTheta3.Size = new System.Drawing.Size(61, 17);
            this.lblTheta3.TabIndex = 47;
            this.lblTheta3.Text = "T3[deg]:";
            // 
            // lblTheta2
            // 
            this.lblTheta2.AutoSize = true;
            this.lblTheta2.Location = new System.Drawing.Point(8, 266);
            this.lblTheta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheta2.Name = "lblTheta2";
            this.lblTheta2.Size = new System.Drawing.Size(61, 17);
            this.lblTheta2.TabIndex = 46;
            this.lblTheta2.Text = "T2[deg]:";
            // 
            // lblTheta1
            // 
            this.lblTheta1.AutoSize = true;
            this.lblTheta1.Location = new System.Drawing.Point(8, 234);
            this.lblTheta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheta1.Name = "lblTheta1";
            this.lblTheta1.Size = new System.Drawing.Size(61, 17);
            this.lblTheta1.TabIndex = 45;
            this.lblTheta1.Text = "T1[deg]:";
            // 
            // tbTheta5
            // 
            this.tbTheta5.Location = new System.Drawing.Point(79, 358);
            this.tbTheta5.Margin = new System.Windows.Forms.Padding(4);
            this.tbTheta5.Name = "tbTheta5";
            this.tbTheta5.Size = new System.Drawing.Size(87, 22);
            this.tbTheta5.TabIndex = 44;
            this.tbTheta5.Text = "65";
            // 
            // tbTheta4
            // 
            this.tbTheta4.Location = new System.Drawing.Point(79, 326);
            this.tbTheta4.Margin = new System.Windows.Forms.Padding(4);
            this.tbTheta4.Name = "tbTheta4";
            this.tbTheta4.Size = new System.Drawing.Size(87, 22);
            this.tbTheta4.TabIndex = 43;
            this.tbTheta4.Text = "65";
            // 
            // tbTheta3
            // 
            this.tbTheta3.Location = new System.Drawing.Point(79, 294);
            this.tbTheta3.Margin = new System.Windows.Forms.Padding(4);
            this.tbTheta3.Name = "tbTheta3";
            this.tbTheta3.Size = new System.Drawing.Size(87, 22);
            this.tbTheta3.TabIndex = 42;
            this.tbTheta3.Text = "-25";
            // 
            // tbTheta2
            // 
            this.tbTheta2.Location = new System.Drawing.Point(79, 262);
            this.tbTheta2.Margin = new System.Windows.Forms.Padding(4);
            this.tbTheta2.Name = "tbTheta2";
            this.tbTheta2.Size = new System.Drawing.Size(87, 22);
            this.tbTheta2.TabIndex = 41;
            this.tbTheta2.Text = "-25";
            // 
            // tbTheta1
            // 
            this.tbTheta1.Location = new System.Drawing.Point(79, 230);
            this.tbTheta1.Margin = new System.Windows.Forms.Padding(4);
            this.tbTheta1.Name = "tbTheta1";
            this.tbTheta1.Size = new System.Drawing.Size(87, 22);
            this.tbTheta1.TabIndex = 40;
            this.tbTheta1.Text = "0";
            // 
            // lblRdeg
            // 
            this.lblRdeg.AutoSize = true;
            this.lblRdeg.Location = new System.Drawing.Point(8, 158);
            this.lblRdeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRdeg.Name = "lblRdeg";
            this.lblRdeg.Size = new System.Drawing.Size(54, 17);
            this.lblRdeg.TabIndex = 39;
            this.lblRdeg.Text = "R[deg]:";
            // 
            // lblPdeg
            // 
            this.lblPdeg.AutoSize = true;
            this.lblPdeg.Location = new System.Drawing.Point(8, 126);
            this.lblPdeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPdeg.Name = "lblPdeg";
            this.lblPdeg.Size = new System.Drawing.Size(53, 17);
            this.lblPdeg.TabIndex = 38;
            this.lblPdeg.Text = "P[deg]:";
            // 
            // lblZmm
            // 
            this.lblZmm.AutoSize = true;
            this.lblZmm.Location = new System.Drawing.Point(8, 94);
            this.lblZmm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZmm.Name = "lblZmm";
            this.lblZmm.Size = new System.Drawing.Size(51, 17);
            this.lblZmm.TabIndex = 37;
            this.lblZmm.Text = "Z[mm]:";
            // 
            // lblYmm
            // 
            this.lblYmm.AutoSize = true;
            this.lblYmm.Location = new System.Drawing.Point(8, 62);
            this.lblYmm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYmm.Name = "lblYmm";
            this.lblYmm.Size = new System.Drawing.Size(51, 17);
            this.lblYmm.TabIndex = 36;
            this.lblYmm.Text = "Y[mm]:";
            // 
            // lblXmm
            // 
            this.lblXmm.AutoSize = true;
            this.lblXmm.Location = new System.Drawing.Point(8, 30);
            this.lblXmm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmm.Name = "lblXmm";
            this.lblXmm.Size = new System.Drawing.Size(51, 17);
            this.lblXmm.TabIndex = 35;
            this.lblXmm.Text = "X[mm]:";
            // 
            // tbRdeg
            // 
            this.tbRdeg.Location = new System.Drawing.Point(68, 154);
            this.tbRdeg.Margin = new System.Windows.Forms.Padding(4);
            this.tbRdeg.Name = "tbRdeg";
            this.tbRdeg.Size = new System.Drawing.Size(97, 22);
            this.tbRdeg.TabIndex = 34;
            this.tbRdeg.Text = "0";
            // 
            // tbPdeg
            // 
            this.tbPdeg.Location = new System.Drawing.Point(68, 122);
            this.tbPdeg.Margin = new System.Windows.Forms.Padding(4);
            this.tbPdeg.Name = "tbPdeg";
            this.tbPdeg.Size = new System.Drawing.Size(97, 22);
            this.tbPdeg.TabIndex = 33;
            this.tbPdeg.Text = "0";
            // 
            // tbZmm
            // 
            this.tbZmm.Location = new System.Drawing.Point(68, 90);
            this.tbZmm.Margin = new System.Windows.Forms.Padding(4);
            this.tbZmm.Name = "tbZmm";
            this.tbZmm.Size = new System.Drawing.Size(97, 22);
            this.tbZmm.TabIndex = 32;
            this.tbZmm.Text = "0";
            // 
            // tbYmm
            // 
            this.tbYmm.Location = new System.Drawing.Point(68, 58);
            this.tbYmm.Margin = new System.Windows.Forms.Padding(4);
            this.tbYmm.Name = "tbYmm";
            this.tbYmm.Size = new System.Drawing.Size(97, 22);
            this.tbYmm.TabIndex = 31;
            this.tbYmm.Text = "0";
            // 
            // tbXmm
            // 
            this.tbXmm.Location = new System.Drawing.Point(68, 26);
            this.tbXmm.Margin = new System.Windows.Forms.Padding(4);
            this.tbXmm.Name = "tbXmm";
            this.tbXmm.Size = new System.Drawing.Size(97, 22);
            this.tbXmm.TabIndex = 30;
            this.tbXmm.Text = "0";
            // 
            // btnCalcForward
            // 
            this.btnCalcForward.Location = new System.Drawing.Point(8, 186);
            this.btnCalcForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcForward.Name = "btnCalcForward";
            this.btnCalcForward.Size = new System.Drawing.Size(68, 28);
            this.btnCalcForward.TabIndex = 29;
            this.btnCalcForward.Text = "Forth";
            this.btnCalcForward.UseVisualStyleBackColor = true;
            this.btnCalcForward.Click += new System.EventHandler(this.btnCalcForward_Click);
            // 
            // gpbGripper
            // 
            this.gpbGripper.Controls.Add(this.lblStepsGripper);
            this.gpbGripper.Controls.Add(this.lblMSecGripper);
            this.gpbGripper.Controls.Add(this.lblGripperStatus);
            this.gpbGripper.Controls.Add(this.tbDelayGripper);
            this.gpbGripper.Controls.Add(this.tbAngleGripper);
            this.gpbGripper.Controls.Add(this.btnCcwGripper);
            this.gpbGripper.Controls.Add(this.btnCwGripper);
            this.gpbGripper.Controls.Add(this.btnDisableGripper);
            this.gpbGripper.Controls.Add(this.btnEnableGripper);
            this.gpbGripper.Location = new System.Drawing.Point(928, 7);
            this.gpbGripper.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGripper.Name = "gpbGripper";
            this.gpbGripper.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGripper.Size = new System.Drawing.Size(176, 388);
            this.gpbGripper.TabIndex = 20;
            this.gpbGripper.TabStop = false;
            this.gpbGripper.Text = "Gripper";
            // 
            // lblStepsGripper
            // 
            this.lblStepsGripper.AutoSize = true;
            this.lblStepsGripper.Location = new System.Drawing.Point(104, 175);
            this.lblStepsGripper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsGripper.Name = "lblStepsGripper";
            this.lblStepsGripper.Size = new System.Drawing.Size(50, 17);
            this.lblStepsGripper.TabIndex = 30;
            this.lblStepsGripper.Text = "[steps]";
            // 
            // lblMSecGripper
            // 
            this.lblMSecGripper.AutoSize = true;
            this.lblMSecGripper.Location = new System.Drawing.Point(104, 202);
            this.lblMSecGripper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSecGripper.Name = "lblMSecGripper";
            this.lblMSecGripper.Size = new System.Drawing.Size(34, 17);
            this.lblMSecGripper.TabIndex = 29;
            this.lblMSecGripper.Text = "[ms]";
            // 
            // lblGripperStatus
            // 
            this.lblGripperStatus.AutoSize = true;
            this.lblGripperStatus.Location = new System.Drawing.Point(8, 226);
            this.lblGripperStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGripperStatus.Name = "lblGripperStatus";
            this.lblGripperStatus.Size = new System.Drawing.Size(45, 17);
            this.lblGripperStatus.TabIndex = 27;
            this.lblGripperStatus.Text = "State:";
            // 
            // tbDelayGripper
            // 
            this.tbDelayGripper.Location = new System.Drawing.Point(8, 198);
            this.tbDelayGripper.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelayGripper.Name = "tbDelayGripper";
            this.tbDelayGripper.Size = new System.Drawing.Size(87, 22);
            this.tbDelayGripper.TabIndex = 11;
            this.tbDelayGripper.Text = "10";
            // 
            // tbAngleGripper
            // 
            this.tbAngleGripper.Location = new System.Drawing.Point(8, 166);
            this.tbAngleGripper.Margin = new System.Windows.Forms.Padding(4);
            this.tbAngleGripper.Name = "tbAngleGripper";
            this.tbAngleGripper.Size = new System.Drawing.Size(87, 22);
            this.tbAngleGripper.TabIndex = 10;
            this.tbAngleGripper.Text = "50";
            // 
            // btnCcwGripper
            // 
            this.btnCcwGripper.Location = new System.Drawing.Point(8, 130);
            this.btnCcwGripper.Margin = new System.Windows.Forms.Padding(4);
            this.btnCcwGripper.Name = "btnCcwGripper";
            this.btnCcwGripper.Size = new System.Drawing.Size(159, 28);
            this.btnCcwGripper.TabIndex = 9;
            this.btnCcwGripper.Text = "CLOSE";
            this.btnCcwGripper.UseVisualStyleBackColor = true;
            this.btnCcwGripper.Click += new System.EventHandler(this.btnCcwGripper_Click);
            // 
            // btnCwGripper
            // 
            this.btnCwGripper.Location = new System.Drawing.Point(8, 95);
            this.btnCwGripper.Margin = new System.Windows.Forms.Padding(4);
            this.btnCwGripper.Name = "btnCwGripper";
            this.btnCwGripper.Size = new System.Drawing.Size(159, 28);
            this.btnCwGripper.TabIndex = 8;
            this.btnCwGripper.Text = "OPEN";
            this.btnCwGripper.UseVisualStyleBackColor = true;
            this.btnCwGripper.Click += new System.EventHandler(this.btnCwGripper_Click);
            // 
            // btnDisableGripper
            // 
            this.btnDisableGripper.Location = new System.Drawing.Point(8, 59);
            this.btnDisableGripper.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisableGripper.Name = "btnDisableGripper";
            this.btnDisableGripper.Size = new System.Drawing.Size(159, 28);
            this.btnDisableGripper.TabIndex = 7;
            this.btnDisableGripper.Text = "Disable";
            this.btnDisableGripper.UseVisualStyleBackColor = true;
            this.btnDisableGripper.Click += new System.EventHandler(this.btnDisableGripper_Click);
            // 
            // btnEnableGripper
            // 
            this.btnEnableGripper.Location = new System.Drawing.Point(8, 23);
            this.btnEnableGripper.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnableGripper.Name = "btnEnableGripper";
            this.btnEnableGripper.Size = new System.Drawing.Size(159, 28);
            this.btnEnableGripper.TabIndex = 6;
            this.btnEnableGripper.Text = "Enable";
            this.btnEnableGripper.UseVisualStyleBackColor = true;
            this.btnEnableGripper.Click += new System.EventHandler(this.btnEnableGripper_Click);
            // 
            // gpbPichRoll
            // 
            this.gpbPichRoll.Controls.Add(this.lblStepsPichRoll);
            this.gpbPichRoll.Controls.Add(this.lblMSecPichRoll);
            this.gpbPichRoll.Controls.Add(this.lblRightStatus);
            this.gpbPichRoll.Controls.Add(this.lblLeftDifferentStatus);
            this.gpbPichRoll.Controls.Add(this.tbDelayPichRoll);
            this.gpbPichRoll.Controls.Add(this.btnCcwRoll);
            this.gpbPichRoll.Controls.Add(this.btnCwRoll);
            this.gpbPichRoll.Controls.Add(this.tbAnglePichRoll);
            this.gpbPichRoll.Controls.Add(this.btnCCWPich);
            this.gpbPichRoll.Controls.Add(this.btnCWPich);
            this.gpbPichRoll.Controls.Add(this.btnDisablePichRoll);
            this.gpbPichRoll.Controls.Add(this.btnEnablePichRoll);
            this.gpbPichRoll.Location = new System.Drawing.Point(560, 7);
            this.gpbPichRoll.Margin = new System.Windows.Forms.Padding(4);
            this.gpbPichRoll.Name = "gpbPichRoll";
            this.gpbPichRoll.Padding = new System.Windows.Forms.Padding(4);
            this.gpbPichRoll.Size = new System.Drawing.Size(360, 388);
            this.gpbPichRoll.TabIndex = 19;
            this.gpbPichRoll.TabStop = false;
            this.gpbPichRoll.Text = "Pich / Roll";
            // 
            // lblStepsPichRoll
            // 
            this.lblStepsPichRoll.AutoSize = true;
            this.lblStepsPichRoll.Location = new System.Drawing.Point(199, 170);
            this.lblStepsPichRoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsPichRoll.Name = "lblStepsPichRoll";
            this.lblStepsPichRoll.Size = new System.Drawing.Size(50, 17);
            this.lblStepsPichRoll.TabIndex = 29;
            this.lblStepsPichRoll.Text = "[steps]";
            // 
            // lblMSecPichRoll
            // 
            this.lblMSecPichRoll.AutoSize = true;
            this.lblMSecPichRoll.Location = new System.Drawing.Point(199, 202);
            this.lblMSecPichRoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSecPichRoll.Name = "lblMSecPichRoll";
            this.lblMSecPichRoll.Size = new System.Drawing.Size(34, 17);
            this.lblMSecPichRoll.TabIndex = 28;
            this.lblMSecPichRoll.Text = "[ms]";
            // 
            // lblRightStatus
            // 
            this.lblRightStatus.AutoSize = true;
            this.lblRightStatus.Location = new System.Drawing.Point(189, 226);
            this.lblRightStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRightStatus.Name = "lblRightStatus";
            this.lblRightStatus.Size = new System.Drawing.Size(45, 17);
            this.lblRightStatus.TabIndex = 26;
            this.lblRightStatus.Text = "State:";
            // 
            // lblLeftDifferentStatus
            // 
            this.lblLeftDifferentStatus.AutoSize = true;
            this.lblLeftDifferentStatus.Location = new System.Drawing.Point(8, 226);
            this.lblLeftDifferentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftDifferentStatus.Name = "lblLeftDifferentStatus";
            this.lblLeftDifferentStatus.Size = new System.Drawing.Size(45, 17);
            this.lblLeftDifferentStatus.TabIndex = 25;
            this.lblLeftDifferentStatus.Text = "State:";
            // 
            // tbDelayPichRoll
            // 
            this.tbDelayPichRoll.Location = new System.Drawing.Point(101, 198);
            this.tbDelayPichRoll.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelayPichRoll.Name = "tbDelayPichRoll";
            this.tbDelayPichRoll.Size = new System.Drawing.Size(88, 22);
            this.tbDelayPichRoll.TabIndex = 14;
            this.tbDelayPichRoll.Text = "10";
            // 
            // btnCcwRoll
            // 
            this.btnCcwRoll.Location = new System.Drawing.Point(8, 95);
            this.btnCcwRoll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCcwRoll.Name = "btnCcwRoll";
            this.btnCcwRoll.Size = new System.Drawing.Size(159, 28);
            this.btnCcwRoll.TabIndex = 12;
            this.btnCcwRoll.Text = "CCW";
            this.btnCcwRoll.UseVisualStyleBackColor = true;
            this.btnCcwRoll.Click += new System.EventHandler(this.btnCcwRoll_Click);
            // 
            // btnCwRoll
            // 
            this.btnCwRoll.Location = new System.Drawing.Point(193, 95);
            this.btnCwRoll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCwRoll.Name = "btnCwRoll";
            this.btnCwRoll.Size = new System.Drawing.Size(159, 28);
            this.btnCwRoll.TabIndex = 11;
            this.btnCwRoll.Text = "CW";
            this.btnCwRoll.UseVisualStyleBackColor = true;
            this.btnCwRoll.Click += new System.EventHandler(this.btnCwRoll_Click);
            // 
            // tbAnglePichRoll
            // 
            this.tbAnglePichRoll.Location = new System.Drawing.Point(101, 166);
            this.tbAnglePichRoll.Margin = new System.Windows.Forms.Padding(4);
            this.tbAnglePichRoll.Name = "tbAnglePichRoll";
            this.tbAnglePichRoll.Size = new System.Drawing.Size(88, 22);
            this.tbAnglePichRoll.TabIndex = 10;
            this.tbAnglePichRoll.Text = "50";
            // 
            // btnCCWPich
            // 
            this.btnCCWPich.Location = new System.Drawing.Point(101, 130);
            this.btnCCWPich.Margin = new System.Windows.Forms.Padding(4);
            this.btnCCWPich.Name = "btnCCWPich";
            this.btnCCWPich.Size = new System.Drawing.Size(159, 28);
            this.btnCCWPich.TabIndex = 9;
            this.btnCCWPich.Text = "DOWN";
            this.btnCCWPich.UseVisualStyleBackColor = true;
            this.btnCCWPich.Click += new System.EventHandler(this.btnCCWPich_Click);
            // 
            // btnCWPich
            // 
            this.btnCWPich.Location = new System.Drawing.Point(101, 59);
            this.btnCWPich.Margin = new System.Windows.Forms.Padding(4);
            this.btnCWPich.Name = "btnCWPich";
            this.btnCWPich.Size = new System.Drawing.Size(159, 28);
            this.btnCWPich.TabIndex = 8;
            this.btnCWPich.Text = "UP";
            this.btnCWPich.UseVisualStyleBackColor = true;
            this.btnCWPich.Click += new System.EventHandler(this.btnCWPich_Click);
            // 
            // btnDisablePichRoll
            // 
            this.btnDisablePichRoll.Location = new System.Drawing.Point(193, 23);
            this.btnDisablePichRoll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisablePichRoll.Name = "btnDisablePichRoll";
            this.btnDisablePichRoll.Size = new System.Drawing.Size(159, 28);
            this.btnDisablePichRoll.TabIndex = 7;
            this.btnDisablePichRoll.Text = "Disable";
            this.btnDisablePichRoll.UseVisualStyleBackColor = true;
            this.btnDisablePichRoll.Click += new System.EventHandler(this.btnDisablePichRoll_Click);
            // 
            // btnEnablePichRoll
            // 
            this.btnEnablePichRoll.Location = new System.Drawing.Point(8, 23);
            this.btnEnablePichRoll.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnablePichRoll.Name = "btnEnablePichRoll";
            this.btnEnablePichRoll.Size = new System.Drawing.Size(159, 28);
            this.btnEnablePichRoll.TabIndex = 6;
            this.btnEnablePichRoll.Text = "Enable";
            this.btnEnablePichRoll.UseVisualStyleBackColor = true;
            this.btnEnablePichRoll.Click += new System.EventHandler(this.btnEnablePichRoll_Click);
            // 
            // gpbElbow
            // 
            this.gpbElbow.Controls.Add(this.lblStepsElbow);
            this.gpbElbow.Controls.Add(this.lblMSecElbow);
            this.gpbElbow.Controls.Add(this.lblElbowStatus);
            this.gpbElbow.Controls.Add(this.tbDelayElbow);
            this.gpbElbow.Controls.Add(this.tbAngleElbow);
            this.gpbElbow.Controls.Add(this.btnCcwElbow);
            this.gpbElbow.Controls.Add(this.btnCwElbow);
            this.gpbElbow.Controls.Add(this.btnDisableElbow);
            this.gpbElbow.Controls.Add(this.btnEnableElbow);
            this.gpbElbow.Location = new System.Drawing.Point(376, 7);
            this.gpbElbow.Margin = new System.Windows.Forms.Padding(4);
            this.gpbElbow.Name = "gpbElbow";
            this.gpbElbow.Padding = new System.Windows.Forms.Padding(4);
            this.gpbElbow.Size = new System.Drawing.Size(176, 388);
            this.gpbElbow.TabIndex = 18;
            this.gpbElbow.TabStop = false;
            this.gpbElbow.Text = "Elbow";
            // 
            // lblStepsElbow
            // 
            this.lblStepsElbow.AutoSize = true;
            this.lblStepsElbow.Location = new System.Drawing.Point(107, 175);
            this.lblStepsElbow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsElbow.Name = "lblStepsElbow";
            this.lblStepsElbow.Size = new System.Drawing.Size(50, 17);
            this.lblStepsElbow.TabIndex = 28;
            this.lblStepsElbow.Text = "[steps]";
            // 
            // lblMSecElbow
            // 
            this.lblMSecElbow.AutoSize = true;
            this.lblMSecElbow.Location = new System.Drawing.Point(107, 202);
            this.lblMSecElbow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSecElbow.Name = "lblMSecElbow";
            this.lblMSecElbow.Size = new System.Drawing.Size(34, 17);
            this.lblMSecElbow.TabIndex = 27;
            this.lblMSecElbow.Text = "[ms]";
            // 
            // lblElbowStatus
            // 
            this.lblElbowStatus.AutoSize = true;
            this.lblElbowStatus.Location = new System.Drawing.Point(8, 226);
            this.lblElbowStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElbowStatus.Name = "lblElbowStatus";
            this.lblElbowStatus.Size = new System.Drawing.Size(45, 17);
            this.lblElbowStatus.TabIndex = 24;
            this.lblElbowStatus.Text = "State:";
            // 
            // tbDelayElbow
            // 
            this.tbDelayElbow.Location = new System.Drawing.Point(8, 198);
            this.tbDelayElbow.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelayElbow.Name = "tbDelayElbow";
            this.tbDelayElbow.Size = new System.Drawing.Size(89, 22);
            this.tbDelayElbow.TabIndex = 11;
            this.tbDelayElbow.Text = "10";
            // 
            // tbAngleElbow
            // 
            this.tbAngleElbow.Location = new System.Drawing.Point(8, 166);
            this.tbAngleElbow.Margin = new System.Windows.Forms.Padding(4);
            this.tbAngleElbow.Name = "tbAngleElbow";
            this.tbAngleElbow.Size = new System.Drawing.Size(89, 22);
            this.tbAngleElbow.TabIndex = 10;
            this.tbAngleElbow.Text = "50";
            // 
            // btnCcwElbow
            // 
            this.btnCcwElbow.Location = new System.Drawing.Point(8, 130);
            this.btnCcwElbow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCcwElbow.Name = "btnCcwElbow";
            this.btnCcwElbow.Size = new System.Drawing.Size(159, 28);
            this.btnCcwElbow.TabIndex = 9;
            this.btnCcwElbow.Text = "CCW";
            this.btnCcwElbow.UseVisualStyleBackColor = true;
            this.btnCcwElbow.Click += new System.EventHandler(this.btnCcwElbow_Click);
            // 
            // btnCwElbow
            // 
            this.btnCwElbow.Location = new System.Drawing.Point(8, 95);
            this.btnCwElbow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCwElbow.Name = "btnCwElbow";
            this.btnCwElbow.Size = new System.Drawing.Size(159, 28);
            this.btnCwElbow.TabIndex = 8;
            this.btnCwElbow.Text = "CW";
            this.btnCwElbow.UseVisualStyleBackColor = true;
            this.btnCwElbow.Click += new System.EventHandler(this.btnCwElbow_Click);
            // 
            // btnDisableElbow
            // 
            this.btnDisableElbow.Location = new System.Drawing.Point(8, 59);
            this.btnDisableElbow.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisableElbow.Name = "btnDisableElbow";
            this.btnDisableElbow.Size = new System.Drawing.Size(159, 28);
            this.btnDisableElbow.TabIndex = 7;
            this.btnDisableElbow.Text = "Disable";
            this.btnDisableElbow.UseVisualStyleBackColor = true;
            this.btnDisableElbow.Click += new System.EventHandler(this.btnDisableElbow_Click);
            // 
            // btnEnableElbow
            // 
            this.btnEnableElbow.Location = new System.Drawing.Point(8, 23);
            this.btnEnableElbow.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnableElbow.Name = "btnEnableElbow";
            this.btnEnableElbow.Size = new System.Drawing.Size(159, 28);
            this.btnEnableElbow.TabIndex = 6;
            this.btnEnableElbow.Text = "Enable";
            this.btnEnableElbow.UseVisualStyleBackColor = true;
            this.btnEnableElbow.Click += new System.EventHandler(this.btnEnableElbow_Click);
            // 
            // gpbShoulder
            // 
            this.gpbShoulder.Controls.Add(this.lblStepsShoulder);
            this.gpbShoulder.Controls.Add(this.lblMSecShoulder);
            this.gpbShoulder.Controls.Add(this.lblShoulderStatus);
            this.gpbShoulder.Controls.Add(this.tbDelayShoulder);
            this.gpbShoulder.Controls.Add(this.tbAngleShoulder);
            this.gpbShoulder.Controls.Add(this.btnCcwShoulder);
            this.gpbShoulder.Controls.Add(this.btnCwShoulder);
            this.gpbShoulder.Controls.Add(this.btnDisableShoulder);
            this.gpbShoulder.Controls.Add(this.btnEnableShoulder);
            this.gpbShoulder.Location = new System.Drawing.Point(192, 7);
            this.gpbShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.gpbShoulder.Name = "gpbShoulder";
            this.gpbShoulder.Padding = new System.Windows.Forms.Padding(4);
            this.gpbShoulder.Size = new System.Drawing.Size(176, 388);
            this.gpbShoulder.TabIndex = 17;
            this.gpbShoulder.TabStop = false;
            this.gpbShoulder.Text = "Shoulder";
            // 
            // lblStepsShoulder
            // 
            this.lblStepsShoulder.AutoSize = true;
            this.lblStepsShoulder.Location = new System.Drawing.Point(104, 175);
            this.lblStepsShoulder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsShoulder.Name = "lblStepsShoulder";
            this.lblStepsShoulder.Size = new System.Drawing.Size(50, 17);
            this.lblStepsShoulder.TabIndex = 27;
            this.lblStepsShoulder.Text = "[steps]";
            // 
            // lblMSecShoulder
            // 
            this.lblMSecShoulder.AutoSize = true;
            this.lblMSecShoulder.Location = new System.Drawing.Point(104, 202);
            this.lblMSecShoulder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSecShoulder.Name = "lblMSecShoulder";
            this.lblMSecShoulder.Size = new System.Drawing.Size(34, 17);
            this.lblMSecShoulder.TabIndex = 26;
            this.lblMSecShoulder.Text = "[ms]";
            // 
            // lblShoulderStatus
            // 
            this.lblShoulderStatus.AutoSize = true;
            this.lblShoulderStatus.Location = new System.Drawing.Point(8, 226);
            this.lblShoulderStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShoulderStatus.Name = "lblShoulderStatus";
            this.lblShoulderStatus.Size = new System.Drawing.Size(45, 17);
            this.lblShoulderStatus.TabIndex = 23;
            this.lblShoulderStatus.Text = "State:";
            // 
            // tbDelayShoulder
            // 
            this.tbDelayShoulder.Location = new System.Drawing.Point(8, 198);
            this.tbDelayShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelayShoulder.Name = "tbDelayShoulder";
            this.tbDelayShoulder.Size = new System.Drawing.Size(87, 22);
            this.tbDelayShoulder.TabIndex = 12;
            this.tbDelayShoulder.Text = "10";
            // 
            // tbAngleShoulder
            // 
            this.tbAngleShoulder.Location = new System.Drawing.Point(8, 166);
            this.tbAngleShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.tbAngleShoulder.Name = "tbAngleShoulder";
            this.tbAngleShoulder.Size = new System.Drawing.Size(87, 22);
            this.tbAngleShoulder.TabIndex = 10;
            this.tbAngleShoulder.Text = "50";
            // 
            // btnCcwShoulder
            // 
            this.btnCcwShoulder.Location = new System.Drawing.Point(8, 130);
            this.btnCcwShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCcwShoulder.Name = "btnCcwShoulder";
            this.btnCcwShoulder.Size = new System.Drawing.Size(159, 28);
            this.btnCcwShoulder.TabIndex = 9;
            this.btnCcwShoulder.Text = "CCW";
            this.btnCcwShoulder.UseVisualStyleBackColor = true;
            this.btnCcwShoulder.Click += new System.EventHandler(this.btnCcwShoulder_Click);
            // 
            // btnCwShoulder
            // 
            this.btnCwShoulder.Location = new System.Drawing.Point(8, 95);
            this.btnCwShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCwShoulder.Name = "btnCwShoulder";
            this.btnCwShoulder.Size = new System.Drawing.Size(159, 28);
            this.btnCwShoulder.TabIndex = 8;
            this.btnCwShoulder.Text = "CW";
            this.btnCwShoulder.UseVisualStyleBackColor = true;
            this.btnCwShoulder.Click += new System.EventHandler(this.btnCwShoulder_Click);
            // 
            // btnDisableShoulder
            // 
            this.btnDisableShoulder.Location = new System.Drawing.Point(8, 59);
            this.btnDisableShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisableShoulder.Name = "btnDisableShoulder";
            this.btnDisableShoulder.Size = new System.Drawing.Size(159, 28);
            this.btnDisableShoulder.TabIndex = 7;
            this.btnDisableShoulder.Text = "Disable";
            this.btnDisableShoulder.UseVisualStyleBackColor = true;
            this.btnDisableShoulder.Click += new System.EventHandler(this.btnDisableShoulder_Click);
            // 
            // btnEnableShoulder
            // 
            this.btnEnableShoulder.Location = new System.Drawing.Point(8, 23);
            this.btnEnableShoulder.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnableShoulder.Name = "btnEnableShoulder";
            this.btnEnableShoulder.Size = new System.Drawing.Size(159, 28);
            this.btnEnableShoulder.TabIndex = 6;
            this.btnEnableShoulder.Text = "Enable";
            this.btnEnableShoulder.UseVisualStyleBackColor = true;
            this.btnEnableShoulder.Click += new System.EventHandler(this.btnEnableShoulder_Click);
            // 
            // gpbBase
            // 
            this.gpbBase.Controls.Add(this.lblStepsBase);
            this.gpbBase.Controls.Add(this.lblMSecBase);
            this.gpbBase.Controls.Add(this.lblBaseStatus);
            this.gpbBase.Controls.Add(this.tbDelayBase);
            this.gpbBase.Controls.Add(this.tbAngleBase);
            this.gpbBase.Controls.Add(this.btnCcwBase);
            this.gpbBase.Controls.Add(this.btnCwBase);
            this.gpbBase.Controls.Add(this.btnDisableBase);
            this.gpbBase.Controls.Add(this.btnEnableBase);
            this.gpbBase.Location = new System.Drawing.Point(8, 7);
            this.gpbBase.Margin = new System.Windows.Forms.Padding(4);
            this.gpbBase.Name = "gpbBase";
            this.gpbBase.Padding = new System.Windows.Forms.Padding(4);
            this.gpbBase.Size = new System.Drawing.Size(176, 388);
            this.gpbBase.TabIndex = 16;
            this.gpbBase.TabStop = false;
            this.gpbBase.Text = "Base";
            // 
            // lblStepsBase
            // 
            this.lblStepsBase.AutoSize = true;
            this.lblStepsBase.Location = new System.Drawing.Point(103, 170);
            this.lblStepsBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsBase.Name = "lblStepsBase";
            this.lblStepsBase.Size = new System.Drawing.Size(50, 17);
            this.lblStepsBase.TabIndex = 26;
            this.lblStepsBase.Text = "[steps]";
            // 
            // lblMSecBase
            // 
            this.lblMSecBase.AutoSize = true;
            this.lblMSecBase.Location = new System.Drawing.Point(103, 202);
            this.lblMSecBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSecBase.Name = "lblMSecBase";
            this.lblMSecBase.Size = new System.Drawing.Size(34, 17);
            this.lblMSecBase.TabIndex = 25;
            this.lblMSecBase.Text = "[ms]";
            // 
            // lblBaseStatus
            // 
            this.lblBaseStatus.AutoSize = true;
            this.lblBaseStatus.Location = new System.Drawing.Point(8, 226);
            this.lblBaseStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseStatus.Name = "lblBaseStatus";
            this.lblBaseStatus.Size = new System.Drawing.Size(45, 17);
            this.lblBaseStatus.TabIndex = 22;
            this.lblBaseStatus.Text = "State:";
            // 
            // tbDelayBase
            // 
            this.tbDelayBase.Location = new System.Drawing.Point(8, 198);
            this.tbDelayBase.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelayBase.Name = "tbDelayBase";
            this.tbDelayBase.Size = new System.Drawing.Size(85, 22);
            this.tbDelayBase.TabIndex = 11;
            this.tbDelayBase.Text = "10";
            // 
            // tbAngleBase
            // 
            this.tbAngleBase.Location = new System.Drawing.Point(8, 166);
            this.tbAngleBase.Margin = new System.Windows.Forms.Padding(4);
            this.tbAngleBase.Name = "tbAngleBase";
            this.tbAngleBase.Size = new System.Drawing.Size(85, 22);
            this.tbAngleBase.TabIndex = 10;
            this.tbAngleBase.Text = "50";
            // 
            // btnCcwBase
            // 
            this.btnCcwBase.Location = new System.Drawing.Point(8, 130);
            this.btnCcwBase.Margin = new System.Windows.Forms.Padding(4);
            this.btnCcwBase.Name = "btnCcwBase";
            this.btnCcwBase.Size = new System.Drawing.Size(159, 28);
            this.btnCcwBase.TabIndex = 9;
            this.btnCcwBase.Text = "CCW";
            this.btnCcwBase.UseVisualStyleBackColor = true;
            this.btnCcwBase.Click += new System.EventHandler(this.btnCcwBase_Click);
            // 
            // btnCwBase
            // 
            this.btnCwBase.Location = new System.Drawing.Point(8, 95);
            this.btnCwBase.Margin = new System.Windows.Forms.Padding(4);
            this.btnCwBase.Name = "btnCwBase";
            this.btnCwBase.Size = new System.Drawing.Size(159, 28);
            this.btnCwBase.TabIndex = 8;
            this.btnCwBase.Text = "CW";
            this.btnCwBase.UseVisualStyleBackColor = true;
            this.btnCwBase.Click += new System.EventHandler(this.btnCwBase_Click);
            // 
            // btnDisableBase
            // 
            this.btnDisableBase.Location = new System.Drawing.Point(8, 59);
            this.btnDisableBase.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisableBase.Name = "btnDisableBase";
            this.btnDisableBase.Size = new System.Drawing.Size(159, 28);
            this.btnDisableBase.TabIndex = 7;
            this.btnDisableBase.Text = "Disable";
            this.btnDisableBase.UseVisualStyleBackColor = true;
            this.btnDisableBase.Click += new System.EventHandler(this.btnDisableBase_Click);
            // 
            // btnEnableBase
            // 
            this.btnEnableBase.Location = new System.Drawing.Point(8, 23);
            this.btnEnableBase.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnableBase.Name = "btnEnableBase";
            this.btnEnableBase.Size = new System.Drawing.Size(159, 28);
            this.btnEnableBase.TabIndex = 6;
            this.btnEnableBase.Text = "Enable";
            this.btnEnableBase.UseVisualStyleBackColor = true;
            this.btnEnableBase.Click += new System.EventHandler(this.btnEnableBase_Click);
            // 
            // tpgAuto
            // 
            this.tpgAuto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpgAuto.Controls.Add(this.lblJoint);
            this.tpgAuto.Controls.Add(this.lblDelay);
            this.tpgAuto.Controls.Add(this.lblSteps);
            this.tpgAuto.Controls.Add(this.chkLoopProgram);
            this.tpgAuto.Controls.Add(this.lblProgramName);
            this.tpgAuto.Controls.Add(this.lblCommandIndex);
            this.tpgAuto.Controls.Add(this.btnResumeProgram);
            this.tpgAuto.Controls.Add(this.btnStopProgram);
            this.tpgAuto.Controls.Add(this.btnRunProgram);
            this.tpgAuto.Controls.Add(this.btnClearCommands);
            this.tpgAuto.Controls.Add(this.cmbAxis);
            this.tpgAuto.Controls.Add(this.tbSteps);
            this.tpgAuto.Controls.Add(this.tbDelay);
            this.tpgAuto.Controls.Add(this.lstCommands);
            this.tpgAuto.Controls.Add(this.lblCommand);
            this.tpgAuto.Controls.Add(this.btnAddCommand);
            this.tpgAuto.Location = new System.Drawing.Point(4, 25);
            this.tpgAuto.Margin = new System.Windows.Forms.Padding(4);
            this.tpgAuto.Name = "tpgAuto";
            this.tpgAuto.Padding = new System.Windows.Forms.Padding(4);
            this.tpgAuto.Size = new System.Drawing.Size(1352, 410);
            this.tpgAuto.TabIndex = 1;
            this.tpgAuto.Text = "Auto";
            // 
            // lblJoint
            // 
            this.lblJoint.AutoSize = true;
            this.lblJoint.Location = new System.Drawing.Point(521, 239);
            this.lblJoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoint.Name = "lblJoint";
            this.lblJoint.Size = new System.Drawing.Size(42, 17);
            this.lblJoint.TabIndex = 17;
            this.lblJoint.Text = "Joint:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(521, 304);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(48, 17);
            this.lblDelay.TabIndex = 16;
            this.lblDelay.Text = "Delay:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(521, 272);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(48, 17);
            this.lblSteps.TabIndex = 15;
            this.lblSteps.Text = "Steps:";
            // 
            // chkLoopProgram
            // 
            this.chkLoopProgram.AutoSize = true;
            this.chkLoopProgram.Location = new System.Drawing.Point(521, 166);
            this.chkLoopProgram.Margin = new System.Windows.Forms.Padding(4);
            this.chkLoopProgram.Name = "chkLoopProgram";
            this.chkLoopProgram.Size = new System.Drawing.Size(165, 21);
            this.chkLoopProgram.TabIndex = 14;
            this.chkLoopProgram.Text = "Run Program In Loop";
            this.chkLoopProgram.UseVisualStyleBackColor = true;
            this.chkLoopProgram.CheckedChanged += new System.EventHandler(this.chkLoopProgram_CheckedChanged);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(517, 7);
            this.lblProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(85, 17);
            this.lblProgramName.TabIndex = 13;
            this.lblProgramName.Text = "Program: ---";
            // 
            // lblCommandIndex
            // 
            this.lblCommandIndex.AutoSize = true;
            this.lblCommandIndex.Location = new System.Drawing.Point(517, 39);
            this.lblCommandIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandIndex.Name = "lblCommandIndex";
            this.lblCommandIndex.Size = new System.Drawing.Size(64, 17);
            this.lblCommandIndex.TabIndex = 10;
            this.lblCommandIndex.Text = "Index: ---";
            // 
            // btnResumeProgram
            // 
            this.btnResumeProgram.Location = new System.Drawing.Point(521, 95);
            this.btnResumeProgram.Margin = new System.Windows.Forms.Padding(4);
            this.btnResumeProgram.Name = "btnResumeProgram";
            this.btnResumeProgram.Size = new System.Drawing.Size(137, 28);
            this.btnResumeProgram.TabIndex = 9;
            this.btnResumeProgram.Text = "Resume";
            this.btnResumeProgram.UseVisualStyleBackColor = true;
            this.btnResumeProgram.Click += new System.EventHandler(this.btnResumeProgram_Click);
            // 
            // btnStopProgram
            // 
            this.btnStopProgram.Location = new System.Drawing.Point(521, 130);
            this.btnStopProgram.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopProgram.Name = "btnStopProgram";
            this.btnStopProgram.Size = new System.Drawing.Size(137, 28);
            this.btnStopProgram.TabIndex = 8;
            this.btnStopProgram.Text = "Stop";
            this.btnStopProgram.UseVisualStyleBackColor = true;
            this.btnStopProgram.Click += new System.EventHandler(this.btnStopProgram_Click);
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Location = new System.Drawing.Point(521, 59);
            this.btnRunProgram.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(137, 28);
            this.btnRunProgram.TabIndex = 7;
            this.btnRunProgram.Text = "Run";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // btnClearCommands
            // 
            this.btnClearCommands.Location = new System.Drawing.Point(521, 368);
            this.btnClearCommands.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearCommands.Name = "btnClearCommands";
            this.btnClearCommands.Size = new System.Drawing.Size(137, 28);
            this.btnClearCommands.TabIndex = 6;
            this.btnClearCommands.Text = "Clear";
            this.btnClearCommands.UseVisualStyleBackColor = true;
            this.btnClearCommands.Click += new System.EventHandler(this.btnClearCommands_Click);
            // 
            // cmbAxis
            // 
            this.cmbAxis.FormattingEnabled = true;
            this.cmbAxis.Location = new System.Drawing.Point(579, 235);
            this.cmbAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAxis.Name = "cmbAxis";
            this.cmbAxis.Size = new System.Drawing.Size(79, 24);
            this.cmbAxis.TabIndex = 5;
            // 
            // tbSteps
            // 
            this.tbSteps.Location = new System.Drawing.Point(579, 268);
            this.tbSteps.Margin = new System.Windows.Forms.Padding(4);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Size = new System.Drawing.Size(79, 22);
            this.tbSteps.TabIndex = 4;
            this.tbSteps.Text = "10";
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(579, 300);
            this.tbDelay.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(79, 22);
            this.tbDelay.TabIndex = 3;
            this.tbDelay.Text = "10";
            // 
            // lstCommands
            // 
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.ItemHeight = 16;
            this.lstCommands.Location = new System.Drawing.Point(8, 7);
            this.lstCommands.Margin = new System.Windows.Forms.Padding(4);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(504, 388);
            this.lstCommands.TabIndex = 2;
            this.lstCommands.SelectedIndexChanged += new System.EventHandler(this.lstCommands_SelectedIndexChanged);
            this.lstCommands.DoubleClick += new System.EventHandler(this.lstCommands_DoubleClick);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(517, 23);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(94, 17);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Command: ---";
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Location = new System.Drawing.Point(521, 332);
            this.btnAddCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(137, 28);
            this.btnAddCommand.TabIndex = 0;
            this.btnAddCommand.Text = "Add";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.gpbRemoteControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1352, 410);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Remote Contorl";
            // 
            // gpbRemoteControl
            // 
            this.gpbRemoteControl.Controls.Add(this.lblRCSlaveAddress);
            this.gpbRemoteControl.Controls.Add(this.tbRCSlaveAddress);
            this.gpbRemoteControl.Controls.Add(this.lblRCStartAddress);
            this.gpbRemoteControl.Controls.Add(this.tbRCStartAddress);
            this.gpbRemoteControl.Controls.Add(this.lblIPAddress);
            this.gpbRemoteControl.Controls.Add(this.lblIPPort);
            this.gpbRemoteControl.Controls.Add(this.tbRCIPPort);
            this.gpbRemoteControl.Controls.Add(this.tbRCIPAddress);
            this.gpbRemoteControl.Controls.Add(this.btnRCStop);
            this.gpbRemoteControl.Controls.Add(this.btnRCStart);
            this.gpbRemoteControl.Location = new System.Drawing.Point(11, 16);
            this.gpbRemoteControl.Margin = new System.Windows.Forms.Padding(4);
            this.gpbRemoteControl.Name = "gpbRemoteControl";
            this.gpbRemoteControl.Padding = new System.Windows.Forms.Padding(4);
            this.gpbRemoteControl.Size = new System.Drawing.Size(239, 233);
            this.gpbRemoteControl.TabIndex = 17;
            this.gpbRemoteControl.TabStop = false;
            this.gpbRemoteControl.Text = "MODBUS-TCP Server";
            // 
            // lblRCSlaveAddress
            // 
            this.lblRCSlaveAddress.AutoSize = true;
            this.lblRCSlaveAddress.Location = new System.Drawing.Point(4, 162);
            this.lblRCSlaveAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRCSlaveAddress.Name = "lblRCSlaveAddress";
            this.lblRCSlaveAddress.Size = new System.Drawing.Size(103, 17);
            this.lblRCSlaveAddress.TabIndex = 31;
            this.lblRCSlaveAddress.Text = "Slave Address:";
            // 
            // tbRCSlaveAddress
            // 
            this.tbRCSlaveAddress.Location = new System.Drawing.Point(116, 159);
            this.tbRCSlaveAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbRCSlaveAddress.Name = "tbRCSlaveAddress";
            this.tbRCSlaveAddress.Size = new System.Drawing.Size(107, 22);
            this.tbRCSlaveAddress.TabIndex = 30;
            this.tbRCSlaveAddress.Text = "0";
            this.tbRCSlaveAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRCStartAddress
            // 
            this.lblRCStartAddress.AutoSize = true;
            this.lblRCStartAddress.Location = new System.Drawing.Point(11, 194);
            this.lblRCStartAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRCStartAddress.Name = "lblRCStartAddress";
            this.lblRCStartAddress.Size = new System.Drawing.Size(98, 17);
            this.lblRCStartAddress.TabIndex = 29;
            this.lblRCStartAddress.Text = "Start Address:";
            // 
            // tbRCStartAddress
            // 
            this.tbRCStartAddress.Location = new System.Drawing.Point(116, 191);
            this.tbRCStartAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbRCStartAddress.Name = "tbRCStartAddress";
            this.tbRCStartAddress.Size = new System.Drawing.Size(107, 22);
            this.tbRCStartAddress.TabIndex = 28;
            this.tbRCStartAddress.Text = "1";
            this.tbRCStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(27, 98);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(80, 17);
            this.lblIPAddress.TabIndex = 26;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // lblIPPort
            // 
            this.lblIPPort.AutoSize = true;
            this.lblIPPort.Location = new System.Drawing.Point(69, 130);
            this.lblIPPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPPort.Name = "lblIPPort";
            this.lblIPPort.Size = new System.Drawing.Size(38, 17);
            this.lblIPPort.TabIndex = 25;
            this.lblIPPort.Text = "Port:";
            // 
            // tbRCIPPort
            // 
            this.tbRCIPPort.Location = new System.Drawing.Point(116, 127);
            this.tbRCIPPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbRCIPPort.Name = "tbRCIPPort";
            this.tbRCIPPort.Size = new System.Drawing.Size(107, 22);
            this.tbRCIPPort.TabIndex = 11;
            this.tbRCIPPort.Text = "502";
            this.tbRCIPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRCIPAddress
            // 
            this.tbRCIPAddress.Location = new System.Drawing.Point(116, 95);
            this.tbRCIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbRCIPAddress.Name = "tbRCIPAddress";
            this.tbRCIPAddress.Size = new System.Drawing.Size(107, 22);
            this.tbRCIPAddress.TabIndex = 10;
            this.tbRCIPAddress.Text = "127.0.0.1";
            this.tbRCIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRCStop
            // 
            this.btnRCStop.Location = new System.Drawing.Point(8, 59);
            this.btnRCStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnRCStop.Name = "btnRCStop";
            this.btnRCStop.Size = new System.Drawing.Size(216, 28);
            this.btnRCStop.TabIndex = 7;
            this.btnRCStop.Text = "Stop";
            this.btnRCStop.UseVisualStyleBackColor = true;
            this.btnRCStop.Click += new System.EventHandler(this.btnRCStop_Click);
            // 
            // btnRCStart
            // 
            this.btnRCStart.Location = new System.Drawing.Point(8, 23);
            this.btnRCStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRCStart.Name = "btnRCStart";
            this.btnRCStart.Size = new System.Drawing.Size(216, 28);
            this.btnRCStart.TabIndex = 6;
            this.btnRCStart.Text = "Start";
            this.btnRCStart.UseVisualStyleBackColor = true;
            this.btnRCStart.Click += new System.EventHandler(this.btnRCStart_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(13, 476);
            this.lstLog.Margin = new System.Windows.Forms.Padding(4);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(911, 308);
            this.lstLog.TabIndex = 28;
            this.lstLog.SelectedIndexChanged += new System.EventHandler(this.lstLog_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.Location = new System.Drawing.Point(929, 476);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(125, 20);
            this.lblMessage.TabIndex = 31;
            this.lblMessage.Text = "Command: ---";
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1360, 28);
            this.menuBar.TabIndex = 32;
            this.menuBar.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.runToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boardTypeToolStripMenuItem,
            this.portsToolStripMenuItem,
            this.mQTTToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // boardTypeToolStripMenuItem
            // 
            this.boardTypeToolStripMenuItem.Name = "boardTypeToolStripMenuItem";
            this.boardTypeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.boardTypeToolStripMenuItem.Text = "Board Type";
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.portsToolStripMenuItem.Text = "Ports";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToGitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // goToGitHubToolStripMenuItem
            // 
            this.goToGitHubToolStripMenuItem.Name = "goToGitHubToolStripMenuItem";
            this.goToGitHubToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.goToGitHubToolStripMenuItem.Text = "Go to GitHub";
            this.goToGitHubToolStripMenuItem.Click += new System.EventHandler(this.goToGitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBoardType,
            this.lblIsConnected,
            this.lblProgState,
            this.lblMotionState});
            this.statusBar.Location = new System.Drawing.Point(0, 803);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1360, 25);
            this.statusBar.TabIndex = 33;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblBoardType
            // 
            this.lblBoardType.Name = "lblBoardType";
            this.lblBoardType.Size = new System.Drawing.Size(127, 20);
            this.lblBoardType.Text = "Board Type: None";
            // 
            // lblIsConnected
            // 
            this.lblIsConnected.Name = "lblIsConnected";
            this.lblIsConnected.Size = new System.Drawing.Size(109, 20);
            this.lblIsConnected.Text = "Not Connected";
            // 
            // lblProgState
            // 
            this.lblProgState.Name = "lblProgState";
            this.lblProgState.Size = new System.Drawing.Size(143, 20);
            this.lblProgState.Text = "Program State: False";
            // 
            // lblMotionState
            // 
            this.lblMotionState.Name = "lblMotionState";
            this.lblMotionState.Size = new System.Drawing.Size(134, 20);
            this.lblMotionState.Text = "Motion State: False";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1221, 476);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 34;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // mQTTToolStripMenuItem
            // 
            this.mQTTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.mQTTToolStripMenuItem.Name = "mQTTToolStripMenuItem";
            this.mQTTToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.mQTTToolStripMenuItem.Text = "MQTT";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 828);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.tbcModes);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Robko 01 - Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbcModes.ResumeLayout(false);
            this.tpgManual.ResumeLayout(false);
            this.gpbKinematics.ResumeLayout(false);
            this.gpbKinematics.PerformLayout();
            this.gpbGripper.ResumeLayout(false);
            this.gpbGripper.PerformLayout();
            this.gpbPichRoll.ResumeLayout(false);
            this.gpbPichRoll.PerformLayout();
            this.gpbElbow.ResumeLayout(false);
            this.gpbElbow.PerformLayout();
            this.gpbShoulder.ResumeLayout(false);
            this.gpbShoulder.PerformLayout();
            this.gpbBase.ResumeLayout(false);
            this.gpbBase.PerformLayout();
            this.tpgAuto.ResumeLayout(false);
            this.tpgAuto.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.gpbRemoteControl.ResumeLayout(false);
            this.gpbRemoteControl.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcModes;
        private System.Windows.Forms.TabPage tpgManual;
        private System.Windows.Forms.TabPage tpgAuto;
        private System.Windows.Forms.GroupBox gpbGripper;
        private System.Windows.Forms.TextBox tbDelayGripper;
        private System.Windows.Forms.TextBox tbAngleGripper;
        private System.Windows.Forms.Button btnCcwGripper;
        private System.Windows.Forms.Button btnCwGripper;
        private System.Windows.Forms.Button btnDisableGripper;
        private System.Windows.Forms.Button btnEnableGripper;
        private System.Windows.Forms.GroupBox gpbPichRoll;
        private System.Windows.Forms.TextBox tbDelayPichRoll;
        private System.Windows.Forms.Button btnCcwRoll;
        private System.Windows.Forms.Button btnCwRoll;
        private System.Windows.Forms.TextBox tbAnglePichRoll;
        private System.Windows.Forms.Button btnCCWPich;
        private System.Windows.Forms.Button btnCWPich;
        private System.Windows.Forms.Button btnDisablePichRoll;
        private System.Windows.Forms.Button btnEnablePichRoll;
        private System.Windows.Forms.GroupBox gpbElbow;
        private System.Windows.Forms.TextBox tbDelayElbow;
        private System.Windows.Forms.TextBox tbAngleElbow;
        private System.Windows.Forms.Button btnCcwElbow;
        private System.Windows.Forms.Button btnCwElbow;
        private System.Windows.Forms.Button btnDisableElbow;
        private System.Windows.Forms.Button btnEnableElbow;
        private System.Windows.Forms.GroupBox gpbShoulder;
        private System.Windows.Forms.TextBox tbDelayShoulder;
        private System.Windows.Forms.TextBox tbAngleShoulder;
        private System.Windows.Forms.Button btnCcwShoulder;
        private System.Windows.Forms.Button btnCwShoulder;
        private System.Windows.Forms.Button btnDisableShoulder;
        private System.Windows.Forms.Button btnEnableShoulder;
        private System.Windows.Forms.GroupBox gpbBase;
        private System.Windows.Forms.TextBox tbDelayBase;
        private System.Windows.Forms.TextBox tbAngleBase;
        private System.Windows.Forms.Button btnCcwBase;
        private System.Windows.Forms.Button btnCwBase;
        private System.Windows.Forms.Button btnDisableBase;
        private System.Windows.Forms.Button btnEnableBase;
        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.ComboBox cmbAxis;
        private System.Windows.Forms.TextBox tbSteps;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Button btnClearCommands;
        private System.Windows.Forms.Button btnResumeProgram;
        private System.Windows.Forms.Button btnStopProgram;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label lblCommandIndex;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkLoopProgram;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblGripperStatus;
        private System.Windows.Forms.Label lblRightStatus;
        private System.Windows.Forms.Label lblLeftDifferentStatus;
        private System.Windows.Forms.Label lblElbowStatus;
        private System.Windows.Forms.Label lblShoulderStatus;
        private System.Windows.Forms.Label lblBaseStatus;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblIsConnected;
        private System.Windows.Forms.ToolStripStatusLabel lblProgState;
        private System.Windows.Forms.ToolStripStatusLabel lblMotionState;
        private System.Windows.Forms.Label lblJoint;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox gpbKinematics;
        private System.Windows.Forms.Button btnCalcForward;
        private System.Windows.Forms.TextBox tbRdeg;
        private System.Windows.Forms.TextBox tbPdeg;
        private System.Windows.Forms.TextBox tbZmm;
        private System.Windows.Forms.TextBox tbYmm;
        private System.Windows.Forms.TextBox tbXmm;
        private System.Windows.Forms.Label lblRdeg;
        private System.Windows.Forms.Label lblPdeg;
        private System.Windows.Forms.Label lblZmm;
        private System.Windows.Forms.Label lblYmm;
        private System.Windows.Forms.Label lblXmm;
        private System.Windows.Forms.Label lblTheta5;
        private System.Windows.Forms.Label lblTheta4;
        private System.Windows.Forms.Label lblTheta3;
        private System.Windows.Forms.Label lblTheta2;
        private System.Windows.Forms.Label lblTheta1;
        private System.Windows.Forms.TextBox tbTheta5;
        private System.Windows.Forms.TextBox tbTheta4;
        private System.Windows.Forms.TextBox tbTheta3;
        private System.Windows.Forms.TextBox tbTheta2;
        private System.Windows.Forms.TextBox tbTheta1;
        private System.Windows.Forms.Button btnCalcInvers;
        private System.Windows.Forms.ToolStripMenuItem boardTypeToolStripMenuItem;
        private System.Windows.Forms.Label lblMSecGripper;
        private System.Windows.Forms.Label lblMSecPichRoll;
        private System.Windows.Forms.Label lblMSecElbow;
        private System.Windows.Forms.Label lblMSecShoulder;
        private System.Windows.Forms.Label lblMSecBase;
        private System.Windows.Forms.Label lblStepsShoulder;
        private System.Windows.Forms.Label lblStepsBase;
        private System.Windows.Forms.Label lblStepsElbow;
        private System.Windows.Forms.Label lblStepsGripper;
        private System.Windows.Forms.Label lblStepsPichRoll;
        private System.Windows.Forms.ToolStripStatusLabel lblBoardType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpbRemoteControl;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblIPPort;
        private System.Windows.Forms.TextBox tbRCIPPort;
        private System.Windows.Forms.TextBox tbRCIPAddress;
        private System.Windows.Forms.Button btnRCStop;
        private System.Windows.Forms.Button btnRCStart;
        private System.Windows.Forms.Label lblRCStartAddress;
        private System.Windows.Forms.TextBox tbRCStartAddress;
        private System.Windows.Forms.Label lblRCSlaveAddress;
        private System.Windows.Forms.TextBox tbRCSlaveAddress;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mQTTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

