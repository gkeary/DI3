using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DispatchAR;
using BLL;
using System.Collections;
using System.Runtime.CompilerServices;

namespace WinClient
{
    public partial class frmDeleteDrivers : Form
    {
        private DataTable DriverTable; 
        private DriverBLL driver;
        private DispatchDB db; 
        

        public frmDeleteDrivers()
        {
            InitializeComponent();
            driver = (DriverBLL)WinClient.ApplicationContext["DriverBLL"];
            db = new DispatchDB();
        }
        private void DeleteDrivers()
        {
                var Drivercoll = Program.DriverList;
                var r2coll = Program.RouteList;

                object selected = dvrList.CheckedIndices;
                foreach (object itemChecked in dvrList.CheckedItems)
                {  
                    var dvr= (DRIVER) itemChecked; 
                    var sb = new StringBuilder();
                    sb.AppendLine(String.Format("{0} {1} -- Route: {2} ", dvr.FirstName, dvr.LastName, dvr.DriverID ));
                    sb.AppendLine(String.Format("ListChecked = {0}",itemChecked.ToString()));
                    //MessageBox.Show(sb.ToString());
                    //TODO: fixup so Route default driver set to "";
                    driver.DeleteById(dvr.DriverID);
                    // try this...
                    var rr = (RouteBLL)WinClient.ApplicationContext["RouteBLL"];
                    rr.SetBlank(dvr.DriverID );

                }
        }

        #region eventhandlers
        private void frmDeleteDrivers_Load(object sender, EventArgs e)
        {
          
            // ToDo: move this where it belongs....
            if (Program.DriverList.Count == 0)
            {
                Program.GetDriverCollection();
                //Program.DriverList.AddRange(driver.GetAll());
            } 

            dvrList.DataSource = Program.DriverList;
            dvrList.DisplayMember = "LastName"; 
            dvrList.ValueMember = "DriverTableID";
            dvrList.Sorted = true;
            if (this.Top < 45) //0x2d)
            {
                 this.Top = 50;
            }
        } 

        private void btnDeleteDrivers_Click(object sender, EventArgs e)
        {
            DeleteDrivers();
        }
 
        #endregion
    }
}
