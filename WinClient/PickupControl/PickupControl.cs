using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DispatchAR;
using SubSonic;
using SubSonic.Query;

namespace WinClient //PickupControlLibrary
{
    public partial class PickupControl : UserControl
    {
        #region Declarations
        private static Properties.Settings mySettings = new Properties.Settings();

        /********
         *              1.
      private static Properties.Settings mySettings = new Properties.Settings();
   
      private void CheckSettings()
      {
         this.Checked = mySettings.ShowInTaskBar;
      }
         * *********/

        #endregion

        #region Constructors

        //private PickupControl()
        //{
        //    InitializeComponent();
        //}

        public PickupControl(DispatchAR.CurrentDayPickup pickup)
        {
            InitializeComponent();

            CurrentPickup = pickup;
            chkDispatched.Checked = pickup.CDPDispatched;
            btnCustomerName.Text = pickup.CDPCustomerName;
            txtComment.Text = pickup.CDPComment;
            txtNotes.Text = pickup.CDPNotes;
            txtID.Text = pickup.CurrentDayPickupID.ToString();
            ReviseStyles();
           
              //from PickupControl.Designer.cs:
            //this.PUControlTooltip.SetToolTip(this.txtComment, "e.g. 2 SK Rdy @2PM"); 
            this.PUControlTooltip.SetToolTip(this.txtComment, this.txtComment.Text); 
            PUControlTooltip.SetToolTip(btnCustomerName, GetCustomerString());
            PUControlTooltip.IsBalloon=true;
        }

        #endregion

        #region getters (includes private instance variables)

        private CurrentDayPickup _CurrentPickup;

        public CurrentDayPickup CurrentPickup
        {
            get { return _CurrentPickup; }
            set { _CurrentPickup = value; }
        }

        #endregion

        private void PickupControl_Load(object sender, EventArgs e)
        {
            chkDispatched.Checked = CurrentPickup.CDPDispatched;
            btnCustomerName.Text = CurrentPickup.CDPCustomerName;
            txtComment.Text = CurrentPickup.CDPComment;
            txtNotes.Text = CurrentPickup.CDPNotes;
            txtID.Text = CurrentPickup.CurrentDayPickupID.ToString();
            ReviseStyles();
        }

        /// <summary>
        /// Changes text to green and Button Backcolor to Yellow if Not Dispatched
        /// </summary>
        private void ReviseStyles()
        {
            if (CurrentPickup.CDPDispatched)
            {
                chkDispatched.ForeColor = Color.Green;
                txtNotes.ForeColor = Color.Green;
                txtNotes.BackColor = Color.White;
                btnCustomerName.ForeColor = Color.Green;
                btnCustomerName.BackColor = Color.LightGray;
                txtComment.ForeColor = Color.Green;
                txtComment.BackColor = Color.White;
            }
            else
            {
                chkDispatched.ForeColor = Color.Black;
                txtNotes.ForeColor = Color.Black;
                txtNotes.BackColor = Color.White;
                btnCustomerName.ForeColor = Color.Black;
                btnCustomerName.BackColor = Color.Yellow;
                txtComment.ForeColor = Color.Black;
                txtComment.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Saves the current pickup with a call to: CurrentDayPickup.Update()
        /// Does not use UserName or terminal (yet)
        /// </summary>
        private void SaveAndPostCDP()
        {
            // SaveAndPostCDP still needed?

            CurrentPickup.CDPStation= Environment.MachineName;
            
            // PostedCount & Save not present in DispatchLINQ
            //CurrentPickup.PostedCount = Settings.Default.ActiveStations - 1;
            CurrentPickup.Terminal = Properties.Settings.Default.terminal;
            CurrentPickup.CDPEditedBy = ""; // used by DnDrop (see frmRoute.cs (SaveDragNDropPickup() )
            // how to save this record??
            // does it use the property changed/property changing events?
            //CurrentPickup.Save();

            // TODO: fix this...
            //if (CurrentPickup.UserName != term) {
            //    Posting  job = new Posting(CurrentPickup,CurrentPickup.PostedCount,term);
            //    job.IsDragnDrop = false;
            //     job.Save();
            }
        

        /// <summary>
        /// Does a soft delete of this pickup.  
        /// Does not set the panel to Nothing
        /// Does not refresh the frmRoute 
        /// </summary>
        private void DeletePickup()
        {
            CurrentPickup.CDPDeleted = true;
            SaveAndPostCDP();
        }

        /// <summary>
        /// Calls PickupControl.DeletePickup() 
        /// and
        /// Dispose() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            DeletePickup();
            Dispose();
        }

        private void examineMenuItem_Click(object sender, EventArgs e)
        {
            string DetailString = GetCustomerString();
            //' TODO:  replace Customer Details messagebox with a new panel object, correctly located...
            //this one just bongs (softly)
            MessageBox.Show(DetailString, "Details", MessageBoxButtons.OK);
            // this one rings the bell (loudly)... 
            //MessageBox.Show(s.ToString(), "Details", _
            //    MessageBoxButtons.OK, _
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, 0)

        }

        private String GetCustomerString()
        {        
            CurrentDayPickup r = CurrentPickup;
            IQuerySurface  db = new DispatchAR.DispatchDB();
       
        //var qry  = from  cust in db.CUSTOMERS 
        //           where cust.CustomerID=r.CDPCustomerID
        //              select cust;

        /**************** 
            String CustomerString = "";

            qry.WHERE("CustomerID", r.CDPCustomerID);
            CollectionOfOneCustomer = controller.FetchByQuery(qry);


            //error checking
            if (CollectionOfOneCustomer.Count != 1)
            {
                string htmlobj;
                htmlobj = qry.Inspect();
                StringBuilder ss = new StringBuilder();
                ss.AppendLine("Cannot See Details");
                ss.AppendLine(CurrentPickup.CurrentDayPickupID.ToString());
                ss.Append(htmlobj);
                CustomerString = ss.ToString();
            }
         * ***********************/

            String CustomerString = "";
            //foreach (var cust in qry)  // there is only one
            //{
            //    StringBuilder CustStringBuilder = new StringBuilder();
            //    CustStringBuilder.AppendLine(cust.CustomerName + " (" + cust.CustomerID + ")");
            //    CustStringBuilder.AppendLine(cust.Address1);
            //    //s.AppendLine(.Address2)
            //    CustStringBuilder.AppendLine(cust.City + ", " + cust.State);
            //    CustStringBuilder.AppendLine("");
            //    CustStringBuilder.Append("Contact: ");
            //    CustStringBuilder.AppendLine(cust.Contact);
            //    CustStringBuilder.Append("Closing Time: ");
            //    CustStringBuilder.AppendLine(cust.ClosingTime);
            //    CustStringBuilder.Append("Phone: ");
            //    CustStringBuilder.AppendLine(cust.Phone);
            //    CustomerString = CustStringBuilder.ToString();
            //  }
            return CustomerString;
        }

        private void txtComment_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbox = (TextBox) sender;
            String mTitle = "Too Many Characters";
            if (tbox.Text.Length > 30)
            {
                MessageBox.Show("Only 30 characters allowed" + Environment.NewLine
                                + "Discarding: " + tbox.Text.Substring(30), mTitle, MessageBoxButtons.OK);
                tbox.Text = tbox.Text.Substring(0, 30);
            }
            txtComment.Text = CurrentPickup.CDPComment = tbox.Text;
        }

        private void chkDispatched_CheckedChanged(object sender, EventArgs e)
        {
            CurrentPickup.CDPDispatched = chkDispatched.Checked;
            SaveAndPostCDP();
            ReviseStyles();
        }

        private void txtComment_Validated(object sender, EventArgs e)
        {
            SaveAndPostCDP();
        }

        private void txtNotes_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbox = (TextBox) sender;
            String mTitle = "Too Many Characters";
            if (tbox.Text.Length > 3)
            {
                MessageBox.Show("Only 3 characters allowed" + Environment.NewLine
                                + "Discarding: " + tbox.Text.Substring(3), mTitle, MessageBoxButtons.OK);
                tbox.Text = tbox.Text.Substring(0, 2);
            }
            txtNotes.Text = CurrentPickup.CDPNotes = tbox.Text;
        }

        private void txtNotes_Validated(object sender, EventArgs e)
        {
            SaveAndPostCDP();
        }

        //private void PickupBindingSource_ListChanged( object sender, ListChangedEventArgs e ) {
        //    MessageBox.Show(sender.ToString());
        //    MessageBox.Show(e.PropertyDescriptor.ToString());
        //}
    } // public partial class pickup control
} // namespace