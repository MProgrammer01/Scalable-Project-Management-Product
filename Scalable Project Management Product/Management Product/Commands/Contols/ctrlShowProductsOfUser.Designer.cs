namespace Management_Product.CTRL_Commands
{
    partial class ctrlShowProductsOfUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowProductsOfUser));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtProductsOfUser = new System.Windows.Forms.DataGridView();
            this.lblNumberOfProductsFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNameOfUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductsOfUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(97, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Products Of : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dtProductsOfUser
            // 
            this.dtProductsOfUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductsOfUser.Location = new System.Drawing.Point(3, 168);
            this.dtProductsOfUser.Name = "dtProductsOfUser";
            this.dtProductsOfUser.ReadOnly = true;
            this.dtProductsOfUser.Size = new System.Drawing.Size(352, 103);
            this.dtProductsOfUser.TabIndex = 22;
            // 
            // lblNumberOfProductsFound
            // 
            this.lblNumberOfProductsFound.AutoSize = true;
            this.lblNumberOfProductsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfProductsFound.Location = new System.Drawing.Point(208, 277);
            this.lblNumberOfProductsFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfProductsFound.Name = "lblNumberOfProductsFound";
            this.lblNumberOfProductsFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfProductsFound.TabIndex = 25;
            this.lblNumberOfProductsFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(2, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Number Of Product Found :";
            // 
            // lblNameOfUser
            // 
            this.lblNameOfUser.AutoSize = true;
            this.lblNameOfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfUser.ForeColor = System.Drawing.Color.Blue;
            this.lblNameOfUser.Location = new System.Drawing.Point(206, 95);
            this.lblNameOfUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameOfUser.Name = "lblNameOfUser";
            this.lblNameOfUser.Size = new System.Drawing.Size(63, 20);
            this.lblNameOfUser.TabIndex = 26;
            this.lblNameOfUser.Text = "??????";
            // 
            // ctrlShowProductsOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameOfUser);
            this.Controls.Add(this.lblNumberOfProductsFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtProductsOfUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlShowProductsOfUser";
            this.Size = new System.Drawing.Size(358, 300);
            this.Load += new System.EventHandler(this.ctrlShowProductsOfUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductsOfUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtProductsOfUser;
        private System.Windows.Forms.Label lblNumberOfProductsFound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNameOfUser;
    }
}
