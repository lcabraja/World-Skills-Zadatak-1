namespace World_Skills_Zadatak_1
{
    partial class aOpenFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aOpenFileForm));
            this.aOpenFileButton = new System.Windows.Forms.Button();
            this.aSelectFile = new System.Windows.Forms.Label();
            this.aDatabaseView = new System.Windows.Forms.DataGridView();
            this.aOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.aReadDataButton = new System.Windows.Forms.Button();
            this.aConnectButton = new System.Windows.Forms.Button();
            this.aConnectionStringBox = new System.Windows.Forms.TextBox();
            this.aPasswordBox = new System.Windows.Forms.TextBox();
            this.aDatabaseBox = new System.Windows.Forms.TextBox();
            this.aServerBox = new System.Windows.Forms.TextBox();
            this.aUsernameBox = new System.Windows.Forms.TextBox();
            this.aTableBox = new System.Windows.Forms.ComboBox();
            this.aImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aDatabaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // aOpenFileButton
            // 
            this.aOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.aOpenFileButton.Location = new System.Drawing.Point(946, 388);
            this.aOpenFileButton.Name = "aOpenFileButton";
            this.aOpenFileButton.Size = new System.Drawing.Size(57, 28);
            this.aOpenFileButton.TabIndex = 0;
            this.aOpenFileButton.Text = "Browse";
            this.aOpenFileButton.UseVisualStyleBackColor = true;
            this.aOpenFileButton.Click += new System.EventHandler(this.aBrowseButton_Click);
            // 
            // aSelectFile
            // 
            this.aSelectFile.AutoSize = true;
            this.aSelectFile.Location = new System.Drawing.Point(9, 393);
            this.aSelectFile.Name = "aSelectFile";
            this.aSelectFile.Size = new System.Drawing.Size(87, 20);
            this.aSelectFile.TabIndex = 2;
            this.aSelectFile.Text = "Select File:";
            // 
            // aDatabaseView
            // 
            this.aDatabaseView.AllowUserToAddRows = false;
            this.aDatabaseView.AllowUserToDeleteRows = false;
            this.aDatabaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.aDatabaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDatabaseView.Dock = System.Windows.Forms.DockStyle.Top;
            this.aDatabaseView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aDatabaseView.Location = new System.Drawing.Point(0, 0);
            this.aDatabaseView.MaximumSize = new System.Drawing.Size(2560, 1600);
            this.aDatabaseView.Name = "aDatabaseView";
            this.aDatabaseView.ReadOnly = true;
            this.aDatabaseView.RowHeadersWidth = 55;
            this.aDatabaseView.RowTemplate.Height = 28;
            this.aDatabaseView.Size = new System.Drawing.Size(1079, 382);
            this.aDatabaseView.TabIndex = 3;
            // 
            // aOpenFileDialog
            // 
            this.aOpenFileDialog.FileName = "aOpenFileDialog";
            // 
            // aTextBox
            // 
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aTextBox.Location = new System.Drawing.Point(102, 388);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(838, 28);
            this.aTextBox.TabIndex = 4;
            // 
            // aReadDataButton
            // 
            this.aReadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.aReadDataButton.Location = new System.Drawing.Point(1009, 388);
            this.aReadDataButton.Name = "aReadDataButton";
            this.aReadDataButton.Size = new System.Drawing.Size(62, 28);
            this.aReadDataButton.TabIndex = 5;
            this.aReadDataButton.Text = "Read Data";
            this.aReadDataButton.UseVisualStyleBackColor = true;
            this.aReadDataButton.Click += new System.EventHandler(this.aReadFileButton_Click);
            // 
            // aConnectButton
            // 
            this.aConnectButton.Location = new System.Drawing.Point(675, 457);
            this.aConnectButton.Name = "aConnectButton";
            this.aConnectButton.Size = new System.Drawing.Size(124, 28);
            this.aConnectButton.TabIndex = 26;
            this.aConnectButton.Text = "Connect...";
            this.aConnectButton.UseVisualStyleBackColor = true;
            this.aConnectButton.Click += new System.EventHandler(this.aConnectButton_Click);
            // 
            // aConnectionStringBox
            // 
            this.aConnectionStringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aConnectionStringBox.Location = new System.Drawing.Point(12, 422);
            this.aConnectionStringBox.Name = "aConnectionStringBox";
            this.aConnectionStringBox.Size = new System.Drawing.Size(991, 28);
            this.aConnectionStringBox.TabIndex = 25;
            // 
            // aPasswordBox
            // 
            this.aPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aPasswordBox.Location = new System.Drawing.Point(383, 456);
            this.aPasswordBox.Name = "aPasswordBox";
            this.aPasswordBox.Size = new System.Drawing.Size(140, 28);
            this.aPasswordBox.TabIndex = 23;
            this.aPasswordBox.Text = "123456789";
            this.aPasswordBox.UseSystemPasswordChar = true;
            this.aPasswordBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aDatabaseBox
            // 
            this.aDatabaseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aDatabaseBox.Location = new System.Drawing.Point(529, 456);
            this.aDatabaseBox.Name = "aDatabaseBox";
            this.aDatabaseBox.Size = new System.Drawing.Size(140, 28);
            this.aDatabaseBox.TabIndex = 24;
            this.aDatabaseBox.Text = "testdb1";
            this.aDatabaseBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aServerBox
            // 
            this.aServerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aServerBox.HideSelection = false;
            this.aServerBox.Location = new System.Drawing.Point(13, 456);
            this.aServerBox.Name = "aServerBox";
            this.aServerBox.Size = new System.Drawing.Size(218, 28);
            this.aServerBox.TabIndex = 22;
            this.aServerBox.Text = "localhost\\STARPLATINUM";
            this.aServerBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aUsernameBox
            // 
            this.aUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aUsernameBox.Location = new System.Drawing.Point(237, 456);
            this.aUsernameBox.Name = "aUsernameBox";
            this.aUsernameBox.Size = new System.Drawing.Size(140, 28);
            this.aUsernameBox.TabIndex = 21;
            this.aUsernameBox.Text = "sa";
            this.aUsernameBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aTableBox
            // 
            this.aTableBox.FormattingEnabled = true;
            this.aTableBox.Location = new System.Drawing.Point(805, 456);
            this.aTableBox.Name = "aTableBox";
            this.aTableBox.Size = new System.Drawing.Size(198, 28);
            this.aTableBox.TabIndex = 20;
            // 
            // aImportButton
            // 
            this.aImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.aImportButton.Location = new System.Drawing.Point(1009, 422);
            this.aImportButton.Name = "aImportButton";
            this.aImportButton.Size = new System.Drawing.Size(62, 62);
            this.aImportButton.TabIndex = 19;
            this.aImportButton.Text = "Import";
            this.aImportButton.UseVisualStyleBackColor = true;
            this.aImportButton.Click += new System.EventHandler(this.aImportButton_Click);
            // 
            // aOpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1079, 496);
            this.Controls.Add(this.aConnectButton);
            this.Controls.Add(this.aConnectionStringBox);
            this.Controls.Add(this.aPasswordBox);
            this.Controls.Add(this.aDatabaseBox);
            this.Controls.Add(this.aServerBox);
            this.Controls.Add(this.aUsernameBox);
            this.Controls.Add(this.aTableBox);
            this.Controls.Add(this.aImportButton);
            this.Controls.Add(this.aReadDataButton);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.aDatabaseView);
            this.Controls.Add(this.aSelectFile);
            this.Controls.Add(this.aOpenFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aOpenFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.updateConnectionString);
            ((System.ComponentModel.ISupportInitialize)(this.aDatabaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aOpenFileButton;
        private System.Windows.Forms.Label aSelectFile;
        private System.Windows.Forms.DataGridView aDatabaseView;
        private System.Windows.Forms.OpenFileDialog aOpenFileDialog;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Button aReadDataButton;
        private System.Windows.Forms.Button aConnectButton;
        private System.Windows.Forms.TextBox aConnectionStringBox;
        private System.Windows.Forms.TextBox aPasswordBox;
        private System.Windows.Forms.TextBox aDatabaseBox;
        private System.Windows.Forms.TextBox aServerBox;
        private System.Windows.Forms.TextBox aUsernameBox;
        private System.Windows.Forms.ComboBox aTableBox;
        private System.Windows.Forms.Button aImportButton;
    }
}

