using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            Customer.frmCustomer customerForm = new Customer.frmCustomer();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void toolStripMenuItemEmployee_Click(object sender, EventArgs e)
        {
            Employee.frmEmployee employeeForm = new Employee.frmEmployee();
            employeeForm.MdiParent = this;
            employeeForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}