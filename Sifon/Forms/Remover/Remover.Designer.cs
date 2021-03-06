﻿namespace Sifon.Forms.Remover
{
    partial class Remover
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remover));
            this.groupDatabases = new System.Windows.Forms.GroupBox();
            this.checkDatabases = new System.Windows.Forms.CheckBox();
            this.textDatabasePrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDatabasePrefix = new System.Windows.Forms.Label();
            this.listDatabases = new System.Windows.Forms.ListBox();
            this.linkSelectAll = new System.Windows.Forms.LinkLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonBrowseHorizon = new System.Windows.Forms.Button();
            this.textHorizonFolder = new System.Windows.Forms.TextBox();
            this.textPublishingFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowsePublishing = new System.Windows.Forms.Button();
            this.checkHorizon = new System.Windows.Forms.CheckBox();
            this.checkPublishing = new System.Windows.Forms.CheckBox();
            this.checkCommerce = new System.Windows.Forms.CheckBox();
            this.buttonBrowseIDS = new System.Windows.Forms.Button();
            this.textIdsFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowseXconnect = new System.Windows.Forms.Button();
            this.textXConnectFolder = new System.Windows.Forms.TextBox();
            this.checkIDS = new System.Windows.Forms.CheckBox();
            this.checkXconnect = new System.Windows.Forms.CheckBox();
            this.buttonBrowseWebfolder = new System.Windows.Forms.Button();
            this.textWebfolder = new System.Windows.Forms.TextBox();
            this.checkFiles = new System.Windows.Forms.CheckBox();
            this.textInstanaceToBackup = new System.Windows.Forms.Label();
            this.comboInstances = new System.Windows.Forms.ComboBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupDatabases.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatabases
            // 
            this.groupDatabases.Controls.Add(this.checkDatabases);
            this.groupDatabases.Controls.Add(this.textDatabasePrefix);
            this.groupDatabases.Controls.Add(this.label1);
            this.groupDatabases.Controls.Add(this.labelDatabasePrefix);
            this.groupDatabases.Controls.Add(this.listDatabases);
            this.groupDatabases.Controls.Add(this.linkSelectAll);
            this.groupDatabases.Location = new System.Drawing.Point(417, 13);
            this.groupDatabases.Name = "groupDatabases";
            this.groupDatabases.Size = new System.Drawing.Size(308, 400);
            this.groupDatabases.TabIndex = 1;
            this.groupDatabases.TabStop = false;
            this.groupDatabases.Text = "Databases";
            // 
            // checkDatabases
            // 
            this.checkDatabases.AutoSize = true;
            this.checkDatabases.Location = new System.Drawing.Point(17, 26);
            this.checkDatabases.Name = "checkDatabases";
            this.checkDatabases.Size = new System.Drawing.Size(104, 17);
            this.checkDatabases.TabIndex = 54;
            this.checkDatabases.Text = "Drop databases:";
            this.checkDatabases.UseVisualStyleBackColor = true;
            this.checkDatabases.CheckedChanged += new System.EventHandler(this.checkDatabases_CheckedChanged);
            // 
            // textDatabasePrefix
            // 
            this.textDatabasePrefix.Location = new System.Drawing.Point(17, 89);
            this.textDatabasePrefix.MaxLength = 50;
            this.textDatabasePrefix.Name = "textDatabasePrefix";
            this.textDatabasePrefix.Size = new System.Drawing.Size(270, 20);
            this.textDatabasePrefix.TabIndex = 55;
            this.textDatabasePrefix.TextChanged += new System.EventHandler(this.textDatabasePrefix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Select databases for removal:";
            // 
            // labelDatabasePrefix
            // 
            this.labelDatabasePrefix.AutoSize = true;
            this.labelDatabasePrefix.Location = new System.Drawing.Point(14, 73);
            this.labelDatabasePrefix.Name = "labelDatabasePrefix";
            this.labelDatabasePrefix.Size = new System.Drawing.Size(169, 13);
            this.labelDatabasePrefix.TabIndex = 40;
            this.labelDatabasePrefix.Text = "Filter / display databases by prefix:";
            // 
            // listDatabases
            // 
            this.listDatabases.BackColor = System.Drawing.SystemColors.Control;
            this.listDatabases.FormattingEnabled = true;
            this.listDatabases.Location = new System.Drawing.Point(17, 152);
            this.listDatabases.Name = "listDatabases";
            this.listDatabases.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listDatabases.Size = new System.Drawing.Size(270, 225);
            this.listDatabases.TabIndex = 57;
            this.listDatabases.SelectedIndexChanged += new System.EventHandler(this.listDatabases_SelectedIndexChanged);
            // 
            // linkSelectAll
            // 
            this.linkSelectAll.AutoSize = true;
            this.linkSelectAll.Location = new System.Drawing.Point(187, 133);
            this.linkSelectAll.Name = "linkSelectAll";
            this.linkSelectAll.Size = new System.Drawing.Size(100, 13);
            this.linkSelectAll.TabIndex = 56;
            this.linkSelectAll.TabStop = true;
            this.linkSelectAll.Text = "select all databases";
            this.linkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonBrowseHorizon);
            this.groupBox.Controls.Add(this.textHorizonFolder);
            this.groupBox.Controls.Add(this.textPublishingFolder);
            this.groupBox.Controls.Add(this.buttonBrowsePublishing);
            this.groupBox.Controls.Add(this.checkHorizon);
            this.groupBox.Controls.Add(this.checkPublishing);
            this.groupBox.Controls.Add(this.checkCommerce);
            this.groupBox.Controls.Add(this.buttonBrowseIDS);
            this.groupBox.Controls.Add(this.textIdsFolder);
            this.groupBox.Controls.Add(this.buttonBrowseXconnect);
            this.groupBox.Controls.Add(this.textXConnectFolder);
            this.groupBox.Controls.Add(this.checkIDS);
            this.groupBox.Controls.Add(this.checkXconnect);
            this.groupBox.Controls.Add(this.buttonBrowseWebfolder);
            this.groupBox.Controls.Add(this.textWebfolder);
            this.groupBox.Controls.Add(this.checkFiles);
            this.groupBox.Controls.Add(this.textInstanaceToBackup);
            this.groupBox.Controls.Add(this.comboInstances);
            this.groupBox.Controls.Add(this.buttonRemove);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(399, 401);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Select instance and what to remove:";
            // 
            // buttonBrowseHorizon
            // 
            this.buttonBrowseHorizon.Enabled = false;
            this.buttonBrowseHorizon.Location = new System.Drawing.Point(339, 264);
            this.buttonBrowseHorizon.Name = "buttonBrowseHorizon";
            this.buttonBrowseHorizon.Size = new System.Drawing.Size(41, 22);
            this.buttonBrowseHorizon.TabIndex = 49;
            this.buttonBrowseHorizon.Text = "...";
            this.buttonBrowseHorizon.UseVisualStyleBackColor = true;
            this.buttonBrowseHorizon.Visible = false;
            this.buttonBrowseHorizon.Click += new System.EventHandler(this.buttonBrowseHorizon_Click);
            // 
            // textHorizonFolder
            // 
            this.textHorizonFolder.Location = new System.Drawing.Point(18, 265);
            this.textHorizonFolder.MaxLength = 255;
            this.textHorizonFolder.Name = "textHorizonFolder";
            this.textHorizonFolder.ReadOnly = true;
            this.textHorizonFolder.Size = new System.Drawing.Size(322, 20);
            this.textHorizonFolder.TabIndex = 48;
            this.textHorizonFolder.Visible = false;
            // 
            // textPublishingFolder
            // 
            this.textPublishingFolder.Location = new System.Drawing.Point(18, 320);
            this.textPublishingFolder.MaxLength = 255;
            this.textPublishingFolder.Name = "textPublishingFolder";
            this.textPublishingFolder.ReadOnly = true;
            this.textPublishingFolder.Size = new System.Drawing.Size(322, 20);
            this.textPublishingFolder.TabIndex = 50;
            this.textPublishingFolder.Visible = false;
            // 
            // buttonBrowsePublishing
            // 
            this.buttonBrowsePublishing.Enabled = false;
            this.buttonBrowsePublishing.Location = new System.Drawing.Point(339, 319);
            this.buttonBrowsePublishing.Name = "buttonBrowsePublishing";
            this.buttonBrowsePublishing.Size = new System.Drawing.Size(41, 22);
            this.buttonBrowsePublishing.TabIndex = 51;
            this.buttonBrowsePublishing.Text = "...";
            this.buttonBrowsePublishing.UseVisualStyleBackColor = true;
            this.buttonBrowsePublishing.Visible = false;
            this.buttonBrowsePublishing.Click += new System.EventHandler(this.buttonBrowsePublishing_Click);
            // 
            // checkHorizon
            // 
            this.checkHorizon.AutoSize = true;
            this.checkHorizon.Location = new System.Drawing.Point(18, 245);
            this.checkHorizon.Name = "checkHorizon";
            this.checkHorizon.Size = new System.Drawing.Size(95, 17);
            this.checkHorizon.TabIndex = 52;
            this.checkHorizon.Text = "Clean Horizon:";
            this.checkHorizon.UseVisualStyleBackColor = true;
            this.checkHorizon.Visible = false;
            this.checkHorizon.CheckedChanged += new System.EventHandler(this.checkHorizon_CheckedChanged);
            // 
            // checkPublishing
            // 
            this.checkPublishing.AutoSize = true;
            this.checkPublishing.Location = new System.Drawing.Point(18, 300);
            this.checkPublishing.Name = "checkPublishing";
            this.checkPublishing.Size = new System.Drawing.Size(146, 17);
            this.checkPublishing.TabIndex = 49;
            this.checkPublishing.Text = "Clean Publishing Service:";
            this.checkPublishing.UseVisualStyleBackColor = true;
            this.checkPublishing.Visible = false;
            this.checkPublishing.CheckedChanged += new System.EventHandler(this.checkPublishing_CheckedChanged);
            // 
            // checkCommerce
            // 
            this.checkCommerce.AutoSize = true;
            this.checkCommerce.Location = new System.Drawing.Point(18, 360);
            this.checkCommerce.Name = "checkCommerce";
            this.checkCommerce.Size = new System.Drawing.Size(109, 17);
            this.checkCommerce.TabIndex = 52;
            this.checkCommerce.Text = "Clean Commerce:";
            this.checkCommerce.UseVisualStyleBackColor = true;
            this.checkCommerce.Visible = false;
            // 
            // buttonBrowseIDS
            // 
            this.buttonBrowseIDS.Enabled = false;
            this.buttonBrowseIDS.Location = new System.Drawing.Point(339, 209);
            this.buttonBrowseIDS.Name = "buttonBrowseIDS";
            this.buttonBrowseIDS.Size = new System.Drawing.Size(41, 22);
            this.buttonBrowseIDS.TabIndex = 47;
            this.buttonBrowseIDS.Text = "...";
            this.buttonBrowseIDS.UseVisualStyleBackColor = true;
            this.buttonBrowseIDS.Visible = false;
            this.buttonBrowseIDS.Click += new System.EventHandler(this.buttonBrowseIDS_Click);
            // 
            // textIdsFolder
            // 
            this.textIdsFolder.Location = new System.Drawing.Point(18, 210);
            this.textIdsFolder.MaxLength = 255;
            this.textIdsFolder.Name = "textIdsFolder";
            this.textIdsFolder.ReadOnly = true;
            this.textIdsFolder.Size = new System.Drawing.Size(322, 20);
            this.textIdsFolder.TabIndex = 46;
            this.textIdsFolder.Visible = false;
            // 
            // buttonBrowseXconnect
            // 
            this.buttonBrowseXconnect.Enabled = false;
            this.buttonBrowseXconnect.Location = new System.Drawing.Point(339, 154);
            this.buttonBrowseXconnect.Name = "buttonBrowseXconnect";
            this.buttonBrowseXconnect.Size = new System.Drawing.Size(41, 22);
            this.buttonBrowseXconnect.TabIndex = 45;
            this.buttonBrowseXconnect.Text = "...";
            this.buttonBrowseXconnect.UseVisualStyleBackColor = true;
            this.buttonBrowseXconnect.Visible = false;
            this.buttonBrowseXconnect.Click += new System.EventHandler(this.buttonBrowseXconnect_Click);
            // 
            // textXConnectFolder
            // 
            this.textXConnectFolder.Location = new System.Drawing.Point(18, 155);
            this.textXConnectFolder.MaxLength = 255;
            this.textXConnectFolder.Name = "textXConnectFolder";
            this.textXConnectFolder.ReadOnly = true;
            this.textXConnectFolder.Size = new System.Drawing.Size(322, 20);
            this.textXConnectFolder.TabIndex = 44;
            this.textXConnectFolder.Visible = false;
            // 
            // checkIDS
            // 
            this.checkIDS.AutoSize = true;
            this.checkIDS.Location = new System.Drawing.Point(18, 190);
            this.checkIDS.Name = "checkIDS";
            this.checkIDS.Size = new System.Drawing.Size(127, 17);
            this.checkIDS.TabIndex = 43;
            this.checkIDS.Text = "Clean Identity Server:";
            this.checkIDS.UseVisualStyleBackColor = true;
            this.checkIDS.Visible = false;
            this.checkIDS.CheckedChanged += new System.EventHandler(this.checkIDS_CheckedChanged);
            // 
            // checkXconnect
            // 
            this.checkXconnect.AutoSize = true;
            this.checkXconnect.Location = new System.Drawing.Point(18, 135);
            this.checkXconnect.Name = "checkXconnect";
            this.checkXconnect.Size = new System.Drawing.Size(104, 17);
            this.checkXconnect.TabIndex = 42;
            this.checkXconnect.Text = "Clean xConnect:";
            this.checkXconnect.UseVisualStyleBackColor = true;
            this.checkXconnect.Visible = false;
            this.checkXconnect.CheckedChanged += new System.EventHandler(this.checkXconnect_CheckedChanged);
            // 
            // buttonBrowseWebfolder
            // 
            this.buttonBrowseWebfolder.Enabled = false;
            this.buttonBrowseWebfolder.Location = new System.Drawing.Point(339, 99);
            this.buttonBrowseWebfolder.Name = "buttonBrowseWebfolder";
            this.buttonBrowseWebfolder.Size = new System.Drawing.Size(41, 22);
            this.buttonBrowseWebfolder.TabIndex = 41;
            this.buttonBrowseWebfolder.Text = "...";
            this.buttonBrowseWebfolder.UseVisualStyleBackColor = true;
            this.buttonBrowseWebfolder.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textWebfolder
            // 
            this.textWebfolder.Location = new System.Drawing.Point(18, 100);
            this.textWebfolder.MaxLength = 255;
            this.textWebfolder.Name = "textWebfolder";
            this.textWebfolder.ReadOnly = true;
            this.textWebfolder.Size = new System.Drawing.Size(322, 20);
            this.textWebfolder.TabIndex = 36;
            // 
            // checkFiles
            // 
            this.checkFiles.AutoSize = true;
            this.checkFiles.Location = new System.Drawing.Point(18, 80);
            this.checkFiles.Name = "checkFiles";
            this.checkFiles.Size = new System.Drawing.Size(75, 17);
            this.checkFiles.TabIndex = 34;
            this.checkFiles.Text = "Clean site:";
            this.checkFiles.UseVisualStyleBackColor = true;
            this.checkFiles.CheckedChanged += new System.EventHandler(this.checkFiles_CheckedChanged);
            // 
            // textInstanaceToBackup
            // 
            this.textInstanaceToBackup.AutoSize = true;
            this.textInstanaceToBackup.Location = new System.Drawing.Point(21, 27);
            this.textInstanaceToBackup.Name = "textInstanaceToBackup";
            this.textInstanaceToBackup.Size = new System.Drawing.Size(148, 13);
            this.textInstanaceToBackup.TabIndex = 32;
            this.textInstanaceToBackup.Text = "Sitecore instance to clean up:";
            // 
            // comboInstances
            // 
            this.comboInstances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInstances.FormattingEnabled = true;
            this.comboInstances.Location = new System.Drawing.Point(18, 43);
            this.comboInstances.Name = "comboInstances";
            this.comboInstances.Size = new System.Drawing.Size(362, 21);
            this.comboInstances.TabIndex = 31;
            this.comboInstances.SelectedIndexChanged += new System.EventHandler(this.comboInstances_SelectedIndexChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(305, 360);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 60;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Remover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 420);
            this.Controls.Add(this.groupDatabases);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Remover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sitecore remover";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.Remover_Load);
            this.groupDatabases.ResumeLayout(false);
            this.groupDatabases.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label textInstanaceToBackup;
        private System.Windows.Forms.ComboBox comboInstances;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textWebfolder;
        private System.Windows.Forms.TextBox textDatabasePrefix;
        private System.Windows.Forms.CheckBox checkFiles;
        private System.Windows.Forms.CheckBox checkDatabases;
        private System.Windows.Forms.LinkLabel linkSelectAll;
        private System.Windows.Forms.ListBox listDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDatabasePrefix;
        private System.Windows.Forms.Button buttonBrowseWebfolder;
        private System.Windows.Forms.CheckBox checkIDS;
        private System.Windows.Forms.CheckBox checkXconnect;
        private System.Windows.Forms.Button buttonBrowseIDS;
        private System.Windows.Forms.TextBox textIdsFolder;
        private System.Windows.Forms.Button buttonBrowseXconnect;
        private System.Windows.Forms.TextBox textXConnectFolder;
        private System.Windows.Forms.GroupBox groupDatabases;
        private System.Windows.Forms.CheckBox checkCommerce;
        private System.Windows.Forms.Button buttonBrowseHorizon;
        private System.Windows.Forms.TextBox textHorizonFolder;
        private System.Windows.Forms.CheckBox checkHorizon;
        private System.Windows.Forms.Button buttonBrowsePublishing;
        private System.Windows.Forms.TextBox textPublishingFolder;
        private System.Windows.Forms.CheckBox checkPublishing;
    }
}