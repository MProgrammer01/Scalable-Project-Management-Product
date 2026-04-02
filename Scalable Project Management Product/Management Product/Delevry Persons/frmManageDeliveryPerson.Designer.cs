namespace Management_Product.Forms_Delivery_Person
{
    partial class frmManageDeliveryPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDeliveryPerson));
            this.dtDeliveryPerson = new System.Windows.Forms.DataGridView();
            this.cmsManageDeliveryPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowInformationsDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationOfCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewDeliveryPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfDeliveryPersonsFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtDeliveryPerson)).BeginInit();
            this.cmsManageDeliveryPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDeliveryPerson
            // 
            this.dtDeliveryPerson.BackgroundColor = System.Drawing.Color.White;
            this.dtDeliveryPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDeliveryPerson.ContextMenuStrip = this.cmsManageDeliveryPerson;
            this.dtDeliveryPerson.Location = new System.Drawing.Point(4, 254);
            this.dtDeliveryPerson.Margin = new System.Windows.Forms.Padding(2);
            this.dtDeliveryPerson.Name = "dtDeliveryPerson";
            this.dtDeliveryPerson.ReadOnly = true;
            this.dtDeliveryPerson.RowHeadersWidth = 51;
            this.dtDeliveryPerson.RowTemplate.Height = 24;
            this.dtDeliveryPerson.Size = new System.Drawing.Size(792, 261);
            this.dtDeliveryPerson.TabIndex = 36;
            this.dtDeliveryPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDeliveryPerson_CellClick);
            // 
            // cmsManageDeliveryPerson
            // 
            this.cmsManageDeliveryPerson.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageDeliveryPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInformationsDeliveryPersonToolStripMenuItem,
            this.EditDeliveryPersonToolStripMenuItem,
            this.DeleteDeliveryPersonToolStripMenuItem,
            this.sendMessageToDeliveryPersonToolStripMenuItem,
            this.callDeliveryPersonToolStripMenuItem,
            this.showInformationOfCommandToolStripMenuItem});
            this.cmsManageDeliveryPerson.Name = "cmsManageUser";
            this.cmsManageDeliveryPerson.Size = new System.Drawing.Size(283, 280);
            // 
            // ShowInformationsDeliveryPersonToolStripMenuItem
            // 
            this.ShowInformationsDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowInformationsDeliveryPersonToolStripMenuItem.Image")));
            this.ShowInformationsDeliveryPersonToolStripMenuItem.Name = "ShowInformationsDeliveryPersonToolStripMenuItem";
            this.ShowInformationsDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(282, 46);
            this.ShowInformationsDeliveryPersonToolStripMenuItem.Text = "Show Informations Delivery Person";
            this.ShowInformationsDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.ShowInformationsDeliveryPersonToolStripMenuItem_Click);
            // 
            // EditDeliveryPersonToolStripMenuItem
            // 
            this.EditDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditDeliveryPersonToolStripMenuItem.Image")));
            this.EditDeliveryPersonToolStripMenuItem.Name = "EditDeliveryPersonToolStripMenuItem";
            this.EditDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(282, 46);
            this.EditDeliveryPersonToolStripMenuItem.Text = "Edit Delivery Person";
            this.EditDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.EditDeliveryPersonToolStripMenuItem_Click);
            // 
            // DeleteDeliveryPersonToolStripMenuItem
            // 
            this.DeleteDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDeliveryPersonToolStripMenuItem.Image")));
            this.DeleteDeliveryPersonToolStripMenuItem.Name = "DeleteDeliveryPersonToolStripMenuItem";
            this.DeleteDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(282, 46);
            this.DeleteDeliveryPersonToolStripMenuItem.Text = "Delete Delivery Person";
            this.DeleteDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.DeleteDeliveryPersonToolStripMenuItem_Click);
            // 
            // sendMessageToDeliveryPersonToolStripMenuItem
            // 
            this.sendMessageToDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendMessageToDeliveryPersonToolStripMenuItem.Image")));
            this.sendMessageToDeliveryPersonToolStripMenuItem.Name = "sendMessageToDeliveryPersonToolStripMenuItem";
            this.sendMessageToDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(282, 46);
            this.sendMessageToDeliveryPersonToolStripMenuItem.Text = "Send Message To Delivery Person";
            this.sendMessageToDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToDeliveryPersonToolStripMenuItem_Click);
            // 
            // callDeliveryPersonToolStripMenuItem
            // 
            this.callDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callDeliveryPersonToolStripMenuItem.Image")));
            this.callDeliveryPersonToolStripMenuItem.Name = "callDeliveryPersonToolStripMenuItem";
            this.callDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(282, 46);
            this.callDeliveryPersonToolStripMenuItem.Text = "Call Delivery Person";
            this.callDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.callDeliveryPersonToolStripMenuItem_Click);
            // 
            // showInformationOfCommandToolStripMenuItem
            // 
            this.showInformationOfCommandToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInformationOfCommandToolStripMenuItem.Image")));
            this.showInformationOfCommandToolStripMenuItem.Name = "showInformationOfCommandToolStripMenuItem";
            this.showInformationOfCommandToolStripMenuItem.Size = new System.Drawing.Size(282, 46);
            this.showInformationOfCommandToolStripMenuItem.Text = "Show Information Of Command";
            this.showInformationOfCommandToolStripMenuItem.Click += new System.EventHandler(this.showInformationOfCommandToolStripMenuItem_Click);
            // 
            // btnAddNewDeliveryPerson
            // 
            this.btnAddNewDeliveryPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewDeliveryPerson.BackgroundImage")));
            this.btnAddNewDeliveryPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewDeliveryPerson.Location = new System.Drawing.Point(748, 200);
            this.btnAddNewDeliveryPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewDeliveryPerson.Name = "btnAddNewDeliveryPerson";
            this.btnAddNewDeliveryPerson.Size = new System.Drawing.Size(48, 48);
            this.btnAddNewDeliveryPerson.TabIndex = 41;
            this.btnAddNewDeliveryPerson.UseVisualStyleBackColor = true;
            this.btnAddNewDeliveryPerson.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Delivery Person";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByName.Location = new System.Drawing.Point(152, 208);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByName.TabIndex = 40;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Filter By Name :";
            // 
            // lblNumberOfDeliveryPersonsFound
            // 
            this.lblNumberOfDeliveryPersonsFound.AutoSize = true;
            this.lblNumberOfDeliveryPersonsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfDeliveryPersonsFound.Location = new System.Drawing.Point(270, 520);
            this.lblNumberOfDeliveryPersonsFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfDeliveryPersonsFound.Name = "lblNumberOfDeliveryPersonsFound";
            this.lblNumberOfDeliveryPersonsFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfDeliveryPersonsFound.TabIndex = 38;
            this.lblNumberOfDeliveryPersonsFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(8, 520);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Number Of Delivery Person Found :";
            // 
            // frmManageDeliveryPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.dtDeliveryPerson);
            this.Controls.Add(this.btnAddNewDeliveryPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfDeliveryPersonsFound);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDeliveryPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageDeliveryPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDeliveryPerson)).EndInit();
            this.cmsManageDeliveryPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDeliveryPerson;
        private System.Windows.Forms.ContextMenuStrip cmsManageDeliveryPerson;
        private System.Windows.Forms.ToolStripMenuItem ShowInformationsDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInformationOfCommandToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewDeliveryPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfDeliveryPersonsFound;
        private System.Windows.Forms.Label label5;
    }
}