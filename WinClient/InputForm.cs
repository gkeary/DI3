using System.IO;
using System.ComponentModel;
using DispatchAR;
using System.Text;
using System.Xml;
using System.Collections;
using System.Windows.Forms;
using WinClient;
namespace WinClent //WinClient
{
partial class InputForm: Form
{
    #region "Declarations"

    static internal CurrentDayRouteCollection CDRCollection = new CurrentDayRouteCollection();
    static internal CurrentDayRouteController CDRController = new CurrentDayRouteController();
    static internal CurrentDayPickupCollection CDPCollection = new CurrentDayPickupCollection();
    static internal CurrentDayPickupController CDPController = new CurrentDayPickupController();

    public int intCDPSyncCount = 0;
    public static bool blnWindowOpen = false;
    public static bool blnDayStarted = false;
    public static object objSourcePickup = new object();
    // declarations for mainform listbox functionality
    public Hashtable PickupHash = new Hashtable();
    //Public CustomerHash1 As Hashtable = New Hashtable()  'bug is this hash redundant?
    public Hashtable CustomerHash = new Hashtable();
    public Hashtable Route2Hash = new Hashtable();
    public CustomerListBoxHelper Helper = new CustomerListBoxHelper();
    //Private mCustomerListCollection As VCustomerListCollection = New VCustomerListCollection()
    public CustomerCollection mCustomerCollection = new CustomerCollection();
    public ROUTE2Collection mRoute2Collection = new ROUTE2Collection();
    //lstCustAddPickup should have a binding source?
    private BindingSource CustomerBindingSource = new BindingSource();
    //Private tick As Integer = 0
    private Form DestinationForm;
    private Form SourceForm;
    //Private SourceRow As DataGridViewRow
    private const var CtrlMask = 8;
    //private MainForm MainWindow; // this.ParentForm;
    private StringBuilder StringSoFar = new StringBuilder();
    #endregion
    #region "Initializing routines"
    ///<summary>
    /// Default, no argument constructor for the InputForm
    ///</summary>
    /// <remarks>
    /// loads hashes PickupHash,Route2Hash,customerHash
    /// contains logic based upon MainForm.blnDayStarted
    /// </remarks>
    public InputForm()
    {

        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // Add any initialization after the InitializeComponent() call.
        // initialize the collections and hashes...
        mRoute2Collection.Load();
        mCustomerCollection.Load();
        mCustomerCollection.Sort("InfoString", true);
        CustomerListBoxHelper.PopulateCustomerHash();
        CustomerListBoxHelper.PopulateRoute2Hash();
        pnlCustomerDetails.Visible = true;
        //\MainWindow =  (MainForm) this.ParentForm;

        if (MainForm.blnDayStarted)
        {
            //LoadMDIRoutes()
            PickupHash = CustomerListBoxHelper.PopulatePickupHash();
            Route2Hash = CustomerListBoxHelper.PopulateRoute2Hash();
            CustomerHash = CustomerListBoxHelper.PopulateCustomerHash();
        }
    }
    private void  // ERROR: Handles clauses are not supported in C#
InputForm_Load(object sender, System.EventArgs e)
    {
        if (Program.ScreenArray.Count == 0 | Program.ScreenArray == null)
        {
            this.Text = "Input";
            this.Top = 0;
            this.Left = 0;
            this.Width = 725;
            this.Height = 500;
        }
        else
        {
            // requires that TabForm occupies Program.ScreenArray.Item(0) AND
            // requires that Input   occupies Program.ScreenArray.Item(LAST)
            int lastindex = Program.ScreenArray.Count() - 1;
            this.Text = "Input";
            this.Top = Program.ScreenArray.Item(lastindex).TopInt;
            this.Left = Program.ScreenArray.Item(lastindex).LeftInt;
            this.Width = Program.ScreenArray.Item(lastindex).WidthInt;
            this.Height = Program.ScreenArray.Item(lastindex).HeightInt;
        }
        this.Tag = this.Text;

        txtCustomerID.Focus();

        // this should occur at load time and also at refresh
        bsrcCustomerList.DataSource = mCustomerCollection;

        bsrcCustomerList.DataSource = mCustomerCollection;
        listboxCustomer.DataSource = bsrcCustomerList;
        listboxCustomer.DisplayMember = "InfoString";
        listboxCustomer.ValueMember = "CustomerID";

        listboxCustomer.SelectedIndex += 1;
        listboxCustomer.SelectedIndex -= 1;
        //move down and back up so event gets fired.
        //set the  binding on one control so we can see how it works.
        //txtCustomerName.DataBindings.Add("Text", mCustomerCollection, "CustomerName", True)
        txtClosingTime.DataBindings.Add("Text", mCustomerCollection, "ClosingTime", true);
    }
    #endregion

    public void RefreshInputWindowControls()
    {
        // try setting the bindingsource and listbox data bindings
        // every time the window is refreshed.
        listboxCustomer.BindingContext = null;
        bsrcCustomerList.DataSource = mCustomerCollection;
        listboxCustomer.DataSource = bsrcCustomerList;
        listboxCustomer.DisplayMember = "InfoString";
        listboxCustomer.ValueMember = "CustomerID";

        //is this a kluge?  will it come back and bite me?
        //throws an exception if this test not present
        if (listboxCustomer.SelectedIndex == -1)
        {
            listboxCustomer.SelectedIndex = 0;
        }
        Customer cust = listboxCustomer.SelectedItem;

        //'now populate customer related values on pnlAddpickup from lstCustomer
        lblDefaultRouteID.Text = "Default route: " + cust.DefaultRouteID + " " + CustomerListBoxHelper.GetRoute2RouteName(cust.DefaultRouteID);
        lblCustomerName.Text = cust.CustomerName;
        lblCustomerCity.Text = cust.City;

        // do not set this to Cust.CustomerID, let the keyboard events handle it
        txtCustomerID.Text = "";
        //cust.CustomerID

        // now do the pnlcustomer details 
        //txtCustomerName.Text = cust.CustomerName
        txtCustID.Text = cust.CustomerID;
        lblOrigCustID.Text = cust.CustomerID;
        txtAddress1.Text = cust.Address1;
        txtAddress2.Text = cust.Address2;
        txtCity.Text = cust.City;
        txtState.Text = cust.State;
        txtContact.Text = cust.Contact;
        txtClosingTime.Text = cust.ClosingTime;
        txtPhone.Text = cust.Phone;

        txtDefaultRoute.Text = cust.DefaultRouteID;
        txtRouteName.Text = CustomerListBoxHelper.GetRoute2RouteName(cust.DefaultRouteID);
        txtDefaultDriverID.Text = CustomerListBoxHelper.GetRoute2DefaultDriverID(cust.DefaultRouteID);
    }

    #region "Data Maintenance"
    /// <summary>
    /// This routine implements the primary functionality of this window.
    /// calls pickup.save(), ReFreshThisRoute()
    /// </summary>
    /// <remarks>
    /// triggered by CRLF in txtComment control
    /// </remarks>
    public void AddPickup()
    {
        //calls pu.save()

        string strCustomerName = null;
        string strComment = " ";
        string strCDPSyncID = null;
        int i = 0;

        lblCustomerName.Text =lblCustomerName.Text == null ? "" : lblCustomerName.Text;
        txtComment.Text =txtComment.Text == null ? "" : txtComment.Text;
        txtComment.Text =txtComment.Text == null ? "" : txtComment.Text;
        strComment =txtComment.Text;

            // force the comment to be only 30 chars long.
            // the database column is only that wide.
            if (strComment.Length > 30)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Only 30 characters allowed");
                sb.AppendLine("Discarding: " + strComment.Substring(31)); 
                   Strings.Mid(strComment, 31));
                MessageBox.Show("Only 30 characters allowed" + Constants.vbCrLf + "Discarding: " + Strings.Mid(strComment, 31));
                strComment = Strings.Mid(strComment, 1, 30);
            }
      

        intCDPSyncCount += 1;
        strCDPSyncID = Environment.MachineName + "_Pkp_" + intCDPSyncCount.ToString;
        CurrentDayPickup pu = new CurrentDayPickup();
        pu.CDPSyncID = strCDPSyncID;
        pu.CDPCustomerName = strCustomerName;
        // use the hidden one here
        pu.CDPCustomerID = pnlCustomerDetails.Controls.Item("lblOrigCustID").Text;
        //pu.CDPCustomerID = txtCustomerID.Text
        pu.CDPComment = strComment;
        pu.CDPPickupDate = Today;
        pu.CDPDefaultRouteID = txtDefaultRoute.Text;
        pu.CDPDispatched = false;
        pu.CDPStation = Environment.MachineName;
        pu.CDPChecked = false;
        pu.UserName = Environment.UserName;
        pu.PostedCount = My.MySettings.Default.ActiveStations - 1;
        pu.Terminal = My.MySettings.Default.Terminal;
        pu.CDPCreatedBy = Environment.MachineName;
        pu.CDPCreatedTime = Now;
        pu.CDPEditedBy = "";
        pu.Save();

        // post it
        int pendingUpdates = My.MySettings.Default.ActiveStations - 1;
        string initiatingUser = Environment.UserName;
        Posting job = new Posting(pu, pendingUpdates, initiatingUser);
        job.Save();

        //Me.ParentForm.MdiChildren(0).Tag
        frmRoute frm = default(frmRoute);
        for (i = 0; i <= this.ParentForm.MdiChildren.Length - 1; i++)
        {
            if (((this.ParentForm.MdiChildren(i)) is TabForm | (this.ParentForm.MdiChildren(i)) is InputForm))
            {
                continue;
            }
            if ((txtDefaultRoute.Text == this.ParentForm.MdiChildren(i).Text.Substring(0, 2)))
            {
                frm = this.ParentForm.MdiChildren(i);
                frm.RefreshDynamicPickupControls();
                //MainWindow.RefreshThisRoute(frm) ' sometimes threw an exception 
                break; // TODO: might not be correct. Was : Exit For
            }
        }

        //ClearCustomerInfo()
        txtComment.Text = "";
        txtCustomerID.Text = "";
        txtCustomerID.Focus();
    }
    public void ClearCustomerInfo()
    {
        txtCustomerID.Text = "";
        lblCustomerName.Text = "";
        lblCustomerCity.Text = "";
        txtComment.Text = "";
        txtAddress1.Text = "";
        txtAddress2.Text = "";
        txtCity.Text = "";
        txtState.Text = "";
        //txtZip.Text = ""
        txtPhone.Text = "";
        txtContact.Text = "";
        txtClosingTime.Text = "";
        lblDefaultRouteID.Text = "";
        txtDefaultDriverID.Text = "";
    }
    public void PostCustomerChange(ref int custtableId)
    {
        int pendingUpdates = My.MySettings.Default.ActiveStations - 1;
        string initiatingUser = Environment.UserName;
        Posting job = new Posting(custtableId, pendingUpdates, initiatingUser);
        job.Save();
    }
    public object ExecuteSpUpdateCustomer()
    {
        string strCustomerID = null;
        string strCustomerName = null;
        string strAddress1 = null;
        string strAddress2 = null;
        string strContact = null;
        string strClosingTime = "";
        string strComment = "\"";
        int result = 0;

        // setup and vet the parameters...    

        if ((txtCustID.Text.Length == 0 | txtCustID.Text == System.DBNull.Value))
        {
            strCustomerID = "";
            MessageBox.Show("Customer ID cannot be empty. Please choose a unique one");
            return -1;
        }
        else
        {
            strCustomerID = Strings.Replace(txtCustID.Text, "'", "''");
        }

        //If (txtCustID.Text <> txtCustomerID.Text) Then
        if ((Strings.RTrim(txtCustID.Text) != lblOrigCustID.Text))
        {
            strCustomerID = Strings.UCase(Strings.RTrim(txtCustID.Text));

            if (CustomerHash.Contains(txtCustID.Text))
            {
                MessageBox.Show("This Customer ID is in use. Please choose another");
                return -1;
            }
        }

        if ((txtCustomerName.Text.Length == 0))
        {
            strCustomerName = "";
            MessageBox.Show("Customer Name cannot be empty. Please type one in");
            return -1;
        }
        else
        {
            strCustomerName = Strings.Replace(txtCustomerName.Text, "'", "''");
        }

        if ((txtCity.Text.Length == 0))
        {
            MessageBox.Show("Customer City cannot be empty. Please type one in");
            return -1;
        }
        else
        {
            txtCity.Text = Strings.Replace(txtCity.Text, "'", "''");
        }

        if ((txtDefaultRoute.Text.Length == 0))
        {
            MessageBox.Show("Default route cannot be empty. Please choose one and type it in.");
            return -1;
        }
        else
        {
            txtDefaultRoute.Text = Strings.Replace(txtDefaultRoute.Text, "'", "''");
        }

        strAddress1 = Strings.Replace(txtAddress1.Text, "'", "''");
        strAddress2 = Strings.Replace(txtAddress2.Text, "'", "''");
        strContact = Strings.Replace(txtContact.Text, "'", "''");
        string strCity = txtCity.Text;
        string strState = txtState.Text;
        string strPhone = txtPhone.Text;
        int intcustomertableid = 0;
        intcustomertableid = CustomerHash(lblOrigCustID.Text).CustomerTableID;

        int rc = 0;
        //execute the puppy...

        try
        {
            SPs.PUpdateCustomer(rc, intcustomertableid, strCustomerID, strCustomerName, txtDefaultRoute.Text, CustomerHash(lblOrigCustID.Text).CustomerSyncID, strAddress1, strAddress2, strCity, txtState.Text,
            txtPhone.Text, txtClosingTime.Text, strContact, strComment).Execute();
            lblCustomerName.Text = strCustomerName;
        }
        catch (Exception ex)
        {
            MessageBox.Show("SP UPdateCustomer Failed");
        }
        //If rc <> 0 Then
        //End If
        //always successful ??
        return 0;
    }
    #endregion

    #region "Eventhandlers"
    private void  // ERROR: Handles clauses are not supported in C#
listboxCustomer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if ((e.KeyValue == 13))
        {
            // the order of these 3 statements is important
            RefreshInputWindowControls();
            txtCustomerID.Text = sender.selectedvalue;
            txtComment.Focus();
            StringSoFar.Length = 0;

        }
    }
    private void  // ERROR: Handles clauses are not supported in C#
listboxCustomer_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        RefreshInputWindowControls();
    }
    private void  // ERROR: Handles clauses are not supported in C#
BtnSaveCustomerInfo_Click(System.Object sender, System.EventArgs e)
    {
        int result = 0;
        result = ExecuteSpUpdateCustomer();
        if (result == 0)
        {
            CustomerHash = CustomerListBoxHelper.PopulateCustomerHash();

            listboxCustomer.SelectedIndex += 1;
            listboxCustomer.SelectedIndex -= 1;
            UpdateCDPRecords(CustomerHash.Item(lblOrigCustID.Text).CustomerTableID);
            PostCustomerChange(CustomerHash.Item(lblOrigCustID.Text).CustomerTableID);
        }
    }
    private void UpdateCDPRecords(int custTableId)
    {
        CurrentDayPickupCollection cdpcollection = new CurrentDayPickupCollection();
        Customer cust = Customer.FetchByID(custTableId);
        cdpcollection.Load();
        foreach (CurrentDayPickup cdp in cdpcollection)
        {
            if (cdp.CDPCustomerID == cust.CustomerID)
            {
                cdp.CDPCustomerName = cust.CustomerName;
                cdp.Save();
                frmRoute f = ObtainfrmRoute(cdp.CDPDefaultRouteID);
                f.RefreshDynamicPickupControls();
            }
        }
    }
    private frmRoute ObtainfrmRoute(string routeTag)
    {
        frmRoute functionReturnValue = default(frmRoute);
        functionReturnValue = null;
        foreach (Form win in this.ParentForm.MdiChildren())
        {
            if (win is InputForm)
            {
                continue;
            }
            if (win is TabForm)
            {
                continue;
            }
            if (win.Tag == routeTag)
            {
                functionReturnValue = win;
                break; // TODO: might not be correct. Was : Exit For
            }
        }
        return functionReturnValue;
    }
    private void  // ERROR: Handles clauses are not supported in C#
txtComment_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if ((e.KeyValue == 13))
        {
            if ((!string.IsNullOrEmpty(lblCustomerName.Text)))
            {
                AddPickup();

                txtCustomerID.Focus();
                StringSoFar.Length = 0;
            }
        }
    }
    private void  // ERROR: Handles clauses are not supported in C#
listboxCustomer_MouseDoubleClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
    {
        RefreshInputWindowControls();
        txtCustomerID.Text = sender.selectedvalue;
        txtComment.Focus();
        StringSoFar.Length = 0;
    }
    private void  // ERROR: Handles clauses are not supported in C#
txtCustomerID_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
    {
        Customer Cust = default(Customer);
        string TestString = StringSoFar.ToString();
        int CurrentIndex = listboxCustomer.SelectedIndex;
        string nextchar = Strings.UCase(Strings.Chr(e.KeyValue));

        //from a forum someplace:
        //
        //        Keydown is used to receive keys, not chars. Use Keypress to evaluate chars.
        //Keyvalues are not character values. For example, pressing the "A" key fires
        //keydown with keycode = Keys.A, but the resulting char might be "a", "A", or
        //chr(1) depending on the state of the shift and ctrl keys. Another example:
        //function keys. They produce keydown events but no keypress events because
        //they are not translated to chars.

        // maybe I should move this code into the KEYPRESS event ???


        if ((e.KeyValue == 13))
        {
            if ((CustomerHash.Contains(txtCustomerID.Text)))
            {
                Cust = CustomerHash.Item(txtCustomerID.Text);
                txtCustomerID.Text = StringSoFar.ToString();
                //Cust.CustomerID
                lblCustomerName.Text = Cust.CustomerName;
                txtCustomerName.Text = Cust.CustomerName;
                txtDefaultRoute.Text = Cust.DefaultRouteID;
                txtRouteName.Text = CustomerListBoxHelper.GetRoute2RouteName(Cust.DefaultRouteID);
                txtDefaultDriverID.Text = CustomerListBoxHelper.GetRoute2DefaultDriverID(Cust.DefaultRouteID);
                listboxCustomer.SelectedIndex = listboxCustomer.FindStringExact(Cust.InfoString);
                txtComment.Focus();
                StringSoFar.Length = 0;
            }
            else
            {
                int lbmax = listboxCustomer.Items.Count() - 1;
                {
                    listboxCustomer.SelectedIndex = listboxCustomer.FindString(txtCustomerID.Text, listboxCustomer.SelectedIndex);
                    //doing this should 'scroll it'
                    if (listboxCustomer.SelectedIndex < lbmax - 2)
                    {
                        listboxCustomer.SelectedIndex += 2;
                        listboxCustomer.SelectedIndex -= 2;
                    }
                    listboxCustomer.Focus();
                    StringSoFar.Length = 0;
                }
            }
        }
        else
        {
            switch (TestString.Length)
            {
                case 0:
                    //txtCustomerID.Text = ""
                    //txtCustomerID.Text = NextChar
                    StringSoFar.Append(nextchar);
                    listboxCustomer.SelectedIndex = 0;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    StringSoFar.Append(nextchar);
                    break;
                //txtCustomerID.Text = TestString + NextChar
                //lstCustAddPickup.FindString(TestString)
                default:
                    StringSoFar.Append(nextchar);
                    break;
                //txtCustomerID.Text = TestString + NextChar
            }
            if (CustomerHash.Contains(StringSoFar.ToString()))
            {
                //can I write to e?  no, but I can suppress other events... (I hope)
                e.SuppressKeyPress = true;
                //Now we can move to the right listbox entry
                Cust = CustomerHash.Item(StringSoFar.ToString());
                listboxCustomer.SelectedIndex = listboxCustomer.FindStringExact(Cust.InfoString);
                txtCustomerID.Text = StringSoFar.ToString();
            }
            // at this point the display should be correct...
            //but don't change the focus --txtComment.Focus()
        }
    }
    private void btnCloseCustomerList_Click(object sender, System.EventArgs e)
    {
        listboxCustomer.Visible = false;
    }
    #endregion
}

}