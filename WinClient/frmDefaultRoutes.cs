using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.CompilerServices;

using DispatchAR;
using System.Runtime.CompilerServices;

namespace WinClient
{
    public partial class frmDefaultRoutes : Form
    {   
        //List<CUSTOMER> CurrentDayRouteCollection = Program.CDRList;
        //List<Route> Route2Collection= Program.RouteList;
        //bool blnPanelRowChanged= false;
        //bool blnRouteSaved = false;
        //int intTxtMessagesIndex;
        //string strCDRSyncID;
        List<DispatchAR.CurrentDayRoute> CurrentDayRouteCollection = Program.CDRList;
        bool blnRouteSaved = false;
        bool blnPanelRowChanged= false;
        int intTxtMessagesIndex;
        string strCDRSyncID;

        public frmDefaultRoutes()
        {
            InitializeComponent();
        }

        private void ConstructPanelFromCDRCollection()
        {
            // lesson learned: use Reflector to translate VB, kick it if needed.
            // don't get involved in a complicated, editing session w/ C# and VIEMU
#if false
            // incomplete and complicated editing session shown below...
            int i = 0;
            int intDriverIDTabIndex;
            int intKeepButtonTabIndex;

            TextBox t1;
            TextBox t2;
            TextBox t3;
            TextBox t4;
            CheckBox t5;
            TextBox t6;

            foreach (var cdr in Program.CDRList)
            {

                intDriverIDTabIndex = 3 * i + 1;
                intKeepButtonTabIndex = 3 * i + 2;

                //
                // dynamically create 6 controls per CDR row
                // some are disabled (greyed-out) and one, txtboxPrimaryKey is invisible
                //
                var txtboxRouteId = new TextBox();
                using (var t1 = txtboxRouteId)
                {
                    t1.Text = cdr.CDRRouteID;
                    t1.Top = (i == 0) ? 8 : (i * 23) + 8;
                    t1.Left = 8;
                    t1.Width = 35;
                    t1.Name = String.Format("txtrouteID{0}", i.ToString());
                    t1.TextAlign = HorizontalAlignment.Center;
                    t1.TabStop = false;
                    t1.Enabled = false;
                pnlCurrentDayRoutes.Controls.Add(txtboxRouteId);
                }

                var txtboxRouteText = new TextBox();
                using (var t2 = txtboxRouteText)
                {
                    t2.Text = cdr.CDRRouteName;
                    t2.Top = (i == 0) ? 8 : (i * 23) + 8;
                    t2.Left = 50;
                    t2.Width = 100;
                    t2.Name = String.Format("txtrouteID{0}", i.ToString());
                    t2.TextAlign = HorizontalAlignment.Center;
                    t2.TabStop = false;
                    t2.Enabled = false;
                pnlCurrentDayRoutes.Controls.Add(txtboxRouteText);
                }

                var txtboxDriverId = new TextBox();
                using (var t3 = txtboxDriverId)
                {
                    t3.Text = cdr.CDRDefaultDriverID;
                    t3.Top = (i == 0) ? 8 : (i * 23) + 8;
                    t3.Left = 161;
                    t3.Width = 50;
                    t3.Name = String.Format("txtrouteID{0}", i.ToString());
                    t3.TextAlign = HorizontalAlignment.Center;
                    t3.TabStop = false;
                    t3.Enabled = false;
                }
                txtboxDriverId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxDriverID_KeyDown);
                txtboxDriverId.TextChanged += new System.EventHandler(this.txtboxDriverID_TextChanged);


                var txtboxLastName = new TextBox();
                using (var t4 = txtboxLastName)
                {
                    t4.Text = cdr.CDRDriverLastName;
                    t4.Top = (i == 0) ? 8 : (i * 23) + 8;
                    t4.Left = 212;
                    t4.Width = 150;
                    t4.Name = String.Format("txtrouteID{0}", i.ToString());
                    t4.TextAlign = HorizontalAlignment.Center;
                    t4.TabStop = false;
                    t4.Enabled = false;
                    pnlCurrentDayRoutes.Controls.Add(txtboxLastName);
                }


                //var chkboxKeep = new CheckBox();
                var chkboxKeep = new TextBox();
                using (var t5 = chkboxKeep)
                {
                    t5.Text = cdr.CDRDriverLastName;
                    t5.Top = (i == 0) ? 8 : (i * 23) + 8;
                    t5.Left = 370;
                    t5.Width = 60;
                    t5.Name = String.Format("txtrouteID{0}", i.ToString());
                    t5.TextAlign = HorizontalAlignment.Center;
                    t5.TabStop = false;
                    t5.Enabled = false;
                    pnlCurrentDayRoutes.Controls.Add(chkboxKeep);
                }


                var txtboxPrimaryKey = new TextBox();
                using (var t6 = txtboxPrimaryKey)
                {
                    t6.Text = cdr.CurrentDayRouteID.ToString();
                    t6.Top = (i == 0) ? 8 : (i * 23) + 8;
                    t6.Left = 435;
                    t6.Width = 150;
                    t6.Name = String.Format("txtrouteID{0}", i.ToString());
                    t6.TextAlign = HorizontalAlignment.Center;
                    t6.TabStop = false;
                    t6.Enabled = false;
                    t6.Visible = false;
                    pnlCurrentDayRoutes.Controls.Add(txtboxPrimaryKey);
                }

                i += 1;//  iterates through this set of dynamic controls
            }
#else
            // CDRList could be empty -- cuz blnStartOfDay is false...
            if (Program.CDRList.Count == 0)
            {
                Program.PopulateCDRFromvDefaultRoutes();
            }
    List<CurrentDayRoute>.Enumerator CDREnumerator= Program.CDRList.GetEnumerator();
    try
    {
        int i = 0;
        while (CDREnumerator.MoveNext())
        {
            CurrentDayRoute cdr = CDREnumerator.Current;
            int intDriverIDTabIndex = ((i + i) + i) + 1;
            int intKeepButtonTabIndex = ((i + i) + i) + 2;
            TextBox txtboxRouteId = new TextBox();
            TextBox tref0 = txtboxRouteId;
            tref0.Text = cdr.CDRRouteID;
            if (i == 0)
            {
                tref0.Top = 8;
            }
            else
            {
                tref0.Top = (i * 0x17) + 8;
            }
            tref0.Left = 8;
            tref0.Width = 0x23;
            tref0.Name = "txtrouteID" + i.ToString();
            tref0.TextAlign = HorizontalAlignment.Center;
            tref0.TabStop = false;
            tref0.Enabled = false;
            tref0 = null;
            this.pnlCurrentDayRoutes.Controls.Add(txtboxRouteId);
            TextBox txtboxRouteText = new TextBox();
            TextBox tref1 = txtboxRouteText;
            tref1.Text = cdr.CDRRouteName;
            if (i == 0)
            {
                tref1.Top = 8;
            }
            else
            {
                tref1.Top = (i * 0x17) + 8;
            }
            tref1.Left = 50;
            tref1.Width = 100;
            tref1.Name = "txtRouteText" + i.ToString();
            tref1.MaxLength = 20;
            tref1.TabIndex = intDriverIDTabIndex;
            tref1 = null;
            this.pnlCurrentDayRoutes.Controls.Add(txtboxRouteText);
            txtboxRouteText.KeyDown += new KeyEventHandler(this.txtboxRouteText_KeyDown);
            txtboxRouteText.TextChanged += new EventHandler(this.txtboxRouteText_TextChanged);
            TextBox txtboxDriverID = new TextBox();
            TextBox tref2 = txtboxDriverID;
            tref2.Text = cdr.CDRDefaultDriverID;
            if (i == 0)
            {
                tref2.Top = 8;
            }
            else
            {
                tref2.Top = (i * 0x17) + 8;
            }
            tref2.Left = 0xa1;
            tref2.Width = 50;
            tref2.Name = "txtDriverID" + i.ToString();
            tref2.MaxLength = 2;
            tref2.CharacterCasing = CharacterCasing.Upper;
            tref2.TabIndex = intDriverIDTabIndex;
            tref2 = null;
            this.pnlCurrentDayRoutes.Controls.Add(txtboxDriverID);
            txtboxDriverID.KeyDown += new KeyEventHandler(this.txtboxDriverID_KeyDown);
            txtboxDriverID.TextChanged += new EventHandler(this.txtboxDriverID_TextChanged);
            TextBox txtboxLastName = new TextBox();
            TextBox tref3 = txtboxLastName;
            tref3.Text = cdr.CDRDriverLastName;
            if (i == 0)
            {
                tref3.Top = 8;
            }
            else
            {
                tref3.Top = (i * 0x17) + 8;
            }
            tref3.Left = 0xd4;
            tref3.Width = 150;
            tref3.Name = "txtLastName" + i.ToString();
            tref3.TextAlign = HorizontalAlignment.Left;
            tref3.TabStop = false;
            tref3.Enabled = false;
            tref3 = null;
            this.pnlCurrentDayRoutes.Controls.Add(txtboxLastName);
            CheckBox chkboxKeep = new CheckBox();
            CheckBox tref4 = chkboxKeep;
            tref4.Name = "chkboxKeep" + i.ToString();
            if (i == 0)
            {
                tref4.Top = 8;
            }
            else
            {
                tref4.Top = (i * 0x17) + 8;
            }
            tref4.Left = 370;
            tref4.Text = "Keep";
            tref4.Width = 60;
            tref4.TabIndex = intKeepButtonTabIndex;
            tref4.Enabled = true;
            tref4 = null;
            this.pnlCurrentDayRoutes.Controls.Add(chkboxKeep);
            TextBox txtboxPrimaryKey = new TextBox();
            TextBox tref5 = txtboxPrimaryKey;
            tref5.Text = cdr.CurrentDayRouteID.ToString();
            if (i == 0)
            {
                tref5.Top = 8;
            }
            else
            {
                tref5.Top = (i * 0x17) + 8;
            }
            tref5.Left = 0x1b3;
            tref5.Width = 150;
            tref5.Name = "txtPrimaryKey" + i.ToString();
            tref5.TextAlign = HorizontalAlignment.Left;
            tref5.TabStop = false;
            tref5.Visible = false;
            tref5.Enabled = false;
            tref5 = null;
            this.pnlCurrentDayRoutes.Controls.Add(txtboxPrimaryKey);
            i++;
        }
    }
    finally
    {
        CDREnumerator.Dispose();
    }
#endif
        }
        public void txtboxDriverID_TextChanged(object sender, KeyEventArgs e)
        {
//                private void btnSetRoutes_KeyDown(object sender, KeyEventArgs e)
}
        public void txtboxDriverID_KeyDown(object sender, KeyEventArgs e)
        {
            int NextOneDown;
            int NextOneUp;
            Panel pnl = this.pnlCurrentDayRoutes;
            if ((pnl.Controls.GetChildIndex((Control)sender) + 5) > pnl.Controls.Count)
            {
                NextOneDown = 1;
            }
            else
            {
                NextOneDown = pnl.Controls.GetChildIndex((Control)sender) + 5;
            }
            if ((pnl.Controls.GetChildIndex((Control)sender) - 4) < 0)
            {
                NextOneUp = pnl.Controls.Count - 3;
            }
            else
            {
                NextOneUp = pnl.Controls.GetChildIndex((Control)sender) - 4;
            }
            if (e.KeyValue == 13)
            {
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Select();
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Focus();
            }
            else if (e.KeyValue == 40)
            {
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Select();
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Focus();
            }
            else if (e.KeyValue == 0x26)
            {
                this.pnlCurrentDayRoutes.Controls[NextOneUp].Select();
                this.pnlCurrentDayRoutes.Controls[NextOneUp].Focus();
            }
        }

        public void txtboxRouteText_TextChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox) 
                this.pnlCurrentDayRoutes.Controls[
                                    this.pnlCurrentDayRoutes
                                        .Controls
                                        .GetChildIndex((Control)sender)+ 3
                                        ];
            this.blnPanelRowChanged = true;
            checkbox.Enabled = true;
        }
        public void txtboxRouteText_KeyDown(object sender, KeyEventArgs e)
        {
            // this works ok but has a problem w/ bottom/top wraparound
            int NextOneDown;
            int NextOneUp;
            Panel pnl = this.pnlCurrentDayRoutes;
            if ((pnl.Controls.GetChildIndex((Control)sender) + 5) > pnl.Controls.Count)
                 { NextOneDown = 2; }
            else { NextOneDown = pnl.Controls.GetChildIndex((Control)sender) + 5; }
            
            if ((pnl.Controls.GetChildIndex((Control)sender) - 4) < 0)
                 { NextOneUp = pnl.Controls.Count - 3; }
            else { NextOneUp = pnl.Controls.GetChildIndex((Control)sender) - 4; }

            if (e.KeyValue == 13)
            {
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Select();
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Focus();
            }
            else if (e.KeyValue == 40)
            {
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Select();
                this.pnlCurrentDayRoutes.Controls[NextOneDown].Focus();
            }
            else if (e.KeyValue == 0x26)
            {
                this.pnlCurrentDayRoutes.Controls[NextOneUp].Select();
                this.pnlCurrentDayRoutes.Controls[NextOneUp].Focus();
            }
        }
        public void txtboxDriverID_TextChanged(object sender, EventArgs e)
        {
            var foo = sender as TextBox;
            if (foo.Text.Length == 2) 
            {
                this.ChangeDriver(RuntimeHelpers.GetObjectValue(sender), e);
            }
        }

        public void ChangeDriver(object sender, EventArgs e)
        {
            int NextOneDown;
            int NextOneUp;
            Panel pnl = this.pnlCurrentDayRoutes;
            if ((pnl.Controls.GetChildIndex((Control) sender) + 5) > pnl.Controls.Count)
            { NextOneDown = 1; }
            else { NextOneDown = pnl.Controls.GetChildIndex((Control) sender) + 5; }

            if ((pnl.Controls.GetChildIndex((Control) sender) - 5) < 0)
            { NextOneUp = pnl.Controls.Count - 3; }
            else { NextOneUp = pnl.Controls.GetChildIndex((Control) sender) - 5; }


            //int intEndPos = Strings.InStr(Strings.InStr(this.pnlCurrentDayRoutes.Controls[this.pnlCurrentDayRoutes.Controls.GetChildIndex((Control) sender)].Name, "_", CompareMethod.Text) + 1, this.pnlCurrentDayRoutes.Controls[this.pnlCurrentDayRoutes.Controls.GetChildIndex((Control) sender)].Name, "_", CompareMethod.Text);
            //var drcoll = new DriverCollection();
            //drcoll.Load();
            //int i = 0;
            if (Program.DriverList.Count == 0) {
                Program.GetDriverCollection();
            }
    
            foreach (var d in Program.DriverList)
            {
                if (d.DriverID == null) 
                {
                    pnl.Controls[pnl.Controls.GetChildIndex((Control) sender) + 1].Text = d.LastName;
                    break;
                }
            }

            if (this.pnlCurrentDayRoutes.Controls[this.pnlCurrentDayRoutes.Controls.GetChildIndex((Control) sender) + 1].Text == "Driver not found!")
            {
                this.pnlCurrentDayRoutes.Controls[this.pnlCurrentDayRoutes.Controls.GetChildIndex((Control) sender) + 1].ForeColor = Color.Red;
            }
            else
            {
                this.pnlCurrentDayRoutes.Controls[this.pnlCurrentDayRoutes.Controls.GetChildIndex((Control) sender) + 1].ForeColor = SystemColors.WindowText;
                this.pnlCurrentDayRoutes.Controls[this.pnlCurrentDayRoutes.Controls.GetChildIndex((Control) sender) + 2].Enabled = true;
            }
            this.pnlCurrentDayRoutes.Controls[NextOneDown].Focus();
        }

    

        private void frmDefaultRoutes_Load(object sender, EventArgs e)
        {
            if (this.Top < 45)
            {
                this.Top = 45;
            }
            this.ConstructPanelFromCDRCollection();
            this.pnlCurrentDayRoutes.Height = (Program.CDRList.Count+ 1) * 26;
            this.Height = this.pnlCurrentDayRoutes.Height;
            var ctrlcount = this.pnlCurrentDayRoutes.Controls.Count - 1;
            for (int i = 0; i <= ctrlcount; i++)
            {
                if (this.pnlCurrentDayRoutes.Controls[i].Name.Substring(0, 3) == "txt")
                {
                    this.pnlCurrentDayRoutes.Controls[i].Focus();
                }
            }
            this.btnSetRoutes.Enabled = true;
        }
        private void SaveAllCDRRoutes()
        {

            {
                Panel pnl = this.pnlCurrentDayRoutes;
                int limit = pnl.Controls.Count - 1;
                for (int k = 0; k <= limit; k += 6)
                {
                    Control.ControlCollection ctrlArray = pnl.Controls;
                    TextBox primarykey = (TextBox)ctrlArray[k + 5];
                    TextBox routeid = (TextBox)ctrlArray[k];
                    TextBox routename = (TextBox)ctrlArray[k + 1];
                    TextBox driverid = (TextBox)ctrlArray[k + 2];
                    TextBox drivername = (TextBox)ctrlArray[k + 3];
                    ctrlArray = null;
                    int PrimaryKey = Convert.ToInt32(primarykey.Text);
                    string strRouteId = routeid.Text;
                    string strRouteName = routename.Text;
                    string strDriverId = driverid.Text;
                    string strDriverName = drivername.Text;
                    if (routename.Modified | driverid.Modified)
                    {
                        // just set "dummysync" and save the datasource guy ??
                        SaveToCurrentDayRoute(PrimaryKey,
                            strRouteId, "dummysync", strDriverId,
                            strDriverName, strRouteName);
                    }
                    CheckBox checkbox = (CheckBox)pnl.Controls[k + 4];
                    if (checkbox.Checked)
                    {
                        SaveToRoute(strRouteName, strDriverId, 
                            strRouteId);
                    }
                }
            }
        }
private void SaveToRoute(string NewRouteName, string NewDriverId, string Routeid)
{
    foreach( var rr in Program.RouteList){
            if (rr.RouteID == Routeid)
            {
                rr.DefaultDriverID = NewDriverId;
                rr.RouteID = Routeid;
                rr.RouteName = NewRouteName;
                rr.Save();
            }
        }
}

        // this may end up going away ???
private void SaveToCurrentDayRoute(
     int PrimaryKey, string strRouteID, string sync,
     string strDriverID, string strDriverName, string strRouteName)
{
    int key = PrimaryKey;
    string usr = Environment.UserName;
    string terminal = Properties.Settings.Default.terminal;
    int PostedCount = Properties.Settings.Default.ActiveStations - 1;

    CurrentDayRoute cdr = new DispatchAR.CurrentDayRoute {
                            // now unused...
                            //CDRChecked = true,
                            //CDRDate= DateTime.Now,
                            //CDRCreatedBy= usr,
                            //CDRSyncID = "strCDRSyncID",
                            CDRDefaultDriverID=strDriverID,
                            CDRDriverLastName= strDriverName,
                            CDRDriverMessage="",
                            CDRRouteID=strRouteID,
                            CDRRouteName= strRouteName,
                            CDRStation = Environment.MachineName,
                            //CDRCreatedTime = DateTime.Now,
                            Terminal= terminal,
                            CurrentDayRouteID=key
                        };
    // tried cdr.save and cdr.update
    // need to put something that works in CurrentDayRouteBLL ...
    //cdr.Save();
    cdr.Update();
    Program.CDRList.Clear();
    Program.CDRList = Program.GetCDRCollection();

    //CurrentDayRoute.Update(key, strRouteID, strRouteName, strDriverID, strDriverName,
        //"", Environment.MachineName, false, DateTime.Now, "", "", 
        //DateTime.Now, "", DateTime.Now, true, DateTime.Now, false, DateTime.Now, 
        //usr, PostedCount, terminal);
}

private void btnSetRoutes_Click(object sender, EventArgs e)
{
    this.SaveAllCDRRoutes();
    this.Close();
}


    }
}