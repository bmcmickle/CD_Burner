namespace CD_Burner
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstFolderFiles = new System.Windows.Forms.ListView();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnWorkFolder = new System.Windows.Forms.Button();
            this.txtWorkFolder = new System.Windows.Forms.TextBox();
            this.btnCreateIso = new System.Windows.Forms.Button();
            this.btnBurnCD = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.txtIsoFile = new System.Windows.Forms.TextBox();
            this.lbl_sourceFolder = new System.Windows.Forms.Label();
            this.lbl_DestinationFolder = new System.Windows.Forms.Label();
            this.lbl_VolumeNmae = new System.Windows.Forms.Label();
            this.txtVolumeName = new System.Windows.Forms.TextBox();
            this.mnuCDBurner = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCDBurner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Folders and Files";
            // 
            // lstFolderFiles
            // 
            this.lstFolderFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFolderFiles.HideSelection = false;
            this.lstFolderFiles.Location = new System.Drawing.Point(103, 58);
            this.lstFolderFiles.Name = "lstFolderFiles";
            this.lstFolderFiles.Size = new System.Drawing.Size(972, 354);
            this.lstFolderFiles.TabIndex = 1;
            this.lstFolderFiles.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(103, 418);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(193, 41);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "Select Files or Folders";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(313, 418);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnWorkFolder
            // 
            this.btnWorkFolder.ImageKey = "(none)";
            this.btnWorkFolder.Location = new System.Drawing.Point(785, 469);
            this.btnWorkFolder.Name = "btnWorkFolder";
            this.btnWorkFolder.Size = new System.Drawing.Size(193, 37);
            this.btnWorkFolder.TabIndex = 4;
            this.btnWorkFolder.Text = "Select Source folder";
            this.btnWorkFolder.UseVisualStyleBackColor = true;
            this.btnWorkFolder.Click += new System.EventHandler(this.btnWorkFolder_Click);
            // 
            // txtWorkFolder
            // 
            this.txtWorkFolder.Location = new System.Drawing.Point(302, 469);
            this.txtWorkFolder.Name = "txtWorkFolder";
            this.txtWorkFolder.ReadOnly = true;
            this.txtWorkFolder.Size = new System.Drawing.Size(448, 26);
            this.txtWorkFolder.TabIndex = 5;
            // 
            // btnCreateIso
            // 
            this.btnCreateIso.Location = new System.Drawing.Point(103, 569);
            this.btnCreateIso.Name = "btnCreateIso";
            this.btnCreateIso.Size = new System.Drawing.Size(261, 38);
            this.btnCreateIso.TabIndex = 6;
            this.btnCreateIso.Text = "Create ISO File";
            this.btnCreateIso.UseVisualStyleBackColor = true;
            this.btnCreateIso.Click += new System.EventHandler(this.btnCreateIso_Click);
            // 
            // btnBurnCD
            // 
            this.btnBurnCD.Location = new System.Drawing.Point(103, 680);
            this.btnBurnCD.Name = "btnBurnCD";
            this.btnBurnCD.Size = new System.Drawing.Size(261, 38);
            this.btnBurnCD.TabIndex = 8;
            this.btnBurnCD.Text = "Burn Disc";
            this.btnBurnCD.UseVisualStyleBackColor = true;
            this.btnBurnCD.Click += new System.EventHandler(this.btnBurnIso_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(785, 528);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(193, 37);
            this.btnDestination.TabIndex = 9;
            this.btnDestination.Text = "Select Destination folder";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(302, 528);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(448, 26);
            this.txtDestinationPath.TabIndex = 10;
            // 
            // txtIsoFile
            // 
            this.txtIsoFile.Location = new System.Drawing.Point(370, 575);
            this.txtIsoFile.Name = "txtIsoFile";
            this.txtIsoFile.ReadOnly = true;
            this.txtIsoFile.Size = new System.Drawing.Size(448, 26);
            this.txtIsoFile.TabIndex = 11;
            // 
            // lbl_sourceFolder
            // 
            this.lbl_sourceFolder.AutoSize = true;
            this.lbl_sourceFolder.Location = new System.Drawing.Point(103, 485);
            this.lbl_sourceFolder.Name = "lbl_sourceFolder";
            this.lbl_sourceFolder.Size = new System.Drawing.Size(113, 20);
            this.lbl_sourceFolder.TabIndex = 12;
            this.lbl_sourceFolder.Text = "Source Folder:";
            // 
            // lbl_DestinationFolder
            // 
            this.lbl_DestinationFolder.AutoSize = true;
            this.lbl_DestinationFolder.Location = new System.Drawing.Point(103, 536);
            this.lbl_DestinationFolder.Name = "lbl_DestinationFolder";
            this.lbl_DestinationFolder.Size = new System.Drawing.Size(143, 20);
            this.lbl_DestinationFolder.TabIndex = 13;
            this.lbl_DestinationFolder.Text = "Destination Folder:";
            // 
            // lbl_VolumeNmae
            // 
            this.lbl_VolumeNmae.AutoSize = true;
            this.lbl_VolumeNmae.Location = new System.Drawing.Point(107, 631);
            this.lbl_VolumeNmae.Name = "lbl_VolumeNmae";
            this.lbl_VolumeNmae.Size = new System.Drawing.Size(113, 20);
            this.lbl_VolumeNmae.TabIndex = 14;
            this.lbl_VolumeNmae.Text = "Volume Name:";
            // 
            // txtVolumeName
            // 
            this.txtVolumeName.Location = new System.Drawing.Point(370, 636);
            this.txtVolumeName.Name = "txtVolumeName";
            this.txtVolumeName.Size = new System.Drawing.Size(448, 26);
            this.txtVolumeName.TabIndex = 15;

            // 
            // mnuCDBurner
            // 
            this.mnuCDBurner.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuCDBurner.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuCDBurner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuCDBurner.Location = new System.Drawing.Point(0, 0);
            this.mnuCDBurner.Name = "mnuCDBurner";
            this.mnuCDBurner.Size = new System.Drawing.Size(1178, 33);
            this.mnuCDBurner.TabIndex = 16;
            this.mnuCDBurner.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.txtVolumeName);
            this.Controls.Add(this.lbl_VolumeNmae);
            this.Controls.Add(this.lbl_DestinationFolder);
            this.Controls.Add(this.lbl_sourceFolder);
            this.Controls.Add(this.txtIsoFile);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnBurnCD);
            this.Controls.Add(this.btnCreateIso);
            this.Controls.Add(this.txtWorkFolder);
            this.Controls.Add(this.btnWorkFolder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lstFolderFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuCDBurner);
            this.MainMenuStrip = this.mnuCDBurner;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CD Burner";
            this.mnuCDBurner.ResumeLayout(false);
            this.mnuCDBurner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstFolderFiles;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnWorkFolder;
        private System.Windows.Forms.TextBox txtWorkFolder;
        private System.Windows.Forms.Button btnCreateIso;
        private System.Windows.Forms.Button btnBurnCD;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.TextBox txtIsoFile;
        private System.Windows.Forms.Label lbl_sourceFolder;
        private System.Windows.Forms.Label lbl_DestinationFolder;
        private System.Windows.Forms.Label lbl_VolumeNmae;
        private System.Windows.Forms.TextBox txtVolumeName;
        private System.Windows.Forms.MenuStrip mnuCDBurner;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

