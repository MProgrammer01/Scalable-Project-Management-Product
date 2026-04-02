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
using Management_Product.Global;

namespace Management_Product.Forms_Employee
{
    public partial class frmShowAccountsOfEmployees : Form
    {
        DataTable dataAccountsOfEmployees;
        DataView dvAccountsOfEmployees;

        public frmShowAccountsOfEmployees()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            dataAccountsOfEmployees = clsEmployees.GetAccountsOfEmployees();

            foreach (DataRow row in dataAccountsOfEmployees.Rows)
            {
                row["Password"] = clsUtils.DecryptText(row["Password"].ToString(), 2);
            }

            dvAccountsOfEmployees = dataAccountsOfEmployees.DefaultView;
            dtAccountsOfEmployees.DataSource = dvAccountsOfEmployees;
            lblNumberOfAccountsEmployeesFound.Text = dvAccountsOfEmployees.Count.ToString();
        }
        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            string valueOfFilter = txtFilterByName.Text.ToString();

            if (string.IsNullOrEmpty(valueOfFilter))
            {
                dvAccountsOfEmployees.RowFilter = string.Empty;
                dtAccountsOfEmployees.DataSource = dvAccountsOfEmployees;
                lblNumberOfAccountsEmployeesFound.Text = dvAccountsOfEmployees.Count.ToString();
                return;
            }
            string query = $"Name like '%{valueOfFilter}%'";
            try
            {
                dvAccountsOfEmployees.RowFilter = query;
                dtAccountsOfEmployees.DataSource = dvAccountsOfEmployees;
                lblNumberOfAccountsEmployeesFound.Text = dvAccountsOfEmployees.Count.ToString();
            }
            catch { }
        }

        private void ShowInformationsEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowEmployeeInfo showEmployeeInfo = new frmShowEmployeeInfo((int)dtAccountsOfEmployees.CurrentRow.Cells["Employee_ID"].Value);
            showEmployeeInfo.ShowDialog();
            _LoadData();
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword updatePassword = new frmUpdatePassword((int)dtAccountsOfEmployees.CurrentRow.Cells["Employee_ID"].Value);
            updatePassword.ShowDialog();
            _LoadData();
        }

        private void frmShowAccountsOfEmployees_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
