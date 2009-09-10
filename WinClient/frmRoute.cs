using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using PickupControlLibrary;

using System.Windows.Forms;

using SubSonic;
using DispatchAR;

namespace WinClient //Dispatch3
{
    public partial class frmRoute : Form
    {
     //   public frmRoute()
     //   {
     //       InitializeComponent();
     //   }
        private CurrentDayRoute _cdr;

        public CurrentDayRoute Cdr
        {
            get { return _cdr; }
            set { _cdr = value; }
        } 

       public frmRoute(ScreenDimension win, CurrentDayRoute cdr)
    {
        Cdr = cdr;
        InitializeComponent();
        
            this.Text = win.WinTitle;
            this.Top = win.TopInt;
            this.Left = win.LeftInt;
            this.Height = win.HeightInt;
            this.Width = win.WidthInt;
            this.Tag = cdr.CDRRouteID;
            this.Name = cdr.CDRRouteID;

            lblDriverName.Text = cdr.CDRDriverLastName;
            txtDriverMessage.Text = cdr.CDRDriverMessage;
            {
                tooltipDriverMessage.AutoPopDelay = 5000;
                tooltipDriverMessage.InitialDelay = 1000;
                tooltipDriverMessage.ReshowDelay = 500;
                tooltipDriverMessage.ShowAlways = true;
                tooltipDriverMessage.IsBalloon = true;
                tooltipDriverMessage.SetToolTip(txtDriverMessage, cdr.CDRDriverMessage);
            }
    }

    
    #region "Declarations"

        // move to BLL
        // 
       private CurrentDayPickup PickupsThisRoute; // temporary, until I figure it out...
       // todo: figure it out...
    //private CurrentDayPickupsTable  PickupsThisRoute ;
    public static int DailyCount;
    
    // seems to be unused.... 
    //private static Query PendingCDPQuery = new Query(CurrentDayPickup.Schema).WHERE("CDPStation", Comparison.NotEquals, Environment.MachineName).AND("CDPChecked", 0);
    //Private Shared _
    //    PendingCDPQueryNew As Query = _
    //        New Query(CurrentDayPickup.Schema).WHERE("UserName", _
    //                Comparison.NotEquals, Environment.UserName).AND("UpdatesRemaining", Comparison.GreaterThan, 1)
    
    // take this out
        //private static CurrentDayPickupController StaticController = new CurrentDayPickupController();
    private static CurrentDayPickupsTable OtherStationsCDPCollection;
    //private static CurrentDayRouteCollection CDRCollection = new CurrentDayRouteCollection();
    public static Panel SendingPanel;
    // replace this when feasible..
    //private Hashtable PickupHash = new Hashtable();
    // where should these live?  here or on Mainform ?
    private static frmRoute frmSourceRoute;
    private static frmRoute frmDestinationRoute;
    private const int CtrlMask = 8;
    //set by HandlebtnCustomerName_MOUSEDOWN, 
    //read by HandlepnlContainer_DRAGDROP 
    private static int intSendingID;
    private PickupControl _PUControl;
    
    #endregion
    
// ERROR: Handles clauses are not supported in C#
    private void frmRoute_Load(object sender, EventArgs e)
    {
        RefreshDynamicPickupControls();
    }

    public void RefreshDynamicPickupControls()
    {
        
        GetPickupsForThisInstance();
        int routecount = 20;
        // pickuphash should be gone now...
        //LoadPickupHash();
        //var routecount = PickupsThisRoute.Count();

        // Add the number of AllPickupsToday to the title 
        // it always starts with a "---" search for DailyCount or newmdichild to see 
        //    where the text gets initialized

        // TODO: fix this up... replace the call to VB STRINGS w/ something???
        //this.Text = Strings.Mid(this.Text, 1, Strings.InStr(this.Text, "---"));
        
        if (routecount == 0 ) {
            this.Text += "-- 0 Pickups";
        }
        else if (routecount  == 1) {
            this.Text += "-- 1 Pickup";
        }
        else {
            this.Text += String.Format("-- {0} Pickups", routecount.ToString()); 
        }
        
        //finally got the right thing here!
        pnlContainer.Controls.Clear();
        
        int PUCount = 0;
        //NEW PANEL  NEW PANEL NEW PANEL NEW PANEL
        //foreach (var cdp in PickupsThisRoute) { 

        //    PickupControl pnlPickup = new PickupControl(cdp);
        //    PUCount += 1;
        //    if ((PUCount == 1)) {
        //        pnlPickup.Top = 0;
        //    }
        //    else {
        //        //pnlPickup.Top = ((PUCount - 1) * 26) ' original 
        //        pnlPickup.Top = ((PUCount - 1) * (pnlPickup.Height + 5));
        //    }
        //    pnlContainer.Controls.Add(pnlPickup);
            
        //    // Todo: MAKE THIS WORK...
        //    //pnlPickup.Controls.Item[0].Controls.Item("btnCustomerName").MouseDown += HandlepnlPickup_MOUSEDOWN;
            
        //    //RefreshDriverMessage()
        //}
    }
    public void RefreshDriverMessage()
    {
        //foreach ( CurrentDayRoute cdr in PickupsThisRoute) {
        //foreach ( var pu  in PickupsThisRoute) {
        //    if (pu.CDRRouteID == this.Tag) {
        //        txtDriverMessage.Text = pu.CDRDriverMessage;
        //    }
        //}
    }
        //Todo: move to BLL layer...
    public void SaveAndPostDriverMessage()
    {
        return;
    }
    //    int key = 0;
    //    bool @checked = false;
    //    var station = Environment.MachineName;
    //    string UserName = Environment.UserName;
    //    string terminal = Dispatch3.Properties.Settings.Default.Terminal;
 
    //    foreach (CurrentDayRoute r in CDRCollection.Load()) {
    //        if (r.CDRRouteID == this.Tag) {
    //            key = r.CurrentDayRouteID;
    //            int count = Properties.Settings.Default.ActiveStations - 1;
    //            CurrentDayRoute.Update(key, r.CDRRouteID, r.CDRRouteName, r.CDRDefaultDriverID, r.CDRDriverLastName, txtDriverMessage.Text, station, @checked, r.CDRDate, r.CDRSyncID, 
    //            r.CDRCreatedBy, r.CDRCreatedTime, r.CDREditedBy, r.CDREditedTime, r.CDRSent, r.CDRSentTime, r.CDRSendConfirmed, r.CDRReceivedTime, UserName, count, 
    //            terminal);
    //            /********
    //             * 
    //    public static void Update(
    //            int varCurrentDayRouteID,                  key, 
    //            string varCDRRouteID,                      r.CDRRouteID, 
    //            string varCDRRouteName,                    r.CDRRouteName, 
    //            string varCDRDefaultDriverID,              r.CDRDefaultDriverID, 
    //            string varCDRDriverLastName,               r.CDRDriverLastName, 
    //            string varCDRDriverMessage,                txtDriverMessage.Text, 
    //            string varCDRStation,                      station, 
    //            bool varCDRChecked,                        @checked, 
    //                DateTime? varCDRDate,                  r.CDRDate, 
    //            string varCDRSyncID,                       r.CDRSyncID, 
    //            string varCDRCreatedBy,                    r.CDRCreatedBy, 
    //                DateTime? varCDRCreatedTime,           r.CDRCreatedTime, 
    //            string varCDREditedBy,                     r.CDREditedBy, 
    //                DateTime? varCDREditedTime,            r.CDREditedTime, 
    //            bool varCDRSent,                           r.CDRSent, 
    //               DateTime? varCDRSentTime,               r.CDRSentTime, 
    //            bool? varCDRSendConfirmed,                 r.CDRSendConfirmed, 
    //                DateTime? varCDRReceivedTime);         r.CDRReceivedTime, 
    //                                                       UserName, 
    //            (                                          count, 
    //                key,                                   terminal
    //                r.CDRRouteID, 
    //                r.CDRRouteName, 
    //                r.CDRDefaultDriverID, 
    //                r.CDRDriverLastName, 
    //                txtDriverMessage.Text, 
    //                station, 
    //                @checked, 
    //                r.CDRDate, 
    //                r.CDRSyncID, 
    //                r.CDRCreatedBy, 
    //                r.CDRCreatedTime, 
    //                r.CDREditedBy, 
    //                r.CDREditedTime, 
    //                r.CDRSent, 
    //                r.CDRSentTime, 
    //                r.CDRSendConfirmed, 
    //                r.CDRReceivedTime, 
    //                UserName, 
    //                count, 
    //                terminal
    //            k);
    //             * ************/
    //            // now post it (there is no dedicated constructor --yet)
    //            Posting p = new Posting();
    //            //Posting p = new Posting(r, Properties.Settings.Default.ActiveStations -1 , Environment.UserName);
    //            p.DataType = "CurrentDayRoute";
    //            p.Key = key;
    //            p.Originator = station;
    //            p.NumberofPendingUpdates = My.MySettings.Default.ActiveStations - 1;
    //            p.DefaultRouteId = this.Tag;
    //            p.IsDragnDrop = false;
    //            p.Save();
    //        }
    //        break; // TODO: might not be correct. Was : Exit For
    //    }
    // }


    //private void LoadPickupHash()
    //{
    //    PickupHash.Clear();
    //    foreach (CurrentDayPickup cdp in CDPCollection) {
    //        if (cdp.CDPDefaultRouteID == this.Tag) {
    //            //they all should equal me.tag  
    //            if (PickupHash.Contains(cdp.CurrentDayPickupID)) {
    //                PickupHash.Item(cdp.CurrentDayPickupID) = cdp;
    //            }
    //            else {
    //                PickupHash.Add(cdp.CurrentDayPickupID, cdp);
    //            }
    //        }
    //    }
    //}
    public static void SyncRouteWindowTextDriverMsgControls(Form[] MDIForms)
    {
        for (int i = 0; i <= MDIForms.Length - 1; i++) {
            if (((MDIForms[i])  is InputForm)) {
                continue;
            }

            foreach (CurrentDayRoute cdr in Program.CDRList) {
                frmRoute form = (frmRoute) MDIForms[i];
                if (form.Tag == cdr.CDRRouteID) {
                    //frmRoute.RefreshDynamicPickupControls now handles the title
                    //form.Text = cdr.CDRRouteID + " " + cdr.CDRRouteName
                    form.Controls["lblDriverName"].Text = cdr.CDRDriverLastName;
                    form.Controls["txtDriverMessage"].Text = cdr.CDRDriverMessage;
                }
                //0 = txtDriverMessage control
            }
        }
        
    private void GetPickupsForThisInstance()
    {
        var db = new DispatchDB();
        var AllPickupsToday = from  cdp in db.CurrentDayPickups
                      select cdp;
        DailyCount = AllPickupsToday.Count();

        var qry  = from cdp in db.CurrentDayPickups
                               where cdp.CDPDefaultRouteID == this.Tag
                               select cdp;

         //PickupsThisRoute= qry.ToList<CurrentDayPickup>();
        
    }
    private void SaveDragandDropPickup()
    {
        CurrentDayPickup pu = MainForm.DraggedCDP;
        
        // record the previous route 
        // do this before we swap them 
        // re-using the editedby column as a place to store DnD Source tag.
        pu.CDPEditedBy = pu.CDPDefaultRouteID;
        
        pu.CDPPreviousRouteID = pu.CDPDefaultRouteID;
        pu.CDPDefaultRouteID = this.Tag.ToString();
        pu.CDPChecked = false;
        pu.CDPStation = Environment.MachineName;
        // should be unused...
        //pu.UserName = Environment.UserName;
        pu.Terminal = Properties.Settings.Default.terminal;
        pu.CDPSentTime = DateTime.Today;
        
        // TODO: see how to do this...
        // or see if its done by the 
        // onchanged/onchanging events???
        //pu.Save();
        MainForm.DraggedCDP = null;
        
        //post it
        int postedcount = Properties.Settings.Default.ActiveStations - 1 ;
        var job = new Posting();
        //job.DataType= "CDP";
        //job.DefaultRouteId= "01";
        //job.JobType="route";
        //job.key= 1;
        //job.MsgFor= "Gregg";
        //job.PostingID=1;
        //job.PreviousRouteID="02";
                
        // TODO: see how to do this...
        //job.Save();
    }
    
    #region "DragDropHandlers"
    
    private void HandlepnlPickup_MOUSEDOWN(object sender, MouseEventArgs e)
    {
        
        // this is the clicked PickupControl
        Button PickupButton = sender as Button ;
        
        if ((e.Button == MouseButtons.Left)) {
            // put it on the mainform so the destination frmRoute can go get it
            //sender is the button
            //sender.parent is pnlPickup
            //sender.parent.parent is PickupControlLibrary.PickupControl
            //sender.parent.parent.CurrentPickup is the public property of the user control
            // ??? MainForm.DraggedCDP = sender.parent.parent.CurrentPickup;
            //sender is the button 
            frmSourceRoute = this;
            // ??? pnlContainer.DoDragDrop(sender.parent.parent.CurrentPickup, DragDropEffects.All);
        }
        else {
            //frmDestinationRoute = sender.parent.parent.parent  ' is this necessary? 
            // ??? MainForm.objSourcePickup = sender.parent.parent.CurrentPickup;
            PickupButton.ContextMenuStrip.Show();
        }
    }
    
    private void  // ERROR: Handles clauses are not supported in C#
HandlepnlContainer_DRAGDROP(object sender, DragEventArgs e)
    {
        frmDestinationRoute = this;
        if ((MainForm.DraggedCDP != null)) {
            SaveDragandDropPickup();
            this.RefreshDynamicPickupControls();
            frmSourceRoute.RefreshDynamicPickupControls();
        }
    }
    
    public void  // ERROR: Handles clauses are not supported in C#
pnlContainer_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }
    
    #endregion
    
    //Private Sub txtDriverMessage_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtDriverMessage.Leave
    //End Sub
    
    private void  // ERROR: Handles clauses are not supported in C#
txtDriverMessage_TextChanged(object sender, System.EventArgs e)
    {
        SaveAndPostDriverMessage();
    }
}

}


