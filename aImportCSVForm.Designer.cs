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
            this.aPanel = new System.Windows.Forms.TableLayoutPanel();
            this.aPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.aPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.aDatabaseView)).BeginInit();
            this.aPanel.SuspendLayout();
            this.aPanelTop.SuspendLayout();
            this.aPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // aOpenFileButton
            // 
            this.aOpenFileButton.AutoSize = true;
            this.aOpenFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aOpenFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aOpenFileButton.FlatAppearance.BorderSize = 0;
            this.aOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aOpenFileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aOpenFileButton.Location = new System.Drawing.Point(561, 0);
            this.aOpenFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.aOpenFileButton.MinimumSize = new System.Drawing.Size(50, 18);
            this.aOpenFileButton.Name = "aOpenFileButton";
            this.aOpenFileButton.Size = new System.Drawing.Size(80, 36);
            this.aOpenFileButton.TabIndex = 0;
            this.aOpenFileButton.Text = "Browse";
            this.aOpenFileButton.UseVisualStyleBackColor = true;
            this.aOpenFileButton.Click += new System.EventHandler(this.aBrowseButton_Click);
            // 
            // aSelectFile
            // 
            this.aSelectFile.AutoSize = true;
            this.aSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aSelectFile.Location = new System.Drawing.Point(0, 0);
            this.aSelectFile.Margin = new System.Windows.Forms.Padding(0);
            this.aSelectFile.Name = "aSelectFile";
            this.aSelectFile.Size = new System.Drawing.Size(67, 36);
            this.aSelectFile.TabIndex = 2;
            this.aSelectFile.Text = "Select File:";
            this.aSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aDatabaseView
            // 
            this.aDatabaseView.AllowUserToAddRows = false;
            this.aDatabaseView.AllowUserToDeleteRows = false;
            this.aDatabaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.aDatabaseView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.aDatabaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDatabaseView.Dock = System.Windows.Forms.DockStyle.Top;
            this.aDatabaseView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aDatabaseView.Location = new System.Drawing.Point(0, 0);
            this.aDatabaseView.Margin = new System.Windows.Forms.Padding(0);
            this.aDatabaseView.MaximumSize = new System.Drawing.Size(1707, 1040);
            this.aDatabaseView.MinimumSize = new System.Drawing.Size(400, 195);
            this.aDatabaseView.Name = "aDatabaseView";
            this.aDatabaseView.ReadOnly = true;
            this.aDatabaseView.RowHeadersWidth = 55;
            this.aDatabaseView.RowTemplate.Height = 28;
            this.aDatabaseView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aDatabaseView.Size = new System.Drawing.Size(725, 210);
            this.aDatabaseView.TabIndex = 3;
            // 
            // aOpenFileDialog
            // 
            this.aOpenFileDialog.FileName = "aOpenFileDialog";
            // 
            // aTextBox
            // 
            this.aTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aTextBox.Location = new System.Drawing.Point(67, 0);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.aTextBox.MinimumSize = new System.Drawing.Size(135, 28);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(494, 21);
            this.aTextBox.TabIndex = 4;
            // 
            // aReadDataButton
            // 
            this.aReadDataButton.AutoSize = true;
            this.aReadDataButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aReadDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aReadDataButton.FlatAppearance.BorderSize = 0;
            this.aReadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aReadDataButton.Location = new System.Drawing.Point(641, 0);
            this.aReadDataButton.Margin = new System.Windows.Forms.Padding(0);
            this.aReadDataButton.MinimumSize = new System.Drawing.Size(60, 18);
            this.aReadDataButton.Name = "aReadDataButton";
            this.aReadDataButton.Size = new System.Drawing.Size(80, 36);
            this.aReadDataButton.TabIndex = 5;
            this.aReadDataButton.Text = "Read Data";
            this.aReadDataButton.UseVisualStyleBackColor = true;
            this.aReadDataButton.Click += new System.EventHandler(this.aReadFileButton_Click);
            // 
            // aConnectButton
            // 
            this.aConnectButton.AutoSize = true;
            this.aConnectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aConnectButton.FlatAppearance.BorderSize = 0;
            this.aConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aConnectButton.Location = new System.Drawing.Point(442, 0);
            this.aConnectButton.Margin = new System.Windows.Forms.Padding(0);
            this.aConnectButton.MinimumSize = new System.Drawing.Size(67, 18);
            this.aConnectButton.Name = "aConnectButton";
            this.aConnectButton.Size = new System.Drawing.Size(117, 40);
            this.aConnectButton.TabIndex = 26;
            this.aConnectButton.Text = "Connect...";
            this.aConnectButton.UseVisualStyleBackColor = true;
            this.aConnectButton.Click += new System.EventHandler(this.aConnectButton_Click);
            // 
            // aConnectionStringBox
            // 
            this.aConnectionStringBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aConnectionStringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aConnectionStringBox.Location = new System.Drawing.Point(0, 40);
            this.aConnectionStringBox.Margin = new System.Windows.Forms.Padding(0);
            this.aConnectionStringBox.MinimumSize = new System.Drawing.Size(368, 28);
            this.aConnectionStringBox.Name = "aConnectionStringBox";
            this.aConnectionStringBox.Size = new System.Drawing.Size(725, 21);
            this.aConnectionStringBox.TabIndex = 25;
            // 
            // aPasswordBox
            // 
            this.aPasswordBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aPasswordBox.Location = new System.Drawing.Point(211, 0);
            this.aPasswordBox.Margin = new System.Windows.Forms.Padding(0);
            this.aPasswordBox.MinimumSize = new System.Drawing.Size(68, 28);
            this.aPasswordBox.Name = "aPasswordBox";
            this.aPasswordBox.Size = new System.Drawing.Size(104, 28);
            this.aPasswordBox.TabIndex = 23;
            this.aPasswordBox.UseSystemPasswordChar = true;
            this.aPasswordBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aDatabaseBox
            // 
            this.aDatabaseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aDatabaseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aDatabaseBox.Location = new System.Drawing.Point(315, 0);
            this.aDatabaseBox.Margin = new System.Windows.Forms.Padding(0);
            this.aDatabaseBox.MinimumSize = new System.Drawing.Size(68, 28);
            this.aDatabaseBox.Name = "aDatabaseBox";
            this.aDatabaseBox.Size = new System.Drawing.Size(127, 28);
            this.aDatabaseBox.TabIndex = 24;
            this.aDatabaseBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aServerBox
            // 
            this.aServerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aServerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aServerBox.Location = new System.Drawing.Point(0, 0);
            this.aServerBox.Margin = new System.Windows.Forms.Padding(0);
            this.aServerBox.MinimumSize = new System.Drawing.Size(68, 28);
            this.aServerBox.Name = "aServerBox";
            this.aServerBox.Size = new System.Drawing.Size(147, 28);
            this.aServerBox.TabIndex = 22;
            this.aServerBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aUsernameBox
            // 
            this.aUsernameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aUsernameBox.Location = new System.Drawing.Point(147, 0);
            this.aUsernameBox.Margin = new System.Windows.Forms.Padding(0);
            this.aUsernameBox.MinimumSize = new System.Drawing.Size(68, 28);
            this.aUsernameBox.Name = "aUsernameBox";
            this.aUsernameBox.Size = new System.Drawing.Size(68, 28);
            this.aUsernameBox.TabIndex = 21;
            this.aUsernameBox.Text = "sa";
            this.aUsernameBox.TextChanged += new System.EventHandler(this.updateConnectionString);
            // 
            // aTableBox
            // 
            this.aTableBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aTableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTableBox.FormattingEnabled = true;
            this.aTableBox.Location = new System.Drawing.Point(559, 0);
            this.aTableBox.Margin = new System.Windows.Forms.Padding(0);
            this.aTableBox.MinimumSize = new System.Drawing.Size(68, 0);
            this.aTableBox.Name = "aTableBox";
            this.aTableBox.Size = new System.Drawing.Size(76, 23);
            this.aTableBox.TabIndex = 20;
            // 
            // aImportButton
            // 
            this.aImportButton.AutoSize = true;
            this.aImportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aImportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aImportButton.FlatAppearance.BorderSize = 0;
            this.aImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aImportButton.Location = new System.Drawing.Point(635, 0);
            this.aImportButton.Margin = new System.Windows.Forms.Padding(0);
            this.aImportButton.MinimumSize = new System.Drawing.Size(67, 18);
            this.aImportButton.Name = "aImportButton";
            this.aImportButton.Size = new System.Drawing.Size(90, 40);
            this.aImportButton.TabIndex = 19;
            this.aImportButton.Text = "Import";
            this.aImportButton.UseVisualStyleBackColor = true;
            this.aImportButton.Click += new System.EventHandler(this.aImportButton_Click);
            // 
            // aPanel
            // 
            this.aPanel.ColumnCount = 1;
            this.aPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.aPanel.Controls.Add(this.aPanelTop, 0, 0);
            this.aPanel.Controls.Add(this.aConnectionStringBox, 0, 1);
            this.aPanel.Controls.Add(this.aPanelBottom, 0, 2);
            this.aPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.aPanel.Location = new System.Drawing.Point(0, 210);
            this.aPanel.Margin = new System.Windows.Forms.Padding(0);
            this.aPanel.MaximumSize = new System.Drawing.Size(2880, 130);
            this.aPanel.MinimumSize = new System.Drawing.Size(400, 84);
            this.aPanel.Name = "aPanel";
            this.aPanel.RowCount = 3;
            this.aPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.aPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.aPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.aPanel.Size = new System.Drawing.Size(725, 120);
            this.aPanel.TabIndex = 27;
            // 
            // aPanelTop
            // 
            this.aPanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aPanelTop.ColumnCount = 4;
            this.aPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.aPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.aPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.aPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.aPanelTop.Controls.Add(this.aSelectFile, 0, 0);
            this.aPanelTop.Controls.Add(this.aReadDataButton, 3, 0);
            this.aPanelTop.Controls.Add(this.aOpenFileButton, 2, 0);
            this.aPanelTop.Controls.Add(this.aTextBox, 1, 0);
            this.aPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanelTop.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.aPanelTop.Location = new System.Drawing.Point(2, 2);
            this.aPanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.aPanelTop.MinimumSize = new System.Drawing.Size(400, 22);
            this.aPanelTop.Name = "aPanelTop";
            this.aPanelTop.RowCount = 1;
            this.aPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.aPanelTop.Size = new System.Drawing.Size(721, 36);
            this.aPanelTop.TabIndex = 0;
            // 
            // aPanelBottom
            // 
            this.aPanelBottom.ColumnCount = 7;
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.64286F));
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.35714F));
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.aPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.aPanelBottom.Controls.Add(this.aServerBox, 0, 0);
            this.aPanelBottom.Controls.Add(this.aImportButton, 6, 0);
            this.aPanelBottom.Controls.Add(this.aDatabaseBox, 3, 0);
            this.aPanelBottom.Controls.Add(this.aTableBox, 5, 0);
            this.aPanelBottom.Controls.Add(this.aUsernameBox, 1, 0);
            this.aPanelBottom.Controls.Add(this.aConnectButton, 4, 0);
            this.aPanelBottom.Controls.Add(this.aPasswordBox, 2, 0);
            this.aPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanelBottom.Location = new System.Drawing.Point(0, 80);
            this.aPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.aPanelBottom.Name = "aPanelBottom";
            this.aPanelBottom.RowCount = 1;
            this.aPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aPanelBottom.Size = new System.Drawing.Size(725, 40);
            this.aPanelBottom.TabIndex = 26;
            // 
            // aOpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(725, 330);
            this.Controls.Add(this.aPanel);
            this.Controls.Add(this.aDatabaseView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(725, 330);
            this.Name = "aOpenFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import CSV";
            this.Load += new System.EventHandler(this.updateConnectionString);
            ((System.ComponentModel.ISupportInitialize)(this.aDatabaseView)).EndInit();
            this.aPanel.ResumeLayout(false);
            this.aPanel.PerformLayout();
            this.aPanelTop.ResumeLayout(false);
            this.aPanelTop.PerformLayout();
            this.aPanelBottom.ResumeLayout(false);
            this.aPanelBottom.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel aPanelTop;
        private System.Windows.Forms.TableLayoutPanel aPanelBottom;
        private System.Windows.Forms.TableLayoutPanel aPanel;
    }
}

