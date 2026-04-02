namespace Management_Product.CTRL_Product
{
    partial class ctrlShowInformationProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowInformationProduct));
            this.lblProduct_ID = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dpCreateAt = new System.Windows.Forms.DateTimePicker();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lklEditProduct = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct_ID
            // 
            this.lblProduct_ID.AutoSize = true;
            this.lblProduct_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProduct_ID.Location = new System.Drawing.Point(141, 87);
            this.lblProduct_ID.Name = "lblProduct_ID";
            this.lblProduct_ID.Size = new System.Drawing.Size(46, 25);
            this.lblProduct_ID.TabIndex = 47;
            this.lblProduct_ID.Text = "N/A";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(27, 87);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 25);
            this.label.TabIndex = 46;
            this.label.Text = "Product ID :";
            // 
            // dpCreateAt
            // 
            this.dpCreateAt.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dpCreateAt.Enabled = false;
            this.dpCreateAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dpCreateAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpCreateAt.Location = new System.Drawing.Point(336, 619);
            this.dpCreateAt.Name = "dpCreateAt";
            this.dpCreateAt.Size = new System.Drawing.Size(301, 26);
            this.dpCreateAt.TabIndex = 45;
            this.dpCreateAt.Value = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Enabled = false;
            this.txtStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStockQuantity.Location = new System.Drawing.Point(336, 545);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(301, 26);
            this.txtStockQuantity.TabIndex = 44;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(336, 464);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(301, 26);
            this.txtPrice.TabIndex = 43;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(336, 361);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(301, 73);
            this.txtDescription.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(336, 289);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 26);
            this.txtName.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(26, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 38;
            this.label6.Text = "Created_At :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(26, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 36);
            this.label5.TabIndex = 37;
            this.label5.Text = "Stock Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(26, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 36;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(26, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 36);
            this.label3.TabIndex = 35;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(26, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lklEditProduct
            // 
            this.lklEditProduct.AutoSize = true;
            this.lklEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lklEditProduct.Location = new System.Drawing.Point(486, 87);
            this.lklEditProduct.Name = "lklEditProduct";
            this.lklEditProduct.Size = new System.Drawing.Size(151, 29);
            this.lklEditProduct.TabIndex = 48;
            this.lklEditProduct.TabStop = true;
            this.lklEditProduct.Text = "Edit Product";
            this.lklEditProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEditProduct_LinkClicked);
            // 
            // ctrlShowInformationProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lklEditProduct);
            this.Controls.Add(this.lblProduct_ID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dpCreateAt);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlShowInformationProduct";
            this.Size = new System.Drawing.Size(661, 664);
            this.Load += new System.EventHandler(this.ctrlShowInformationProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProduct_ID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dpCreateAt;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lklEditProduct;
    }
}
