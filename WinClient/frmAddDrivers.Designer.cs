namespace Dispatch3
{
[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
partial class frmAddDrivers : System.Windows.Forms.Form
{

    public frmAddDrivers()
        : base()
    {

        //This call is required by the Windows Form Designer.

        //Add any initialization after the InitializeComponent() call

        InitializeComponent();
    }

    //Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    //NOTE: The following procedure is required by the Windows Form Designer
    //It can be modified using the Windows Form Designer.  
    //Do not modify it using the code editor.
    internal System.Windows.Forms.Label lblDriverID;
    internal System.Windows.Forms.Label lblFirstName;
    internal System.Windows.Forms.Label lblMiddleInitial;
    internal System.Windows.Forms.Label lblLastName;
    internal System.Windows.Forms.TextBox txtDriverID;
    internal System.Windows.Forms.TextBox txtFirstName;
    internal System.Windows.Forms.TextBox txtLastName;
    internal System.Windows.Forms.TextBox txtMiddleInitial;
    internal System.Windows.Forms.Button btnSaveAndClose;
    internal System.Windows.Forms.Button btnSaveAndAddAnother;
    internal System.Windows.Forms.Button btnClearForm;

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

    //NOTE: The following procedure is required by the Windows Form Designer
    //It can be modified using the Windows Form Designer.  
    //Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
        this.lblDriverID = new System.Windows.Forms.Label();
        this.lblFirstName = new System.Windows.Forms.Label();
        this.lblMiddleInitial = new System.Windows.Forms.Label();
        this.lblLastName = new System.Windows.Forms.Label();
        this.txtDriverID = new System.Windows.Forms.TextBox();
        this.txtFirstName = new System.Windows.Forms.TextBox();
        this.txtLastName = new System.Windows.Forms.TextBox();
        this.txtMiddleInitial = new System.Windows.Forms.TextBox();
        this.btnSaveAndClose = new System.Windows.Forms.Button();
        this.btnSaveAndAddAnother = new System.Windows.Forms.Button();
        this.btnClearForm = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lblDriverID
        // 
        this.lblDriverID.Location = new System.Drawing.Point(8, 8);
        this.lblDriverID.Name = "lblDriverID";
        this.lblDriverID.Size = new System.Drawing.Size(88, 20);
        this.lblDriverID.TabIndex = 0;
        this.lblDriverID.Text = "Driver ID:";
        this.lblDriverID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblFirstName
        // 
        this.lblFirstName.Location = new System.Drawing.Point(8, 32);
        this.lblFirstName.Name = "lblFirstName";
        this.lblFirstName.Size = new System.Drawing.Size(88, 20);
        this.lblFirstName.TabIndex = 0;
        this.lblFirstName.Text = "First Name:";
        this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblMiddleInitial
        // 
        this.lblMiddleInitial.Location = new System.Drawing.Point(8, 56);
        this.lblMiddleInitial.Name = "lblMiddleInitial";
        this.lblMiddleInitial.Size = new System.Drawing.Size(88, 20);
        this.lblMiddleInitial.TabIndex = 0;
        this.lblMiddleInitial.Text = "Middle Initial:";
        this.lblMiddleInitial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblLastName
        // 
        this.lblLastName.Location = new System.Drawing.Point(8, 80);
        this.lblLastName.Name = "lblLastName";
        this.lblLastName.Size = new System.Drawing.Size(88, 20);
        this.lblLastName.TabIndex = 0;
        this.lblLastName.Text = "Last Name:";
        this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtDriverID
        // 
        this.txtDriverID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        this.txtDriverID.Location = new System.Drawing.Point(104, 8);
        this.txtDriverID.MaxLength = 2;
        this.txtDriverID.Name = "txtDriverID";
        this.txtDriverID.Size = new System.Drawing.Size(40, 20);
        this.txtDriverID.TabIndex = 1;
        // 
        // txtFirstName
        // 
        this.txtFirstName.Location = new System.Drawing.Point(104, 32);
        this.txtFirstName.Name = "txtFirstName";
        this.txtFirstName.Size = new System.Drawing.Size(168, 20);
        this.txtFirstName.TabIndex = 2;
        // 
        // txtLastName
        // 
        this.txtLastName.Location = new System.Drawing.Point(104, 80);
        this.txtLastName.Name = "txtLastName";
        this.txtLastName.Size = new System.Drawing.Size(168, 20);
        this.txtLastName.TabIndex = 4;
        // 
        // txtMiddleInitial
        // 
        this.txtMiddleInitial.Location = new System.Drawing.Point(104, 56);
        this.txtMiddleInitial.MaxLength = 1;
        this.txtMiddleInitial.Name = "txtMiddleInitial";
        this.txtMiddleInitial.Size = new System.Drawing.Size(40, 20);
        this.txtMiddleInitial.TabIndex = 3;
        // 
        // btnSaveAndClose
        // 
        this.btnSaveAndClose.Location = new System.Drawing.Point(72, 120);
        this.btnSaveAndClose.Name = "btnSaveAndClose";
        this.btnSaveAndClose.Size = new System.Drawing.Size(136, 23);
        this.btnSaveAndClose.TabIndex = 5;
        this.btnSaveAndClose.Text = "Save and Close";
        this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
        // 
        // 
        // btnSaveAndAddAnother
        // 
        this.btnSaveAndAddAnother.Location = new System.Drawing.Point(72, 160);
        this.btnSaveAndAddAnother.Name = "btnSaveAndAddAnother";
        this.btnSaveAndAddAnother.Size = new System.Drawing.Size(136, 23);
        this.btnSaveAndAddAnother.TabIndex = 6;
        this.btnSaveAndAddAnother.Text = "Save and Add Another";
        this.btnSaveAndAddAnother.Click += new System.EventHandler(this.btnSaveAndAddAnother_Click );
        // 
        // btnClearForm
        // 
        this.btnClearForm.Location = new System.Drawing.Point(72, 200);
        this.btnClearForm.Name = "btnClearForm";
        this.btnClearForm.Size = new System.Drawing.Size(136, 23);
        this.btnClearForm.TabIndex = 7;
        this.btnClearForm.Text = "Clear Form";
        this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
        // 
        // frmAddDrivers
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(280, 229);
        this.Controls.Add(this.btnSaveAndClose);
        this.Controls.Add(this.btnSaveAndAddAnother);
        this.Controls.Add(this.btnClearForm);
        this.Controls.Add(this.txtFirstName);
        this.Controls.Add(this.txtDriverID);
        this.Controls.Add(this.lblDriverID);
        this.Controls.Add(this.lblFirstName);
        this.Controls.Add(this.lblMiddleInitial);
        this.Controls.Add(this.lblLastName);
        this.Controls.Add(this.txtLastName);
        this.Controls.Add(this.txtMiddleInitial);
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Name = "frmAddDrivers";
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.Text = "Add Driver";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
}

}