namespace Lab1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numArea = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resultTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultDistance = new System.Windows.Forms.Label();
            this.resultMaxHeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultSpeedEndPoint = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // numHeight
            // 
            this.numHeight.DecimalPlaces = 2;
            this.numHeight.Location = new System.Drawing.Point(120, 33);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 22);
            this.numHeight.TabIndex = 2;
            // 
            // numAngle
            // 
            this.numAngle.DecimalPlaces = 2;
            this.numAngle.Location = new System.Drawing.Point(120, 77);
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(120, 22);
            this.numAngle.TabIndex = 4;
            this.numAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle";
            // 
            // numWeight
            // 
            this.numWeight.DecimalPlaces = 2;
            this.numWeight.Location = new System.Drawing.Point(387, 77);
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 22);
            this.numWeight.TabIndex = 8;
            this.numWeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight";
            // 
            // numSpeed
            // 
            this.numSpeed.DecimalPlaces = 2;
            this.numSpeed.Location = new System.Drawing.Point(387, 33);
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(120, 22);
            this.numSpeed.TabIndex = 6;
            this.numSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Speed";
            // 
            // numArea
            // 
            this.numArea.DecimalPlaces = 2;
            this.numArea.Location = new System.Drawing.Point(658, 33);
            this.numArea.Name = "numArea";
            this.numArea.Size = new System.Drawing.Size(120, 22);
            this.numArea.TabIndex = 10;
            this.numArea.Value = new decimal(new int[] {
            23,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Area";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 20D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 151);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1309, 468);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resultTime
            // 
            this.resultTime.AutoSize = true;
            this.resultTime.Location = new System.Drawing.Point(1257, 25);
            this.resultTime.Name = "resultTime";
            this.resultTime.Size = new System.Drawing.Size(16, 16);
            this.resultTime.TabIndex = 14;
            this.resultTime.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1091, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1091, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Distance";
            // 
            // resultDistance
            // 
            this.resultDistance.AutoSize = true;
            this.resultDistance.Location = new System.Drawing.Point(1257, 53);
            this.resultDistance.Name = "resultDistance";
            this.resultDistance.Size = new System.Drawing.Size(16, 16);
            this.resultDistance.TabIndex = 17;
            this.resultDistance.Text = "...";
            // 
            // resultMaxHeight
            // 
            this.resultMaxHeight.AutoSize = true;
            this.resultMaxHeight.Location = new System.Drawing.Point(1257, 80);
            this.resultMaxHeight.Name = "resultMaxHeight";
            this.resultMaxHeight.Size = new System.Drawing.Size(16, 16);
            this.resultMaxHeight.TabIndex = 19;
            this.resultMaxHeight.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1091, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Max height";
            // 
            // resultSpeedEndPoint
            // 
            this.resultSpeedEndPoint.AutoSize = true;
            this.resultSpeedEndPoint.Location = new System.Drawing.Point(1257, 108);
            this.resultSpeedEndPoint.Name = "resultSpeedEndPoint";
            this.resultSpeedEndPoint.Size = new System.Drawing.Size(16, 16);
            this.resultSpeedEndPoint.TabIndex = 21;
            this.resultSpeedEndPoint.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1091, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Speed at the end point";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(811, 97);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(107, 32);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(942, 22);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(95, 60);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(942, 97);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(95, 32);
            this.btNew.TabIndex = 24;
            this.btNew.Text = "New Chart";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 642);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultSpeedEndPoint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resultMaxHeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultDistance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultTime);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label resultTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resultDistance;
        private System.Windows.Forms.Label resultMaxHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resultSpeedEndPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btNew;
    }
}

