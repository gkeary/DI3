using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SubSonic.Repository;
using BLL.Driver;

namespace WinClient.Driver
{
    public partial class frmDriver : Form
    {
        private SimpleRepository repo = (SimpleRepository)WinClient.ApplicationContext["myRepo"];
        private BLL.Driver.DriverBLL driver;

        public frmDriver()
        {
            InitializeComponent();
            driver = (DriverBLL)WinClient.ApplicationContext["DriverBLL"];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string employeeID = textBoxID.Text.Trim();
            DRIVERTableBindingSource.DataSource = driver.GetAll();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}