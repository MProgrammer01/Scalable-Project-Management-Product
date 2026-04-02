using Business_Layer_Management_Product;
using Management_Product.CTRL_Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product
{
    public partial class frmAddOrEditUser : Form
    {
        clsUser _user;
        static int _UserID = -1;

        public frmAddOrEditUser(int userID = -1)
        {
            InitializeComponent();

            _UserID = userID;
        }

        void _LoadData()
        {
            if (_UserID == -1)
            {
                _user = new clsUser();
                lblAddOrEditUser.Text = "Add New User";
                dpCreateAt.Value = DateTime.Now;
                return;
            }
            _user = clsUser.FindUserByID(_UserID);
            if (_user == null)
            {
                MessageBox.Show($"The Form Will Be Closed Because No User With This ID {_UserID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();

                return;
            }

            lblAddOrEditUser.Text = "Edit User";
            lblUser_ID.Text = _user.User_ID.ToString();
            txtUsername.Text = _user.Username.ToString();
            txtEmail.Text = _user.Email.ToString();
            txtPhoneNumber.Text = _user.Phone_Number.ToString();
            txtAddress.Text = _user.Address.ToString();
            dpCreateAt.Value = _user.Created_At;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.Username = txtUsername.Text.ToString();
            _user.Email = txtEmail.Text.ToString();
            _user.Phone_Number = txtPhoneNumber.Text.ToString();
            _user.Address = txtAddress.Text.ToString();
            _user.Created_At = dpCreateAt.Value;

            if (_user.Save())
            {
                MessageBox.Show("Data Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAddOrEditUser.Text = "Edit User";
                lblUser_ID.Text = _user.User_ID.ToString();
            }
            else
            {
                MessageBox.Show("Data Not Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void validatingTxtForm(Control txtForm, string nameTxtForm, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtForm.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtForm, $"Enter A {nameTxtForm}");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtForm, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtUsername, "Username", e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtEmail, "Email", e);
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtPhoneNumber, "Phone Number", e);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtAddress, "Address", e);
        }

        private void frmAddOrEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
