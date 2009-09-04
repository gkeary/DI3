using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SubSonic.Repository;

namespace WinClient.Driver
{
    public partial class frmDriver : Form
    {
        private SimpleRepository repo = (SimpleRepository)WinClient.ApplicationContext["myRepo"];

        public frmDriver()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string employeeID = textBoxID.Text.Trim();
            var drivers = repo.All<DispatchAR.DRIVER>();
            DRIVERTableBindingSource.DataSource = drivers;
            //dataGridViewDriver.DataSource = presenter.GetData(employeeID);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}