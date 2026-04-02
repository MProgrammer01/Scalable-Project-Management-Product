namespace Management_Product.Forms_Product
{
    partial class frmShowInformationProduct
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
            this.ctrlShowInformationProduct1 = new Management_Product.CTRL_Product.ctrlShowInformationProduct();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShowInformationProduct1
            // 
            this.ctrlShowInformationProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlShowInformationProduct1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowInformationProduct1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlShowInformationProduct1.Name = "ctrlShowInformationProduct1";
            this.ctrlShowInformationProduct1.Size = new System.Drawing.Size(502, 583);
            this.ctrlShowInformationProduct1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(392, 540);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowInformationProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 583);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlShowInformationProduct1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInformationProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CTRL_Product.ctrlShowInformationProduct ctrlShowInformationProduct1;
        private System.Windows.Forms.Button btnClose;
    }
}