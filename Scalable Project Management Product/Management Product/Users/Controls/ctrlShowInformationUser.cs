using Business_Layer_Management_Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.CTRL_Users
{
    public partial class ctrlShowInformationUser : UserControl
    {
        static int _UserID = -1;

        clsUser _User;
        public ctrlShowInformationUser()
        {
            InitializeComponent();
        }

        public ctrlShowInformationUser(int UserID = -1)
        {
            _UserID = UserID;
        }

        void _LoadData()
        {
            if(_UserID == -1)
            {
                return;
            }
            _User = clsUser.FindUserByID(_UserID);
            if(_User == null)
            {
                MessageBox.Show($"The Window Will Be Colsed Because No User Have ID {_UserID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();
                return;
            }
            lblUser_ID.Text = _UserID.ToString();
            txtUsername.Text = _User.Username.ToString();
            txtEmail.Text = _User.Email.ToString();
            txtPhoneNumber.Text = _User.Phone_Number.ToString();
            txtAddress.Text = _User.Address.ToString();
            dpCreateAt.Value = _User.Created_At;
        }

        private void ctrlShowInformationUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrEditUser addOrEditUser = new frmAddOrEditUser(_UserID);
            addOrEditUser.ShowDialog();
            _LoadData();
        }
    }
}
