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
    public partial class frmAddOrEditEmployees : Form
    {
        static int employeeID = -1;

        clsEmployees employees;

        public frmAddOrEditEmployees(int EmployeeID = -1)
        {
            InitializeComponent();

            employeeID = EmployeeID;
        }

        void _LoadData()
        {
            if (employeeID == -1)
            {
                employees = new clsEmployees();
                lblAddOrEditEmployee.Text = "Add New Employee";
                return;
            }

            employees = clsEmployees.FindEmployeeByID(employeeID);
            if (employees == null)
            {
                MessageBox.Show($"The Form Will Be Closed Because No Employee With This ID {employeeID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();

                return;
            }
            lblEmployeeID.Text = employees.EmployeeID.ToString();
            lblAddOrEditEmployee.Text = "Edit Employee";
            txtName.Text = employees.EmployeeName;
            txtPhoneNumber.Text = employees.PhoneNumber;
            txtEmail.Text = employees.Email;
            txtStatus.Text = employees.Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employees.EmployeeName = txtName.Text;
            employees.PhoneNumber = txtPhoneNumber.Text;
            employees.Email = txtEmail.Text;
            employees.Status = txtStatus.Text;
            // password : name + UperLetter + four number + two symbols
            string password = employees.EmployeeName + clsUtils.GeneratePassword();
            // Encript Password
            employees.Password = clsUtils.EncryptText(password, 2);

            if (employees.Save())
            {
                MessageBox.Show("Data Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAddOrEditEmployee.Text = "Edit Employee";
                lblEmployeeID.Text = employees.EmployeeID.ToString();
            }
            else
            {
                MessageBox.Show("Data Not Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddOrEditEmployees_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
