using Business_Layer_Management_Product;
using Management_Product.CTRL_Employees;
using Management_Product.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.Forms_Employee
{
    public partial class frmUpdatePassword : Form
    {
        static int _EmployeeID = -1;

        clsEmployees employee;

        static string password = string.Empty;

        public frmUpdatePassword(int EmployeeID = -1)
        {
            InitializeComponent();

            _EmployeeID = EmployeeID;
        }

        void _LoadData()
        {
            if (_EmployeeID == -1)
            {
                return;
            }

            employee = clsEmployees.FindEmployeeByID(_EmployeeID);

            if (employee == null)
            {
                MessageBox.Show($"The Form Will Be Closed Because No Employee With This ID {_EmployeeID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();

                return;
            }

            lblNameEmployee.Text = employee.EmployeeName;

        }

        private void btnGenerateNewPassword_Click(object sender, EventArgs e)
        {
            string[] name = employee.EmployeeName.Split(' ');

            password = name[0] + clsUtils.GeneratePassword();

            txtNewPassword.Text = password;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employee.Password = clsUtils.EncryptText(txtNewPassword.Text.Trim(), 2);

            if (employee.Save())
            {
                MessageBox.Show("Data Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Text = string.Empty;
                _LoadData();
            }
            else
            {
                MessageBox.Show("Data Not Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
