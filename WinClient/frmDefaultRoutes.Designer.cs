using DispatchAR;

namespace WinClient
{
    partial class frmDefaultRoutes
    {
        //List<CUSTOMER> CurrentDayRouteCollection = Program.CDRList;
        //List<Route> Route2Collection= Program.RouteList;
        //bool blnPanelRowChanged= false;
        //bool blnRouteSaved = false;
        //int intTxtMessagesIndex;
        //string strCDRSyncID;

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
            this.btnSetRoutes = new System.Windows.Forms.Button();
            this.pnlCurrentDayRoutes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSetRoutes
            // 
            this.btnSetRoutes.Location = new System.Drawing.Point(26, 24);
            this.btnSetRoutes.Name = "btnSetRoutes";
            this.btnSetRoutes.Size = new System.Drawing.Size(99, 32);
            this.btnSetRoutes.TabIndex = 0;
            this.btnSetRoutes.Text = "&Set Routes";
            this.btnSetRoutes.UseVisualStyleBackColor = true;
            this.btnSetRoutes.Click += new System.EventHandler(this.btnSetRoutes_Click);
            // 
            // pnlCurrentDayRoutes
            // 
            this.pnlCurrentDayRoutes.Location = new System.Drawing.Point(26, 74);
            this.pnlCurrentDayRoutes.Name = "pnlCurrentDayRoutes";
            this.pnlCurrentDayRoutes.Size = new System.Drawing.Size(420, 328);
            this.pnlCurrentDayRoutes.TabIndex = 1;
            // 
            // frmDefaultRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 414);
            this.Controls.Add(this.pnlCurrentDayRoutes);
            this.Controls.Add(this.btnSetRoutes);
            this.Name = "frmDefaultRoutes";
            this.Text = "frmDefaultRoutes";
            this.Load += new System.EventHandler(this.frmDefaultRoutes_Load);
            this.ResumeLayout(false);

        }
        public System.Windows.Forms.Button btnSetRoutes = new System.Windows.Forms.Button();
        public System.Windows.Forms.Panel pnlCurrentDayRoutes = new System.Windows.Forms.Panel();

        #endregion
    }
}