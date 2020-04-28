namespace PdfStitcher
{
    partial class StitcherGUI
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
            this.grpDirectory = new System.Windows.Forms.GroupBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.btnBrowseOrigin = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSameDestination = new System.Windows.Forms.CheckBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGathering = new System.Windows.Forms.GroupBox();
            this.btnBrowsePdfFiles = new System.Windows.Forms.Button();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.rdoRegex = new System.Windows.Forms.RadioButton();
            this.rdoListFiles = new System.Windows.Forms.RadioButton();
            this.rdoAllFiles = new System.Windows.Forms.RadioButton();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRotate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDirectory.SuspendLayout();
            this.grpGathering.SuspendLayout();
            this.grpMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDirectory
            // 
            this.grpDirectory.Controls.Add(this.btnBrowseDestination);
            this.grpDirectory.Controls.Add(this.btnBrowseOrigin);
            this.grpDirectory.Controls.Add(this.txtDestination);
            this.grpDirectory.Controls.Add(this.label2);
            this.grpDirectory.Controls.Add(this.chkSameDestination);
            this.grpDirectory.Controls.Add(this.txtOrigin);
            this.grpDirectory.Controls.Add(this.label1);
            this.grpDirectory.Location = new System.Drawing.Point(13, 13);
            this.grpDirectory.Name = "grpDirectory";
            this.grpDirectory.Size = new System.Drawing.Size(506, 95);
            this.grpDirectory.TabIndex = 0;
            this.grpDirectory.TabStop = false;
            this.grpDirectory.Text = "PDF Directory Options";
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Enabled = false;
            this.btnBrowseDestination.Location = new System.Drawing.Point(414, 66);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseDestination.TabIndex = 6;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.BtnBrowseDestination_Click);
            // 
            // btnBrowseOrigin
            // 
            this.btnBrowseOrigin.Location = new System.Drawing.Point(414, 17);
            this.btnBrowseOrigin.Name = "btnBrowseOrigin";
            this.btnBrowseOrigin.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseOrigin.TabIndex = 5;
            this.btnBrowseOrigin.Text = "Browse";
            this.btnBrowseOrigin.UseVisualStyleBackColor = true;
            this.btnBrowseOrigin.Click += new System.EventHandler(this.BtnBrowseOrigin_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(179, 66);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(229, 20);
            this.txtDestination.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File Destination Directory";
            // 
            // chkSameDestination
            // 
            this.chkSameDestination.AutoSize = true;
            this.chkSameDestination.Checked = true;
            this.chkSameDestination.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSameDestination.Location = new System.Drawing.Point(10, 43);
            this.chkSameDestination.Name = "chkSameDestination";
            this.chkSameDestination.Size = new System.Drawing.Size(241, 17);
            this.chkSameDestination.TabIndex = 2;
            this.chkSameDestination.Text = "Destination Directory Same as Orgin Directory";
            this.chkSameDestination.UseVisualStyleBackColor = true;
            this.chkSameDestination.CheckedChanged += new System.EventHandler(this.ChkSameDestination_CheckedChanged);
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(179, 17);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(229, 20);
            this.txtOrigin.TabIndex = 1;
            this.txtOrigin.TextChanged += new System.EventHandler(this.TxtOrigin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Origin Directory";
            // 
            // grpGathering
            // 
            this.grpGathering.Controls.Add(this.btnBrowsePdfFiles);
            this.grpGathering.Controls.Add(this.txtFiles);
            this.grpGathering.Controls.Add(this.txtRegex);
            this.grpGathering.Controls.Add(this.rdoRegex);
            this.grpGathering.Controls.Add(this.rdoListFiles);
            this.grpGathering.Controls.Add(this.rdoAllFiles);
            this.grpGathering.Controls.Add(this.chkSubfolders);
            this.grpGathering.Controls.Add(this.label6);
            this.grpGathering.Location = new System.Drawing.Point(13, 114);
            this.grpGathering.Name = "grpGathering";
            this.grpGathering.Size = new System.Drawing.Size(506, 193);
            this.grpGathering.TabIndex = 1;
            this.grpGathering.TabStop = false;
            this.grpGathering.Text = "PDF Gathering Options";
            // 
            // btnBrowsePdfFiles
            // 
            this.btnBrowsePdfFiles.Enabled = false;
            this.btnBrowsePdfFiles.Location = new System.Drawing.Point(425, 63);
            this.btnBrowsePdfFiles.Name = "btnBrowsePdfFiles";
            this.btnBrowsePdfFiles.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePdfFiles.TabIndex = 7;
            this.btnBrowsePdfFiles.Text = "Browse";
            this.btnBrowsePdfFiles.UseVisualStyleBackColor = true;
            this.btnBrowsePdfFiles.Click += new System.EventHandler(this.BtnBrowsePdfFiles_Click);
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(10, 92);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ReadOnly = true;
            this.txtFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFiles.Size = new System.Drawing.Size(490, 46);
            this.txtFiles.TabIndex = 6;
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(10, 167);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.ReadOnly = true;
            this.txtRegex.Size = new System.Drawing.Size(490, 20);
            this.txtRegex.TabIndex = 5;
            // 
            // rdoRegex
            // 
            this.rdoRegex.AutoSize = true;
            this.rdoRegex.Location = new System.Drawing.Point(10, 144);
            this.rdoRegex.Name = "rdoRegex";
            this.rdoRegex.Size = new System.Drawing.Size(136, 17);
            this.rdoRegex.TabIndex = 4;
            this.rdoRegex.Text = "Specify as Regex string";
            this.rdoRegex.UseVisualStyleBackColor = true;
            this.rdoRegex.CheckedChanged += new System.EventHandler(this.RdoRegex_CheckedChanged);
            // 
            // rdoListFiles
            // 
            this.rdoListFiles.AutoSize = true;
            this.rdoListFiles.Location = new System.Drawing.Point(10, 69);
            this.rdoListFiles.Name = "rdoListFiles";
            this.rdoListFiles.Size = new System.Drawing.Size(136, 17);
            this.rdoListFiles.TabIndex = 3;
            this.rdoListFiles.Text = "Specify List of PDF files";
            this.rdoListFiles.UseVisualStyleBackColor = true;
            this.rdoListFiles.CheckedChanged += new System.EventHandler(this.RdoListFiles_CheckedChanged);
            // 
            // rdoAllFiles
            // 
            this.rdoAllFiles.AutoSize = true;
            this.rdoAllFiles.Checked = true;
            this.rdoAllFiles.Location = new System.Drawing.Point(10, 46);
            this.rdoAllFiles.Name = "rdoAllFiles";
            this.rdoAllFiles.Size = new System.Drawing.Size(167, 17);
            this.rdoAllFiles.TabIndex = 2;
            this.rdoAllFiles.TabStop = true;
            this.rdoAllFiles.Text = "All PDF files in Origin Directory";
            this.rdoAllFiles.UseVisualStyleBackColor = true;
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Checked = true;
            this.chkSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubfolders.Location = new System.Drawing.Point(107, 26);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(15, 14);
            this.chkSubfolders.TabIndex = 1;
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Subfolders";
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.chkShow);
            this.grpMisc.Controls.Add(this.label5);
            this.grpMisc.Controls.Add(this.txtOutputName);
            this.grpMisc.Controls.Add(this.label4);
            this.grpMisc.Controls.Add(this.cboRotate);
            this.grpMisc.Controls.Add(this.label3);
            this.grpMisc.Location = new System.Drawing.Point(13, 344);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(506, 145);
            this.grpMisc.TabIndex = 2;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc. PDF Options";
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Checked = true;
            this.chkShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShow.Location = new System.Drawing.Point(188, 94);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(15, 14);
            this.chkShow.TabIndex = 5;
            this.chkShow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Show Output File When Finished";
            // 
            // txtOutputName
            // 
            this.txtOutputName.Location = new System.Drawing.Point(125, 52);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(229, 20);
            this.txtOutputName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Output File Name";
            // 
            // cboRotate
            // 
            this.cboRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRotate.FormattingEnabled = true;
            this.cboRotate.Items.AddRange(new object[] {
            "0°",
            "90°",
            "180°",
            "270°"});
            this.cboRotate.Location = new System.Drawing.Point(125, 17);
            this.cboRotate.Name = "cboRotate";
            this.cboRotate.Size = new System.Drawing.Size(59, 21);
            this.cboRotate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rotate Input PDFs";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(419, 495);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StitcherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpGathering);
            this.Controls.Add(this.grpDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StitcherGUI";
            this.Text = "PDF Stitcher";
            this.Load += new System.EventHandler(this.StitcherGUI_Load);
            this.grpDirectory.ResumeLayout(false);
            this.grpDirectory.PerformLayout();
            this.grpGathering.ResumeLayout(false);
            this.grpGathering.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDirectory;
        private System.Windows.Forms.GroupBox grpGathering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Button btnBrowseOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSameDestination;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoRegex;
        private System.Windows.Forms.RadioButton rdoListFiles;
        private System.Windows.Forms.RadioButton rdoAllFiles;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Button btnBrowsePdfFiles;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}