namespace WinClient
{

    //[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class InputForm : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        internal System.Windows.Forms.TextBox txtCustomerID;
        internal System.Windows.Forms.Label lblCustomerID;
        internal System.Windows.Forms.Label lblComment;
        internal System.Windows.Forms.TextBox txtComment;
        internal System.Windows.Forms.Label lblCustomerName;
        internal System.Windows.Forms.Panel pnlDataEntry;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label lblCustomerCity;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        //[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listboxCustomer = new System.Windows.Forms.ListBox();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.grpAddPickup = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDefaultRouteID = new System.Windows.Forms.Label();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
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
            this.pnlCustomerDetails = new System.Windows.Forms.Panel();
            this.lblOrigCustID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnSaveCustomerInfo = new System.Windows.Forms.Button();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtClosingTime = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grpRoute = new System.Windows.Forms.GroupBox();
            this.lblDefaultDriver = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.txtDefaultRoute = new System.Windows.Forms.TextBox();
            this.lblDefaultRoute = new System.Windows.Forms.Label();
            this.txtDefaultDriverID = new System.Windows.Forms.TextBox();
            this.bsrcCustomerList = new System.Windows.Forms.BindingSource(this.components);
            this.tabControllInput = new System.Windows.Forms.TabControl();
            this.tabpageDataEntry = new System.Windows.Forms.TabPage();
            this.tabpageCustomerDetails = new System.Windows.Forms.TabPage();
            this.pnlDataEntry.SuspendLayout();
            this.grpAddPickup.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.pnlCustomerDetails.SuspendLayout();
            this.grpRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCustomerList)).BeginInit();
            this.tabControllInput.SuspendLayout();
            this.tabpageDataEntry.SuspendLayout();
            this.tabpageCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxCustomer
            // 
            this.listboxCustomer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCustomer.ItemHeight = 14;
            this.listboxCustomer.Location = new System.Drawing.Point(12, 279);
            this.listboxCustomer.Name = "listboxCustomer";
            this.listboxCustomer.Size = new System.Drawing.Size(281, 270);
            this.listboxCustomer.TabIndex = 2;
            this.listboxCustomer.SelectedIndexChanged += new System.EventHandler(this.listboxCustomer_SelectedIndexChanged);
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDataEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataEntry.Controls.Add(this.grpAddPickup);
            this.pnlDataEntry.Controls.Add(this.lblCustomerID);
            this.pnlDataEntry.Controls.Add(this.txtCustomerID);
            this.pnlDataEntry.Controls.Add(this.lblComment);
            this.pnlDataEntry.Controls.Add(this.txtComment);
            this.pnlDataEntry.Location = new System.Drawing.Point(6, 6);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(535, 235);
            this.pnlDataEntry.TabIndex = 2;
            // 
            // grpAddPickup
            // 
            this.grpAddPickup.Controls.Add(this.lblCustomerName);
            this.grpAddPickup.Controls.Add(this.lblDefaultRouteID);
            this.grpAddPickup.Controls.Add(this.lblCustomerCity);
            this.grpAddPickup.Location = new System.Drawing.Point(129, 119);
            this.grpAddPickup.Name = "grpAddPickup";
            this.grpAddPickup.Size = new System.Drawing.Size(271, 91);
            this.grpAddPickup.TabIndex = 10;
            this.grpAddPickup.TabStop = false;
            this.grpAddPickup.Text = "Customer";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(6, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(255, 20);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "lbCustomerName";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDefaultRouteID
            // 
            this.lblDefaultRouteID.AutoSize = true;
            this.lblDefaultRouteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultRouteID.Location = new System.Drawing.Point(6, 65);
            this.lblDefaultRouteID.Name = "lblDefaultRouteID";
            this.lblDefaultRouteID.Size = new System.Drawing.Size(112, 13);
            this.lblDefaultRouteID.TabIndex = 9;
            this.lblDefaultRouteID.Text = "RouteText 123456";
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCity.Location = new System.Drawing.Point(6, 38);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(126, 20);
            this.lblCustomerCity.TabIndex = 5;
            this.lblCustomerCity.Text = "lblCustomerCity";
            this.lblCustomerCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Location = new System.Drawing.Point(8, 4);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(74, 23);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID:";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(88, 4);
            this.txtCustomerID.MaxLength = 10;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(85, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // lblComment
            // 
            this.lblComment.Location = new System.Drawing.Point(8, 42);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(74, 23);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = "Pickup Text:";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(88, 45);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(169, 20);
            this.txtComment.TabIndex = 6;
            this.txtComment.TabStop = false;
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
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.BackColor = System.Drawing.Color.MistyRose;
            this.pnlCustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomerDetails.Controls.Add(this.lblOrigCustID);
            this.pnlCustomerDetails.Controls.Add(this.lblCustName);
            this.pnlCustomerDetails.Controls.Add(this.txtCustomerName);
            this.pnlCustomerDetails.Controls.Add(this.lblCustId);
            this.pnlCustomerDetails.Controls.Add(this.txtCustID);
            this.pnlCustomerDetails.Controls.Add(this.btnSaveCustomerInfo);
            this.pnlCustomerDetails.Controls.Add(this.txtAddress2);
            this.pnlCustomerDetails.Controls.Add(this.txtAddress1);
            this.pnlCustomerDetails.Controls.Add(this.txtState);
            this.pnlCustomerDetails.Controls.Add(this.lblAddress1);
            this.pnlCustomerDetails.Controls.Add(this.lblCity);
            this.pnlCustomerDetails.Controls.Add(this.lblState);
            this.pnlCustomerDetails.Controls.Add(this.txtCity);
            this.pnlCustomerDetails.Controls.Add(this.txtContact);
            this.pnlCustomerDetails.Controls.Add(this.txtClosingTime);
            this.pnlCustomerDetails.Controls.Add(this.lblPhone);
            this.pnlCustomerDetails.Controls.Add(this.lblContact);
            this.pnlCustomerDetails.Controls.Add(this.lblClosingTime);
            this.pnlCustomerDetails.Controls.Add(this.txtPhone);
            this.pnlCustomerDetails.Controls.Add(this.grpRoute);
            this.pnlCustomerDetails.Location = new System.Drawing.Point(3, 6);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(534, 232);
            this.pnlCustomerDetails.TabIndex = 8;
            this.pnlCustomerDetails.Visible = false;
            // 
            // lblOrigCustID
            // 
            this.lblOrigCustID.AutoSize = true;
            this.lblOrigCustID.Enabled = false;
            this.lblOrigCustID.Location = new System.Drawing.Point(207, 19);
            this.lblOrigCustID.Name = "lblOrigCustID";
            this.lblOrigCustID.Size = new System.Drawing.Size(96, 13);
            this.lblOrigCustID.TabIndex = 11;
            this.lblOrigCustID.Text = "InvisibleOrigCustID";
            this.lblOrigCustID.Visible = false;
            // 
            // lblCustName
            // 
            this.lblCustName.Location = new System.Drawing.Point(16, 46);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(98, 20);
            this.lblCustName.TabIndex = 10;
            this.lblCustName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 39);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(152, 20);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.TabStop = false;
            // 
            // lblCustId
            // 
            this.lblCustId.BackColor = System.Drawing.Color.MistyRose;
            this.lblCustId.Location = new System.Drawing.Point(16, 16);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(98, 20);
            this.lblCustId.TabIndex = 0;
            this.lblCustId.Text = "Customer ID:";
            // 
            // txtCustID
            // 
            this.txtCustID.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustID.Location = new System.Drawing.Point(120, 16);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(80, 20);
            this.txtCustID.TabIndex = 1;
            this.txtCustID.TabStop = false;
            // 
            // btnSaveCustomerInfo
            // 
            this.btnSaveCustomerInfo.Location = new System.Drawing.Point(212, 187);
            this.btnSaveCustomerInfo.Name = "btnSaveCustomerInfo";
            this.btnSaveCustomerInfo.Size = new System.Drawing.Size(110, 40);
            this.btnSaveCustomerInfo.TabIndex = 10;
            this.btnSaveCustomerInfo.TabStop = false;
            this.btnSaveCustomerInfo.Text = "&Save Customer Info";
            this.btnSaveCustomerInfo.Click += new System.EventHandler(this.BtnSaveCustomerInfo_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(66, 119);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(187, 20);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.TabStop = false;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(66, 95);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(187, 20);
            this.txtAddress1.TabIndex = 3;
            this.txtAddress1.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(225, 143);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(28, 20);
            this.txtState.TabIndex = 9;
            this.txtState.TabStop = false;
            // 
            // lblAddress1
            // 
            this.lblAddress1.Location = new System.Drawing.Point(3, 99);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(55, 16);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Address:";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(16, 147);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 16);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(181, 147);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 16);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(66, 143);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(95, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.TabStop = false;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(395, 35);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(123, 20);
            this.txtContact.TabIndex = 6;
            this.txtContact.TabStop = false;
            // 
            // txtClosingTime
            // 
            this.txtClosingTime.Location = new System.Drawing.Point(395, 59);
            this.txtClosingTime.Name = "txtClosingTime";
            this.txtClosingTime.Size = new System.Drawing.Size(123, 20);
            this.txtClosingTime.TabIndex = 9;
            this.txtClosingTime.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(331, 11);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(331, 35);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(56, 16);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact:";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.Location = new System.Drawing.Point(307, 59);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(80, 16);
            this.lblClosingTime.TabIndex = 0;
            this.lblClosingTime.Text = "Closing Time:";
            this.lblClosingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(395, 11);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TabStop = false;
            // 
            // grpRoute
            // 
            this.grpRoute.Controls.Add(this.lblDefaultDriver);
            this.grpRoute.Controls.Add(this.txtRouteName);
            this.grpRoute.Controls.Add(this.txtDefaultRoute);
            this.grpRoute.Controls.Add(this.lblDefaultRoute);
            this.grpRoute.Controls.Add(this.txtDefaultDriverID);
            this.grpRoute.Location = new System.Drawing.Point(272, 85);
            this.grpRoute.Name = "grpRoute";
            this.grpRoute.Size = new System.Drawing.Size(248, 93);
            this.grpRoute.TabIndex = 5;
            this.grpRoute.TabStop = false;
            this.grpRoute.Text = "Route";
            // 
            // lblDefaultDriver
            // 
            this.lblDefaultDriver.Location = new System.Drawing.Point(1, 50);
            this.lblDefaultDriver.Name = "lblDefaultDriver";
            this.lblDefaultDriver.Size = new System.Drawing.Size(79, 16);
            this.lblDefaultDriver.TabIndex = 3;
            this.lblDefaultDriver.Text = "Default Driver:";
            this.lblDefaultDriver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRouteName
            // 
            this.txtRouteName.Enabled = false;
            this.txtRouteName.Location = new System.Drawing.Point(120, 24);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(126, 20);
            this.txtRouteName.TabIndex = 1;
            this.txtRouteName.TabStop = false;
            // 
            // txtDefaultRoute
            // 
            this.txtDefaultRoute.Location = new System.Drawing.Point(83, 24);
            this.txtDefaultRoute.MaxLength = 2;
            this.txtDefaultRoute.Name = "txtDefaultRoute";
            this.txtDefaultRoute.Size = new System.Drawing.Size(29, 20);
            this.txtDefaultRoute.TabIndex = 0;
            this.txtDefaultRoute.TabStop = false;
            // 
            // lblDefaultRoute
            // 
            this.lblDefaultRoute.Location = new System.Drawing.Point(1, 24);
            this.lblDefaultRoute.Name = "lblDefaultRoute";
            this.lblDefaultRoute.Size = new System.Drawing.Size(79, 16);
            this.lblDefaultRoute.TabIndex = 0;
            this.lblDefaultRoute.Text = "Default Route:";
            this.lblDefaultRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDefaultDriverID
            // 
            this.txtDefaultDriverID.Enabled = false;
            this.txtDefaultDriverID.Location = new System.Drawing.Point(83, 50);
            this.txtDefaultDriverID.Name = "txtDefaultDriverID";
            this.txtDefaultDriverID.Size = new System.Drawing.Size(29, 20);
            this.txtDefaultDriverID.TabIndex = 2;
            this.txtDefaultDriverID.TabStop = false;
            // 
            // tabControllInput
            // 
            this.tabControllInput.Controls.Add(this.tabpageDataEntry);
            this.tabControllInput.Controls.Add(this.tabpageCustomerDetails);
            this.tabControllInput.Location = new System.Drawing.Point(2, 3);
            this.tabControllInput.Name = "tabControllInput";
            this.tabControllInput.SelectedIndex = 0;
            this.tabControllInput.ShowToolTips = true;
            this.tabControllInput.Size = new System.Drawing.Size(552, 270);
            this.tabControllInput.TabIndex = 9;
            // 
            // tabpageDataEntry
            // 
            this.tabpageDataEntry.Controls.Add(this.pnlDataEntry);
            this.tabpageDataEntry.Location = new System.Drawing.Point(4, 22);
            this.tabpageDataEntry.Name = "tabpageDataEntry";
            this.tabpageDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDataEntry.Size = new System.Drawing.Size(544, 244);
            this.tabpageDataEntry.TabIndex = 0;
            this.tabpageDataEntry.Text = "Enter Pickups";
            this.tabpageDataEntry.ToolTipText = "Use this screen to enter AllPickupsToday";
            this.tabpageDataEntry.UseVisualStyleBackColor = true;
            // 
            // tabpageCustomerDetails
            // 
            this.tabpageCustomerDetails.Controls.Add(this.pnlCustomerDetails);
            this.tabpageCustomerDetails.Location = new System.Drawing.Point(4, 22);
            this.tabpageCustomerDetails.Name = "tabpageCustomerDetails";
            this.tabpageCustomerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCustomerDetails.Size = new System.Drawing.Size(544, 244);
            this.tabpageCustomerDetails.TabIndex = 1;
            this.tabpageCustomerDetails.Text = "Edit Customers";
            this.tabpageCustomerDetails.ToolTipText = "Edit and Change CustomerID, et al";
            this.tabpageCustomerDetails.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 417);
            this.ControlBox = false;
            this.Controls.Add(this.listboxCustomer);
            this.Controls.Add(this.tabControllInput);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 425);
            this.Name = "InputForm";
            this.ShowInTaskbar = false;
            this.Text = "Input";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlDataEntry.PerformLayout();
            this.grpAddPickup.ResumeLayout(false);
            this.grpAddPickup.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.pnlCustomerDetails.ResumeLayout(false);
            this.pnlCustomerDetails.PerformLayout();
            this.grpRoute.ResumeLayout(false);
            this.grpRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcCustomerList)).EndInit();
            this.tabControllInput.ResumeLayout(false);
            this.tabpageDataEntry.ResumeLayout(false);
            this.tabpageCustomerDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        //Friend WithEvents mnuCloseRoutes As System.Windows.Forms.MenuItem
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.TextBox TextBox12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TextBox13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox TextBox14;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.TextBox TextBox15;
        internal System.Windows.Forms.TextBox TextBox16;
        internal System.Windows.Forms.TextBox TextBox17;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox TextBox18;
        internal System.Windows.Forms.TextBox TextBox19;
        internal System.Windows.Forms.TextBox TextBox20;
        internal System.Windows.Forms.TextBox TextBox21;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox TextBox22;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox TextBox23;
        internal System.Windows.Forms.TextBox TextBox24;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox TextBox25;
        internal System.Windows.Forms.ListBox listboxCustomer;
        internal System.Windows.Forms.Panel pnlCustomerDetails;
        internal System.Windows.Forms.Label lblCustName;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.Label lblCustId;
        internal System.Windows.Forms.TextBox txtCustID;
        internal System.Windows.Forms.Button btnSaveCustomerInfo;
        internal System.Windows.Forms.TextBox txtAddress2;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.Label lblAddress1;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.Label lblState;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.TextBox txtClosingTime;
        internal System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.Label lblContact;
        internal System.Windows.Forms.Label lblClosingTime;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.GroupBox grpRoute;
        internal System.Windows.Forms.Label lblDefaultDriver;
        internal System.Windows.Forms.TextBox txtRouteName;
        internal System.Windows.Forms.TextBox txtDefaultRoute;
        internal System.Windows.Forms.Label lblDefaultRoute;
        internal System.Windows.Forms.TextBox txtDefaultDriverID;
        internal System.Windows.Forms.Label lblDefaultRouteID;
        internal System.Windows.Forms.GroupBox grpAddPickup;
        internal System.Windows.Forms.Label lblOrigCustID;
        internal System.Windows.Forms.BindingSource bsrcCustomerList;
        internal System.Windows.Forms.TabControl tabControllInput;
        internal System.Windows.Forms.TabPage tabpageDataEntry;
        internal System.Windows.Forms.TabPage tabpageCustomerDetails;

    }
}