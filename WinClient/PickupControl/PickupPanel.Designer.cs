namespace WinClient //RossCSharp 
{
    partial class PickupPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose( bool disposing ) {
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
            this.pnlPickup = new System.Windows.Forms.Panel();
            this.chkDispatched = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCustomerName = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlPickup
            // 
            this.pnlPickup.Location = new System.Drawing.Point(0, 0);
            this.pnlPickup.Name = "pnlPickup";
            this.pnlPickup.Size = new System.Drawing.Size(200, 100);
            this.pnlPickup.TabIndex = 0;
            // 
            // chkDispatched
            // 
            this.chkDispatched.AutoSize = false;
            this.chkDispatched.Location = new System.Drawing.Point(0, 0);
            this.chkDispatched.Name = "chkDispatched";
            this.chkDispatched.Size = new System.Drawing.Size(16, 24);
            this.chkDispatched.TabIndex = 0;
            this.chkDispatched.Text = "checkBox1";
            this.chkDispatched.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(0, 0);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 20);
            this.txtComment.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(0, 0);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(100, 20);
            this.txtNotes.TabIndex = 0;
            // 
            // btnCustomerName
            // 
            this.btnCustomerName.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerName.Name = "btnCustomerName";
            this.btnCustomerName.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerName.TabIndex = 0;
            this.btnCustomerName.Text = "button1";
            this.btnCustomerName.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPickup;
        private System.Windows.Forms.CheckBox chkDispatched;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCustomerName;
        private System.Windows.Forms.TextBox txtID;
    }
}
