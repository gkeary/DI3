namespace WinClient //Dispatch3
{
    partial class frmRoute
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
        internal System.Windows.Forms.Label lblDriverName;
        internal System.Windows.Forms.Panel pnlContainer;
        internal System.Windows.Forms.TextBox txtDriverMessage;
        internal System.Windows.Forms.BindingSource PickupBindingSource;
        internal System.Windows.Forms.ContextMenuStrip mnuRoute;
        internal System.Windows.Forms.ToolStripMenuItem DeletePickup;
        internal System.Windows.Forms.ToolStripMenuItem ExamineCustomerDetails;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.mnuRoute = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeletePickup = new System.Windows.Forms.ToolStripMenuItem();
            this.ExamineCustomerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDriverMessage = new System.Windows.Forms.TextBox();
            this.PickupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tooltipDriverMessage = new System.Windows.Forms.ToolTip(this.components);
            this.mnuRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverName
            // 
            this.lblDriverName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDriverName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.Location = new System.Drawing.Point(0, 0);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(332, 24);
            this.lblDriverName.TabIndex = 0;
            this.lblDriverName.Text = "lblDriverName";
            this.lblDriverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AllowDrop = true;
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(332, 172);
            this.pnlContainer.TabIndex = 3;
            // 
            // mnuRoute
            // 
            this.mnuRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeletePickup,
            this.ExamineCustomerDetails});
            this.mnuRoute.Name = "grid1Menu";
            this.mnuRoute.Size = new System.Drawing.Size(210, 48);
            // 
            // DeletePickup
            // 
            this.DeletePickup.Name = "DeletePickup";
            this.DeletePickup.Size = new System.Drawing.Size(209, 22);
            this.DeletePickup.Text = "&Delete Pickup";
            // 
            // ExamineCustomerDetails
            // 
            this.ExamineCustomerDetails.Name = "ExamineCustomerDetails";
            this.ExamineCustomerDetails.Size = new System.Drawing.Size(209, 22);
            this.ExamineCustomerDetails.Text = "Examine &Customer Details";
            // 
            // txtDriverMessage
            // 
            this.txtDriverMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtDriverMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverMessage.ForeColor = System.Drawing.Color.Black;
            this.txtDriverMessage.Location = new System.Drawing.Point(107, 2);
            this.txtDriverMessage.Name = "txtDriverMessage";
            this.txtDriverMessage.Size = new System.Drawing.Size(120, 20);
            this.txtDriverMessage.TabIndex = 4;
            // 
            // frmRoute
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(332, 196);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.txtDriverMessage);
            this.Controls.Add(this.lblDriverName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(340, 230);
            this.Name = "frmRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Route ---";
            this.mnuRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PickupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ToolTip tooltipDriverMessage;
    }
        #endregion
}