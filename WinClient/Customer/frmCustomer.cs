using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WinClient.Presenters;

namespace WinClient.Customer
{
    public partial class frmCustomer : Form
    {
        private IPresenter presenter = null;

        public frmCustomer()
        {
            InitializeComponent();
            presenter = (IPresenter) WinClient.ApplicationContext["CustomerPresenter"];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string customerID = textBoxID.Text.Trim();
            dataGridViewCustomers.DataSource = presenter.GetData(customerID);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}