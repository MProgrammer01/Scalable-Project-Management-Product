using Business_Layer_Management_Product;
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

namespace Management_Product.CTRL_Product
{
    public partial class ctrlShowInformationProduct : UserControl
    {

        static int ProductID = -1;

        clsProduct product;

        public ctrlShowInformationProduct()
        {
            InitializeComponent();
        }

        public ctrlShowInformationProduct(int productID)
        {
            ProductID = productID;
        }

        void _LoadData()
        {
            if (ProductID == -1)
            {
                return;
            }
            product = clsProduct.FindProductByID(ProductID);
            if (product == null)
            {
                MessageBox.Show($"The Form Will Be Closed Because No Peoduct With This ID {ProductID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();
                return;
            }

            lblProduct_ID.Text = ProductID.ToString();
            txtName.Text = product.ProductName.ToString();
            txtDescription.Text = product.ProductDescription.ToString();
            txtPrice.Text = product.ProductPrice.ToString();
            txtStockQuantity.Text = product.StockQuantity.ToString();
            dpCreateAt.Value = product.Create_At;
        }

        private void ctrlShowInformationProduct_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void lklEditProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrUpdateProduct addOrUpdateProduct = new frmAddOrUpdateProduct(ProductID);
            addOrUpdateProduct.ShowDialog();
            _LoadData();
        }
    }
}
