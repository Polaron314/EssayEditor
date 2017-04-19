namespace EssayEditor
{
    partial class StatisticsWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            this.pronounChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.voiceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.characterLabel = new System.Windows.Forms.Label();
            this.scLabel = new System.Windows.Forms.Label();
            this.wcLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pronounChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pronounChart
            // 
            this.pronounChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            chartArea7.Position.Auto = false;
            chartArea7.Position.Height = 100F;
            chartArea7.Position.Width = 100F;
            chartArea7.Position = new System.Windows.Forms.DataVisualization.Charting.ElementPosition(-23, 0, 100, 100); ;
            this.pronounChart.ChartAreas.Add(chartArea7);
            legend7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.pronounChart.Legends.Add(legend7);
            this.pronounChart.Location = new System.Drawing.Point(3, 165);
            this.pronounChart.Name = "pronounChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            dataPoint17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(162)))), ((int)(((byte)(8)))));
            dataPoint17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint17.Label = "";
            dataPoint17.LegendText = "1st Person";
            dataPoint18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(224)))));
            dataPoint18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint18.Label = "";
            dataPoint18.LegendText = "2nd Person";
            dataPoint19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataPoint19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint19.Label = "";
            dataPoint19.LegendText = "3rd Person";
            series7.Points.Add(dataPoint17);
            series7.Points.Add(dataPoint18);
            series7.Points.Add(dataPoint19);
            this.pronounChart.Series.Add(series7);
            this.pronounChart.Size = new System.Drawing.Size(280, 75);
            this.pronounChart.TabIndex = 2;
            this.pronounChart.Text = "chart2";
            this.pronounChart.Click += new System.EventHandler(this.chart2_Click);
            // 
            // tenseChart
            // 
            this.tenseChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            chartArea8.Position.Auto = false;
            chartArea8.Position.Height = 100F;
            chartArea8.Position.Width = 100F;
            chartArea8.Position = new System.Windows.Forms.DataVisualization.Charting.ElementPosition(-23, 0, 100, 100);
            this.tenseChart.ChartAreas.Add(chartArea8);
            legend8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.tenseChart.Legends.Add(legend8);
            this.tenseChart.Location = new System.Drawing.Point(3, 84);
            this.tenseChart.Name = "tenseChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            dataPoint20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            dataPoint20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint20.Label = "";
            dataPoint20.LegendText = "Past Tense";
            dataPoint21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(224)))), ((int)(((byte)(157)))));
            dataPoint21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint21.Label = "";
            dataPoint21.LegendText = "Present Tense";
            dataPoint22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(187)))));
            dataPoint22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint22.Label = "";
            dataPoint22.LegendText = "Future Tense";
            series8.Points.Add(dataPoint20);
            series8.Points.Add(dataPoint21);
            series8.Points.Add(dataPoint22);
            this.tenseChart.Series.Add(series8);
            this.tenseChart.Size = new System.Drawing.Size(280, 75);
            this.tenseChart.TabIndex = 0;
            this.tenseChart.Text = "chart1";
            this.tenseChart.Click += new System.EventHandler(this.tenseChart_Click);
            // 
            // voiceChart
            // 
            this.voiceChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.Name = "ChartArea1";
            chartArea9.Position.Auto = false;
            chartArea9.Position.Height = 100F;
            chartArea9.Position.Width = 100F;
            chartArea9.Position = new System.Windows.Forms.DataVisualization.Charting.ElementPosition(-23, 0, 100, 100); ;
            this.voiceChart.ChartAreas.Add(chartArea9);
            legend9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend9.IsTextAutoFit = false;
            legend9.Name = "Legend1";
            this.voiceChart.Legends.Add(legend9);
            this.voiceChart.Location = new System.Drawing.Point(3, 3);
            this.voiceChart.Name = "voiceChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            dataPoint23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(61)))));
            dataPoint23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint23.Label = "";
            dataPoint23.LegendText = "Active";
            dataPoint24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            dataPoint24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint24.Label = "";
            dataPoint24.LegendText = "Passive";
            series9.Points.Add(dataPoint23);
            series9.Points.Add(dataPoint24);
            this.voiceChart.Series.Add(series9);
            this.voiceChart.Size = new System.Drawing.Size(280, 75);
            this.voiceChart.TabIndex = 1;
            this.voiceChart.Text = "chart1";
            this.voiceChart.Click += new System.EventHandler(this.voiceChart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.24667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75333F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 252);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 246);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.characterLabel);
            this.groupBox1.Controls.Add(this.scLabel);
            this.groupBox1.Controls.Add(this.wcLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // characterLabel
            // 
            this.characterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(9, 21);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(245, 23);
            this.characterLabel.TabIndex = 0;
            this.characterLabel.Text = "Characters: ";
            this.characterLabel.Click += new System.EventHandler(this.characterLabel_Click);
            // 
            // scLabel
            // 
            this.scLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLabel.Location = new System.Drawing.Point(9, 71);
            this.scLabel.Name = "scLabel";
            this.scLabel.Size = new System.Drawing.Size(245, 26);
            this.scLabel.TabIndex = 2;
            this.scLabel.Text = "Sentences: ";
            // 
            // wcLabel
            // 
            this.wcLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcLabel.Location = new System.Drawing.Point(9, 46);
            this.wcLabel.Name = "wcLabel";
            this.wcLabel.Size = new System.Drawing.Size(245, 25);
            this.wcLabel.TabIndex = 1;
            this.wcLabel.Text = "Words: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common Words";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel.Location = new System.Drawing.Point(6, 0);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(43, 17);
            this.frequencyLabel.TabIndex = 3;
            this.frequencyLabel.Text = "label4";
            this.frequencyLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.voiceChart);
            this.flowLayoutPanel2.Controls.Add(this.tenseChart);
            this.flowLayoutPanel2.Controls.Add(this.pronounChart);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(275, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(286, 246);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.frequencyLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 108);
            this.panel1.TabIndex = 4;
            this.panel1.AutoScroll = true;
            // 
            // StatisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 252);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatisticsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsWindowcs";
            ((System.ComponentModel.ISupportInitialize)(this.pronounChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart tenseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pronounChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart voiceChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Label wcLabel;
        private System.Windows.Forms.Label scLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}