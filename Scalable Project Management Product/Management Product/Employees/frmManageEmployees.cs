using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer_Management_Product;

namespace Management_Product.Forms_Employee
{
    public partial class frmManageEmployees : Form
    {
        DataTable dataEmployees;
        DataView dvEmployees;

        int EmployeeIDSelected = -1;

        public frmManageEmployees()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            dataEmployees = clsEmployees.GetAllEmployees();
            dvEmployees = dataEmployees.DefaultView;
            dtEmployees.DataSource = dvEmployees;
            lblNumberOfEmployeesFound.Text = dvEmployees.Count.ToString();
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            string valueOfFilter = txtFilterByName.Text.ToString();

            if (string.IsNullOrEmpty(valueOfFilter))
            {
                dvEmployees.RowFilter = string.Empty;
                dtEmployees.DataSource = dvEmployees;
                lblNumberOfEmployeesFound.Text = dvEmployees.Count.ToString();
                return;
            }
            string query = $"Name like '%{valueOfFilter}%'";
            try
            {
                dvEmployees.RowFilter = query;
                dtEmployees.DataSource = dvEmployees;
                lblNumberOfEmployeesFound.Text = dvEmployees.Count.ToString();
            }
            catch { }
        }

        private void sendMessageToDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplemented Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void callDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplemented Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtEmployees.Rows[e.RowIndex];
            EmployeeIDSelected = int.Parse(row.Cells["Employee_ID"].Value.ToString());
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddOrEditEmployees addOrEditEmployees = new frmAddOrEditEmployees();
            addOrEditEmployees.ShowDialog();
            _LoadData();
        }

        private void EditEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditEmployees addOrEditEmployees = new frmAddOrEditEmployees(EmployeeIDSelected);
            addOrEditEmployees.ShowDialog();
            _LoadData();
        }

        private void DeleteEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Delete This Employe Have ID = {EmployeeIDSelected}", "Conferm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsEmployees.DeleteEmployee(EmployeeIDSelected))
                {
                    MessageBox.Show("Employee Is Deleted");
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("Employee Is Not Deleted");
                    _LoadData();
                }
            }
        }

        private void ShowInformationsEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowEmployeeInfo showEmployeeInfo = new frmShowEmployeeInfo(EmployeeIDSelected);
            showEmployeeInfo.ShowDialog();
            _LoadData();
        }

        private void btnShowAccountsOfEmployees_Click(object sender, EventArgs e)
        {
            frmShowAccountsOfEmployees showAccountsOfEmployees = new frmShowAccountsOfEmployees();
            showAccountsOfEmployees.ShowDialog();
            _LoadData();
        }

        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
