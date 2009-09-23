namespace WinClient //Dispatch3
{
    partial class MainForm
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

        //Required by the Windows Form Designer
        /*
         * ***/
        private System.Windows.Forms.MenuItem mnuDispatchx;
        private System.Windows.Forms.MenuItem mnuEmptyArchive;
        private System.Windows.Forms.MenuItem mnuCleanUpDatabase;
        private System.Windows.Forms.MenuItem mnuCloseRoutes;
        private System.Windows.Forms.MenuItem mnuSetDispatchDate;
        private System.Windows.Forms.MenuItem mnuRoute;
        private System.Windows.Forms.MenuItem mnuCustomerDetails;
        private System.Windows.Forms.MenuItem mnuDeletePickup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenu mnuRefresh;
        private System.Windows.Forms.MenuItem mnuRefreshRoute;
        private System.Windows.Forms.MenuItem mnuSelectDataSource;
        private System.Windows.Forms.MenuItem mnuAddDailyPickup;
        private System.Windows.Forms.MenuItem mnuAddDriver;
        private System.Windows.Forms.MenuItem mnuRefresh_EditRoute;
        private System.Windows.Forms.MenuItem mnuRefresh_DeleteRoute;
        private System.Windows.Forms.MenuItem mnuEditDeleteDailyPickup;
        //private System.Windows.Forms.MenuItem mnuRefreshRoutes;
        //' mnuEditCustomers As System.Windows.Forms.MenuItem
        //private System.Windows.Forms.TextBox txtDebug;
        //private System.Windows.Forms.MenuItem mnuShowHideMessages;
        //private System.Windows.Forms.MenuItem mnuGetData;
        //private System.Windows.Forms.Timer Timer2;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent() 
    {
        this.components = new System.ComponentModel.Container();
        this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
        this.MenuItem1 = new System.Windows.Forms.MenuItem();
        this.mnuStartOfDay = new System.Windows.Forms.MenuItem();
        this.mnuEndOfDay = new System.Windows.Forms.MenuItem();
        this.mnuCloseRoutes = new System.Windows.Forms.MenuItem();
        this.mnuDefaultRoutes = new System.Windows.Forms.MenuItem();
        this.mnuExit = new System.Windows.Forms.MenuItem();
        this.MenuItem2 = new System.Windows.Forms.MenuItem();
        this.mnuAddDrivers = new System.Windows.Forms.MenuItem();
        this.mnuDeleteDrivers = new System.Windows.Forms.MenuItem();
        this.mnuEditRoutes = new System.Windows.Forms.MenuItem();
        this.MenuItem3 = new System.Windows.Forms.MenuItem();
        this.mnuAddOneTimePickup = new System.Windows.Forms.MenuItem();
        this.mnuEditOneTimePickup = new System.Windows.Forms.MenuItem();
        this.MenuItem4 = new System.Windows.Forms.MenuItem();
        this.mnuSaveWindowPositions = new System.Windows.Forms.MenuItem();
        this.Button4 = new System.Windows.Forms.Button();
        this.TextBox12 = new System.Windows.Forms.TextBox();
        this.Label10 = new System.Windows.Forms.Label();
        this.TextBox13 = new System.Windows.Forms.TextBox();
        this.Label11 = new System.Windows.Forms.Label();
        this.TextBox14 = new System.Windows.Forms.TextBox();
        this.Button5 = new System.Windows.Forms.Button();
        this.TextBox15 = new System.Windows.Forms.TextBox();
        this.TextBox16 = new System.Windows.Forms.TextBox();
        this.TextBox17 = new System.Windows.Forms.TextBox();
        this.Label12 = new System.Windows.Forms.Label();
        this.Label13 = new System.Windows.Forms.Label();
        this.Label14 = new System.Windows.Forms.Label();
        this.Label15 = new System.Windows.Forms.Label();
        this.TextBox18 = new System.Windows.Forms.TextBox();
        this.TextBox19 = new System.Windows.Forms.TextBox();
        this.TextBox20 = new System.Windows.Forms.TextBox();
        this.TextBox21 = new System.Windows.Forms.TextBox();
        this.Label16 = new System.Windows.Forms.Label();
        this.Label17 = new System.Windows.Forms.Label();
        this.Label18 = new System.Windows.Forms.Label();
        this.TextBox22 = new System.Windows.Forms.TextBox();
        this.GroupBox1 = new System.Windows.Forms.GroupBox();
        this.Label19 = new System.Windows.Forms.Label();
        this.TextBox23 = new System.Windows.Forms.TextBox();
        this.TextBox24 = new System.Windows.Forms.TextBox();
        this.Label20 = new System.Windows.Forms.Label();
        this.TextBox25 = new System.Windows.Forms.TextBox();
        this.bsrcCustomerList = new System.Windows.Forms.BindingSource(this.components);
        this.Timer1 = new System.Windows.Forms.Timer(this.components);
        this.sbarMain = new System.Windows.Forms.StatusStrip();
        this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        this.menuItem5 = new System.Windows.Forms.MenuItem();
        this.menuItem6 = new System.Windows.Forms.MenuItem();
        this.menuItem7 = new System.Windows.Forms.MenuItem();
        this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        this.GroupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.bsrcCustomerList)).BeginInit();
        this.sbarMain.SuspendLayout();
        this.SuspendLayout();
        // 
        // MainMenu1
        // 
        this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem4});
        // 
        // MenuItem1
        // 
        this.MenuItem1.Index = 0;
        this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuStartOfDay,
            this.mnuEndOfDay,
            this.mnuCloseRoutes,
            this.mnuDefaultRoutes,
            this.mnuExit});
        this.MenuItem1.Text = "Current Day";
        // 
        // mnuStartOfDay
        // 
        this.mnuStartOfDay.Index = 0;
        this.mnuStartOfDay.Text = "Start of Day";
        this.mnuStartOfDay.Click += new System.EventHandler(this.mnuStartOfDay_Click);
        // 
        // mnuEndOfDay
        // 
        this.mnuEndOfDay.Index = 1;
        this.mnuEndOfDay.Text = "End of Day";
        this.mnuEndOfDay.Click += new System.EventHandler(this.mnuEndOfDay_Click);
        // 
        // mnuCloseRoutes
        // 
        this.mnuCloseRoutes.Index = 2;
        this.mnuCloseRoutes.Text = "Close Routes";
        this.mnuCloseRoutes.Click += new System.EventHandler(this.mnuCloseRoutes_Click);
        // 
        // mnuDefaultRoutes
        // 
        this.mnuDefaultRoutes.Index = 3;
        this.mnuDefaultRoutes.Text = "Set routes for today";
        this.mnuDefaultRoutes.Click += new System.EventHandler(this.mnuDefaultRoutes_Click);
        // 
        // mnuExit
        // 
        this.mnuExit.Index = 4;
        this.mnuExit.Text = "Exit";
        this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
        // 
        // MenuItem2
        // 
        this.MenuItem2.Index = 1;
        this.MenuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAddDrivers,
            this.mnuDeleteDrivers,
            this.mnuEditRoutes});
        this.MenuItem2.Text = "Dispatch";
        // 
        // mnuAddDrivers
        // 
        this.mnuAddDrivers.Index = 0;
        this.mnuAddDrivers.Text = "Add Drivers";
        this.mnuAddDrivers.Click += new System.EventHandler(this.mnuAddDrivers_Click);
        // 
        // mnuDeleteDrivers
        // 
        this.mnuDeleteDrivers.Index = 1;
        this.mnuDeleteDrivers.Text = "Delete Drivers";
        this.mnuDeleteDrivers.Click += new System.EventHandler(this.mnuDeleteDrivers_Click);
        // 
        // mnuEditRoutes
        // 
        this.mnuEditRoutes.Index = 2;
        this.mnuEditRoutes.Text = "Edit Routes";
        this.mnuEditRoutes.Click += new System.EventHandler(this.mnuEditRoutes_Click);
        // 
        // MenuItem3
        // 
        this.MenuItem3.Index = 2;
        this.MenuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAddOneTimePickup,
            this.mnuEditOneTimePickup});
        this.MenuItem3.Text = "Utility";
        // 
        // mnuAddOneTimePickup
        // 
        this.mnuAddOneTimePickup.Index = 0;
        this.mnuAddOneTimePickup.Text = "Add One Time Pickup";
        this.mnuAddOneTimePickup.Click += new System.EventHandler(this.mnuAddOneTimePickup_Click);
        // 
        // mnuEditOneTimePickup
        // 
        this.mnuEditOneTimePickup.Index = 1;
        this.mnuEditOneTimePickup.Text = "Edit Daily Pickups";
        this.mnuEditOneTimePickup.Click += new System.EventHandler(this.mnuEditOneTimePickup_Click);
        // 
        // MenuItem4
        // 
        this.MenuItem4.Index = 3;
        this.MenuItem4.MdiList = true;
        this.MenuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSaveWindowPositions});
        this.MenuItem4.Text = "Window";
        // 
        // mnuSaveWindowPositions
        // 
        this.mnuSaveWindowPositions.Index = 0;
        this.mnuSaveWindowPositions.Text = "&Save Window Positions";
        this.mnuSaveWindowPositions.Click += new System.EventHandler(this.mnuSaveWindowPositions_Click);
        // 
        // Button4
        // 
        this.Button4.Location = new System.Drawing.Point(381, 331);
        this.Button4.Name = "Button4";
        this.Button4.Size = new System.Drawing.Size(110, 40);
        this.Button4.TabIndex = 14;
        this.Button4.Text = "&Close";
        // 
        // TextBox12
        // 
        this.TextBox12.Enabled = false;
        this.TextBox12.Location = new System.Drawing.Point(19, 302);
        this.TextBox12.Name = "TextBox12";
        this.TextBox12.Size = new System.Drawing.Size(232, 20);
        this.TextBox12.TabIndex = 13;
        this.TextBox12.Visible = false;
        // 
        // Label10
        // 
        this.Label10.Location = new System.Drawing.Point(16, 46);
        this.Label10.Name = "Label10";
        this.Label10.Size = new System.Drawing.Size(136, 20);
        this.Label10.TabIndex = 10;
        this.Label10.Text = "Customer Name:";
        // 
        // TextBox13
        // 
        this.TextBox13.Location = new System.Drawing.Point(171, 39);
        this.TextBox13.Name = "TextBox13";
        this.TextBox13.Size = new System.Drawing.Size(337, 20);
        this.TextBox13.TabIndex = 2;
        // 
        // Label11
        // 
        this.Label11.BackColor = System.Drawing.Color.RosyBrown;
        this.Label11.Location = new System.Drawing.Point(16, 16);
        this.Label11.Name = "Label11";
        this.Label11.Size = new System.Drawing.Size(136, 20);
        this.Label11.TabIndex = 0;
        this.Label11.Text = "NEW Customer ID:";
        // 
        // TextBox14
        // 
        this.TextBox14.BackColor = System.Drawing.SystemColors.Control;
        this.TextBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        this.TextBox14.Location = new System.Drawing.Point(171, 16);
        this.TextBox14.Name = "TextBox14";
        this.TextBox14.Size = new System.Drawing.Size(100, 20);
        this.TextBox14.TabIndex = 1;
        // 
        // Button5
        // 
        this.Button5.Location = new System.Drawing.Point(255, 331);
        this.Button5.Name = "Button5";
        this.Button5.Size = new System.Drawing.Size(110, 40);
        this.Button5.TabIndex = 10;
        this.Button5.Text = "&Save Customer Info";
        // 
        // TextBox15
        // 
        this.TextBox15.Location = new System.Drawing.Point(80, 111);
        this.TextBox15.Name = "TextBox15";
        this.TextBox15.Size = new System.Drawing.Size(224, 20);
        this.TextBox15.TabIndex = 5;
        // 
        // TextBox16
        // 
        this.TextBox16.Location = new System.Drawing.Point(80, 87);
        this.TextBox16.Name = "TextBox16";
        this.TextBox16.Size = new System.Drawing.Size(224, 20);
        this.TextBox16.TabIndex = 3;
        // 
        // TextBox17
        // 
        this.TextBox17.Location = new System.Drawing.Point(80, 159);
        this.TextBox17.Name = "TextBox17";
        this.TextBox17.Size = new System.Drawing.Size(48, 20);
        this.TextBox17.TabIndex = 9;
        // 
        // Label12
        // 
        this.Label12.Location = new System.Drawing.Point(3, 87);
        this.Label12.Name = "Label12";
        this.Label12.Size = new System.Drawing.Size(69, 16);
        this.Label12.TabIndex = 0;
        this.Label12.Text = "Address:";
        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label13
        // 
        this.Label13.Location = new System.Drawing.Point(16, 135);
        this.Label13.Name = "Label13";
        this.Label13.Size = new System.Drawing.Size(56, 16);
        this.Label13.TabIndex = 0;
        this.Label13.Text = "City:";
        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label14
        // 
        this.Label14.Location = new System.Drawing.Point(16, 159);
        this.Label14.Name = "Label14";
        this.Label14.Size = new System.Drawing.Size(56, 16);
        this.Label14.TabIndex = 0;
        this.Label14.Text = "State:";
        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label15
        // 
        this.Label15.Enabled = false;
        this.Label15.Location = new System.Drawing.Point(136, 159);
        this.Label15.Name = "Label15";
        this.Label15.Size = new System.Drawing.Size(56, 16);
        this.Label15.TabIndex = 0;
        this.Label15.Text = "Zip:";
        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label15.Visible = false;
        // 
        // TextBox18
        // 
        this.TextBox18.Location = new System.Drawing.Point(80, 135);
        this.TextBox18.Name = "TextBox18";
        this.TextBox18.Size = new System.Drawing.Size(224, 20);
        this.TextBox18.TabIndex = 7;
        // 
        // TextBox19
        // 
        this.TextBox19.Enabled = false;
        this.TextBox19.Location = new System.Drawing.Point(204, 159);
        this.TextBox19.Name = "TextBox19";
        this.TextBox19.Size = new System.Drawing.Size(100, 20);
        this.TextBox19.TabIndex = 6;
        this.TextBox19.Visible = false;
        // 
        // TextBox20
        // 
        this.TextBox20.Location = new System.Drawing.Point(408, 111);
        this.TextBox20.Name = "TextBox20";
        this.TextBox20.Size = new System.Drawing.Size(100, 20);
        this.TextBox20.TabIndex = 6;
        // 
        // TextBox21
        // 
        this.TextBox21.Location = new System.Drawing.Point(408, 135);
        this.TextBox21.Name = "TextBox21";
        this.TextBox21.Size = new System.Drawing.Size(100, 20);
        this.TextBox21.TabIndex = 9;
        // 
        // Label16
        // 
        this.Label16.Location = new System.Drawing.Point(344, 87);
        this.Label16.Name = "Label16";
        this.Label16.Size = new System.Drawing.Size(56, 16);
        this.Label16.TabIndex = 0;
        this.Label16.Text = "Phone:";
        this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label17
        // 
        this.Label17.Location = new System.Drawing.Point(344, 111);
        this.Label17.Name = "Label17";
        this.Label17.Size = new System.Drawing.Size(56, 16);
        this.Label17.TabIndex = 0;
        this.Label17.Text = "Contact:";
        this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Label18
        // 
        this.Label18.Location = new System.Drawing.Point(320, 135);
        this.Label18.Name = "Label18";
        this.Label18.Size = new System.Drawing.Size(80, 16);
        this.Label18.TabIndex = 0;
        this.Label18.Text = "Closing Time:";
        this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TextBox22
        // 
        this.TextBox22.Location = new System.Drawing.Point(408, 87);
        this.TextBox22.Name = "TextBox22";
        this.TextBox22.Size = new System.Drawing.Size(100, 20);
        this.TextBox22.TabIndex = 4;
        // 
        // GroupBox1
        // 
        this.GroupBox1.Controls.Add(this.Label19);
        this.GroupBox1.Controls.Add(this.TextBox23);
        this.GroupBox1.Controls.Add(this.TextBox24);
        this.GroupBox1.Controls.Add(this.Label20);
        this.GroupBox1.Controls.Add(this.TextBox25);
        this.GroupBox1.Location = new System.Drawing.Point(19, 192);
        this.GroupBox1.Name = "GroupBox1";
        this.GroupBox1.Size = new System.Drawing.Size(288, 104);
        this.GroupBox1.TabIndex = 5;
        this.GroupBox1.TabStop = false;
        this.GroupBox1.Text = "Route";
        // 
        // Label19
        // 
        this.Label19.Location = new System.Drawing.Point(40, 72);
        this.Label19.Name = "Label19";
        this.Label19.Size = new System.Drawing.Size(100, 16);
        this.Label19.TabIndex = 3;
        this.Label19.Text = "Default Driver:";
        this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TextBox23
        // 
        this.TextBox23.Enabled = false;
        this.TextBox23.Location = new System.Drawing.Point(8, 48);
        this.TextBox23.Name = "TextBox23";
        this.TextBox23.Size = new System.Drawing.Size(272, 20);
        this.TextBox23.TabIndex = 1;
        // 
        // TextBox24
        // 
        this.TextBox24.Location = new System.Drawing.Point(152, 24);
        this.TextBox24.MaxLength = 2;
        this.TextBox24.Name = "TextBox24";
        this.TextBox24.Size = new System.Drawing.Size(56, 20);
        this.TextBox24.TabIndex = 0;
        // 
        // Label20
        // 
        this.Label20.Location = new System.Drawing.Point(40, 24);
        this.Label20.Name = "Label20";
        this.Label20.Size = new System.Drawing.Size(100, 16);
        this.Label20.TabIndex = 0;
        this.Label20.Text = "Default Route:";
        this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TextBox25
        // 
        this.TextBox25.Enabled = false;
        this.TextBox25.Location = new System.Drawing.Point(152, 72);
        this.TextBox25.Name = "TextBox25";
        this.TextBox25.Size = new System.Drawing.Size(56, 20);
        this.TextBox25.TabIndex = 2;
        // 
        // Timer1
        // 
        this.Timer1.Enabled = true;
        this.Timer1.Interval = 1000;
        this.Timer1.Tag = "Synch";
        this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
        // 
        // sbarMain
        // 
        this.sbarMain.BackColor = System.Drawing.Color.Beige;
        this.sbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
        this.sbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
        this.sbarMain.Location = new System.Drawing.Point(0, 573);
        this.sbarMain.Name = "sbarMain";
        this.sbarMain.Size = new System.Drawing.Size(926, 22);
        this.sbarMain.SizingGrip = false;
        this.sbarMain.TabIndex = 1;
        this.sbarMain.Text = "sbarMain";
        // 
        // statusLabel
        // 
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new System.Drawing.Size(66, 17);
        this.statusLabel.Text = "startinglabel";
        this.statusLabel.ToolTipText = "text for toolStripStatusLabel1";
        // 
        // menuItem5
        // 
        this.menuItem5.Index = -1;
        this.menuItem5.Text = "";
        // 
        // menuItem6
        // 
        this.menuItem6.Index = -1;
        this.menuItem6.Text = "";
        // 
        // menuItem7
        // 
        this.menuItem7.Index = -1;
        this.menuItem7.Text = "";
        // 
        // toolStripProgressBar1
        // 
        this.toolStripProgressBar1.Name = "toolStripProgressBar1";
        this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(926, 595);
        this.Controls.Add(this.sbarMain);
        this.IsMdiContainer = true;
        this.Menu = this.MainMenu1;
        this.Name = "MainForm";
        this.Text = "Ross Dispatch  *** Version 3.0**";
        this.GroupBox1.ResumeLayout(false);
        this.GroupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.bsrcCustomerList)).EndInit();
        this.sbarMain.ResumeLayout(false);
        this.sbarMain.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

}
#endregion 
        private System.Windows.Forms.MainMenu MainMenu1;
        
        
            private System.Windows.Forms.MenuItem  MenuItem1;
            private System.Windows.Forms.MenuItem  mnuStartOfDay;
            private System.Windows.Forms.MenuItem  mnuEndOfDay;
            //Friend WithEvents mnuCloseRoutes;
            private System.Windows.Forms.MenuItem  MenuItem2;
            private System.Windows.Forms.MenuItem  mnuDeleteDrivers;
            private System.Windows.Forms.MenuItem  mnuEditRoutes;
            private System.Windows.Forms.MenuItem  mnuAddOneTimePickup;
            private System.Windows.Forms.MenuItem  MenuItem3;
            private System.Windows.Forms.MenuItem  MenuItem4;
            private System.Windows.Forms.Button  Button4;
            private System.Windows.Forms.TextBox  TextBox12;
            private System.Windows.Forms.Label  Label10;
            private System.Windows.Forms.TextBox  TextBox13;
            private System.Windows.Forms.Label  Label11;
            private System.Windows.Forms.TextBox  TextBox14;
            private System.Windows.Forms.Button  Button5;
            private System.Windows.Forms.TextBox  TextBox15;
            private System.Windows.Forms.TextBox  TextBox16;
            private System.Windows.Forms.TextBox  TextBox17;
            private System.Windows.Forms.Label  Label12;
            private System.Windows.Forms.Label  Label13;
            private System.Windows.Forms.Label  Label14;
            private System.Windows.Forms.Label  Label15;

            private System.Windows.Forms.TextBox  TextBox18;
            private System.Windows.Forms.TextBox  TextBox19;
            private System.Windows.Forms.TextBox TextBox20;
            private System.Windows.Forms.TextBox TextBox21;
            private System.Windows.Forms.Label Label16;
            private System.Windows.Forms.Label Label17;
            private System.Windows.Forms.Label Label18;
            private System.Windows.Forms.TextBox TextBox22;
            private System.Windows.Forms.GroupBox GroupBox1;
            private System.Windows.Forms.Label Label19;
            private System.Windows.Forms.TextBox TextBox23;
            private System.Windows.Forms.TextBox TextBox24;
            private System.Windows.Forms.Label Label20;
            private System.Windows.Forms.TextBox TextBox25;
            //private System.Windows.Forms.MenuItem mnuSaveWindowPositions;
            private System.Windows.Forms.MenuItem mnuEditOneTimePickup;
            private System.Windows.Forms.BindingSource bsrcCustomerList;
            private System.Windows.Forms.MenuItem mnuDefaultRoutes;
            private System.Windows.Forms.MenuItem mnuExit;
            private System.Windows.Forms.Timer Timer1;
            private System.Windows.Forms.MenuItem mnuAddDrivers;
            private System.Windows.Forms.StatusStrip sbarMain;
            //private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
            private System.Windows.Forms.MenuItem menuItem5;
            private System.Windows.Forms.MenuItem menuItem6;
            private System.Windows.Forms.MenuItem menuItem7;
            private System.Windows.Forms.MenuItem mnuSaveWindowPositions;
            private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
            private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}
