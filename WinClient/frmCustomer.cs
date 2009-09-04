using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SubSonic.Repository;


namespace WinClient.Customer
{
    public partial class frmCustomer : Form
    {
		private SimpleRepository repo = (SimpleRepository)WinClient.ApplicationContext["myRepo"];
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string customerID = textBoxID.Text.Trim();
          
            var foo = repo.All<DispatchAR.CUSTOMER>();
            CUSTOMERSTableBindingSource.DataSource = foo;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}