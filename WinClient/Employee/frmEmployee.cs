using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinClient.Presenters;
using SubSonic.Repository;

namespace WinClient.Employee
{
    public partial class frmEmployee : Form
    {
        private IPresenter presenter = null;
        private SimpleRepository repo = (SimpleRepository)WinClient.ApplicationContext["myRepo"];

        public frmEmployee()
        {
            InitializeComponent();
            presenter = (IPresenter)WinClient.ApplicationContext["EmployeePresenter"];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string employeeID = textBoxID.Text.Trim();
            var drivers = repo.All<DispatchAR.DRIVER>();
            DRIVERTableBindingSource.DataSource = drivers;
            //dataGridViewEmployee.DataSource = presenter.GetData(employeeID);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}