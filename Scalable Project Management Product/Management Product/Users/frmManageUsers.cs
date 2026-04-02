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

namespace Management_Product.Forms_Product
{
    public partial class frmManageUsers : Form
    {
        static int UserIDSelected = -1;

        static DataTable dataUsers;
        static DataView dataUserView;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            dataUsers = clsUser.GetAllDataOfUsers();
            dataUserView = dataUsers.DefaultView;
            dtUsers.DataSource = dataUserView;
            lblNumberOfUsersFound.Text = dataUserView.Count.ToString();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser addOrEditUser = new frmAddOrEditUser();
            addOrEditUser.ShowDialog();
            _LoadData();
        }

        private void dtUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtUsers.Rows[e.RowIndex];
            UserIDSelected = int.Parse(row.Cells["User_ID"].Value.ToString());
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser addOrEditUser = new frmAddOrEditUser(UserIDSelected);
            addOrEditUser.ShowDialog();
            _LoadData();
        }

        private void showInfoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo showUserInfo = new frmShowUserInfo(UserIDSelected);
            showUserInfo.ShowDialog();
            _LoadData();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Delete This User Have ID {UserIDSelected}",
                "Conferm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(UserIDSelected))
                {
                    MessageBox.Show("User Is Deleted Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("User Is Not Deleted Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendMessageToUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplemented Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void callUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplemented Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFilterByUsername_TextChanged(object sender, EventArgs e)
        {
            string valueTxtFilterByUsername = txtFilterByUsername.Text.ToString();

            if (string.IsNullOrEmpty(valueTxtFilterByUsername))
            {
                dataUserView.RowFilter = string.Empty;
                dtUsers.DataSource = dataUserView;
                lblNumberOfUsersFound.Text = dataUserView.Count.ToString();
                return;
            }
            try
            {
                string query = $"Username like '%{valueTxtFilterByUsername}%'";
                dataUserView.RowFilter = query;
                dtUsers.DataSource = dataUserView;
                lblNumberOfUsersFound.Text = dataUserView.Count.ToString();

            }
            catch { }

        }

        private void frmManageProducts_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
