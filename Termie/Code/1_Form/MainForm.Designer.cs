namespace Termie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBreath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRPMLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRPMRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SettingButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.IntervalComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnLogStop = new System.Windows.Forms.Button();
            this.btnLogStart = new System.Windows.Forms.Button();
            this.LogPathBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChartRPM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChartBreath = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRPM)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPressure)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBreath)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTime,
            this.colBreath,
            this.colPressure,
            this.colRPMLeft,
            this.colRPMRight});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Location = new System.Drawing.Point(980, 121);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(358, 702);
            this.dataGridView.TabIndex = 15;
            // 
            // ColTime
            // 
            this.ColTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTime.HeaderText = "Time(sec)";
            this.ColTime.Name = "ColTime";
            // 
            // colBreath
            // 
            this.colBreath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBreath.HeaderText = "Breath";
            this.colBreath.Name = "colBreath";
            // 
            // colPressure
            // 
            this.colPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPressure.HeaderText = "Pressure";
            this.colPressure.Name = "colPressure";
            // 
            // colRPMLeft
            // 
            this.colRPMLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRPMLeft.HeaderText = "LRPM";
            this.colRPMLeft.Name = "colRPMLeft";
            // 
            // colRPMRight
            // 
            this.colRPMRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRPMRight.HeaderText = "RRPM";
            this.colRPMRight.Name = "colRPMRight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sampling Interval [ms]";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(173, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 25);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Connection State";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(1187, 46);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(127, 34);
            this.SettingButton.TabIndex = 12;
            this.SettingButton.Text = "Setting";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(11, 29);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(63, 50);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.IntervalComboBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.SettingButton);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.ResetButton);
            this.groupBox4.Controls.Add(this.StartButton);
            this.groupBox4.Location = new System.Drawing.Point(14, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1320, 99);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Measurement Control";
            // 
            // IntervalComboBox
            // 
            this.IntervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IntervalComboBox.FormattingEnabled = true;
            this.IntervalComboBox.Location = new System.Drawing.Point(327, 55);
            this.IntervalComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntervalComboBox.Name = "IntervalComboBox";
            this.IntervalComboBox.Size = new System.Drawing.Size(66, 23);
            this.IntervalComboBox.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPath);
            this.groupBox6.Controls.Add(this.btnLogStop);
            this.groupBox6.Controls.Add(this.btnLogStart);
            this.groupBox6.Controls.Add(this.LogPathBox);
            this.groupBox6.Location = new System.Drawing.Point(409, 25);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(772, 61);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Logging";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(0, 22);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(56, 26);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogStop
            // 
            this.btnLogStop.Location = new System.Drawing.Point(707, 22);
            this.btnLogStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogStop.Name = "btnLogStop";
            this.btnLogStop.Size = new System.Drawing.Size(59, 29);
            this.btnLogStop.TabIndex = 6;
            this.btnLogStop.Text = "Stop";
            this.btnLogStop.UseVisualStyleBackColor = true;
            this.btnLogStop.Click += new System.EventHandler(this.btnLogStop_Click);
            // 
            // btnLogStart
            // 
            this.btnLogStart.Location = new System.Drawing.Point(642, 22);
            this.btnLogStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogStart.Name = "btnLogStart";
            this.btnLogStart.Size = new System.Drawing.Size(59, 29);
            this.btnLogStart.TabIndex = 2;
            this.btnLogStart.Text = "Start";
            this.btnLogStart.UseVisualStyleBackColor = true;
            this.btnLogStart.Click += new System.EventHandler(this.btnLogStart_Click);
            // 
            // LogPathBox
            // 
            this.LogPathBox.Location = new System.Drawing.Point(62, 24);
            this.LogPathBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogPathBox.Name = "LogPathBox";
            this.LogPathBox.Size = new System.Drawing.Size(574, 25);
            this.LogPathBox.TabIndex = 0;
            this.LogPathBox.Text = Settings.Option.LogFilePath;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(83, 29);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(63, 50);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChartRPM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(960, 175);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // ChartRPM
            // 
            chartArea4.Name = "RPM";
            this.ChartRPM.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartRPM.Legends.Add(legend4);
            this.ChartRPM.Location = new System.Drawing.Point(167, 21);
            this.ChartRPM.Name = "ChartRPM";
            this.ChartRPM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartRPM.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue};
            series5.ChartArea = "RPM";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "LRPM";
            series6.ChartArea = "RPM";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "RRPM";
            this.ChartRPM.Series.Add(series5);
            this.ChartRPM.Series.Add(series6);
            this.ChartRPM.Size = new System.Drawing.Size(776, 154);
            this.ChartRPM.TabIndex = 15;
            this.ChartRPM.Text = "RPMs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(94, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "RPM";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ChartPressure);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(14, 652);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(960, 175);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // ChartPressure
            // 
            chartArea5.Name = "Pressure";
            this.ChartPressure.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ChartPressure.Legends.Add(legend5);
            this.ChartPressure.Location = new System.Drawing.Point(167, 25);
            this.ChartPressure.Name = "ChartPressure";
            this.ChartPressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartPressure.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series7.ChartArea = "Pressure";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Pressure";
            this.ChartPressure.Series.Add(series7);
            this.ChartPressure.Size = new System.Drawing.Size(776, 143);
            this.ChartPressure.TabIndex = 15;
            this.ChartPressure.Text = "Pressure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(77, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "7.890";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pressure";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChartBreath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(960, 375);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ChartBreath
            // 
            chartArea6.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea6.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea6.Name = "Breath";
            this.ChartBreath.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartBreath.Legends.Add(legend6);
            this.ChartBreath.Location = new System.Drawing.Point(167, 25);
            this.ChartBreath.Name = "ChartBreath";
            this.ChartBreath.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartBreath.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))))};
            this.ChartBreath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series8.ChartArea = "Breath";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Breath";
            this.ChartBreath.Series.Add(series8);
            this.ChartBreath.Size = new System.Drawing.Size(776, 350);
            this.ChartBreath.TabIndex = 13;
            this.ChartBreath.Text = "Breath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(70, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "3.456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Breath";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1346, 841);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRPM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPressure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBreath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLogStart;
        private System.Windows.Forms.TextBox LogPathBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button btnLogStop;

        private System.Windows.Forms.ComboBox IntervalComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartRPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPressure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBreath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBreath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPMLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPMRight;
        private System.Windows.Forms.Button btnPath;
    }
}