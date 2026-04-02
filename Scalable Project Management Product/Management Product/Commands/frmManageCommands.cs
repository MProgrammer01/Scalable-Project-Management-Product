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
using Management_Product.Forms_Delivery_Person;

namespace Management_Product.Forms_Command
{
    public partial class frmManageCommands : Form
    {
        DataTable dataCommands;
        DataView dvCommands;

        static int CommandIDSelected = -1;
        static string NameOfUserSelected = "";

        public frmManageCommands()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            dataCommands = clsCommand.GetAllDataOfCommands();
            dvCommands = dataCommands.DefaultView;
            dtCommands.DataSource = dvCommands;
            lblNumberOfCommandsFound.Text = dvCommands.Count.ToString();
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            string valueTxtFilterName = txtFilterByName.Text.ToString();

            if (string.IsNullOrEmpty(valueTxtFilterName))
            {
                dvCommands.RowFilter = string.Empty;
                dtCommands.DataSource = dvCommands;
                lblNumberOfCommandsFound.Text = dvCommands.Count.ToString();
                return;
            }
            try
            {
                string query = $"Username like '%{valueTxtFilterName}%'";
                dvCommands.RowFilter = query;
                dtCommands.DataSource = dvCommands;
                lblNumberOfCommandsFound.Text = dvCommands.Count.ToString();

            }
            catch { }
        }

        private void dtCommands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtCommands.Rows[e.RowIndex];
            CommandIDSelected = int.Parse(row.Cells["Command_ID"].Value.ToString());
            NameOfUserSelected = row.Cells["Username"].Value.ToString();
        }

        private void ShowInformationsOfProductUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowProductsOfUser showProductsOfUser = new frmShowProductsOfUser(CommandIDSelected, NameOfUserSelected);
            showProductsOfUser.ShowDialog();
            _LoadData();
        }

        private void ShowInformationsOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsCommand.GetIDOfUser(CommandIDSelected);
            if (UserID != -1)
            {
                frmShowUserInfo showUserInfo = new frmShowUserInfo(UserID);
                showUserInfo.ShowDialog();
                _LoadData();
            }
            else
            {
                MessageBox.Show($"The Person Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInformationsOfDelevryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DeliveryPersonID = clsCommand.GetDeliveryPersonID(CommandIDSelected);
            if (DeliveryPersonID != -1)
            {
                frmShowInformationDeliveryPerson showInformationDeliveryPerson = new frmShowInformationDeliveryPerson(DeliveryPersonID);
                showInformationDeliveryPerson.ShowDialog();
                _LoadData();
            }
            else
            {
                MessageBox.Show($"The Delivery Person Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManageCommands_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
