namespace Management_Product.Forms_Command
{
    partial class frmShowProductsOfUser
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
            this.ctrlShowProductsOfUser1 = new Management_Product.CTRL_Commands.ctrlShowProductsOfUser();
            this.SuspendLayout();
            // 
            // ctrlShowProductsOfUser1
            // 
            this.ctrlShowProductsOfUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlShowProductsOfUser1.Location = new System.Drawing.Point(0, 0);
            this.ctrlShowProductsOfUser1.Name = "ctrlShowProductsOfUser1";
            this.ctrlShowProductsOfUser1.Size = new System.Drawing.Size(361, 307);
            this.ctrlShowProductsOfUser1.TabIndex = 0;
            // 
            // frmShowProductsOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 307);
            this.Controls.Add(this.ctrlShowProductsOfUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowProductsOfUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CTRL_Commands.ctrlShowProductsOfUser ctrlShowProductsOfUser1;
    }
}