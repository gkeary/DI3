namespace WinClient.Customer
{
    partial class frmCustomer
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.CUSTOMERSTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultRouteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSyncIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCreatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCreatedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEditedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEditedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSendConfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerReceivedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualifiedNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasPrimaryKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.primaryKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friendlyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createSqlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropSqlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMERSTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveChanges);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 49);
            this.panel1.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(232, 15);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(103, 19);
            this.buttonSaveChanges.TabIndex = 2;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(63, 16);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(78, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(155, 16);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(62, 19);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoGenerateColumns = false;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.closingTimeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.defaultRouteIDDataGridViewTextBoxColumn,
            this.customerSyncIDDataGridViewTextBoxColumn,
            this.customerCreatedByDataGridViewTextBoxColumn,
            this.customerCreatedTimeDataGridViewTextBoxColumn,
            this.customerEditedByDataGridViewTextBoxColumn,
            this.customerEditedTimeDataGridViewTextBoxColumn,
            this.customerSentDataGridViewTextBoxColumn,
            this.customerSentTimeDataGridViewTextBoxColumn,
            this.customerSendConfirmedDataGridViewTextBoxColumn,
            this.customerReceivedTimeDataGridViewTextBoxColumn,
            this.terminalDataGridViewTextBoxColumn,
            this.infoStringDataGridViewTextBoxColumn,
            this.qualifiedNameDataGridViewTextBoxColumn,
            this.hasPrimaryKeyDataGridViewCheckBoxColumn,
            this.primaryKeyDataGridViewTextBoxColumn,
            this.descriptorDataGridViewTextBoxColumn,
            this.schemaNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.friendlyNameDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.columnsDataGridViewTextBoxColumn,
            this.createSqlDataGridViewTextBoxColumn,
            this.dropSqlDataGridViewTextBoxColumn});
            this.dataGridViewCustomers.DataSource = this.CUSTOMERSTableBindingSource;
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 49);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(488, 357);
            this.dataGridViewCustomers.TabIndex = 1;
            // 
            // CUSTOMERSTableBindingSource
            // 
            this.CUSTOMERSTableBindingSource.DataSource = typeof(DispatchAR.CUSTOMERSTable);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closingTimeDataGridViewTextBoxColumn
            // 
            this.closingTimeDataGridViewTextBoxColumn.DataPropertyName = "ClosingTime";
            this.closingTimeDataGridViewTextBoxColumn.HeaderText = "ClosingTime";
            this.closingTimeDataGridViewTextBoxColumn.Name = "closingTimeDataGridViewTextBoxColumn";
            this.closingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultRouteIDDataGridViewTextBoxColumn
            // 
            this.defaultRouteIDDataGridViewTextBoxColumn.DataPropertyName = "DefaultRouteID";
            this.defaultRouteIDDataGridViewTextBoxColumn.HeaderText = "DefaultRouteID";
            this.defaultRouteIDDataGridViewTextBoxColumn.Name = "defaultRouteIDDataGridViewTextBoxColumn";
            this.defaultRouteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerSyncIDDataGridViewTextBoxColumn
            // 
            this.customerSyncIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerSyncID";
            this.customerSyncIDDataGridViewTextBoxColumn.HeaderText = "CustomerSyncID";
            this.customerSyncIDDataGridViewTextBoxColumn.Name = "customerSyncIDDataGridViewTextBoxColumn";
            this.customerSyncIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCreatedByDataGridViewTextBoxColumn
            // 
            this.customerCreatedByDataGridViewTextBoxColumn.DataPropertyName = "CustomerCreatedBy";
            this.customerCreatedByDataGridViewTextBoxColumn.HeaderText = "CustomerCreatedBy";
            this.customerCreatedByDataGridViewTextBoxColumn.Name = "customerCreatedByDataGridViewTextBoxColumn";
            this.customerCreatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCreatedTimeDataGridViewTextBoxColumn
            // 
            this.customerCreatedTimeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCreatedTime";
            this.customerCreatedTimeDataGridViewTextBoxColumn.HeaderText = "CustomerCreatedTime";
            this.customerCreatedTimeDataGridViewTextBoxColumn.Name = "customerCreatedTimeDataGridViewTextBoxColumn";
            this.customerCreatedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEditedByDataGridViewTextBoxColumn
            // 
            this.customerEditedByDataGridViewTextBoxColumn.DataPropertyName = "CustomerEditedBy";
            this.customerEditedByDataGridViewTextBoxColumn.HeaderText = "CustomerEditedBy";
            this.customerEditedByDataGridViewTextBoxColumn.Name = "customerEditedByDataGridViewTextBoxColumn";
            this.customerEditedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEditedTimeDataGridViewTextBoxColumn
            // 
            this.customerEditedTimeDataGridViewTextBoxColumn.DataPropertyName = "CustomerEditedTime";
            this.customerEditedTimeDataGridViewTextBoxColumn.HeaderText = "CustomerEditedTime";
            this.customerEditedTimeDataGridViewTextBoxColumn.Name = "customerEditedTimeDataGridViewTextBoxColumn";
            this.customerEditedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerSentDataGridViewTextBoxColumn
            // 
            this.customerSentDataGridViewTextBoxColumn.DataPropertyName = "CustomerSent";
            this.customerSentDataGridViewTextBoxColumn.HeaderText = "CustomerSent";
            this.customerSentDataGridViewTextBoxColumn.Name = "customerSentDataGridViewTextBoxColumn";
            this.customerSentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerSentTimeDataGridViewTextBoxColumn
            // 
            this.customerSentTimeDataGridViewTextBoxColumn.DataPropertyName = "CustomerSentTime";
            this.customerSentTimeDataGridViewTextBoxColumn.HeaderText = "CustomerSentTime";
            this.customerSentTimeDataGridViewTextBoxColumn.Name = "customerSentTimeDataGridViewTextBoxColumn";
            this.customerSentTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerSendConfirmedDataGridViewTextBoxColumn
            // 
            this.customerSendConfirmedDataGridViewTextBoxColumn.DataPropertyName = "CustomerSendConfirmed";
            this.customerSendConfirmedDataGridViewTextBoxColumn.HeaderText = "CustomerSendConfirmed";
            this.customerSendConfirmedDataGridViewTextBoxColumn.Name = "customerSendConfirmedDataGridViewTextBoxColumn";
            this.customerSendConfirmedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerReceivedTimeDataGridViewTextBoxColumn
            // 
            this.customerReceivedTimeDataGridViewTextBoxColumn.DataPropertyName = "CustomerReceivedTime";
            this.customerReceivedTimeDataGridViewTextBoxColumn.HeaderText = "CustomerReceivedTime";
            this.customerReceivedTimeDataGridViewTextBoxColumn.Name = "customerReceivedTimeDataGridViewTextBoxColumn";
            this.customerReceivedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            this.terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            this.terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            this.terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            this.terminalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoStringDataGridViewTextBoxColumn
            // 
            this.infoStringDataGridViewTextBoxColumn.DataPropertyName = "InfoString";
            this.infoStringDataGridViewTextBoxColumn.HeaderText = "InfoString";
            this.infoStringDataGridViewTextBoxColumn.Name = "infoStringDataGridViewTextBoxColumn";
            this.infoStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualifiedNameDataGridViewTextBoxColumn
            // 
            this.qualifiedNameDataGridViewTextBoxColumn.DataPropertyName = "QualifiedName";
            this.qualifiedNameDataGridViewTextBoxColumn.HeaderText = "QualifiedName";
            this.qualifiedNameDataGridViewTextBoxColumn.Name = "qualifiedNameDataGridViewTextBoxColumn";
            this.qualifiedNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasPrimaryKeyDataGridViewCheckBoxColumn
            // 
            this.hasPrimaryKeyDataGridViewCheckBoxColumn.DataPropertyName = "HasPrimaryKey";
            this.hasPrimaryKeyDataGridViewCheckBoxColumn.HeaderText = "HasPrimaryKey";
            this.hasPrimaryKeyDataGridViewCheckBoxColumn.Name = "hasPrimaryKeyDataGridViewCheckBoxColumn";
            this.hasPrimaryKeyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // primaryKeyDataGridViewTextBoxColumn
            // 
            this.primaryKeyDataGridViewTextBoxColumn.DataPropertyName = "PrimaryKey";
            this.primaryKeyDataGridViewTextBoxColumn.HeaderText = "PrimaryKey";
            this.primaryKeyDataGridViewTextBoxColumn.Name = "primaryKeyDataGridViewTextBoxColumn";
            this.primaryKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptorDataGridViewTextBoxColumn
            // 
            this.descriptorDataGridViewTextBoxColumn.DataPropertyName = "Descriptor";
            this.descriptorDataGridViewTextBoxColumn.HeaderText = "Descriptor";
            this.descriptorDataGridViewTextBoxColumn.Name = "descriptorDataGridViewTextBoxColumn";
            this.descriptorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemaNameDataGridViewTextBoxColumn
            // 
            this.schemaNameDataGridViewTextBoxColumn.DataPropertyName = "SchemaName";
            this.schemaNameDataGridViewTextBoxColumn.HeaderText = "SchemaName";
            this.schemaNameDataGridViewTextBoxColumn.Name = "schemaNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // friendlyNameDataGridViewTextBoxColumn
            // 
            this.friendlyNameDataGridViewTextBoxColumn.DataPropertyName = "FriendlyName";
            this.friendlyNameDataGridViewTextBoxColumn.HeaderText = "FriendlyName";
            this.friendlyNameDataGridViewTextBoxColumn.Name = "friendlyNameDataGridViewTextBoxColumn";
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // columnsDataGridViewTextBoxColumn
            // 
            this.columnsDataGridViewTextBoxColumn.DataPropertyName = "Columns";
            this.columnsDataGridViewTextBoxColumn.HeaderText = "Columns";
            this.columnsDataGridViewTextBoxColumn.Name = "columnsDataGridViewTextBoxColumn";
            // 
            // createSqlDataGridViewTextBoxColumn
            // 
            this.createSqlDataGridViewTextBoxColumn.DataPropertyName = "CreateSql";
            this.createSqlDataGridViewTextBoxColumn.HeaderText = "CreateSql";
            this.createSqlDataGridViewTextBoxColumn.Name = "createSqlDataGridViewTextBoxColumn";
            this.createSqlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dropSqlDataGridViewTextBoxColumn
            // 
            this.dropSqlDataGridViewTextBoxColumn.DataPropertyName = "DropSql";
            this.dropSqlDataGridViewTextBoxColumn.HeaderText = "DropSql";
            this.dropSqlDataGridViewTextBoxColumn.Name = "dropSqlDataGridViewTextBoxColumn";
            this.dropSqlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 406);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCustomer";
            this.Text = "Manage Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMERSTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultRouteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSyncIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCreatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCreatedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEditedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEditedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSendConfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerReceivedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualifiedNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasPrimaryKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendlyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createSqlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dropSqlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource CUSTOMERSTableBindingSource;
    }
}