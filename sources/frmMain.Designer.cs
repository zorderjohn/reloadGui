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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chartTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBootloader = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.tmrSetCurrent = new System.Windows.Forms.Timer(this.components);
            this.grpConn.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonitorInterval)).BeginInit();
            this.grpMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
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
            this.grpControlPanel.Controls.Add(this.btnZero);
            this.grpControlPanel.Controls.Add(this.btnDec1000);
            this.grpControlPanel.Controls.Add(this.btnDec100);
            this.grpControlPanel.Controls.Add(this.btnDec10);
            this.grpControlPanel.Controls.Add(this.btnBootloader);
            this.grpControlPanel.Controls.Add(this.btnInc1000);
            this.grpControlPanel.Controls.Add(this.btnInc100);
            this.grpControlPanel.Controls.Add(this.btnInc10);
            this.grpControlPanel.Controls.Add(this.numSetCurrent);
            this.grpControlPanel.Controls.Add(this.lblSetCurrent);
            this.grpControlPanel.Controls.Add(this.lblSetCurrentT);
            this.grpControlPanel.Enabled = false;
            this.grpControlPanel.Location = new System.Drawing.Point(12, 150);
            this.grpControlPanel.Name = "grpControlPanel";
            this.grpControlPanel.Size = new System.Drawing.Size(194, 290);
            this.grpControlPanel.TabIndex = 3;
            this.grpControlPanel.TabStop = false;
            this.grpControlPanel.Text = "Control Panel";
            // 
            // prgAutoSet
            // 
            this.prgAutoSet.Location = new System.Drawing.Point(119, 174);
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
            this.chkAutoSet.Location = new System.Drawing.Point(11, 176);
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
            this.btnSetCurrent.Location = new System.Drawing.Point(119, 144);
            this.btnSetCurrent.Name = "btnSetCurrent";
            this.btnSetCurrent.Size = new System.Drawing.Size(44, 23);
            this.btnSetCurrent.TabIndex = 4;
            this.btnSetCurrent.Text = "Set";
            this.btnSetCurrent.UseVisualStyleBackColor = true;
            this.btnSetCurrent.Click += new System.EventHandler(this.btnSetCurrent_Click);
            // 
            // btnDec1000
            // 
            this.btnDec1000.Location = new System.Drawing.Point(107, 228);
            this.btnDec1000.Name = "btnDec1000";
            this.btnDec1000.Size = new System.Drawing.Size(57, 23);
            this.btnDec1000.TabIndex = 3;
            this.btnDec1000.Text = "-1000";
            this.btnDec1000.UseVisualStyleBackColor = true;
            this.btnDec1000.Click += new System.EventHandler(this.btnDec1000_Click);
            // 
            // btnDec100
            // 
            this.btnDec100.Location = new System.Drawing.Point(59, 228);
            this.btnDec100.Name = "btnDec100";
            this.btnDec100.Size = new System.Drawing.Size(42, 23);
            this.btnDec100.TabIndex = 3;
            this.btnDec100.Text = "-100";
            this.btnDec100.UseVisualStyleBackColor = true;
            this.btnDec100.Click += new System.EventHandler(this.btnDec100_Click);
            // 
            // btnDec10
            // 
            this.btnDec10.Location = new System.Drawing.Point(11, 228);
            this.btnDec10.Name = "btnDec10";
            this.btnDec10.Size = new System.Drawing.Size(42, 23);
            this.btnDec10.TabIndex = 3;
            this.btnDec10.Text = "-10";
            this.btnDec10.UseVisualStyleBackColor = true;
            this.btnDec10.Click += new System.EventHandler(this.btnDec10_Click);
            // 
            // btnInc1000
            // 
            this.btnInc1000.Location = new System.Drawing.Point(107, 199);
            this.btnInc1000.Name = "btnInc1000";
            this.btnInc1000.Size = new System.Drawing.Size(57, 23);
            this.btnInc1000.TabIndex = 2;
            this.btnInc1000.Text = "+1000";
            this.btnInc1000.UseVisualStyleBackColor = true;
            this.btnInc1000.Click += new System.EventHandler(this.btnInc1000_Click);
            // 
            // btnInc100
            // 
            this.btnInc100.Location = new System.Drawing.Point(59, 199);
            this.btnInc100.Name = "btnInc100";
            this.btnInc100.Size = new System.Drawing.Size(42, 23);
            this.btnInc100.TabIndex = 2;
            this.btnInc100.Text = "+100";
            this.btnInc100.UseVisualStyleBackColor = true;
            this.btnInc100.Click += new System.EventHandler(this.btnInc100_Click);
            // 
            // btnInc10
            // 
            this.btnInc10.Location = new System.Drawing.Point(11, 199);
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
            this.numSetCurrent.Location = new System.Drawing.Point(11, 144);
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
            this.lblSetCurrent.Location = new System.Drawing.Point(92, 146);
            this.lblSetCurrent.Name = "lblSetCurrent";
            this.lblSetCurrent.Size = new System.Drawing.Size(21, 19);
            this.lblSetCurrent.TabIndex = 0;
            this.lblSetCurrent.Text = "A";
            // 
            // lblSetCurrentT
            // 
            this.lblSetCurrentT.AutoSize = true;
            this.lblSetCurrentT.Location = new System.Drawing.Point(8, 16);
            this.lblSetCurrentT.Name = "lblSetCurrentT";
            this.lblSetCurrentT.Size = new System.Drawing.Size(62, 13);
            this.lblSetCurrentT.TabIndex = 0;
            this.lblSetCurrentT.Text = "Commands:";
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
            this.numMonitorInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMonitorInterval.Name = "numMonitorInterval";
            this.numMonitorInterval.Size = new System.Drawing.Size(56, 20);
            this.numMonitorInterval.TabIndex = 11;
            this.numMonitorInterval.Value = new decimal(new int[] {
            100,
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
            this.grpMonitor.Location = new System.Drawing.Point(12, 446);
            this.grpMonitor.Name = "grpMonitor";
            this.grpMonitor.Size = new System.Drawing.Size(194, 153);
            this.grpMonitor.TabIndex = 4;
            this.grpMonitor.TabStop = false;
            this.grpMonitor.Text = "Monitor";
            // 
            // chartTime
            // 
            this.chartTime.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Volts";
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.Maximum = 5D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.AxisY2.Title = "Amps";
            chartArea1.Name = "ChartArea1";
            this.chartTime.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chartTime.Legends.Add(legend1);
            this.chartTime.Location = new System.Drawing.Point(6, 48);
            this.chartTime.Margin = new System.Windows.Forms.Padding(2);
            this.chartTime.Name = "chartTime";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Voltage";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Intensity";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "SetIntensity";
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Power";
            this.chartTime.Series.Add(series1);
            this.chartTime.Series.Add(series2);
            this.chartTime.Series.Add(series3);
            this.chartTime.Series.Add(series4);
            this.chartTime.Size = new System.Drawing.Size(529, 390);
            this.chartTime.TabIndex = 5;
            this.chartTime.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chartTime);
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 489);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(212, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 587);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "X/Y";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBootloader
            // 
            this.btnBootloader.Location = new System.Drawing.Point(10, 32);
            this.btnBootloader.Name = "btnBootloader";
            this.btnBootloader.Size = new System.Drawing.Size(74, 23);
            this.btnBootloader.TabIndex = 2;
            this.btnBootloader.Text = "Bootloader";
            this.btnBootloader.UseVisualStyleBackColor = true;
            this.btnBootloader.Click += new System.EventHandler(this.btnBootloader_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(42, 257);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(101, 23);
            this.btnZero.TabIndex = 3;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // tmrSetCurrent
            // 
            this.tmrSetCurrent.Enabled = true;
            this.tmrSetCurrent.Interval = 500;
            this.tmrSetCurrent.Tick += new System.EventHandler(this.tmrSetCurrent_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 649);
            this.Controls.Add(this.tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBootloader;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Timer tmrSetCurrent;
    }
}

