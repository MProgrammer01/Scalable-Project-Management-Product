namespace Management_Product.CTRL_Delevry_Person
{
    partial class ctrlShowInformationsOfCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlShowInformationsOfCommand));
            this.lblNumberOfCommandsFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCommandsOfUser = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInformationOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showInformationsDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationsOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandsOfUser)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfCommandsFound
            // 
            this.lblNumberOfCommandsFound.AutoSize = true;
            this.lblNumberOfCommandsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfCommandsFound.Location = new System.Drawing.Point(208, 283);
            this.lblNumberOfCommandsFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfCommandsFound.Name = "lblNumberOfCommandsFound";
            this.lblNumberOfCommandsFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfCommandsFound.TabIndex = 31;
            this.lblNumberOfCommandsFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(2, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Number Of Command Found :";
            // 
            // dtCommandsOfUser
            // 
            this.dtCommandsOfUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCommandsOfUser.ContextMenuStrip = this.contextMenuStrip;
            this.dtCommandsOfUser.Location = new System.Drawing.Point(5, 145);
            this.dtCommandsOfUser.Name = "dtCommandsOfUser";
            this.dtCommandsOfUser.ReadOnly = true;
            this.dtCommandsOfUser.Size = new System.Drawing.Size(437, 129);
            this.dtCommandsOfUser.TabIndex = 29;
            this.dtCommandsOfUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCommandsOfUser_CellClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInformationOfProductsToolStripMenuItem,
            this.showInformationsDeliveryPersonToolStripMenuItem,
            this.showInformationsOfUserToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(291, 164);
            // 
            // showInformationOfProductsToolStripMenuItem
            // 
            this.showInformationOfProductsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInformationOfProductsToolStripMenuItem.Image")));
            this.showInformationOfProductsToolStripMenuItem.Name = "showInformationOfProductsToolStripMenuItem";
            this.showInformationOfProductsToolStripMenuItem.Size = new System.Drawing.Size(290, 46);
            this.showInformationOfProductsToolStripMenuItem.Text = "Show Informations Of Products User";
            this.showInformationOfProductsToolStripMenuItem.Click += new System.EventHandler(this.showInformationOfProductsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(186, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Commands";
            // 
            // showInformationsDeliveryPersonToolStripMenuItem
            // 
            this.showInformationsDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInformationsDeliveryPersonToolStripMenuItem.Image")));
            this.showInformationsDeliveryPersonToolStripMenuItem.Name = "showInformationsDeliveryPersonToolStripMenuItem";
            this.showInformationsDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(290, 46);
            this.showInformationsDeliveryPersonToolStripMenuItem.Text = "Show Informations Delivery Person";
            this.showInformationsDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.showInformationsDeliveryPersonToolStripMenuItem_Click);
            // 
            // showInformationsOfUserToolStripMenuItem
            // 
            this.showInformationsOfUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInformationsOfUserToolStripMenuItem.Image")));
            this.showInformationsOfUserToolStripMenuItem.Name = "showInformationsOfUserToolStripMenuItem";
            this.showInformationsOfUserToolStripMenuItem.Size = new System.Drawing.Size(290, 46);
            this.showInformationsOfUserToolStripMenuItem.Text = "Show Informations Of User";
            this.showInformationsOfUserToolStripMenuItem.Click += new System.EventHandler(this.showInformationsOfUserToolStripMenuItem_Click);
            // 
            // ctrlShowInformationsOfCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumberOfCommandsFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtCommandsOfUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlShowInformationsOfCommand";
            this.Size = new System.Drawing.Size(446, 309);
            this.Load += new System.EventHandler(this.ctrlShowInformationsOfCommand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandsOfUser)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberOfCommandsFound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtCommandsOfUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInformationOfProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInformationsDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInformationsOfUserToolStripMenuItem;
    }
}
