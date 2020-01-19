namespace World_Skills_Zadatak_1
{
    partial class aConnectToServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aConnectionStringBox = new System.Windows.Forms.TextBox();
            this.aDatabaseBox = new System.Windows.Forms.TextBox();
            this.aServerBox = new System.Windows.Forms.TextBox();
            this.aUsernameBox = new System.Windows.Forms.TextBox();
            this.aTableBox = new System.Windows.Forms.ComboBox();
            this.aImportButton = new System.Windows.Forms.Button();
            this.aConnectButton = new System.Windows.Forms.Button();
            this.aPasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aConnectionStringBox
            // 
            this.aConnectionStringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aConnectionStringBox.Location = new System.Drawing.Point(3, 3);
            this.aConnectionStringBox.Name = "aConnectionStringBox";
            this.aConnectionStringBox.Size = new System.Drawing.Size(1006, 28);
            this.aConnectionStringBox.TabIndex = 17;
            // 
            // aDatabaseBox
            // 
            this.aDatabaseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aDatabaseBox.Location = new System.Drawing.Point(535, 37);
            this.aDatabaseBox.Name = "aDatabaseBox";
            this.aDatabaseBox.Size = new System.Drawing.Size(140, 28);
            this.aDatabaseBox.TabIndex = 16;
            this.aDatabaseBox.Text = "testdb1";
            this.aDatabaseBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aServerBox
            // 
            this.aServerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aServerBox.HideSelection = false;
            this.aServerBox.Location = new System.Drawing.Point(3, 37);
            this.aServerBox.Name = "aServerBox";
            this.aServerBox.Size = new System.Drawing.Size(234, 28);
            this.aServerBox.TabIndex = 15;
            this.aServerBox.Text = "localhost\\STARPLATINUM";
            this.aServerBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aUsernameBox
            // 
            this.aUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aUsernameBox.Location = new System.Drawing.Point(243, 37);
            this.aUsernameBox.Name = "aUsernameBox";
            this.aUsernameBox.Size = new System.Drawing.Size(140, 28);
            this.aUsernameBox.TabIndex = 14;
            this.aUsernameBox.Text = "sa";
            this.aUsernameBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aTableBox
            // 
            this.aTableBox.FormattingEnabled = true;
            this.aTableBox.Location = new System.Drawing.Point(811, 37);
            this.aTableBox.Name = "aTableBox";
            this.aTableBox.Size = new System.Drawing.Size(198, 28);
            this.aTableBox.TabIndex = 13;
            // 
            // aImportButton
            // 
            this.aImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.aImportButton.Location = new System.Drawing.Point(1015, 3);
            this.aImportButton.Name = "aImportButton";
            this.aImportButton.Size = new System.Drawing.Size(62, 62);
            this.aImportButton.TabIndex = 12;
            this.aImportButton.Text = "Import";
            this.aImportButton.UseVisualStyleBackColor = true;
            this.aImportButton.Click += new System.EventHandler(this.aImportButton_Click);
            // 
            // aConnectButton
            // 
            this.aConnectButton.Location = new System.Drawing.Point(681, 38);
            this.aConnectButton.Name = "aConnectButton";
            this.aConnectButton.Size = new System.Drawing.Size(124, 28);
            this.aConnectButton.TabIndex = 18;
            this.aConnectButton.Text = "Connect...";
            this.aConnectButton.UseVisualStyleBackColor = true;
            this.aConnectButton.Click += new System.EventHandler(this.aConnectButton_Click);
            // 
            // aPasswordBox
            // 
            this.aPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aPasswordBox.Location = new System.Drawing.Point(389, 37);
            this.aPasswordBox.Name = "aPasswordBox";
            this.aPasswordBox.Size = new System.Drawing.Size(140, 28);
            this.aPasswordBox.TabIndex = 16;
            this.aPasswordBox.Text = "123456789";
            this.aPasswordBox.UseSystemPasswordChar = true;
            this.aPasswordBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aConnectToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.aConnectButton);
            this.Controls.Add(this.aConnectionStringBox);
            this.Controls.Add(this.aPasswordBox);
            this.Controls.Add(this.aDatabaseBox);
            this.Controls.Add(this.aServerBox);
            this.Controls.Add(this.aUsernameBox);
            this.Controls.Add(this.aTableBox);
            this.Controls.Add(this.aImportButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "aConnectToServer";
            this.Size = new System.Drawing.Size(1080, 68);
            this.Load += new System.EventHandler(this.updateConnectionString);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aConnectionStringBox;
        private System.Windows.Forms.TextBox aServerBox;
        private System.Windows.Forms.TextBox aUsernameBox;
        private System.Windows.Forms.TextBox aPasswordBox;
        private System.Windows.Forms.TextBox aDatabaseBox;
        private System.Windows.Forms.Button aConnectButton;
        private System.Windows.Forms.ComboBox aTableBox;
        private System.Windows.Forms.Button aImportButton;
    }
}
