namespace WinClient
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instrumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instrumentationToolStripMenuItem
            // 
            this.instrumentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCustomer,
            this.toolStripMenuItemEmployee,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.instrumentationToolStripMenuItem.Name = "instrumentationToolStripMenuItem";
            this.instrumentationToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.instrumentationToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItemCustomer
            // 
            this.toolStripMenuItemCustomer.Name = "toolStripMenuItemCustomer";
            this.toolStripMenuItemCustomer.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItemCustomer.Text = "Customer";
            this.toolStripMenuItemCustomer.Click += new System.EventHandler(this.toolStripMenuItemCustomer_Click);
            // 
            // toolStripMenuItemEmployee
            // 
            this.toolStripMenuItemEmployee.Name = "toolStripMenuItemEmployee";
            this.toolStripMenuItemEmployee.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItemEmployee.Text = "Driver";
            this.toolStripMenuItemEmployee.Click += new System.EventHandler(this.toolStripMenuItemEmployee_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Spring Level 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instrumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCustomer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmployee;
    }
}

