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

namespace Management_Product.CTRL_Product
{
    public partial class ctrlAddOrEditProduct : UserControl
    {
        static int ProductID = -1;

        clsProduct product;
        public ctrlAddOrEditProduct()
        {
            InitializeComponent();
        }

        public ctrlAddOrEditProduct(int productID)
        {
            ProductID = productID;
        }

        void _LoadData()
        {
            if(ProductID == -1)
            {
                product = new clsProduct();
                lblAddOrEditProduct.Text = "Add New Product";
                dpCreateAt.Value = DateTime.Now;
                return;
            }
            product = clsProduct.FindProductByID(ProductID);
            if(product == null)
            {
                MessageBox.Show($"The Form Will Be Closed Because No Peoduct With This ID {ProductID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();
                return;
            }

            lblAddOrEditProduct.Text = "Update Product";
            lblProduct_ID.Text = ProductID.ToString();
            txtName.Text = product.ProductName.ToString();
            txtDescription.Text = product.ProductDescription.ToString();
            txtPrice.Text = product.ProductPrice.ToString();
            txtStockQuantity.Text = product.StockQuantity.ToString();
            dpCreateAt.Value = product.Create_At;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            // Check if the parent form is not null and close it
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            product.ProductName = txtName.Text;
            product.ProductDescription = txtDescription.Text;
            product.ProductPrice = decimal.Parse(txtPrice.Text);
            product.StockQuantity = int.Parse(txtStockQuantity.Text);
            product.Create_At = dpCreateAt.Value;

            if (product.Save())
            {
                MessageBox.Show("Data Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAddOrEditProduct.Text = "Edit Product";
                lblProduct_ID.Text = product.ProductID.ToString();
            }
            else
            {
                MessageBox.Show("Data Not Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlAddOrEditProduct_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        void validatingTxtForm(Control txtForm, string nameTxtForm, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtForm.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtForm, $"Enter A {nameTxtForm} Of Product");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtForm, "");
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtName, "Name", e);
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtDescription, "Description", e);
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtPrice, "Price", e);
        }

        private void txtStockQuantity_Validating(object sender, CancelEventArgs e)
        {
            validatingTxtForm(txtStockQuantity, "Stock Quantity", e);
        }
    }
}
