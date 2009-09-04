namespace WinClient.Driver
{
    partial class frmDriver
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
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.DRIVERTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverSyncIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverCreatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverCreatedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverEditedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverEditedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverSentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverSentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverSendConfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverReceivedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DRIVERTableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverTableIDDataGridViewTextBoxColumn,
            this.driverIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleInitialDataGridViewTextBoxColumn,
            this.driverSyncIDDataGridViewTextBoxColumn,
            this.driverCreatedByDataGridViewTextBoxColumn,
            this.driverCreatedTimeDataGridViewTextBoxColumn,
            this.driverEditedByDataGridViewTextBoxColumn,
            this.driverEditedTimeDataGridViewTextBoxColumn,
            this.driverSentDataGridViewTextBoxColumn,
            this.driverSentTimeDataGridViewTextBoxColumn,
            this.driverSendConfirmedDataGridViewTextBoxColumn,
            this.driverReceivedTimeDataGridViewTextBoxColumn,
            this.terminalDataGridViewTextBoxColumn,
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
            this.dataGridViewEmployee.DataSource = this.DRIVERTableBindingSource;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 49);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(464, 363);
            this.dataGridViewEmployee.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(63, 16);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(78, 20);
            this.textBoxID.TabIndex = 1;
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
            this.panel1.Size = new System.Drawing.Size(464, 49);
            this.panel1.TabIndex = 2;
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
            // DRIVERTableBindingSource
            // 
            this.DRIVERTableBindingSource.DataSource = typeof(DispatchAR.DRIVERTable);
            // 
            // driverTableIDDataGridViewTextBoxColumn
            // 
            this.driverTableIDDataGridViewTextBoxColumn.DataPropertyName = "DriverTableID";
            this.driverTableIDDataGridViewTextBoxColumn.HeaderText = "DriverTableID";
            this.driverTableIDDataGridViewTextBoxColumn.Name = "driverTableIDDataGridViewTextBoxColumn";
            this.driverTableIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            this.driverIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleInitialDataGridViewTextBoxColumn
            // 
            this.middleInitialDataGridViewTextBoxColumn.DataPropertyName = "MiddleInitial";
            this.middleInitialDataGridViewTextBoxColumn.HeaderText = "MiddleInitial";
            this.middleInitialDataGridViewTextBoxColumn.Name = "middleInitialDataGridViewTextBoxColumn";
            this.middleInitialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverSyncIDDataGridViewTextBoxColumn
            // 
            this.driverSyncIDDataGridViewTextBoxColumn.DataPropertyName = "DriverSyncID";
            this.driverSyncIDDataGridViewTextBoxColumn.HeaderText = "DriverSyncID";
            this.driverSyncIDDataGridViewTextBoxColumn.Name = "driverSyncIDDataGridViewTextBoxColumn";
            this.driverSyncIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverCreatedByDataGridViewTextBoxColumn
            // 
            this.driverCreatedByDataGridViewTextBoxColumn.DataPropertyName = "DriverCreatedBy";
            this.driverCreatedByDataGridViewTextBoxColumn.HeaderText = "DriverCreatedBy";
            this.driverCreatedByDataGridViewTextBoxColumn.Name = "driverCreatedByDataGridViewTextBoxColumn";
            this.driverCreatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverCreatedTimeDataGridViewTextBoxColumn
            // 
            this.driverCreatedTimeDataGridViewTextBoxColumn.DataPropertyName = "DriverCreatedTime";
            this.driverCreatedTimeDataGridViewTextBoxColumn.HeaderText = "DriverCreatedTime";
            this.driverCreatedTimeDataGridViewTextBoxColumn.Name = "driverCreatedTimeDataGridViewTextBoxColumn";
            this.driverCreatedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverEditedByDataGridViewTextBoxColumn
            // 
            this.driverEditedByDataGridViewTextBoxColumn.DataPropertyName = "DriverEditedBy";
            this.driverEditedByDataGridViewTextBoxColumn.HeaderText = "DriverEditedBy";
            this.driverEditedByDataGridViewTextBoxColumn.Name = "driverEditedByDataGridViewTextBoxColumn";
            this.driverEditedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverEditedTimeDataGridViewTextBoxColumn
            // 
            this.driverEditedTimeDataGridViewTextBoxColumn.DataPropertyName = "DriverEditedTime";
            this.driverEditedTimeDataGridViewTextBoxColumn.HeaderText = "DriverEditedTime";
            this.driverEditedTimeDataGridViewTextBoxColumn.Name = "driverEditedTimeDataGridViewTextBoxColumn";
            this.driverEditedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverSentDataGridViewTextBoxColumn
            // 
            this.driverSentDataGridViewTextBoxColumn.DataPropertyName = "DriverSent";
            this.driverSentDataGridViewTextBoxColumn.HeaderText = "DriverSent";
            this.driverSentDataGridViewTextBoxColumn.Name = "driverSentDataGridViewTextBoxColumn";
            this.driverSentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverSentTimeDataGridViewTextBoxColumn
            // 
            this.driverSentTimeDataGridViewTextBoxColumn.DataPropertyName = "DriverSentTime";
            this.driverSentTimeDataGridViewTextBoxColumn.HeaderText = "DriverSentTime";
            this.driverSentTimeDataGridViewTextBoxColumn.Name = "driverSentTimeDataGridViewTextBoxColumn";
            this.driverSentTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverSendConfirmedDataGridViewTextBoxColumn
            // 
            this.driverSendConfirmedDataGridViewTextBoxColumn.DataPropertyName = "DriverSendConfirmed";
            this.driverSendConfirmedDataGridViewTextBoxColumn.HeaderText = "DriverSendConfirmed";
            this.driverSendConfirmedDataGridViewTextBoxColumn.Name = "driverSendConfirmedDataGridViewTextBoxColumn";
            this.driverSendConfirmedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverReceivedTimeDataGridViewTextBoxColumn
            // 
            this.driverReceivedTimeDataGridViewTextBoxColumn.DataPropertyName = "DriverReceivedTime";
            this.driverReceivedTimeDataGridViewTextBoxColumn.HeaderText = "DriverReceivedTime";
            this.driverReceivedTimeDataGridViewTextBoxColumn.Name = "driverReceivedTimeDataGridViewTextBoxColumn";
            this.driverReceivedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            this.terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            this.terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            this.terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            this.terminalDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 412);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDriver";
            this.Text = "Manage Driver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DRIVERTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverSyncIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverCreatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverCreatedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverEditedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverEditedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverSentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverSentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverSendConfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverReceivedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource DRIVERTableBindingSource;
    }
}