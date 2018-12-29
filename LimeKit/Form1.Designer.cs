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
            this.propertyGridMain = new System.Windows.Forms.PropertyGrid();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDbg});
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
            // propertyGridMain
            // 
            this.propertyGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridMain.Location = new System.Drawing.Point(0, 33);
            this.propertyGridMain.Name = "propertyGridMain";
            this.propertyGridMain.Size = new System.Drawing.Size(1641, 1100);
            this.propertyGridMain.TabIndex = 1;
            // 
            // frmLimeKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 1133);
            this.Controls.Add(this.propertyGridMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmLimeKit";
            this.Text = "LimeKit";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDbg;
        private System.Windows.Forms.PropertyGrid propertyGridMain;
    }
}

