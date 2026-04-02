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

namespace Management_Product.CTRL_Commands
{
    public partial class ctrlShowProductsOfUser : UserControl
    {
        static int commandID = -1;
        static int commandProductID = -1;
        static string nameOfUser = "";

        DataTable dataProductsOfUser;
        
        public ctrlShowProductsOfUser()
        {
            InitializeComponent();
        }
        public ctrlShowProductsOfUser(int Command_ID = -1, string NameOfUser = "", int CommandProductID = -1)
        {
            commandID = Command_ID;
            commandProductID = CommandProductID;
            nameOfUser = NameOfUser;
        }
        void _LoadData()
        {
            if (commandID == -1 && commandProductID == -1)
            {
                return;
            }
            lblNameOfUser.Text = nameOfUser;
            if (commandID != -1)
            {
                dataProductsOfUser = clsCommand.ShowProductsOfUser(commandID);
            }
            else
            {
                dataProductsOfUser = clsCommand.ShowProductsOfUserByCommandProductID(commandProductID);
            }
            if (dataProductsOfUser == null)
            {
                MessageBox.Show("The Window Will Be Close Because No Products Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();
                return;
            }
            dtProductsOfUser.DataSource = dataProductsOfUser;
            lblNumberOfProductsFound.Text = dataProductsOfUser.Rows.Count.ToString();
        }

        private void ctrlShowProductsOfUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
