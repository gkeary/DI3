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
          
            var foo = repo.All<DispatchAR.CUSTOMER>();
            //CUSTOMERSTableBindingSource.DataSource = foo;
            CUSTOMERSTableBindingSource.DataSource = cust.GetAll();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}