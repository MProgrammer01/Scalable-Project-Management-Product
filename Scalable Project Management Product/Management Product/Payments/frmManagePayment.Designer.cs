namespace Management_Product.Forms_Payment
{
    partial class frmManagePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePayment));
            this.dtPaymentData = new System.Windows.Forms.DataGridView();
            this.cmsManageDeliveryPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInformationOfCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfPaymentFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentData)).BeginInit();
            this.cmsManageDeliveryPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPaymentData
            // 
            this.dtPaymentData.BackgroundColor = System.Drawing.Color.White;
            this.dtPaymentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPaymentData.Location = new System.Drawing.Point(3, 250);
            this.dtPaymentData.Margin = new System.Windows.Forms.Padding(2);
            this.dtPaymentData.Name = "dtPaymentData";
            this.dtPaymentData.ReadOnly = true;
            this.dtPaymentData.RowHeadersWidth = 51;
            this.dtPaymentData.RowTemplate.Height = 24;
            this.dtPaymentData.Size = new System.Drawing.Size(792, 261);
            this.dtPaymentData.TabIndex = 43;
            // 
            // cmsManageDeliveryPerson
            // 
            this.cmsManageDeliveryPerson.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageDeliveryPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInformationOfCommandToolStripMenuItem});
            this.cmsManageDeliveryPerson.Name = "cmsManageUser";
            this.cmsManageDeliveryPerson.Size = new System.Drawing.Size(280, 50);
            // 
            // showInformationOfCommandToolStripMenuItem
            // 
            this.showInformationOfCommandToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInformationOfCommandToolStripMenuItem.Image")));
            this.showInformationOfCommandToolStripMenuItem.Name = "showInformationOfCommandToolStripMenuItem";
            this.showInformationOfCommandToolStripMenuItem.Size = new System.Drawing.Size(279, 46);
            this.showInformationOfCommandToolStripMenuItem.Text = "Show Informations Of Commands";
            this.showInformationOfCommandToolStripMenuItem.Click += new System.EventHandler(this.showInformationOfCommandToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByName.Location = new System.Drawing.Point(151, 204);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByName.TabIndex = 47;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Filter By Name :";
            // 
            // lblNumberOfPaymentFound
            // 
            this.lblNumberOfPaymentFound.AutoSize = true;
            this.lblNumberOfPaymentFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfPaymentFound.Location = new System.Drawing.Point(226, 521);
            this.lblNumberOfPaymentFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfPaymentFound.Name = "lblNumberOfPaymentFound";
            this.lblNumberOfPaymentFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfPaymentFound.TabIndex = 45;
            this.lblNumberOfPaymentFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(3, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Number Of Payment Found :";
            // 
            // frmManagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 553);
            this.Controls.Add(this.dtPaymentData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfPaymentFound);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmManagePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentData)).EndInit();
            this.cmsManageDeliveryPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPaymentData;
        private System.Windows.Forms.ContextMenuStrip cmsManageDeliveryPerson;
        private System.Windows.Forms.ToolStripMenuItem showInformationOfCommandToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfPaymentFound;
        private System.Windows.Forms.Label label5;
    }
}