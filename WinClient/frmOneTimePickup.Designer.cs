namespace WinClient
{
    partial class frmOneTimePickup
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.comboRoutes = new System.Windows.Forms.ComboBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.txtPickupTableId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxDaysOfWeek = new System.Windows.Forms.GroupBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.txtInputCustomerName = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtDefaultRouteID = new System.Windows.Forms.TextBox();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.lblPickupText = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dpkrPickupDate = new System.Windows.Forms.DateTimePicker();
            this.lblDefaultRouteID = new System.Windows.Forms.Label();
            this.lblPickupDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnSaveAndAddAnother = new System.Windows.Forms.Button();
            this.txtInputCustomerID = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.gbxDaysOfWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.lstCustomers, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(777, 422);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // lstCustomers
            // 
            this.lstCustomers.ColumnWidth = 300;
            this.lstCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCustomers.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.ItemHeight = 12;
            this.lstCustomers.Location = new System.Drawing.Point(391, 3);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(383, 412);
            this.lstCustomers.TabIndex = 9;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.comboRoutes);
            this.Panel1.Controls.Add(this.txtCustomerCity);
            this.Panel1.Controls.Add(this.lblCustomerCity);
            this.Panel1.Controls.Add(this.txtPickupTableId);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.gbxDaysOfWeek);
            this.Panel1.Controls.Add(this.txtInputCustomerName);
            this.Panel1.Controls.Add(this.txtComment);
            this.Panel1.Controls.Add(this.txtCustomerName);
            this.Panel1.Controls.Add(this.txtCustomerID);
            this.Panel1.Controls.Add(this.txtDefaultRouteID);
            this.Panel1.Controls.Add(this.btnSaveAndClose);
            this.Panel1.Controls.Add(this.lblPickupText);
            this.Panel1.Controls.Add(this.lblCustomerName);
            this.Panel1.Controls.Add(this.dpkrPickupDate);
            this.Panel1.Controls.Add(this.lblDefaultRouteID);
            this.Panel1.Controls.Add(this.lblPickupDate);
            this.Panel1.Controls.Add(this.lblCustomerID);
            this.Panel1.Controls.Add(this.btnSaveAndAddAnother);
            this.Panel1.Controls.Add(this.txtInputCustomerID);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(382, 416);
            this.Panel1.TabIndex = 10;
            // 
            // comboRoutes
            // 
            this.comboRoutes.FormattingEnabled = true;
            this.comboRoutes.Location = new System.Drawing.Point(186, 75);
            this.comboRoutes.Name = "comboRoutes";
            this.comboRoutes.Size = new System.Drawing.Size(146, 21);
            this.comboRoutes.TabIndex = 32;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Enabled = false;
            this.txtCustomerCity.Location = new System.Drawing.Point(132, 124);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerCity.TabIndex = 29;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.Location = new System.Drawing.Point(23, 125);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerCity.TabIndex = 30;
            this.lblCustomerCity.Text = "Customer City:";
            this.lblCustomerCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPickupTableId
            // 
            this.txtPickupTableId.Enabled = false;
            this.txtPickupTableId.Location = new System.Drawing.Point(132, 203);
            this.txtPickupTableId.Name = "txtPickupTableId";
            this.txtPickupTableId.Size = new System.Drawing.Size(200, 20);
            this.txtPickupTableId.TabIndex = 27;
            this.txtPickupTableId.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(22, 203);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 16);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Key:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label1.Visible = false;
            // 
            // gbxDaysOfWeek
            // 
            this.gbxDaysOfWeek.Controls.Add(this.chkMonday);
            this.gbxDaysOfWeek.Controls.Add(this.chkTuesday);
            this.gbxDaysOfWeek.Controls.Add(this.chkWednesday);
            this.gbxDaysOfWeek.Controls.Add(this.chkThursday);
            this.gbxDaysOfWeek.Controls.Add(this.chkFriday);
            this.gbxDaysOfWeek.Location = new System.Drawing.Point(14, 241);
            this.gbxDaysOfWeek.Name = "gbxDaysOfWeek";
            this.gbxDaysOfWeek.Size = new System.Drawing.Size(328, 88);
            this.gbxDaysOfWeek.TabIndex = 26;
            this.gbxDaysOfWeek.TabStop = false;
            this.gbxDaysOfWeek.Text = "Days Of Week";
            // 
            // chkMonday
            // 
            this.chkMonday.Location = new System.Drawing.Point(16, 24);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(72, 24);
            this.chkMonday.TabIndex = 0;
            this.chkMonday.Text = "Monday";
            // 
            // chkTuesday
            // 
            this.chkTuesday.Location = new System.Drawing.Point(120, 24);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(98, 24);
            this.chkTuesday.TabIndex = 0;
            this.chkTuesday.Text = "Tuesday";
            // 
            // chkWednesday
            // 
            this.chkWednesday.Location = new System.Drawing.Point(224, 24);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(104, 24);
            this.chkWednesday.TabIndex = 0;
            this.chkWednesday.Text = "Wednesday";
            // 
            // chkThursday
            // 
            this.chkThursday.Location = new System.Drawing.Point(72, 56);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(96, 24);
            this.chkThursday.TabIndex = 0;
            this.chkThursday.Text = "Thursday";
            // 
            // chkFriday
            // 
            this.chkFriday.Location = new System.Drawing.Point(225, 56);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(72, 24);
            this.chkFriday.TabIndex = 0;
            this.chkFriday.Text = "Friday";
            // 
            // txtInputCustomerName
            // 
            this.txtInputCustomerName.Location = new System.Drawing.Point(14, 345);
            this.txtInputCustomerName.Name = "txtInputCustomerName";
            this.txtInputCustomerName.Size = new System.Drawing.Size(72, 20);
            this.txtInputCustomerName.TabIndex = 25;
            this.txtInputCustomerName.Visible = false;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(132, 150);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(200, 20);
            this.txtComment.TabIndex = 18;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(132, 99);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 17;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerID.Location = new System.Drawing.Point(132, 51);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(88, 20);
            this.txtCustomerID.TabIndex = 12;
            // 
            // txtDefaultRouteID
            // 
            this.txtDefaultRouteID.Location = new System.Drawing.Point(132, 75);
            this.txtDefaultRouteID.Name = "txtDefaultRouteID";
            this.txtDefaultRouteID.Size = new System.Drawing.Size(48, 20);
            this.txtDefaultRouteID.TabIndex = 14;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Enabled = false;
            this.btnSaveAndClose.Location = new System.Drawing.Point(102, 345);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(136, 23);
            this.btnSaveAndClose.TabIndex = 20;
            this.btnSaveAndClose.Text = "Save And Close";
            // 
            // lblPickupText
            // 
            this.lblPickupText.Location = new System.Drawing.Point(22, 151);
            this.lblPickupText.Name = "lblPickupText";
            this.lblPickupText.Size = new System.Drawing.Size(100, 16);
            this.lblPickupText.TabIndex = 23;
            this.lblPickupText.Text = "Pickup Text:";
            this.lblPickupText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(22, 99);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Customer Name:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dpkrPickupDate
            // 
            this.dpkrPickupDate.Location = new System.Drawing.Point(132, 27);
            this.dpkrPickupDate.Name = "dpkrPickupDate";
            this.dpkrPickupDate.Size = new System.Drawing.Size(200, 20);
            this.dpkrPickupDate.TabIndex = 22;
            // 
            // lblDefaultRouteID
            // 
            this.lblDefaultRouteID.Location = new System.Drawing.Point(22, 75);
            this.lblDefaultRouteID.Name = "lblDefaultRouteID";
            this.lblDefaultRouteID.Size = new System.Drawing.Size(100, 16);
            this.lblDefaultRouteID.TabIndex = 13;
            this.lblDefaultRouteID.Text = "Default Route ID:";
            this.lblDefaultRouteID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPickupDate
            // 
            this.lblPickupDate.Location = new System.Drawing.Point(22, 27);
            this.lblPickupDate.Name = "lblPickupDate";
            this.lblPickupDate.Size = new System.Drawing.Size(100, 16);
            this.lblPickupDate.TabIndex = 15;
            this.lblPickupDate.Text = "Pickup Date:";
            this.lblPickupDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Location = new System.Drawing.Point(22, 51);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerID.TabIndex = 16;
            this.lblCustomerID.Text = "Customer ID:";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSaveAndAddAnother
            // 
            this.btnSaveAndAddAnother.Enabled = false;
            this.btnSaveAndAddAnother.Location = new System.Drawing.Point(102, 385);
            this.btnSaveAndAddAnother.Name = "btnSaveAndAddAnother";
            this.btnSaveAndAddAnother.Size = new System.Drawing.Size(136, 23);
            this.btnSaveAndAddAnother.TabIndex = 21;
            this.btnSaveAndAddAnother.Text = "Save And Add Another";
            // 
            // txtInputCustomerID
            // 
            this.txtInputCustomerID.Location = new System.Drawing.Point(14, 377);
            this.txtInputCustomerID.Name = "txtInputCustomerID";
            this.txtInputCustomerID.Size = new System.Drawing.Size(72, 20);
            this.txtInputCustomerID.TabIndex = 24;
            this.txtInputCustomerID.Visible = false;
            // 
            // frmOneTimePickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 422);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "frmOneTimePickup";
            this.Text = "frmOneTimePickup";
            this.Load += new System.EventHandler(this.frmOneTimePickup_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.gbxDaysOfWeek.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        System.Windows.Forms.ListBox lstCustomers;
        System.Windows.Forms.Panel Panel1;
        System.Windows.Forms.TextBox txtPickupTableId;
        System.Windows.Forms.Label Label1;
        System.Windows.Forms.GroupBox gbxDaysOfWeek;
        System.Windows.Forms.CheckBox chkMonday;
        System.Windows.Forms.CheckBox chkTuesday;
        System.Windows.Forms.CheckBox chkWednesday;
        System.Windows.Forms.CheckBox chkThursday;
        System.Windows.Forms.CheckBox chkFriday;
        System.Windows.Forms.TextBox txtInputCustomerName;
        System.Windows.Forms.TextBox txtComment;
        System.Windows.Forms.TextBox txtCustomerName;
        System.Windows.Forms.TextBox txtCustomerID;
        System.Windows.Forms.TextBox txtDefaultRouteID;
        System.Windows.Forms.Button btnSaveAndClose;
        System.Windows.Forms.Label lblPickupText;
        System.Windows.Forms.Label lblCustomerName;
        System.Windows.Forms.DateTimePicker dpkrPickupDate;
        System.Windows.Forms.Label lblDefaultRouteID;
        System.Windows.Forms.Label lblPickupDate;
        System.Windows.Forms.Label lblCustomerID;
        System.Windows.Forms.Button btnSaveAndAddAnother;
        System.Windows.Forms.TextBox txtInputCustomerID;
        System.Windows.Forms.TextBox txtCustomerCity;
        System.Windows.Forms.Label lblCustomerCity;
        System.Windows.Forms.ComboBox comboRoutes;
        #endregion
    }
}