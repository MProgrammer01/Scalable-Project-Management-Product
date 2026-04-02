using Management_Product.Forms_Command;
using Management_Product.Forms_Delivery_Person;
using Management_Product.Forms_Employee;
using Management_Product.Forms_Payment;
using Management_Product.Forms_Product;
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
    public partial class frmMainDashboard : Form
    {
        
        public frmMainDashboard(int Permission = -1)
        {
            InitializeComponent();
        }
        void _Load()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            
            frmManageUsers manageUsers = new frmManageUsers();
            manageUsers.MdiParent = this;
            manageUsers.Show();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            frmManageProducts manageProducts = new frmManageProducts();
            manageProducts.MdiParent = this;
            manageProducts.Show();
        }

        private void manageCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            frmManageCommands manageCommands = new frmManageCommands(); 
            manageCommands.MdiParent = this;
            manageCommands.Show();
            
        }

        private void manageDeliveryPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            frmManageDeliveryPerson deliveryPerson = new frmManageDeliveryPerson();
            deliveryPerson.MdiParent = this;
            deliveryPerson.Show();
        }

        private void managePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            frmManagePayment payment = new frmManagePayment();
            payment.MdiParent = this;
            payment.Show();
        }


        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            frmManageEmployees manageEmployees = new frmManageEmployees();
            manageEmployees.MdiParent = this;
            manageEmployees.Show();
        }

        private void commandDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Load();
            frmManageCommands manageCommands = new frmManageCommands();
            manageCommands.MdiParent = this;
            manageCommands.Show();
        }
    }
}
