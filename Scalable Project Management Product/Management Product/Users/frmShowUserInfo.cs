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
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UserID = -1)
        {
            InitializeComponent();

            ctrlShowInformationUser showInformationUser = new ctrlShowInformationUser(UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
