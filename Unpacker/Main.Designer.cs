
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
            this.เอกสารขอความToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version10BetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorSopanatxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseAG001400TA00054100041XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expired20220905235959ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDEVLICENSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ไฟลToolStripMenuItem
            // 
            this.ไฟลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenu,
            this.บนทกToolStripMenuItem,
            this.สงออกToolStripMenuItem});
            this.ไฟลToolStripMenuItem.Name = "ไฟลToolStripMenuItem";
            this.ไฟลToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ไฟลToolStripMenuItem.Text = "File";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(108, 22);
            this.openFileMenu.Text = "Open";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // บนทกToolStripMenuItem
            // 
            this.บนทกToolStripMenuItem.Name = "บนทกToolStripMenuItem";
            this.บนทกToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.บนทกToolStripMenuItem.Text = "Save";
            // 
            // สงออกToolStripMenuItem
            // 
            this.สงออกToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryFileToolStripMenuItem,
            this.เอกสารขอความToolStripMenuItem,
            this.excelFileToolStripMenuItem});
            this.สงออกToolStripMenuItem.Name = "สงออกToolStripMenuItem";
            this.สงออกToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.สงออกToolStripMenuItem.Text = "Export";
            // 
            // binaryFileToolStripMenuItem
            // 
            this.binaryFileToolStripMenuItem.Name = "binaryFileToolStripMenuItem";
            this.binaryFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.binaryFileToolStripMenuItem.Text = "Binary File (.itm / .etb)";
            // 
            // เอกสารขอความToolStripMenuItem
            // 
            this.เอกสารขอความToolStripMenuItem.Name = "เอกสารขอความToolStripMenuItem";
            this.เอกสารขอความToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.เอกสารขอความToolStripMenuItem.Text = "Text File";
            // 
            // excelFileToolStripMenuItem
            // 
            this.excelFileToolStripMenuItem.Name = "excelFileToolStripMenuItem";
            this.excelFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.excelFileToolStripMenuItem.Text = "Excel File";
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
            this.checkUpdateMenu.Click += new System.EventHandler(this.checkUpdateMenu_Click);
            // 
            // เกยวกบโปรแกรมToolStripMenuItem
            // 
            this.เกยวกบโปรแกรมToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version10BetaToolStripMenuItem,
            this.authorSopanatxToolStripMenuItem,
            this.licenseAG001400TA00054100041XToolStripMenuItem,
            this.expired20220905235959ToolStripMenuItem,
            this.userDEVLICENSEToolStripMenuItem});
            this.เกยวกบโปรแกรมToolStripMenuItem.Name = "เกยวกบโปรแกรมToolStripMenuItem";
            this.เกยวกบโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.เกยวกบโปรแกรมToolStripMenuItem.Text = "About This Program";
            // 
            // version10BetaToolStripMenuItem
            // 
            this.version10BetaToolStripMenuItem.Enabled = false;
            this.version10BetaToolStripMenuItem.Name = "version10BetaToolStripMenuItem";
            this.version10BetaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.version10BetaToolStripMenuItem.Text = "Version 1.0 (Beta)";
            // 
            // authorSopanatxToolStripMenuItem
            // 
            this.authorSopanatxToolStripMenuItem.Enabled = false;
            this.authorSopanatxToolStripMenuItem.Name = "authorSopanatxToolStripMenuItem";
            this.authorSopanatxToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.authorSopanatxToolStripMenuItem.Text = "Author: @Sopanatx";
            // 
            // licenseAG001400TA00054100041XToolStripMenuItem
            // 
            this.licenseAG001400TA00054100041XToolStripMenuItem.Enabled = false;
            this.licenseAG001400TA00054100041XToolStripMenuItem.Name = "licenseAG001400TA00054100041XToolStripMenuItem";
            this.licenseAG001400TA00054100041XToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.licenseAG001400TA00054100041XToolStripMenuItem.Text = "License: AG-001400-TA00054100041-X";
            // 
            // expired20220905235959ToolStripMenuItem
            // 
            this.expired20220905235959ToolStripMenuItem.Enabled = false;
            this.expired20220905235959ToolStripMenuItem.Name = "expired20220905235959ToolStripMenuItem";
            this.expired20220905235959ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.expired20220905235959ToolStripMenuItem.Text = "Expired: 2022-09-05 23:59:59";
            // 
            // userDEVLICENSEToolStripMenuItem
            // 
            this.userDEVLICENSEToolStripMenuItem.Enabled = false;
            this.userDEVLICENSEToolStripMenuItem.Name = "userDEVLICENSEToolStripMenuItem";
            this.userDEVLICENSEToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.userDEVLICENSEToolStripMenuItem.Text = "User: DEV_LICENSE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 537);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 9;
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelRowCount.Location = new System.Drawing.Point(284, 9);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(75, 13);
            this.labelRowCount.TabIndex = 10;
            this.labelRowCount.Text = "Row Count : 0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 564);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "JvCryption Reader";
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
        private System.Windows.Forms.ToolStripMenuItem เอกสารขอความToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateMenu;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version10BetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorSopanatxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseAG001400TA00054100041XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expired20220905235959ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDEVLICENSEToolStripMenuItem;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

