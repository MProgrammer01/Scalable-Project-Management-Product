using Business_Layer_Management_Product;
using Management_Product.Forms_Command;
using Management_Product.Forms_Delivery_Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.CTRL_Delevry_Person
{
    public partial class ctrlShowInformationsOfCommand : UserControl
    {
        static int deliveryPersonID = -1;

        static int selectedDeliveryPersonID = -1;

        static int commandID = -1;

        DataTable dataIformationsOfCommand;

        DataView dvInformationsOfCommand;

        static int CommandIDSelected = -1;

        static string NameOfUserSelected = "";

        static int CommandProductIDSelected = -1;

        public ctrlShowInformationsOfCommand()
        {
            InitializeComponent();
        }
        public ctrlShowInformationsOfCommand(int DeliveryPersonID = -1, int CommandID = -1)
        {
            deliveryPersonID = DeliveryPersonID;
            commandID = CommandID;
        }

        void _LoadData()
        {
            if(deliveryPersonID == -1 && commandID == -1)
            {
                return;
            }

            if(deliveryPersonID != -1)
            {
                dataIformationsOfCommand = clsDeliveryPerson.GetInformationOfCommand(deliveryPersonID);
                showInformationsDeliveryPersonToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                if(commandID != -1)
                {
                    dataIformationsOfCommand = clsCommand.GetNumberOfCommands(commandID);  
                }
            }
            if (dataIformationsOfCommand == null)
            {
                MessageBox.Show($"The Window Will Be Close Because No Command Have {commandID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();
                return;
            }
            dtCommandsOfUser.DataSource = dataIformationsOfCommand;
            dvInformationsOfCommand = dataIformationsOfCommand.DefaultView;
            lblNumberOfCommandsFound.Text = dvInformationsOfCommand.Count.ToString();
        }

        private void ctrlShowInformationsOfCommand_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void dtCommandsOfUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtCommandsOfUser.Rows[e.RowIndex];
            
            NameOfUserSelected = row.Cells["Username"].Value.ToString();
            
            if(commandID != -1)
            {
                if (row.DataGridView.Columns.Contains("Command_Product_ID") &&
                row.Cells["Command_Product_ID"].Value != null &&
                !string.IsNullOrEmpty(row.Cells["Command_Product_ID"].Value.ToString()))
                {
                    CommandProductIDSelected = int.Parse(row.Cells["Command_Product_ID"].Value.ToString());
                }
                else
                {
                    return;
                }

                if (row.DataGridView.Columns.Contains("Delivery_Person_ID") &&
                row.Cells["Delivery_Person_ID"].Value != null &&
                !string.IsNullOrEmpty(row.Cells["Delivery_Person_ID"].Value.ToString()))
                {
                    selectedDeliveryPersonID = int.Parse(row.Cells["Delivery_Person_ID"].Value.ToString());
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (row.DataGridView.Columns.Contains("Command_ID") &&
                row.Cells["Command_ID"].Value != null &&
                !string.IsNullOrEmpty(row.Cells["Command_ID"].Value.ToString()))
                {
                    CommandIDSelected = int.Parse(row.Cells["Command_ID"].Value.ToString());
                }
                else
                {
                    return;
                }

                
            }
        }

        private void showInformationOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowProductsOfUser showProductsOfUser;

            if (commandID == -1)
            {
               
                showProductsOfUser = new frmShowProductsOfUser(Command_ID: CommandIDSelected, NameOfUser: NameOfUserSelected);
            }
            else
            {
                showProductsOfUser = new frmShowProductsOfUser(NameOfUser: NameOfUserSelected, CommandProductID: CommandProductIDSelected);
            }
            showProductsOfUser.ShowDialog();
            _LoadData();
        }

        private void showInformationsDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmShowInformationDeliveryPerson showInformationDeliveryPerson = new frmShowInformationDeliveryPerson(selectedDeliveryPersonID);
            showInformationDeliveryPerson.ShowDialog();
            _LoadData();
        }

        private void showInformationsOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID;
            if (commandID == -1)
            {
                UserID = clsCommand.GetIDOfUser(CommandIDSelected);
            }
            else
            {
                UserID = clsCommand.GetIDOfUser(commandID);
            }


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
    }
}
