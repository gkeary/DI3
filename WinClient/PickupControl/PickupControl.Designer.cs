namespace WinClient //PickupControlLibrary
{
    partial class PickupControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.chkDispatched = new System.Windows.Forms.CheckBox();
            this.btnCustomerName = new System.Windows.Forms.Button();
            this.mnuRoute = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePickupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examineCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlPickup = new System.Windows.Forms.Panel();
            this.PickupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PUControlTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuRoute.SuspendLayout();
            this.pnlPickup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDispatched
            // 
            this.chkDispatched.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDispatched.Location = new System.Drawing.Point(2, 3);
            this.chkDispatched.MaximumSize = new System.Drawing.Size(83, 20);
            this.chkDispatched.Name = "chkDispatched";
            this.chkDispatched.Size = new System.Drawing.Size(15, 17);
            this.chkDispatched.TabIndex = 0;
            this.chkDispatched.TabStop = false;
            this.chkDispatched.UseVisualStyleBackColor = true;
            this.chkDispatched.CheckedChanged += new System.EventHandler(this.chkDispatched_CheckedChanged);
            // 
            // btnCustomerName
            // 
            this.btnCustomerName.AutoEllipsis = true;
            this.btnCustomerName.ContextMenuStrip = this.mnuRoute;
            this.btnCustomerName.Location = new System.Drawing.Point(19, 0);
            this.btnCustomerName.Name = "btnCustomerName";
            this.btnCustomerName.Size = new System.Drawing.Size(116, 20);
            this.btnCustomerName.TabIndex = 1;
            this.btnCustomerName.Text = "btnCustomerName";
            this.btnCustomerName.UseVisualStyleBackColor = true;
            // 
            // mnuRoute
            // 
            this.mnuRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePickupToolStripMenuItem,
            this.examineCustomerDetailsToolStripMenuItem});
            this.mnuRoute.Name = "mnuRoute";
            this.mnuRoute.Size = new System.Drawing.Size(210, 48);
            // 
            // deletePickupToolStripMenuItem
            // 
            this.deletePickupToolStripMenuItem.Name = "deletePickupToolStripMenuItem";
            this.deletePickupToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deletePickupToolStripMenuItem.Text = "&Delete Pickup";
            this.deletePickupToolStripMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // examineCustomerDetailsToolStripMenuItem
            // 
            this.examineCustomerDetailsToolStripMenuItem.Name = "examineCustomerDetailsToolStripMenuItem";
            this.examineCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.examineCustomerDetailsToolStripMenuItem.Text = "Examine &Customer Details";
            this.examineCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.examineMenuItem_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(141, 1);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(115, 20);
            this.txtComment.TabIndex = 0;
            this.txtComment.Text = "txtComment";
            this.PUControlTooltip.SetToolTip(this.txtComment, "e.g. 8 sk rdy");
            this.txtComment.Validated += new System.EventHandler(this.txtComment_Validated);
            this.txtComment.Validating += new System.ComponentModel.CancelEventHandler(this.txtComment_Validating);
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.Location = new System.Drawing.Point(258, 2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(22, 20);
            this.txtNotes.TabIndex = 1;
            this.txtNotes.Text = "txtNotes";
            this.PUControlTooltip.SetToolTip(this.txtNotes, "e.g. VT");
            this.txtNotes.Validated += new System.EventHandler(this.txtNotes_Validated);
            this.txtNotes.Validating += new System.ComponentModel.CancelEventHandler(this.txtNotes_Validating);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(34, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(10, 20);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "txtId";
            this.txtID.Visible = false;
            // 
            // pnlPickup
            // 
            this.pnlPickup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPickup.Controls.Add(this.chkDispatched);
            this.pnlPickup.Controls.Add(this.txtComment);
            this.pnlPickup.Controls.Add(this.btnCustomerName);
            this.pnlPickup.Controls.Add(this.txtID);
            this.pnlPickup.Controls.Add(this.txtNotes);
            this.pnlPickup.Location = new System.Drawing.Point(3, 0);
            this.pnlPickup.Name = "pnlPickup";
            this.pnlPickup.Size = new System.Drawing.Size(294, 27);
            this.pnlPickup.TabIndex = 1;
            // 
            // PickupBindingSource
            // 
            //this.PickupBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.PickupBindingSource_ListChanged);
            // 
            // PickupControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPickup);
            this.Name = "PickupControl";
            this.Size = new System.Drawing.Size(357, 27);
            this.Load += new System.EventHandler(this.PickupControl_Load);
            this.mnuRoute.ResumeLayout(false);
            this.pnlPickup.ResumeLayout(false);
            this.pnlPickup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDispatched;
        private System.Windows.Forms.Button btnCustomerName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlPickup;
        private System.Windows.Forms.ContextMenuStrip mnuRoute;
        private System.Windows.Forms.ToolStripMenuItem deletePickupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examineCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.BindingSource PickupBindingSource;
        private System.Windows.Forms.ToolTip PUControlTooltip;
    }
}
