using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SubSonic.Repository;
using BLL.Customer;


namespace WinClient.Customer
{
    public partial class frmCustomer : Form
    {
		private SimpleRepository repo = (SimpleRepository)WinClient.ApplicationContext["myRepo"];
        private BLL.Customer.CustomerBLL cust;
        public frmCustomer()
        {
            InitializeComponent();
            cust = (CustomerBLL) WinClient.ApplicationContext["CustomerBLL"];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string customerID = textBoxID.Text.Trim();
            if (customerID == "")
            {
                CUSTOMERSTableBindingSource.DataSource = cust.GetAll(); // violated IoC principles...
            }
            else
            {
                CUSTOMERSTableBindingSource.DataSource = cust.GetById(customerID);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            var foo = this.CUSTOMERSTableBindingSource;
            var chg = foo.SupportsChangeNotification;
            var foo1= this.CUSTOMERSTableBindingSource.List; 
            //foo.
            //cust.SaveOrUpdate(foo);

        }
    }
}