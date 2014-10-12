namespace ReloadGUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.grpConn = new System.Windows.Forms.GroupBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionT = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpControlPanel = new System.Windows.Forms.GroupBox();
            this.prgAutoSet = new System.Windows.Forms.ProgressBar();
            this.chkAutoSet = new System.Windows.Forms.CheckBox();
            this.btnSetCurrent = new System.Windows.Forms.Button();
            this.btnDec1000 = new System.Windows.Forms.Button();
            this.btnDec100 = new System.Windows.Forms.Button();
            this.btnDec10 = new System.Windows.Forms.Button();
            this.btnInc1000 = new System.Windows.Forms.Button();
            this.btnInc100 = new System.Windows.Forms.Button();
            this.btnInc10 = new System.Windows.Forms.Button();
            this.numSetCurrent = new System.Windows.Forms.NumericUpDown();
            this.lblSetCurrent = new System.Windows.Forms.Label();
            this.lblSetCurrentT = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.LblPowerT = new System.Windows.Forms.Label();
            this.lblVolt = new System.Windows.Forms.Label();
            this.lblVoltT = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrentT = new System.Windows.Forms.Label();
            this.tmrAutoSet = new System.Windows.Forms.Timer(this.components);
            this.btnRead = new System.Windows.Forms.Button();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.numMonitorInterval = new System.Windows.Forms.NumericUpDown();
            this.lblMs = new System.Windows.Forms.Label();
            this.grpMonitor = new System.Windows.Forms.GroupBox();
            this.grpConn.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonitorInterval)).BeginInit();
            this.grpMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConn
            // 
            this.grpConn.Controls.Add(this.cmbPort);
            this.grpConn.Controls.Add(this.btnConnect);
            this.grpConn.Controls.Add(this.lblPort);
            this.grpConn.Location = new System.Drawing.Point(12, 12);
            this.grpConn.Name = "grpConn";
            this.grpConn.Size = new System.Drawing.Size(194, 66);
            this.grpConn.TabIndex = 0;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "Connection";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(42, 26);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(66, 21);
            this.cmbPort.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(114, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(7, 29);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblVersion);
            this.grpInfo.Controls.Add(this.lblVersionT);
            this.grpInfo.Location = new System.Drawing.Point(12, 84);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(194, 60);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(69, 30);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(25, 13);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "x.xx";
            // 
            // lblVersionT
            // 
            this.lblVersionT.AutoSize = true;
            this.lblVersionT.Location = new System.Drawing.Point(10, 30);
            this.lblVersionT.Name = "lblVersionT";
            this.lblVersionT.Size = new System.Drawing.Size(61, 13);
            this.lblVersionT.TabIndex = 0;
            this.lblVersionT.Text = "Fw version:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(79, 17);
            this.status.Text = "Disconnected";
            // 
            // grpControlPanel
            // 
            this.grpControlPanel.Controls.Add(this.prgAutoSet);
            this.grpControlPanel.Controls.Add(this.chkAutoSet);
            this.grpControlPanel.Controls.Add(this.btnSetCurrent);
            this.grpControlPanel.Controls.Add(this.btnDec1000);
            this.grpControlPanel.Controls.Add(this.btnDec100);
            this.grpControlPanel.Controls.Add(this.btnDec10);
            this.grpControlPanel.Controls.Add(this.btnInc1000);
            this.grpControlPanel.Controls.Add(this.btnInc100);
            this.grpControlPanel.Controls.Add(this.btnInc10);
            this.grpControlPanel.Controls.Add(this.numSetCurrent);
            this.grpControlPanel.Controls.Add(this.lblSetCurrent);
            this.grpControlPanel.Controls.Add(this.lblSetCurrentT);
            this.grpControlPanel.Enabled = false;
            this.grpControlPanel.Location = new System.Drawing.Point(12, 150);
            this.grpControlPanel.Name = "grpControlPanel";
            this.grpControlPanel.Size = new System.Drawing.Size(194, 161);
            this.grpControlPanel.TabIndex = 3;
            this.grpControlPanel.TabStop = false;
            this.grpControlPanel.Text = "Control Panel";
            // 
            // prgAutoSet
            // 
            this.prgAutoSet.Location = new System.Drawing.Point(117, 71);
            this.prgAutoSet.MarqueeAnimationSpeed = 0;
            this.prgAutoSet.Maximum = 10;
            this.prgAutoSet.Name = "prgAutoSet";
            this.prgAutoSet.Size = new System.Drawing.Size(45, 19);
            this.prgAutoSet.Step = 1;
            this.prgAutoSet.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgAutoSet.TabIndex = 8;
            this.prgAutoSet.Value = 10;
            this.prgAutoSet.Visible = false;
            // 
            // chkAutoSet
            // 
            this.chkAutoSet.AutoSize = true;
            this.chkAutoSet.Location = new System.Drawing.Point(9, 73);
            this.chkAutoSet.Name = "chkAutoSet";
            this.chkAutoSet.Size = new System.Drawing.Size(65, 17);
            this.chkAutoSet.TabIndex = 5;
            this.chkAutoSet.Text = "Auto-set";
            this.chkAutoSet.UseVisualStyleBackColor = true;
            this.chkAutoSet.CheckedChanged += new System.EventHandler(this.chkAutoSet_CheckedChanged);
            // 
            // btnSetCurrent
            // 
            this.btnSetCurrent.Enabled = false;
            this.btnSetCurrent.Location = new System.Drawing.Point(117, 41);
            this.btnSetCurrent.Name = "btnSetCurrent";
            this.btnSetCurrent.Size = new System.Drawing.Size(44, 23);
            this.btnSetCurrent.TabIndex = 4;
            this.btnSetCurrent.Text = "Set";
            this.btnSetCurrent.UseVisualStyleBackColor = true;
            this.btnSetCurrent.Click += new System.EventHandler(this.btnSetCurrent_Click);
            // 
            // btnDec1000
            // 
            this.btnDec1000.Location = new System.Drawing.Point(105, 125);
            this.btnDec1000.Name = "btnDec1000";
            this.btnDec1000.Size = new System.Drawing.Size(57, 23);
            this.btnDec1000.TabIndex = 3;
            this.btnDec1000.Text = "-1000";
            this.btnDec1000.UseVisualStyleBackColor = true;
            this.btnDec1000.Click += new System.EventHandler(this.btnDec1000_Click);
            // 
            // btnDec100
            // 
            this.btnDec100.Location = new System.Drawing.Point(57, 125);
            this.btnDec100.Name = "btnDec100";
            this.btnDec100.Size = new System.Drawing.Size(42, 23);
            this.btnDec100.TabIndex = 3;
            this.btnDec100.Text = "-100";
            this.btnDec100.UseVisualStyleBackColor = true;
            this.btnDec100.Click += new System.EventHandler(this.btnDec100_Click);
            // 
            // btnDec10
            // 
            this.btnDec10.Location = new System.Drawing.Point(9, 125);
            this.btnDec10.Name = "btnDec10";
            this.btnDec10.Size = new System.Drawing.Size(42, 23);
            this.btnDec10.TabIndex = 3;
            this.btnDec10.Text = "-10";
            this.btnDec10.UseVisualStyleBackColor = true;
            this.btnDec10.Click += new System.EventHandler(this.btnDec10_Click);
            // 
            // btnInc1000
            // 
            this.btnInc1000.Location = new System.Drawing.Point(105, 96);
            this.btnInc1000.Name = "btnInc1000";
            this.btnInc1000.Size = new System.Drawing.Size(57, 23);
            this.btnInc1000.TabIndex = 2;
            this.btnInc1000.Text = "+1000";
            this.btnInc1000.UseVisualStyleBackColor = true;
            this.btnInc1000.Click += new System.EventHandler(this.btnInc1000_Click);
            // 
            // btnInc100
            // 
            this.btnInc100.Location = new System.Drawing.Point(57, 96);
            this.btnInc100.Name = "btnInc100";
            this.btnInc100.Size = new System.Drawing.Size(42, 23);
            this.btnInc100.TabIndex = 2;
            this.btnInc100.Text = "+100";
            this.btnInc100.UseVisualStyleBackColor = true;
            this.btnInc100.Click += new System.EventHandler(this.btnInc100_Click);
            // 
            // btnInc10
            // 
            this.btnInc10.Location = new System.Drawing.Point(9, 96);
            this.btnInc10.Name = "btnInc10";
            this.btnInc10.Size = new System.Drawing.Size(42, 23);
            this.btnInc10.TabIndex = 2;
            this.btnInc10.Text = "+10";
            this.btnInc10.UseVisualStyleBackColor = true;
            this.btnInc10.Click += new System.EventHandler(this.btnInc10_Click);
            // 
            // numSetCurrent
            // 
            this.numSetCurrent.DecimalPlaces = 3;
            this.numSetCurrent.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSetCurrent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numSetCurrent.Location = new System.Drawing.Point(9, 41);
            this.numSetCurrent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSetCurrent.Name = "numSetCurrent";
            this.numSetCurrent.Size = new System.Drawing.Size(81, 26);
            this.numSetCurrent.TabIndex = 1;
            this.numSetCurrent.Tag = "";
            this.numSetCurrent.ValueChanged += new System.EventHandler(this.numSetCurrent_ValueChanged);
            this.numSetCurrent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSetCurrent_KeyDown);
            // 
            // lblSetCurrent
            // 
            this.lblSetCurrent.AutoSize = true;
            this.lblSetCurrent.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetCurrent.Location = new System.Drawing.Point(90, 43);
            this.lblSetCurrent.Name = "lblSetCurrent";
            this.lblSetCurrent.Size = new System.Drawing.Size(21, 19);
            this.lblSetCurrent.TabIndex = 0;
            this.lblSetCurrent.Text = "A";
            // 
            // lblSetCurrentT
            // 
            this.lblSetCurrentT.AutoSize = true;
            this.lblSetCurrentT.Location = new System.Drawing.Point(6, 25);
            this.lblSetCurrentT.Name = "lblSetCurrentT";
            this.lblSetCurrentT.Size = new System.Drawing.Size(62, 13);
            this.lblSetCurrentT.TabIndex = 0;
            this.lblSetCurrentT.Text = "Set current:";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(9, 126);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(80, 19);
            this.lblPower.TabIndex = 6;
            this.lblPower.Text = "0.000 W";
            // 
            // LblPowerT
            // 
            this.LblPowerT.AutoSize = true;
            this.LblPowerT.Location = new System.Drawing.Point(9, 113);
            this.LblPowerT.Name = "LblPowerT";
            this.LblPowerT.Size = new System.Drawing.Size(38, 13);
            this.LblPowerT.TabIndex = 7;
            this.LblPowerT.Text = "Watts:";
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.Location = new System.Drawing.Point(107, 91);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(75, 19);
            this.lblVolt.TabIndex = 0;
            this.lblVolt.Text = "0.000 V";
            // 
            // lblVoltT
            // 
            this.lblVoltT.AutoSize = true;
            this.lblVoltT.Location = new System.Drawing.Point(107, 78);
            this.lblVoltT.Name = "lblVoltT";
            this.lblVoltT.Size = new System.Drawing.Size(46, 13);
            this.lblVoltT.TabIndex = 0;
            this.lblVoltT.Text = "Voltage:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(9, 91);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(75, 19);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "0.000 A";
            // 
            // lblCurrentT
            // 
            this.lblCurrentT.AutoSize = true;
            this.lblCurrentT.Location = new System.Drawing.Point(9, 78);
            this.lblCurrentT.Name = "lblCurrentT";
            this.lblCurrentT.Size = new System.Drawing.Size(44, 13);
            this.lblCurrentT.TabIndex = 0;
            this.lblCurrentT.Text = "Current:";
            // 
            // tmrAutoSet
            // 
            this.tmrAutoSet.Tick += new System.EventHandler(this.tmrAutoSet_Tick);
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Location = new System.Drawing.Point(9, 44);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Manual Update";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Checked = true;
            this.chkMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonitor.Location = new System.Drawing.Point(9, 21);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(90, 17);
            this.chkMonitor.TabIndex = 10;
            this.chkMonitor.Text = "Monitor mode";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // numMonitorInterval
            // 
            this.numMonitorInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMonitorInterval.Location = new System.Drawing.Point(107, 19);
            this.numMonitorInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMonitorInterval.Name = "numMonitorInterval";
            this.numMonitorInterval.Size = new System.Drawing.Size(56, 20);
            this.numMonitorInterval.TabIndex = 11;
            this.numMonitorInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMonitorInterval.ValueChanged += new System.EventHandler(this.numMonitorInterval_ValueChanged);
            // 
            // lblMs
            // 
            this.lblMs.AutoSize = true;
            this.lblMs.Location = new System.Drawing.Point(169, 21);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(20, 13);
            this.lblMs.TabIndex = 0;
            this.lblMs.Text = "ms";
            // 
            // grpMonitor
            // 
            this.grpMonitor.Controls.Add(this.numMonitorInterval);
            this.grpMonitor.Controls.Add(this.chkMonitor);
            this.grpMonitor.Controls.Add(this.lblCurrentT);
            this.grpMonitor.Controls.Add(this.btnRead);
            this.grpMonitor.Controls.Add(this.lblMs);
            this.grpMonitor.Controls.Add(this.lblCurrent);
            this.grpMonitor.Controls.Add(this.lblPower);
            this.grpMonitor.Controls.Add(this.lblVoltT);
            this.grpMonitor.Controls.Add(this.LblPowerT);
            this.grpMonitor.Controls.Add(this.lblVolt);
            this.grpMonitor.Location = new System.Drawing.Point(12, 317);
            this.grpMonitor.Name = "grpMonitor";
            this.grpMonitor.Size = new System.Drawing.Size(194, 153);
            this.grpMonitor.TabIndex = 4;
            this.grpMonitor.TabStop = false;
            this.grpMonitor.Text = "Monitor";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 496);
            this.Controls.Add(this.grpMonitor);
            this.Controls.Add(this.grpControlPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpConn);
            this.Name = "frmMain";
            this.Text = "Re:load Pro GUI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpConn.ResumeLayout(false);
            this.grpConn.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpControlPanel.ResumeLayout(false);
            this.grpControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonitorInterval)).EndInit();
            this.grpMonitor.ResumeLayout(false);
            this.grpMonitor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConn;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.GroupBox grpControlPanel;
        private System.Windows.Forms.Label lblSetCurrent;
        private System.Windows.Forms.Label lblSetCurrentT;
        private System.Windows.Forms.CheckBox chkAutoSet;
        private System.Windows.Forms.Button btnSetCurrent;
        private System.Windows.Forms.Button btnDec1000;
        private System.Windows.Forms.Button btnDec100;
        private System.Windows.Forms.Button btnDec10;
        private System.Windows.Forms.Button btnInc1000;
        private System.Windows.Forms.Button btnInc100;
        private System.Windows.Forms.Button btnInc10;
        private System.Windows.Forms.NumericUpDown numSetCurrent;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.Label lblVoltT;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCurrentT;
        private System.Windows.Forms.ProgressBar prgAutoSet;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label LblPowerT;
        private System.Windows.Forms.Timer tmrAutoSet;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.NumericUpDown numMonitorInterval;
        private System.Windows.Forms.Label lblMs;
        private System.Windows.Forms.GroupBox grpMonitor;
    }
}

