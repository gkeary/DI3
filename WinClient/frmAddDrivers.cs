using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dispatch.LINQ;
using SubSonic;

namespace Dispatch3
{
    public partial class frmAddDrivers : Form
    {
        bool blnSaveDriver;
        DispatchDB db = new DispatchDB();

       // Odbc.OdbcDataAdapter dadDrivers = new Odbc.OdbcDataAdapter();
       // Data.DataSet dstDrivers = new Data.DataSet();
        public frmAddDrivers()
        {
            InitializeComponent();
        }

        private void frmAddDriver_Load(object sender, System.EventArgs e)
        {
            return;
        }

        private void CheckDriverID(string id)
        {
            var existingdriver = from d in db.DRIVERS
                                 where d.DriverID == id
                                 select d;
            int dd = existingdriver.ToList<DRIVER>().Count();
           blnSaveDriver = (dd == 0) ? true : false;
            ///
            ///
            /// prototype LINQ query
            ///
            //var products = from p in db.Products
            //               where p.CategoryID == 5
            //               select p;
            //foreach (var p in products) {
            //    Console.WriteLine(p.ProductName);
            }

        private void SaveDriver()
        {
            this.Top = (Top < 45) ? 45 : Top;
            if ((blnSaveDriver))
            { db.Insert.Into<DRIVER>( x => x.DriverID, x => x.LastName, x => x.FirstName, x => x.MiddleInitial)
               .Values( txtDriverID.Text, txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text)
               .Execute();
                ///
                /// this uses Subsonic 3.0 LINQ
                /// Todo:  move it to a BLL layer...
                ///
            }
            else
            {
                string msg = "That DriverId is in use, please choose another";
                MessageBox.Show(msg);
            }
        }
        private void ClearForm()
        {
            txtDriverID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
        }

        private void txtDriverID_TextChanged(System.Object sender, System.EventArgs e)
        {
            if ((txtDriverID.Text.Length > 1))
            {
                CheckDriverID(txtDriverID.Text);
            }
        }

        private void btnSaveAndClose_Click(System.Object sender, System.EventArgs e)
        {
            SaveDriver();
            this.Close();
        }

        private void btnSaveAndAddAnother_Click(System.Object sender, System.EventArgs e)
        {
            SaveDriver();
            ClearForm();
            txtDriverID.Focus();
        }

        private void btnClearForm_Click(System.Object sender, System.EventArgs e)
        {
            ClearForm();
            txtDriverID.Focus();
        }



    }
}
