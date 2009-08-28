using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinClient.Presenters;

namespace WinClient.Employee
{
    public partial class frmEmployee : Form
    {
        private IPresenter presenter = null;

        public frmEmployee()
        {
            InitializeComponent();
            presenter = (IPresenter)WinClient.ApplicationContext["EmployeePresenter"];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string employeeID = textBoxID.Text.Trim();
            dataGridViewEmployee.DataSource = presenter.GetData(employeeID);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}