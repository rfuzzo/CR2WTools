namespace LimeKit
{
    partial class frmLimeKit
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemDbg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCompare = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGridMain = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDbg,
            this.toolStripMenuItemCompare});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1641, 33);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemDbg
            // 
            this.toolStripMenuItemDbg.Name = "toolStripMenuItemDbg";
            this.toolStripMenuItemDbg.Size = new System.Drawing.Size(94, 29);
            this.toolStripMenuItemDbg.Text = "Load File";
            this.toolStripMenuItemDbg.Click += new System.EventHandler(this.toolStripMenuItemDbg_Click);
            // 
            // toolStripMenuItemCompare
            // 
            this.toolStripMenuItemCompare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFile1ToolStripMenuItem,
            this.loadFile2ToolStripMenuItem,
            this.loadFile3ToolStripMenuItem,
            this.compareToolStripMenuItem});
            this.toolStripMenuItemCompare.Name = "toolStripMenuItemCompare";
            this.toolStripMenuItemCompare.Size = new System.Drawing.Size(97, 29);
            this.toolStripMenuItemCompare.Text = "Compare";
            // 
            // loadFile1ToolStripMenuItem
            // 
            this.loadFile1ToolStripMenuItem.Name = "loadFile1ToolStripMenuItem";
            this.loadFile1ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.loadFile1ToolStripMenuItem.Text = "Load File 1";
            this.loadFile1ToolStripMenuItem.Click += new System.EventHandler(this.loadFile1ToolStripMenuItem_Click);
            // 
            // loadFile2ToolStripMenuItem
            // 
            this.loadFile2ToolStripMenuItem.Name = "loadFile2ToolStripMenuItem";
            this.loadFile2ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.loadFile2ToolStripMenuItem.Text = "Load File 2";
            this.loadFile2ToolStripMenuItem.Click += new System.EventHandler(this.loadFile2ToolStripMenuItem_Click);
            // 
            // loadFile3ToolStripMenuItem
            // 
            this.loadFile3ToolStripMenuItem.Name = "loadFile3ToolStripMenuItem";
            this.loadFile3ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.loadFile3ToolStripMenuItem.Text = "Load File 3";
            this.loadFile3ToolStripMenuItem.Click += new System.EventHandler(this.loadFile3ToolStripMenuItem_Click);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // propertyGridMain
            // 
            this.propertyGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridMain.Location = new System.Drawing.Point(0, 0);
            this.propertyGridMain.Name = "propertyGridMain";
            this.propertyGridMain.Size = new System.Drawing.Size(1199, 1100);
            this.propertyGridMain.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGridMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(1641, 1100);
            this.splitContainer1.SplitterDistance = 1199;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(438, 1100);
            this.textBoxLog.TabIndex = 0;
            // 
            // frmLimeKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 1133);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmLimeKit";
            this.Text = "LimeKit";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDbg;
        private System.Windows.Forms.PropertyGrid propertyGridMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCompare;
        private System.Windows.Forms.ToolStripMenuItem loadFile1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFile2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFile3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}

