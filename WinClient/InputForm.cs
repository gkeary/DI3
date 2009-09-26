using System.IO;
using System.ComponentModel;
using DispatchAR;
using System.Text;
using System.Xml;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace WinClient
{
    partial class InputForm : Form
    {
        #region "Declarations"


        public int intCDPSyncCount = 0;
        public static bool blnWindowOpen = false;
        public static bool blnDayStarted = false;
        public static object objSourcePickup = new object();
        // declarations for mainform listbox functionality
        // public Hashtable CustomerHash = new Hashtable();
        public List<CUSTOMER> inputCustList = Program.CustomerList;
        public List<Route> inputRouteList = Program.RouteList;
        private BindingSource CustomerBindingSource = new BindingSource();
        private Form DestinationForm;
        private Form SourceForm;
        private const int CtrlMask = 8;
        private StringBuilder StringSoFar = new StringBuilder();
        #endregion
        #region "Initializing routines"
        ///<summary>
        /// Default, no argument constructor for the InputForm
        ///</summary>
        /// <remarks>
        /// 
        /// contains logic based upon MainForm.blnDayStarted
        /// </remarks>
        public InputForm()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            pnlCustomerDetails.Visible = true;

            if (MainForm.blnDayStarted)
            {
                if (inputCustList.Count == 0)
                {
                    Program.GetCustomerCollection();
                    inputCustList = Program.CustomerList;
                }
                if (inputRouteList.Count == 0)
                {
                    Program.GetRouteCollection();
                    inputRouteList = Program.RouteList;
                }
            }
        }
        private void InputForm_Load(object sender, System.EventArgs e)
        {

            if (Program.CDRList.Count == 0 | Program.CDRList == null)
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
                //int lastindex = Program.ScreenList.Count - 1;
                this.Text = "Input";

                var inputscreen = Program.ScreenList
                                    .Find(x => x.WinTitle == "Input");
                this.Top = inputscreen.TopInt;
                this.Left = inputscreen.LeftInt;
                this.Width = inputscreen.WidthInt;
                this.Height = inputscreen.HeightInt;
            }
            this.Tag = this.Text;

            txtCustomerID.Focus();

            // this should occur at load time and also at refresh
            bsrcCustomerList.DataSource = inputCustList;

            bsrcCustomerList.DataSource = inputCustList;
            listboxCustomer.DataSource = bsrcCustomerList;
            listboxCustomer.DisplayMember = "InfoString";
            listboxCustomer.ValueMember = "CustomerID";

            listboxCustomer.SelectedIndex += 1;
            listboxCustomer.SelectedIndex -= 1;
            //move down and back up so event gets fired.
            //set the  binding on one control so we can see how it works.
            //txtCustomerName.DataBindings.Add("Text", inputCustList, "CustomerName", True)
            txtClosingTime.DataBindings.Add("Text", inputCustList, "ClosingTime", true);
        }
        #endregion

        public void RefreshInputWindowControls()
        {
            // try setting the bindingsource and listbox data bindings
            // every time the window is refreshed.
            listboxCustomer.BindingContext = null;
            bsrcCustomerList.DataSource = inputCustList;
            listboxCustomer.DataSource = bsrcCustomerList;
            listboxCustomer.DisplayMember = "InfoString";
            listboxCustomer.ValueMember = "CustomerID";

            //is this a kluge?  will it come back and bite me?
            //throws an exception if this test not present
            if (listboxCustomer.SelectedIndex == -1)
            {
                listboxCustomer.SelectedIndex = 0;
            }
            CUSTOMER cust = (CUSTOMER)listboxCustomer.SelectedItem;

            //'now populate customer related values on pnlAddpickup from lstCustomer
            lblDefaultRouteID.Text = "Default route: " +
                  cust.DefaultRouteID + " " +
                  Program.RouteList.Find(x => x.RouteID == cust.DefaultRouteID).RouteName;

            lblCustomerName.Text = cust.CustomerName;
            lblCustomerCity.Text = cust.City;

            // do not set this to Cust.CustomerID, let the keyboard events handle it
            txtCustomerID.Text = "";

            // now do the pnlcustomer details 
            //txtCustomerName.Text = cust.CustomerName
            txtCustID.Text = cust.CustomerID;
            txtCustomerName.Text = cust.CustomerName;
            lblOrigCustID.Text = cust.CustomerID;
            txtAddress1.Text = cust.Address1;
            txtAddress2.Text = cust.Address2;
            txtCity.Text = cust.City;
            txtState.Text = cust.State;
            txtContact.Text = cust.Contact;
            txtClosingTime.Text = cust.ClosingTime;
            txtPhone.Text = cust.Phone;

            txtDefaultRoute.Text = cust.DefaultRouteID;
            // change these so I can eliminate CustomerListBoxHelper.cs
            //txtRouteName.Text = CustomerListBoxHelper.GetRoute2RouteName(cust.DefaultRouteID);
            //txtDefaultDriverID.Text = CustomerListBoxHelper.GetRoute2DefaultDriverID(cust.DefaultRouteID);
            var theRoute = Program.RouteList
                                .Find(x => x.RouteID == cust.DefaultRouteID);

            txtRouteName.Text = theRoute.RouteName;
            txtDefaultDriverID.Text = theRoute.DefaultDriverID;
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

            lblCustomerName.Text = lblCustomerName.Text == null ? "" : lblCustomerName.Text;
            txtComment.Text = txtComment.Text == null ? "" : txtComment.Text;
            txtComment.Text = txtComment.Text == null ? "" : txtComment.Text;
            strComment = txtComment.Text;

            // force the comment to be only 30 chars long.
            // the database column is only that wide.
            if (strComment.Length > 30)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Only 30 characters allowed");
                sb.AppendLine("Discarding: " + strComment.Substring(31));

                MessageBox.Show("Only 30 characters allowed\n Discarding: " + strComment.Substring(31));
                strComment = strComment.Substring(1, 31);
            }


            intCDPSyncCount += 1;
            strCDPSyncID = Environment.MachineName + "_Pkp_" + intCDPSyncCount.ToString();
            CurrentDayPickup pu = new CurrentDayPickup();
            pu.CDPCustomerName = strCustomerName;
            // use the hidden one here

            var lbl = pnlCustomerDetails.Controls.Find("lblOrigCustID", true);
            pu.CDPCustomerID = lbl[0].Text;
            //pu.CDPCustomerID = txtCustomerID.Text
            pu.CDPComment = strComment;
            pu.CDPPickupDate = DateTime.Today;
            pu.CDPDefaultRouteID = txtDefaultRoute.Text;
            pu.CDPDispatched = false;
            pu.CDPStation = Environment.MachineName;
            //pu.CDPChecked = false;
            //pu.UserName = Environment.UserName;
            // needed or not ?? pu.CDPStation = Properties.Settings.Default.ActiveStations - 1;
            //pu.PostedCount = My.MySettings.Default.ActiveStations - 1;
            pu.Terminal = Properties.Settings.Default.terminal;
            //pu.CDPCreatedBy = Environment.MachineName;
            //pu.CDPCreatedTime = Now;
            //pu.CDPEditedBy = "";
            pu.Save();

            // post it
            int pendingUpdates = Properties.Settings.Default.ActiveStations - 1;
            string initiatingUser = Environment.UserName;
            // another mess....
            ///

            //Posting job = new Posting();

            // job.DataType = "CDP";
            // job.= new Posting(pu, pendingUpdates, initiatingUser);
            //Posting job = new Posting(pu, pendingUpdates, initiatingUser);
            //Posting job = new Posting(pu, pendingUpdates, initiatingUser);
            //job.Save();

            //Me.ParentForm.MdiChildren(0).Tag
            frmRoute frm = default(frmRoute);
            for (i = 0; i <= this.ParentForm.MdiChildren.Length - 1; i++)
            {
                if ((this.ParentForm.MdiChildren[i]) is InputForm)
                {
                    continue;
                }
                if ((txtDefaultRoute.Text == this.ParentForm.MdiChildren[i].Text.Substring(0, 2)))
                {
                    frm = (frmRoute)ParentForm.MdiChildren[i];
                    frm.RefreshDynamicPickupControls();
                    //MainWindow.RefreshThisRoute(frm) ' sometimes threw an exception 
                    break; // TODO: might not be correct. Was : Exit For
                }
            }

            ClearCustomerInfo();
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
        public void PostCustomerChange(string custID)
        {
            int pendingUpdates = Properties.Settings.Default.ActiveStations - 1;
            string initiatingUser = Environment.UserName;
            throw new NotImplementedException();

            // this is a mess
            // put it in Program and have it call something in BLL
            // which does the right thing....
            //
            //Posting job = new Posting();        
            //Posting job = new Posting(custId, pendingUpdates, initiatingUser);
            //job.Save();
        }
        public int ExecuteSpUpdateCustomer()
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

            if (txtCustID.Text.Length == 0 | txtCustID.Text == null)
            {
                strCustomerID = "";
                MessageBox.Show("Customer ID cannot be empty. Please choose a unique one");
                return -1;
            }
            else
            {
                strCustomerID = txtCustID.Text.Replace("'", "''");

            }

            //If (txtCustID.Text <> txtCustomerID.Text) Then
            if (txtCustID.Text.Trim() != lblOrigCustID.Text)
            {
                txtCustID.Text = txtCustID.Text.Trim();
                strCustomerID = txtCustID.Text.ToUpper();
                // Strings.UCase(Strings.RTrim(txtCustID.Text));

                var custid = inputCustList
                    .Find(x => x.CustomerID == txtCustID.Text)
                    .CustomerID;
                if (custid != null)
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
                strCustomerName = txtCustomerName.Text.Replace("'", "''");
            }

            if ((txtCity.Text.Length == 0))
            {
                MessageBox.Show("Customer City cannot be empty. Please type one in");
                return -1;
            }
            else
            {
                txtCity.Text = txtCity.Text.Replace("'", "''");
            }

            if ((txtDefaultRoute.Text.Length == 0))
            {
                MessageBox.Show("Default route cannot be empty. Please choose one and type it in.");
                return -1;
            }
            else
            {
                txtDefaultRoute.Text = txtDefaultRoute.Text.Replace("'", "''");
            }

            strAddress1 = txtAddress1.Text.Replace("'", "''");
            strAddress2 = txtAddress2.Text.Replace("'", "''");
            strContact = txtContact.Text.Replace("'", "''");
            string strCity = txtCity.Text;
            string strState = txtState.Text;
            string strPhone = txtPhone.Text;
            //int intcustomertableid = 0;
            //        intcustomertableid = CustomerHash(lblOrigCustID.Text).CustomerTableID;

            int rc = 0;
            //execute the puppy...

            try
            {
                //          SPs.PUpdateCustomer(rc, intcustomertableid, strCustomerID, strCustomerName, txtDefaultRoute.Text, CustomerHash(lblOrigCustID.Text).CustomerSyncID, strAddress1, strAddress2, strCity, txtState.Text,
                //          txtPhone.Text, txtClosingTime.Text, strContact, strComment).Execute();
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
        private void listboxCustomer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.KeyValue == 13))
            {
                // the order of these 3 statements is important
                RefreshInputWindowControls();
                var ss = sender as ListBox;
                txtCustomerID.Text = ss.SelectedValue.ToString();
                txtComment.Focus();
                StringSoFar.Length = 0;

            }
        }
        private void listboxCustomer_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshInputWindowControls();
        }
        private void BtnSaveCustomerInfo_Click(System.Object sender, System.EventArgs e)
        {
            int result = 0;
            result = ExecuteSpUpdateCustomer();
            if (result == 0)
            {
                Program.CustomerList.Clear();
                Program.GetCustomerCollection();

                listboxCustomer.SelectedIndex += 1;
                listboxCustomer.SelectedIndex -= 1;
                UpdateCDPRecords(lblOrigCustID.Text);
                PostCustomerChange(lblOrigCustID.Text);
            }
        }
        private void UpdateCDPRecords(string custID)
        {
            List<CurrentDayPickup> cdpcollection = Program.CDPList;
            CUSTOMER cust = inputCustList.Find(x => x.CustomerID == custID);

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
            foreach (Form win in this.ParentForm.MdiChildren)
            {
                if (win is InputForm)
                {
                    continue;
                }
                if (win.Tag == routeTag)
                {
                    functionReturnValue = (frmRoute)win;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            return functionReturnValue;
        }
        private void txtComment_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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
        private void listboxCustomer_MouseDoubleClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var ss = sender as ListBox;
            RefreshInputWindowControls();
            txtCustomerID.Text = ss.SelectedValue.ToString();
            txtComment.Focus();
            StringSoFar.Length = 0;
        }
        //private void txtCustomerID_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    CUSTOMER Cust = default(CUSTOMER);
        //    string TestString = StringSoFar.ToString();
        //    int CurrentIndex = listboxCustomer.SelectedIndex;
        //    string nextchar = e.KeyValue.ToString().ToUpper();


        //    //from a forum someplace:
        //    //
        //    //        Keydown is used to receive keys, not chars. Use Keypress to evaluate chars.
        //    //Keyvalues are not character values. For example, pressing the "A" key fires
        //    //keydown with keycode = Keys.A, but the resulting char might be "a", "A", or
        //    //chr(1) depending on the state of the shift and ctrl keys. Another example:
        //    //function keys. They produce keydown events but no keypress events because
        //    //they are not translated to chars.

        //    // maybe I should move this code into the KEYPRESS event ???


        //    if ((e.KeyValue == 13))
        //    {
        //        Cust = inputCustList.Find(x => x.CustomerID == txtCustomerID.Text); //CustomerHash.Contains(txtCustomerID.Text)))
        //        if (Cust != null)  //CustomerHash.Contains(txtCustomerID.Text)))
        //        {
        //            Cust = inputCustList.Find(x => x.CustomerID == txtCustomerID.Text);//CustomerHash.Item(txtCustomerID.Text);
        //            txtCustomerID.Text = StringSoFar.ToString();
        //            //Cust.CustomerID
        //            lblCustomerName.Text = Cust.CustomerName;
        //            txtCustomerName.Text = Cust.CustomerName;
        //            txtDefaultRoute.Text = Cust.DefaultRouteID;
        //            txtRouteName.Text = "route2name";//CustomerListBoxHelper.GetRoute2RouteName(Cust.DefaultRouteID);
        //            txtDefaultDriverID.Text = "defaultdriverid";//CustomerListBoxHelper.GetRoute2DefaultDriverID(Cust.DefaultRouteID);
        //            listboxCustomer.SelectedIndex = listboxCustomer.FindStringExact(Cust.InfoString, 0);
        //            txtComment.Focus();
        //            StringSoFar.Length = 0;
        //        }
        //        else
        //        {
        //            {
        //                int lbmax = listboxCustomer.Items.Count - 1;
        //                listboxCustomer.SelectedIndex = listboxCustomer.FindString(txtCustomerID.Text, listboxCustomer.SelectedIndex);
        //                //doing this should 'scroll it'
        //                if (listboxCustomer.SelectedIndex < lbmax - 2)
        //                {
        //                    listboxCustomer.SelectedIndex += 2;
        //                    listboxCustomer.SelectedIndex -= 2;
        //                }
        //                listboxCustomer.Focus();
        //                StringSoFar.Length = 0;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        switch (TestString.Length)
        //        {
        //            case 0:
        //                //txtCustomerID.Text = ""
        //                //txtCustomerID.Text = NextChar
        //                StringSoFar.Append(nextchar);
        //                listboxCustomer.SelectedIndex = 0;
        //                break;
        //            case 1:
        //            case 2:
        //            case 3:
        //            case 4:
        //                StringSoFar.Append(nextchar);
        //                break;
        //            //txtCustomerID.Text = TestString + NextChar
        //            //lstCustAddPickup.FindString(TestString)
        //            default:
        //                StringSoFar.Append(nextchar);
        //                break;
        //            //txtCustomerID.Text = TestString + NextChar
        //        }
        //        Cust = inputCustList.Find(x => x.CustomerID == StringSoFar.ToString());
        //        //if (CustomerHash.Contains(StringSoFar.ToString()))
        //        if (Cust != null)
        //        {
        //            //can I write to e?  no, but I can suppress other events... (I hope)
        //            e.SuppressKeyPress = true;
        //            //Now we can move to the right listbox entry
        //            //Cust = CustomerHash.Item(StringSoFar.ToString());
        //            listboxCustomer.SelectedIndex = listboxCustomer.FindStringExact(Cust.InfoString);
        //            txtCustomerID.Text = StringSoFar.ToString();
        //        }
        //        // at this point the display should be correct...
        //        //but don't change the focus --txtComment.Focus()
        //    }
        //}
        private void btnCloseCustomerList_Click(object sender, System.EventArgs e)
        {
            listboxCustomer.Visible = false;
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            CUSTOMER Cust = default(CUSTOMER);
            string TestString = StringSoFar.ToString();
            int CurrentIndex = listboxCustomer.SelectedIndex;
            char c = e.KeyChar;
            string nextchar = c.ToString().ToUpper();


            //from a forum someplace:
            //
            //        Keydown is used to receive keys, not chars. Use Keypress to evaluate chars.
            //Keyvalues are not character values. For example, pressing the "A" key fires
            //keydown with keycode = Keys.A, but the resulting char might be "a", "A", or
            //chr(1) depending on the state of the shift and ctrl keys. Another example:
            //function keys. They produce keydown events but no keypress events because
            //they are not translated to chars.

            // maybe I should move this code into the KEYPRESS event ???


            //if (e.KeyChar.ToString() == "13")
            //if ( 1 == 2  )
            if (e.KeyChar == '\r' ) // finally  (this took about an hour!) 
            {
                Cust = inputCustList.Find(x => x.CustomerID == txtCustomerID.Text); //CustomerHash.Contains(txtCustomerID.Text)))
                if (Cust != null)  //CustomerHash.Contains(txtCustomerID.Text)))
                {
                    Cust = inputCustList.Find(x => x.CustomerID == txtCustomerID.Text);//CustomerHash.Item(txtCustomerID.Text);
                    txtCustomerID.Text = StringSoFar.ToString();
                    //Cust.CustomerID
                    lblCustomerName.Text = Cust.CustomerName;
                    txtCustomerName.Text = Cust.CustomerName;
                    txtDefaultRoute.Text = Cust.DefaultRouteID;
                    txtRouteName.Text = "route2name";//CustomerListBoxHelper.GetRoute2RouteName(Cust.DefaultRouteID);
                    txtDefaultDriverID.Text = "defaultdriverid";//CustomerListBoxHelper.GetRoute2DefaultDriverID(Cust.DefaultRouteID);
                    listboxCustomer.SelectedIndex = listboxCustomer.FindStringExact(Cust.InfoString, 0);
                    txtComment.Focus();
                    StringSoFar.Length = 0;
                }
                else
                {
                    {
                        int lbmax = listboxCustomer.Items.Count - 1;
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
                Cust = inputCustList.Find(x => x.CustomerID == StringSoFar.ToString());
                //if (CustomerHash.Contains(StringSoFar.ToString()))
                if (Cust != null)
                {
                    //can I write to e?  no, but I can suppress other events... (I hope)
                    //??? e.SuppressKeyPress = true;

                    //Now we can move to the right listbox entry
                    //Cust = CustomerHash.Item(StringSoFar.ToString());
                    listboxCustomer.SelectedIndex = listboxCustomer.FindStringExact(Cust.InfoString);
                    txtCustomerID.Text = StringSoFar.ToString();
                }
                // at this point the display should be correct...
                //but don't change the focus --txtComment.Focus()
            }

        }
        #endregion

    }
}