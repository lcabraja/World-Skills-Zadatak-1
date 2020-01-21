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
            this.aPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // aPanel
            // 
            this.aPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanel.Location = new System.Drawing.Point(0, 0);
            this.aPanel.Name = "aPanel";
            this.aPanel.Size = new System.Drawing.Size(800, 450);
            this.aPanel.TabIndex = 0;
            this.aPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aPanel);
            this.Name = "aDraw";
            this.Text = "aDraw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aDraw_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.aDraw_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aPanel;
    }
}