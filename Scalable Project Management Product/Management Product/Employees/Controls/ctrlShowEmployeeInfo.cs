using Business_Layer_Management_Product;
using Management_Product.Forms_Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.CTRL_Employees
{
    public partial class ctrlShowEmployeeInfo : UserControl
    {

        static int employeeID = -1;

        clsEmployees employees;

        public ctrlShowEmployeeInfo()
        {
            InitializeComponent();
        }

        public ctrlShowEmployeeInfo(int EmployeeID)
        {
            employeeID = EmployeeID;
        }

        void _LoadData()
        {
            if (employeeID == -1)
            {
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
            
            txtName.Text = employees.EmployeeName;
            txtPhoneNumber.Text = employees.PhoneNumber;
            txtEmail.Text = employees.Email;
            txtStatus.Text = employees.Status;
        }

        private void ctrlShowEmployeeInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void lklEditEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrEditEmployees addOrEditEmployees = new frmAddOrEditEmployees(employees.EmployeeID);
            addOrEditEmployees.ShowDialog();
            _LoadData();
        }
    }
}
