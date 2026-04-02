using Management_Product.CTRL_Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.Forms_Command
{
    public partial class frmShowProductsOfUser : Form
    {
        public frmShowProductsOfUser(int Command_ID = -1, string NameOfUser = "", int CommandProductID = -1)
        {
            InitializeComponent();

           
            ctrlShowProductsOfUser showProductsOfUser = new ctrlShowProductsOfUser(Command_ID, NameOfUser, CommandProductID);

        }
    }
}
