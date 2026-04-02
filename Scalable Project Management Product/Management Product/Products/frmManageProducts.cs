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
    public partial class frmManageProducts : Form
    {
        DataTable dataProducts;
        DataView dvProducts;

        static int ProductIDSelected = -1;
        public frmManageProducts()
        {
            InitializeComponent();
        }
        void _LoadData()
        {
            dataProducts = clsProduct.GetAllDataOfProducts();
            dvProducts = dataProducts.DefaultView;
            dtProducts.DataSource = dataProducts;
            lblNumberOfProductsFound.Text = dvProducts.Count.ToString();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateProduct addOrUpdateProduct = new frmAddOrUpdateProduct();
            addOrUpdateProduct.ShowDialog();
            _LoadData();
        }

        private void dtProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtProducts.Rows[e.RowIndex];
            ProductIDSelected = int.Parse(row.Cells["Product_ID"].Value.ToString());
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateProduct addOrUpdateProduct = new frmAddOrUpdateProduct(ProductIDSelected);
            addOrUpdateProduct.ShowDialog();
            _LoadData();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Delete This Product Have ID {ProductIDSelected}",
                "Conferm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsProduct.DeleteProduct(ProductIDSelected))
                {
                    MessageBox.Show("Product Is Deleted Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("Product Is Not Deleted Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showInfoProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInformationProduct showInformationProduct = new frmShowInformationProduct(ProductIDSelected);
            showInformationProduct.ShowDialog();
            _LoadData();
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            string valueTxtFilterByUsername = txtFilterByName.Text.ToString();

            if (string.IsNullOrEmpty(valueTxtFilterByUsername))
            {
                dvProducts.RowFilter = string.Empty;
                dtProducts.DataSource = dvProducts;
                lblNumberOfProductsFound.Text = dvProducts.Count.ToString();
                return;
            }
            try
            {
                string query = $"Product_Name like '%{valueTxtFilterByUsername}%'";
                dvProducts.RowFilter = query;
                dtProducts.DataSource = dvProducts;
                lblNumberOfProductsFound.Text = dvProducts.Count.ToString();

            }
            catch { }
        }

        private void frmManageProducts_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
