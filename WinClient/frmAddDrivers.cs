using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DispatchAR;
using SubSonic;

namespace WinClient //Dispatch3
{
    public partial class frmAddDrivers : Form
    {
        bool blnSaveDriver;
        // TODO: inject this one too.
        DispatchDB db = new DispatchDB();

       // Odbc.OdbcDataAdapter dadDrivers = new Odbc.OdbcDataAdapter();
       // Data.DataSet dstDrivers = new Data.DataSet();
        //public frmAddDrivers()
        //{
        //    InitializeComponent();
        //}

        private void frmAddDrivers_Load(object sender, System.EventArgs e)
        {
            btnSaveAndClose.Enabled = false;
            btnSaveAndAddAnother.Enabled = false;
        }

        private bool DriverIDExists(string id)
        {
            var existingdriver = from d in db.DRIVERS
                                 where d.DriverID == id
                                 select d;
            int dd = existingdriver.ToList<DRIVER>().Count();
           return  (dd == 0) ? false : true;
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

            if (ValidateForm())
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
                string msg = "Invalid Data";
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

        private bool ValidateForm()
        {
            bool result= false;

            if (
                txtDriverID.Text.Length == 2 &&
                ! DriverIDExists(txtDriverID.Text) &&
                txtFirstName.Text.Length>0 &&
                txtLastName.Text.Length>0){
                result = true;
            }
            return result;
                
        }
        private void txtDriverID_TextChanged(System.Object sender, System.EventArgs e)
        {
            if ((txtDriverID.Text.Length > 1))
            {
                if (DriverIDExists(txtDriverID.Text))
                {
                    string msg = "That DriverId is in use, please choose another";
                    MessageBox.Show(msg);
                    btnSaveAndClose.Enabled = false;
                    btnSaveAndAddAnother.Enabled = false;
                    txtDriverID.Focus();
                }
                else
                {
                btnSaveAndAddAnother.Enabled = true;
                btnSaveAndClose.Enabled = true;
                }
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
