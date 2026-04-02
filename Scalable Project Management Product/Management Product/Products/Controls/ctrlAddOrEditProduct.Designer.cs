namespace Management_Product.CTRL_Product
{
    partial class ctrlAddOrEditProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddOrEditProduct));
            this.lblProduct_ID = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dpCreateAt = new System.Windows.Forms.DateTimePicker();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddOrEditProduct = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct_ID
            // 
            this.lblProduct_ID.AutoSize = true;
            this.lblProduct_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProduct_ID.Location = new System.Drawing.Point(578, 94);
            this.lblProduct_ID.Name = "lblProduct_ID";
            this.lblProduct_ID.Size = new System.Drawing.Size(46, 25);
            this.lblProduct_ID.TabIndex = 31;
            this.lblProduct_ID.Text = "N/A";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(464, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 25);
            this.label.TabIndex = 30;
            this.label.Text = "Product ID :";
            // 
            // dpCreateAt
            // 
            this.dpCreateAt.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dpCreateAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dpCreateAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpCreateAt.Location = new System.Drawing.Point(313, 616);
            this.dpCreateAt.Name = "dpCreateAt";
            this.dpCreateAt.Size = new System.Drawing.Size(301, 26);
            this.dpCreateAt.TabIndex = 29;
            this.dpCreateAt.Value = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStockQuantity.Location = new System.Drawing.Point(313, 542);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(301, 26);
            this.txtStockQuantity.TabIndex = 28;
            this.txtStockQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtStockQuantity_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(313, 461);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(301, 26);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(313, 358);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(301, 73);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(313, 286);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 26);
            this.txtName.TabIndex = 25;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(412, 688);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 40);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 688);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(3, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 22;
            this.label6.Text = "Created_At :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(3, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(3, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(3, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(3, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name :";
            // 
            // lblAddOrEditProduct
            // 
            this.lblAddOrEditProduct.AutoSize = true;
            this.lblAddOrEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblAddOrEditProduct.ForeColor = System.Drawing.Color.Blue;
            this.lblAddOrEditProduct.Location = new System.Drawing.Point(131, 204);
            this.lblAddOrEditProduct.Name = "lblAddOrEditProduct";
            this.lblAddOrEditProduct.Size = new System.Drawing.Size(376, 46);
            this.lblAddOrEditProduct.TabIndex = 17;
            this.lblAddOrEditProduct.Text = "Add Or Edit Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ctrlAddOrEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProduct_ID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dpCreateAt);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddOrEditProduct);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlAddOrEditProduct";
            this.Size = new System.Drawing.Size(661, 731);
            this.Load += new System.EventHandler(this.ctrlAddOrEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddOrEditProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
