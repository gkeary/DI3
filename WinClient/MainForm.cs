using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using RossData;
//using PickupControlLibrary;
using System.IO;
//using Dispatch.LINQ; 


namespace WinClient //Dispatch3
{
    public partial class MainForm : Form
    {

        // Todo: springify this...
        private static Stream Stream = File.Open("scr1.xml", FileMode.OpenOrCreate);
        //private static Stream _stream = File.Open("scr.xml", FileMode.OpenOrCreate);
        //public Stream Stream { get; set; }
        public MainForm()
        {
            InitializeComponent();
            // call the MainForm setup routine here  -- it used to be: MainForm(Program.XMLStream fileStream)
            //Program.Stream stream; 
            setup(Stream);
        }
        #region Declarations

        public int intCDPSyncCount = 0;
        public static bool blnWindowOpen = false;
        public static bool blnDayStarted = false;
        public static Object objSourcePickup = new Object();
        public static DispatchAR.CurrentDayPickup DraggedCDP;
        private int tick = 0;
        private Form DestinationForm;
        private Form SourceForm;
        #endregion

        ////<summary>
        ////</summary>
        //// <remarks></remarks>
        //public MainForm(Program.XMLStream fileStream)
        public void setup(Stream fileStream)
        {
            Program.ComputeScreenBoundaries(); // this must be called from somewhere
            // this is no longer a screenarray but a List<SCREENDIMENSION> ... 
            // it should really be springified...
            Program.LoadScreenListFromXml(); //' populates ScreenList from xmlfile 
            //Program.LoadScreenListFromXml(Stream); //' with a stream 
            //Program.XMLStream = fileStream;
            // Exit gracefully if somethins is wrong with the connection.
            if (!Program.TestConnectionString())
            {
                Application.Exit();
            }

            // only used for testing...
            var Count3 = Program.GetPickupCount();
            var Count4 = Program.GetPostingCount();

            // blnDayStarted is controlled here
            var Count1 = Program.GetCDRCount();
            var Count2 = Program.GetCDPCount();
            MainForm.blnDayStarted = (Count1 > 0 && Count2 > 0) ? true : false;

            if (blnDayStarted)
            {
                LoadfrmRoutes();
                Stream.Close();
                //'InputForm.PickupHash = CustomerListBoxHelper.PopulatePickupHash()
                //'InputForm.Route2Hash = CustomerListBoxHelper.PopulateRoute2Hash()
                //'InputForm.CustomerHash = CustomerListBoxHelper.PopulateCustomerHash()
            }
            else
            {

                mnuStartOfDay.Enabled = false;
                mnuDefaultRoutes.Enabled = true;
            }

            LoadInputWindow();
        }

        private void LoadfrmRoutes()
        {
            var RouteCount = Program.GetCDRCount();


            var cdrqry = from cdr in Program.CDRList
                         select cdr;
            var sdqry = from sd in Program.ScreenList
                        select sd;

            for (int i = 0; i < RouteCount; i++)
            {
                foreach (DispatchAR.CurrentDayRoute route in cdrqry)
                {
                    foreach (ScreenDimension screen in sdqry)
                    {
                        if (route.CDRRouteID.Equals(screen.WinTitle.Substring(0, 2)))
                        {
                            var rw = new frmRoute(screen, route);
                            rw.MdiParent = this;
                            rw.Show();
                        }
                    }

                }
                return;
            }
        }


        private void LoadInputWindow()
        {
            return;
            // InputForm has many issues
            // stub it out for now...
            //var InputForm = new InputForm();
            // InputForm.MdiParent = this;
            //InputForm.Show();
        }

        public void RefreshThisRoute(frmRoute whichForm)
        {
            frmRoute.SyncRouteWindowTextDriverMsgControls(this.MdiChildren);
            whichForm.RefreshDynamicPickupControls();
        }

        public void RefreshAllRoutes()
        {
            for (int i = 0; i <= this.MdiChildren.Length - 1; i++)
            {
                if (MdiChildren[i].Tag == "Dynamic")
                {
                    RefreshThisRoute((frmRoute)MdiChildren[i]); // dangerous -- may throw an exception
                }
            }
        }


        private void SyncCustomerList()
        {
            {
                return;
                //MyProject.Forms.InputForm.mCustomerCollection.Clear();
                //MyProject.Forms.InputForm.mCustomerCollection.Load();
                //MyProject.Forms.InputForm.bsrcCustomerList.DataSource = MyProject.Forms.InputForm.mCustomerCollection;
                //MyProject.Forms.InputForm.listboxCustomer.DataSource = null;
                //MyProject.Forms.InputForm.listboxCustomer.DisplayMember = "InfoString";
                //MyProject.Forms.InputForm.listboxCustomer.ValueMember = "CustomerID";
                //MyProject.Forms.InputForm.listboxCustomer.DataSource = MyProject.Forms.InputForm.bsrcCustomerList;
                //MyProject.Forms.InputForm.RefreshInputWindowControls();
                //MyProject.Forms.InputForm.Refresh();
            }

        }
        private void SyncPosting()
        {
            return;
            //        PostingCollection jobs = new PostingCollection();
            //jobs.Load();
            //int a = jobs.Count;
            //foreach (Posting p in jobs)
            //{
            //    if (Strings.RTrim(p.Originator) == Environment.UserName)
            //    {
            //        break;
            //    }
            //    this.PostToMDI(p);

        }
        private void SyncroutFormTitles()
        {
            return;
            //        CDRCollection.Clear();
            //CDRCollection.Load();
            //Form[] MDIForms = this.MdiChildren;
            //int VB$t_i4$L0 = MDIForms.Length - 1;
            //for (int i = 0; i <= VB$t_i4$L0; i++)
            //{
            //    if (MDIForms[i] is frmRoute)
            //    {
            //        frmRoute routeform = (frmRoute) MDIForms[i];
            //        foreach (CurrentDayRoute route in CDRCollection)
            //        {
            //            if (Conversions.ToBoolean(Operators.AndObject(!route.CDRChecked, Operators.CompareObjectEqual(routeform.Tag, route.CDRRouteID, false))))
            //            {
            //                StringBuilder title = new StringBuilder();
            //                int pos1 = Strings.InStr(routeform.Text, "---", CompareMethod.Binary);
            //                title.Append(route.CDRRouteID + " ");
            //                title.Append(route.CDRRouteName + " ");
            //                title.Append(Strings.Mid(routeform.Text, pos1));
            //                frmRoute VB$t_ref$L0 = routeform;
            //                lock (VB$t_ref$L0)
            //                {
            //                    routeform.Text = title.ToString();
            //                    routeform.Controls[1].Text = route.CDRDriverMessage;
            //                    routeform.Controls[2].Text = route.CDRDriverLastName;
            //                }
            //                route.CDRChecked = true;
            //                route.CDRStation = Environment.MachineName;
            //                route.UserName = Environment.UserName;
            //                route.Terminal = MySettings.Default.Terminal;
            //                route.Save();
        }
        private void PostToMDI(Posting p)
        {
            return;
            //foreach (Form frm in this.MdiChildren)
            //{
            //    if (((frm is TabForm) || (frm is InputForm)) || Operators.ConditionalCompareObjectNotEqual(frm.Tag, p.DefaultRouteId, false))
            //    {
            //        goto Label_0267;
            //    }
            //    frmRoute mdi = (frmRoute) frm;
            //    StringBuilder strbuilder = new StringBuilder();
            //    switch (p.DataType)
            //    {
            //        case "CurrentDayRoute":
            //        {
            //            CurrentDayRoute cdr = ActiveRecord<CurrentDayRoute>.FetchByID(p.Key);
            //            int pos1 = Strings.InStr(mdi.Text, "---", CompareMethod.Binary);
            //            strbuilder.Append(cdr.CDRRouteID + " ");
            //            strbuilder.Append(cdr.CDRRouteName + " ");
            //            strbuilder.Append(Strings.Mid(mdi.Text, pos1));
            //            frmRoute VB$t_ref$L0 = mdi;
            //            lock (VB$t_ref$L0)
            //            {
            //                mdi.Text = strbuilder.ToString();
            //                mdi.Controls[1].Text = cdr.CDRDriverMessage;
            //                mdi.Controls[2].Text = cdr.CDRDriverLastName;
            //            }
            //            cdr.CDRChecked = true;
            //            cdr.CDRStation = Environment.MachineName;
            //            cdr.UserName = Environment.UserName;
            //            cdr.Terminal = MySettings.Default.Terminal;
            //            cdr.Save();
            //            goto Label_021C;
            //        }
            //        case "Customer":
            //            MyProject.Forms.InputForm.RefreshInputWindowControls();
            //            mdi.RefreshDynamicPickupControls();
            //            goto Label_021C;

            //        case "CurrentDayPickup":
            //        {
            //            CurrentDayPickup cdp = ActiveRecord<CurrentDayPickup>.FetchByID(p.Key);
            //            if (p.IsDragnDrop)
            //            {
            //                this.SourceForm = this.GetDnDSourceForm(ref cdp);
            //                frmRoute VB$t_ref$S1 = (frmRoute) this.SourceForm;
            //                this.RefreshThisRoute(ref VB$t_ref$S1);
            //                this.SourceForm = VB$t_ref$S1;
            //            }
            //            this.RefreshThisRoute(ref mdi);
            //            break;
            //        }
            //    }
            //Label_021C:
            //    if (p.NumberofPendingUpdates == (MySettings.Default.ActiveStations - 1))
            //    {
            //        ActiveRecord<Posting>.Destroy(p.PostingID);
            //    }
            //    else
            //    {
            //        Posting VB$t_ref$S2 = p;
            //        VB$t_ref$S2.NumberofPendingUpdates--;
            //        p.Save();
            //    }
            //Label_0267:;
            //}
        }

        private void SyncrouteFormTitles()
        {
            return;
            //CDRCollection.Clear();
            //CDRCollection.Load();
            //Form[] MDIForms = this.MdiChildren;
            //int VB$t_i4$L0 = MDIForms.Length - 1;
            //for (int i = 0; i <= VB$t_i4$L0; i++)
            //{
            //    if (MDIForms[i] is frmRoute)
            //    {
            //        frmRoute routeform = (frmRoute) MDIForms[i];
            //        foreach (CurrentDayRoute route in CDRCollection)
            //        {
            //            if (Conversions.ToBoolean(Operators.AndObject(!route.CDRChecked, Operators.CompareObjectEqual(routeform.Tag, route.CDRRouteID, false))))
            //            {
            //                StringBuilder title = new StringBuilder();
            //                int pos1 = Strings.InStr(routeform.Text, "---", CompareMethod.Binary);
            //                title.Append(route.CDRRouteID + " ");
            //                title.Append(route.CDRRouteName + " ");
            //                title.Append(Strings.Mid(routeform.Text, pos1));
            //                frmRoute VB$t_ref$L0 = routeform;
            //                lock (VB$t_ref$L0)
            //                {
            //                    routeform.Text = title.ToString();
            //                    routeform.Controls[1].Text = route.CDRDriverMessage;
            //                    routeform.Controls[2].Text = route.CDRDriverLastName;
            //                }
            //                route.CDRChecked = true;
            //                route.CDRStation = Environment.MachineName;
            //                route.UserName = Environment.UserName;
            //                route.Terminal = MySettings.Default.Terminal;
            //                route.Save();
            //       }
            //        }
            //    }
            //            //}
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // something is calling this twice?
            // todo: fix double calls to Timer1_Tick
            this.tick++;

            this.Text = "Dispatch v3.0 (Spring) --  tick: " + this.tick.ToString();
            switch ((this.tick % 3))
            {
                case 0:
                    this.SyncCustomerList();
                    break;
                case 1:
                    this.SyncPosting();
                    break;

                case 2:
                    this.SyncrouteFormTitles();
                    break;
            }

            switch ((this.tick % 4))
            {
                case 1:
                    sbarMain.BackColor = System.Drawing.Color.AliceBlue;
                    sbarMain.Items["statusLabel"].Text = "Case 1foo";
                    //sbarMain.Items[0].Text = "foo";
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: 1";//+ frmRoute.DailyCount.ToString() + ".";
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: " + frmRoute.DailyCount.ToString() + ".";
                    break;

                case 2:
                    sbarMain.BackColor = System.Drawing.Color.Gray;
                    sbarMain.Items["statusLabel"].Text = "";
                    //sbarMain.Text = "Case 2foo";
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: 2";//+ frmRoute.DailyCount.ToString() + "..";
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: " + frmRoute.DailyCount.ToString() + "..";
                    break;

                case 3:
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: 10";//" + frmRoute.DailyCount.ToString() + "...";
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: " + frmRoute.DailyCount.ToString() + "...";
                    break;

                default:
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: 20";// + frmRoute.DailyCount.ToString();
                    //this.sbarMain.Items["StatusLabel"].Text = " Pickups Today: " + frmRoute.DailyCount.ToString();
                    break;
            }
            //this.sbarMain.Text = frmRoute.DailyCount.ToString();
        }
        private void StartOfDay()
        {
            this.PopulateCurrentDayPickups();
            this.LoadfrmRoutes();
            this.SetStartItems();
            //MyProject.Forms.InputForm.txtCustomerID.Focus();
        }

        private void SetStartItems()
        {
            this.mnuSaveWindowPositions.Enabled = true;
            this.mnuCloseRoutes.Enabled = true;
            this.mnuDefaultRoutes.Enabled = false;
            this.mnuEditRoutes.Enabled = true;
            this.Activate();
        }
        public void PopulateCurrentDayPickups()
        {
            int intCDPSyncCount = 0;
            //Form frmNewForm = new Form();
            //PickupCollection pucoll = new PickupCollection();
            bool addflag = false;
            
            if (Program.PickupList.Count == 0)
            {
                Program.GetPickupCollection();
            }
            if (Program.CDPList.Count == 0)
            {
                foreach (DispatchAR.Pickup p in Program.PickupList)
                {
                    intCDPSyncCount++;
                    string strCDPSyncID = Environment.MachineName + "-CDP-" + intCDPSyncCount.ToString();
                    string strRouteName = p.RouteName.Replace( "'", "''");
                    string strDriverName = p.DriverName.Replace( "'", "''");
                    string strCustomerName = p.CustomerName.Replace( "'", "''");
                    string strComment = p.Comment.Replace("'", "''");
                    if (p.DefaultRouteID == "")
                    {
                        MessageBox.Show("MainForm PopulateCDP\r\n The Pickup Table is faulty,  maybe p.defaultRouteID is blank");
                    }
                    DateTime mToday = DateTime.Now;
                    switch (((int)mToday.DayOfWeek))
                    {
                        case 1: if ((bool)p.Monday)    { addflag = true; } break;
                        case 2: if ((bool)p.Tuesday)   { addflag = true; } break;
                        case 3: if ((bool)p.Wednesday) { addflag = true; } break;
                        case 4: if ((bool)p.Thursday)  { addflag = true; } break;
                        case 5: if ((bool)p.Friday)    { addflag = true; } break;
                        default: addflag = false; break;
                    }
                    if (((!addflag && (p.Comment == "DP")) ? 1 : 0) != 0)
                    {
                        addflag = true;
                    }
                    if ((((!addflag && p.PickupDate.HasValue) ? 1 : 0) != 0) 
                                    && (((DateTime)p.PickupDate) == mToday))
                    {
                        addflag = true;
                    }
                    if (addflag)
                    {
                        addflag = false;
                        new DispatchAR.CurrentDayPickup
                        {
                            CDPChecked = true,
                            CDPComment = strComment,
                            CDPSyncID = strCDPSyncID,
                            CDPDriverName = strDriverName,
                            //CDPRouteName = strRouteName,// duplicated below
                            CDPCustomerName = strCustomerName,
                            CDPDispatched = false,
                            CDPCreatedBy = Environment.MachineName,
                            CDPStation = Environment.MachineName,
                            CDPCreatedTime = DateTime.Now,
                            CDPPickupDate = mToday,
                            CDPDefaultRouteID = p.DefaultRouteID,
                            CDPCustomerID = p.CustomerID,
                            CDPRouteName = p.RouteName,
                            //UserName = Environment.UserName,
                            //PostedCount = Properties.Settings.Default.ActiveStations - 1,
                            Terminal = Properties.Settings.Default.terminal
                        }.Save();
                    }
                }
            }
        }
        public void PopulateCurrentDayRoutes()
        {
            return;
            //int intCDRSyncCount = 0;
            //CDRCollection.Load();
            //int CDRCount = CDRCollection.Count;
            //VDefaultRouteCollection defRouteCollection = new VDefaultRouteCollection();
            //if (CDRCount == 0)
            //{
            //    foreach (VDefaultRoute r in defRouteCollection.Load())
            //    {
            //        intCDRSyncCount++;
            //        string strCDRSyncID = Environment.MachineName + "-CDR-" + intCDRSyncCount.ToString();
            //        string strRouteName = Strings.Replace(r.RouteName, "'", "''", 1, -1, CompareMethod.Binary);
            //        string strLastName = Strings.Replace(r.LastName, "'", "''", 1, -1, CompareMethod.Binary);
            //        string strDriverMessage = Strings.Replace(r.DriverMessage, "'", "''", 1, -1, CompareMethod.Binary);
            //        new CurrentDayRoute { CDRChecked = true, CDRSyncID = strCDRSyncID, CDRDriverLastName = strLastName, CDRRouteName = strRouteName, CDRCreatedBy = Environment.MachineName, CDRCreatedTime = DateAndTime.Now, CDRDate = DateAndTime.Today, CDRDefaultDriverID = r.DefaultDriverID, CDRRouteID = r.RouteID, CDRStation = Environment.MachineName, UserName = Environment.UserName, Terminal = MySettings.Default.Terminal }.Save();
            //    }
            //}
        }
        #region menuEventHandlers
        private void mnuAddDrivers_Click(object sender, EventArgs e)
        {
            new frmAddDrivers { MdiParent = this, Text = "xxxAdd a New Driver" }.Show();
        }

        private void mnuAddOneTimePickup_Click(object sender, EventArgs e)
        {
            //frmOneTimePickup NewWindow = new frmOneTimePickup("Add") {
            //    MdiParent = this
            //};
            //NewWindow.Show();
            //NewWindow.Closed += new EventHandler(this.hfrmOneTimePickup_Closed);
        }



        private void mnuCloseRoutes_Click(object sender, EventArgs e)
        {
            int l = this.MdiChildren.Length - 1;
            for (int i = 0; i <= l; i++)
            {
                if (i != 0)
                {
                    this.ActiveMdiChild.Close();
                }
            }
            this.mnuStartOfDay.Enabled = false;
        }


        public void OpenfrmDefaultRoutes()
        {
            frmDefaultRoutes NewWindow = new frmDefaultRoutes();
            if (blnDayStarted)
            {
                NewWindow.btnSetRoutes.Text = "Change Route(s)";
                NewWindow.btnSetRoutes.Enabled = false;
            }
            NewWindow.MdiParent = this;
            NewWindow.Parent.Name = this.Name;
            NewWindow.Show();
            NewWindow.Closed += new EventHandler(this.hfrmDefaultRoutes_Closed);
            return;
        }


        public void hfrmDefaultRoutes_Closed(object sender, EventArgs e)
        {
            blnWindowOpen = false;
            this.mnuDefaultRoutes.Enabled = false;
            this.mnuEditRoutes.Enabled = true;
            if (blnDayStarted)
            {
                this.mnuStartOfDay.Enabled = false;
            }
            else
            {
                this.mnuStartOfDay.Enabled = true;
            }
        }

        private void mnuDefaultRoutes_Click(object sender, EventArgs e)
        {

            this.PopulateCurrentDayRoutes();
            OpenfrmDefaultRoutes();

        }

        private void mnuDeleteDrivers_Click(object sender, EventArgs e)
        {
            new frmDeleteDrivers { MdiParent = this, Text = "Delete one or more drivers" }.Show();
        }





        private void mnuEditOneTimePickup_Click(object sender, EventArgs e)
        {
            //frmOneTimePickup NewWindow = new frmOneTimePickup("Edit")
            //{
            //    MdiParent = this
            //};
            //NewWindow.Show();
            //NewWindow.Closed += new EventHandler(this.hfrmOneTimePickup_Closed);
        }






        private void mnuEditRoutes_Click(object sender, EventArgs e)
        {
            // new frmEditRoutes { MdiParent = this, Text = "Add a New Driver" }.Show();
            return;

        }

        private void mnuEndOfDay_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Are you sure you want to end the day?");
            sb.AppendLine("");
            sb.AppendLine("This is the only way to clear the current day's data.".ToUpper());
            var style = MessageBoxButtons.OKCancel;
            var clickedOK = MessageBox.Show(sb.ToString(), "End of Day", style).Equals(DialogResult.OK);
            if (clickedOK)
            {
                Console.WriteLine("hoo");
                //hmmm...
                //Program.EndOfDay();
                //if ( result == DialogResult.OK )// not sure what result will be... 
            }
        }


        private void EndofDay()
        {
            this.EmptyCurrentDayRoutes();
            this.EmptyCurrentDayPickups();
            this.EmptyPosting();
            this.mnuEndOfDay.Enabled = false;

        }

        public void EmptyPosting()
        {
            //PostingCollection PostingCollection = new PostingCollection();
            //PostingController PostingController = new PostingController();
            //PostingCollection.Load();
            //if (PostingCollection.Count > 0)
            //{
            //    foreach (Posting job in PostingCollection)
            //    {
            //        PostingController.Destroy(job.PostingID);
            //    }
            //}
            return;
        }





        public void EmptyCurrentDayRoutes()
        {
            //List<CurrentDayRoute>.Enumerator VB$t_struct$L0;
            //CDRCollection.Load();
            //try
            //{
            //    VB$t_struct$L0 = CDRCollection.GetEnumerator();
            //    while (VB$t_struct$L0.MoveNext())
            //    {
            //        CurrentDayRoute route = VB$t_struct$L0.Current;
            //        CDRController.Destroy(route.CurrentDayRouteID);
            //    }
            //}
            //finally
            //{
            //    VB$t_struct$L0.Dispose();
            //}
            return;
        }






        public void EmptyCurrentDayPickups()
        {
            //List<CurrentDayPickup>.Enumerator VB$t_struct$L0;
            //CurrentDayPickupCollection cdpCollection = new CurrentDayPickupCollection();
            //CurrentDayPickupController cdpController = new CurrentDayPickupController();
            //cdpCollection.Load();
            //try
            //{
            //    VB$t_struct$L0 = cdpCollection.GetEnumerator();
            //    while (VB$t_struct$L0.MoveNext())
            //    {
            //        CurrentDayPickup pickup = VB$t_struct$L0.Current;
            //        cdpController.Destroy(pickup.CurrentDayPickupID);
            //    }
            //}
            //finally
            //{
            //    VB$t_struct$L0.Dispose();
            //}
            return;
        }

        private void mnuExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void mnuSaveWindowPositions_Click(object sender, EventArgs e)
        {
            Program.SaveWindowPositions(this);

        }

        private void mnuStartOfDay_Click(object sender, EventArgs e)
        {
            this.StartOfDay();
            blnDayStarted = true;
        }
        #endregion
















    } // class MainForm
} //namespace WinClient (Dispatch3)
