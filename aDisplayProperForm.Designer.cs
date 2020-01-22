namespace World_Skills_Zadatak_1
{
    partial class aDisplayProperForm
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
            this.aDisplay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.aOpenChartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aDisplay
            // 
            this.aDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aDisplay.Location = new System.Drawing.Point(0, 0);
            this.aDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aDisplay.Name = "aDisplay";
            this.aDisplay.RowHeadersWidth = 62;
            this.aDisplay.RowTemplate.Height = 28;
            this.aDisplay.Size = new System.Drawing.Size(533, 292);
            this.aDisplay.TabIndex = 0;
            this.aDisplay.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.aDisplay_CellBeginEdit);
            this.aDisplay.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDisplay_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aOpenChartButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 24);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 1000;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // aOpenChartButton
            // 
            this.aOpenChartButton.Location = new System.Drawing.Point(455, 1);
            this.aOpenChartButton.Name = "aOpenChartButton";
            this.aOpenChartButton.Size = new System.Drawing.Size(75, 23);
            this.aOpenChartButton.TabIndex = 2;
            this.aOpenChartButton.Text = "Visualize";
            this.aOpenChartButton.UseVisualStyleBackColor = true;
            this.aOpenChartButton.Click += new System.EventHandler(this.aOpenChartButton_Click);
            // 
            // aDisplayProperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "aDisplayProperForm";
            this.Text = "aDisplayProperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aDraw_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.aDisplayProperForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.aDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Button aOpenChartButton;
    }
}