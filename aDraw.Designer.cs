namespace World_Skills_Zadatak_1
{
    partial class aDraw
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aPanel = new System.Windows.Forms.Panel();
            this.aChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aChart)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel
            // 
            this.aPanel.Controls.Add(this.aChart);
            this.aPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanel.Location = new System.Drawing.Point(0, 0);
            this.aPanel.Margin = new System.Windows.Forms.Padding(2);
            this.aPanel.Name = "aPanel";
            this.aPanel.Size = new System.Drawing.Size(533, 292);
            this.aPanel.TabIndex = 0;
            this.aPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aChart
            // 
            this.aChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.aChart.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.aChart.ChartAreas.Add(chartArea1);
            this.aChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aChart.Location = new System.Drawing.Point(0, 0);
            this.aChart.Name = "aChart";
            this.aChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.aChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.IsXValueIndexed = true;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.aChart.Series.Add(series1);
            this.aChart.Size = new System.Drawing.Size(533, 292);
            this.aChart.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.aPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "aDraw";
            this.Text = "aDraw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aDraw_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.aDraw_FormClosed);
            this.aPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart aChart;
        private System.Windows.Forms.Timer timer1;
    }
}