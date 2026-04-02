namespace Management_Product.Forms_Product
{
    partial class frmManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProducts));
            this.dtProducts = new System.Windows.Forms.DataGridView();
            this.cmsManageUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfProductsFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).BeginInit();
            this.cmsManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProducts
            // 
            this.dtProducts.BackgroundColor = System.Drawing.Color.White;
            this.dtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProducts.ContextMenuStrip = this.cmsManageUser;
            this.dtProducts.Location = new System.Drawing.Point(3, 252);
            this.dtProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dtProducts.Name = "dtProducts";
            this.dtProducts.ReadOnly = true;
            this.dtProducts.RowHeadersWidth = 51;
            this.dtProducts.RowTemplate.Height = 24;
            this.dtProducts.Size = new System.Drawing.Size(792, 261);
            this.dtProducts.TabIndex = 20;
            this.dtProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProducts_CellClick);
            // 
            // cmsManageUser
            // 
            this.cmsManageUser.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeProductToolStripMenuItem,
            this.editProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.cmsManageUser.Name = "cmsManageUser";
            this.cmsManageUser.Size = new System.Drawing.Size(244, 142);
            // 
            // editeProductToolStripMenuItem
            // 
            this.editeProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editeProductToolStripMenuItem.Image")));
            this.editeProductToolStripMenuItem.Name = "editeProductToolStripMenuItem";
            this.editeProductToolStripMenuItem.Size = new System.Drawing.Size(243, 46);
            this.editeProductToolStripMenuItem.Text = "Show Informations Product";
            this.editeProductToolStripMenuItem.Click += new System.EventHandler(this.showInfoProductToolStripMenuItem_Click);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editProductToolStripMenuItem.Image")));
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(243, 46);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductToolStripMenuItem.Image")));
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(243, 46);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Manage Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByName.Location = new System.Drawing.Point(200, 205);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByName.TabIndex = 25;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filter By Product Name :";
            // 
            // lblNumberOfProductsFound
            // 
            this.lblNumberOfProductsFound.AutoSize = true;
            this.lblNumberOfProductsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfProductsFound.Location = new System.Drawing.Point(221, 518);
            this.lblNumberOfProductsFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfProductsFound.Name = "lblNumberOfProductsFound";
            this.lblNumberOfProductsFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfProductsFound.TabIndex = 23;
            this.lblNumberOfProductsFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Number Of Products Found :";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.BackgroundImage")));
            this.btnAddNewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewProduct.Location = new System.Drawing.Point(747, 191);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(48, 55);
            this.btnAddNewProduct.TabIndex = 21;
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // frmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.Controls.Add(this.dtProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfProductsFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddNewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).EndInit();
            this.cmsManageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtProducts;
        private System.Windows.Forms.ContextMenuStrip cmsManageUser;
        private System.Windows.Forms.ToolStripMenuItem editeProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfProductsFound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNewProduct;
    }
}