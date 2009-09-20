using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinClient
{
    public partial class frmOneTimePickup : Form
    {
        public List<string> custlist = new List<string>();
        public frmOneTimePickup()
        {
            InitializeComponent();
        }
        public frmOneTimePickup(string mode)
        {
            base.Load += new EventHandler(this.frmOneTimePickup_Load);
            InitializeComponent();
            if (mode == "Edit")
            {
                Text = "Edit Daily Pickup";
                gbxDaysOfWeek.Visible = true;
                gbxDaysOfWeek.Enabled = true;
                dpkrPickupDate.Enabled = false;
                btnSaveAndAddAnother.Text = "Save Daily Pickup";
            }
            else
            {
                Text = "Add One-Time Pickup -- for a specific Date";
                gbxDaysOfWeek.Visible = true;
                gbxDaysOfWeek.Enabled = false;
                btnSaveAndAddAnother.Text = "Save One-Time Pickup";
            }
        }

        private void frmOneTimePickup_Load(object sender, EventArgs e)
        {

            btnSaveAndClose.Enabled = true;
            dpkrPickupDate.MinDate = DateTime.Today.AddDays(1.0);
            if (this.Top < 0x2d)
            {
                this.Top = 0x2d;
            }
            txtCustomerID.Focus();
            comboRoutes.Items.Add("Route names...");
            foreach (var cr in Program.GetRouteCollection())
            {
                comboRoutes.Items.Add(cr.RouteID + " " + cr.RouteName);
            }
            var bll =(BLL.CustomerBLL)WinClient.ApplicationContext["CustomerBLL"];
            custlist.AddRange(bll.GetCustView());
            lstCustomers.DataSource = custlist;
        }
    }
}

