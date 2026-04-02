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
    public partial class frmLoginEmployees : Form
    {
        static string email = "", password = "";

        public frmLoginEmployees()
        {
            InitializeComponent();
        }

        void _LoadData()
        {

            if (clsForSavingEmployeeDataLoginInFile.FindLoginForEmployee(ref email, ref password))
            {
                txtEmail.Text = email;
                txtPassword.Text = password;
                cbRememberMe.Checked = true;
            }
            else
            {
                txtEmail.Text = "";
                txtPassword.Text = "";
                cbRememberMe.Checked = false;
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show($"The Email And Password Is Required", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string email = txtEmail.Text.ToString().Trim();
            string password = txtPassword.Text.ToString().Trim();

            if (clsLoginEmployees.CorrectEmailAndPassword(email, clsUtils.EncryptText(password, 0)))
            {
                int Permission = clsLoginEmployees.GetPermissionOfEmployeeByEmailAndPassword(email, password);
                frmMainDashboard mainDashboard = new frmMainDashboard();
                mainDashboard.ShowDialog();
                _LoadData();
            }
            else
            {
                MessageBox.Show($"The Email And Password Is Not Correct", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text.ToString().Trim();
            password = txtPassword.Text.ToString().Trim();
            if (cbRememberMe.Checked)
            {
                clsForSavingEmployeeDataLoginInFile.AddLoginForEmployeeToFile(email, password);
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.BalloonTipTitle = "Remember Your Information";
                notifyIcon.BalloonTipText = "Thank You, Now I Remember You";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(2000);

            }
            else
            {
                clsForSavingEmployeeDataLoginInFile.DeleteLogin();
                notifyIcon.Icon = SystemIcons.Error;
                notifyIcon.BalloonTipTitle = "Remember Your Information";
                notifyIcon.BalloonTipText = "Sorry, Now I Can't Remember You";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon.ShowBalloonTip(2000);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            //string email = txtEmail.Text.ToString().Trim();
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Enter Your Email");

            }
            else
            {
                errorProvider.SetError(txtEmail, "");

            }
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            //string Patern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$";

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Enter Your Passord");
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }
        }
    }
}
