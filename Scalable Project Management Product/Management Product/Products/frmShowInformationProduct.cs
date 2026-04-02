using Management_Product.CTRL_Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.Forms_Product
{
    public partial class frmShowInformationProduct : Form
    {
        public frmShowInformationProduct(int ProductID)
        {
            InitializeComponent();

            ctrlShowInformationProduct showInformationProduct = new ctrlShowInformationProduct(ProductID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
