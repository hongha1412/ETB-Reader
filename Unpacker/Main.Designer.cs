﻿
namespace Unpacker
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ไฟลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.บนทกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สงออกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItemFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.readPacketEncryptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lZFUnpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lZFPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lZFMSGUnpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.authorSopanatxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.currentOpenFileLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(12, 508);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ไฟลToolStripMenuItem,
            this.แกไขToolStripMenuItem,
            this.เกยวกบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ไฟลToolStripMenuItem
            // 
            this.ไฟลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenu,
            this.บนทกToolStripMenuItem,
            this.สงออกToolStripMenuItem,
            this.openItemFileMenu,
            this.readPacketEncryptionMenu,
            this.lZFUnpackToolStripMenuItem,
            this.lZFPackToolStripMenuItem,
            this.lZFMSGUnpackToolStripMenuItem});
            this.ไฟลToolStripMenuItem.Name = "ไฟลToolStripMenuItem";
            this.ไฟลToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ไฟลToolStripMenuItem.Text = "File";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(198, 22);
            this.openFileMenu.Text = "Open";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // บนทกToolStripMenuItem
            // 
            this.บนทกToolStripMenuItem.Name = "บนทกToolStripMenuItem";
            this.บนทกToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.บนทกToolStripMenuItem.Text = "Save";
            // 
            // สงออกToolStripMenuItem
            // 
            this.สงออกToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryFileToolStripMenuItem,
            this.exportToTextFileMenu,
            this.excelFileToolStripMenuItem});
            this.สงออกToolStripMenuItem.Name = "สงออกToolStripMenuItem";
            this.สงออกToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.สงออกToolStripMenuItem.Text = "Export";
            // 
            // binaryFileToolStripMenuItem
            // 
            this.binaryFileToolStripMenuItem.Name = "binaryFileToolStripMenuItem";
            this.binaryFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.binaryFileToolStripMenuItem.Text = "Binary File (.itm / .etb)";
            // 
            // exportToTextFileMenu
            // 
            this.exportToTextFileMenu.Name = "exportToTextFileMenu";
            this.exportToTextFileMenu.Size = new System.Drawing.Size(191, 22);
            this.exportToTextFileMenu.Text = "Text File";
            this.exportToTextFileMenu.Click += new System.EventHandler(this.exportToTextFileMenu_Click);
            // 
            // excelFileToolStripMenuItem
            // 
            this.excelFileToolStripMenuItem.Name = "excelFileToolStripMenuItem";
            this.excelFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.excelFileToolStripMenuItem.Text = "Excel File";
            // 
            // openItemFileMenu
            // 
            this.openItemFileMenu.Name = "openItemFileMenu";
            this.openItemFileMenu.Size = new System.Drawing.Size(198, 22);
            this.openItemFileMenu.Text = "Open Item File";
            this.openItemFileMenu.Click += new System.EventHandler(this.openItemFileMenu_Click);
            // 
            // readPacketEncryptionMenu
            // 
            this.readPacketEncryptionMenu.Name = "readPacketEncryptionMenu";
            this.readPacketEncryptionMenu.Size = new System.Drawing.Size(198, 22);
            this.readPacketEncryptionMenu.Text = "Read Packet Encryption";
            this.readPacketEncryptionMenu.Click += new System.EventHandler(this.readPacketEncryptionMenu_Click);
            // 
            // lZFUnpackToolStripMenuItem
            // 
            this.lZFUnpackToolStripMenuItem.Name = "lZFUnpackToolStripMenuItem";
            this.lZFUnpackToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lZFUnpackToolStripMenuItem.Text = "LZF Unpack";
            this.lZFUnpackToolStripMenuItem.Click += new System.EventHandler(this.lZFUnpackToolStripMenuItem_Click);
            // 
            // lZFPackToolStripMenuItem
            // 
            this.lZFPackToolStripMenuItem.Name = "lZFPackToolStripMenuItem";
            this.lZFPackToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lZFPackToolStripMenuItem.Text = "LZF Pack";
            this.lZFPackToolStripMenuItem.Click += new System.EventHandler(this.lZFPackToolStripMenuItem_Click);
            // 
            // lZFMSGUnpackToolStripMenuItem
            // 
            this.lZFMSGUnpackToolStripMenuItem.Name = "lZFMSGUnpackToolStripMenuItem";
            this.lZFMSGUnpackToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lZFMSGUnpackToolStripMenuItem.Text = "LZF MSG Unpack";
            this.lZFMSGUnpackToolStripMenuItem.Click += new System.EventHandler(this.lZFMSGUnpackToolStripMenuItem_Click);
            // 
            // แกไขToolStripMenuItem
            // 
            this.แกไขToolStripMenuItem.Name = "แกไขToolStripMenuItem";
            this.แกไขToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.แกไขToolStripMenuItem.Text = "Edit";
            // 
            // เกยวกบToolStripMenuItem
            // 
            this.เกยวกบToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpdateMenu,
            this.เกยวกบโปรแกรมToolStripMenuItem});
            this.เกยวกบToolStripMenuItem.Name = "เกยวกบToolStripMenuItem";
            this.เกยวกบToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.เกยวกบToolStripMenuItem.Text = "About";
            // 
            // checkUpdateMenu
            // 
            this.checkUpdateMenu.Name = "checkUpdateMenu";
            this.checkUpdateMenu.Size = new System.Drawing.Size(180, 22);
            this.checkUpdateMenu.Text = "Check Update";
            // 
            // เกยวกบโปรแกรมToolStripMenuItem
            // 
            this.เกยวกบโปรแกรมToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentVersion,
            this.authorSopanatxToolStripMenuItem});
            this.เกยวกบโปรแกรมToolStripMenuItem.Name = "เกยวกบโปรแกรมToolStripMenuItem";
            this.เกยวกบโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.เกยวกบโปรแกรมToolStripMenuItem.Text = "About This Program";
            // 
            // CurrentVersion
            // 
            this.CurrentVersion.Enabled = false;
            this.CurrentVersion.Name = "CurrentVersion";
            this.CurrentVersion.Size = new System.Drawing.Size(177, 22);
            this.CurrentVersion.Text = "Version 1.1.6.0";
            // 
            // authorSopanatxToolStripMenuItem
            // 
            this.authorSopanatxToolStripMenuItem.Enabled = false;
            this.authorSopanatxToolStripMenuItem.Name = "authorSopanatxToolStripMenuItem";
            this.authorSopanatxToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.authorSopanatxToolStripMenuItem.Text = "Author: @Sopanatx";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 33;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 544);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 9;
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelRowCount.Location = new System.Drawing.Point(253, 9);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(75, 13);
            this.labelRowCount.TabIndex = 10;
            this.labelRowCount.Text = "Row Count : 0";
            this.labelRowCount.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // currentOpenFileLabel
            // 
            this.currentOpenFileLabel.AutoSize = true;
            this.currentOpenFileLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currentOpenFileLabel.Location = new System.Drawing.Point(843, 9);
            this.currentOpenFileLabel.Name = "currentOpenFileLabel";
            this.currentOpenFileLabel.Size = new System.Drawing.Size(35, 13);
            this.currentOpenFileLabel.TabIndex = 11;
            this.currentOpenFileLabel.Text = "label1";
            this.currentOpenFileLabel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.Location = new System.Drawing.Point(357, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Encrypt Packet Output";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 569);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.currentOpenFileLabel);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ไฟลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem บนทกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem แกไขToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สงออกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTextFileMenu;
        private System.Windows.Forms.ToolStripMenuItem excelFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateMenu;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentVersion;
        private System.Windows.Forms.ToolStripMenuItem authorSopanatxToolStripMenuItem;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label currentOpenFileLabel;
        private System.Windows.Forms.ToolStripMenuItem openItemFileMenu;
        private System.Windows.Forms.ToolStripMenuItem readPacketEncryptionMenu;
        private System.Windows.Forms.ToolStripMenuItem lZFUnpackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lZFPackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lZFMSGUnpackToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

