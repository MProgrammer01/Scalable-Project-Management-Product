namespace Management_Product.Forms_Product
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.dtUsers = new System.Windows.Forms.DataGridView();
            this.cmsManageUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterByUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfUsersFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).BeginInit();
            this.cmsManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUsers
            // 
            this.dtUsers.BackgroundColor = System.Drawing.Color.White;
            this.dtUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsers.ContextMenuStrip = this.cmsManageUser;
            this.dtUsers.Location = new System.Drawing.Point(3, 252);
            this.dtUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dtUsers.Name = "dtUsers";
            this.dtUsers.ReadOnly = true;
            this.dtUsers.RowHeadersWidth = 51;
            this.dtUsers.RowTemplate.Height = 24;
            this.dtUsers.Size = new System.Drawing.Size(792, 261);
            this.dtUsers.TabIndex = 12;
            this.dtUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsers_CellClick);
            // 
            // cmsManageUser
            // 
            this.cmsManageUser.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.sendMessageToUserToolStripMenuItem,
            this.callUserToolStripMenuItem});
            this.cmsManageUser.Name = "cmsManageUser";
            this.cmsManageUser.Size = new System.Drawing.Size(225, 234);
            // 
            // editeUserToolStripMenuItem
            // 
            this.editeUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editeUserToolStripMenuItem.Image")));
            this.editeUserToolStripMenuItem.Name = "editeUserToolStripMenuItem";
            this.editeUserToolStripMenuItem.Size = new System.Drawing.Size(224, 46);
            this.editeUserToolStripMenuItem.Text = "Show Informations User";
            this.editeUserToolStripMenuItem.Click += new System.EventHandler(this.showInfoUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editUserToolStripMenuItem.Image")));
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(224, 46);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(224, 46);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // sendMessageToUserToolStripMenuItem
            // 
            this.sendMessageToUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendMessageToUserToolStripMenuItem.Image")));
            this.sendMessageToUserToolStripMenuItem.Name = "sendMessageToUserToolStripMenuItem";
            this.sendMessageToUserToolStripMenuItem.Size = new System.Drawing.Size(224, 46);
            this.sendMessageToUserToolStripMenuItem.Text = "Send Message To User";
            this.sendMessageToUserToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToUserToolStripMenuItem_Click);
            // 
            // callUserToolStripMenuItem
            // 
            this.callUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callUserToolStripMenuItem.Image")));
            this.callUserToolStripMenuItem.Name = "callUserToolStripMenuItem";
            this.callUserToolStripMenuItem.Size = new System.Drawing.Size(224, 46);
            this.callUserToolStripMenuItem.Text = "Call User";
            this.callUserToolStripMenuItem.Click += new System.EventHandler(this.callUserToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterByUsername
            // 
            this.txtFilterByUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByUsername.Location = new System.Drawing.Point(177, 207);
            this.txtFilterByUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByUsername.Name = "txtFilterByUsername";
            this.txtFilterByUsername.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByUsername.TabIndex = 17;
            this.txtFilterByUsername.TextChanged += new System.EventHandler(this.txtFilterByUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter By Username :";
            // 
            // lblNumberOfUsersFound
            // 
            this.lblNumberOfUsersFound.AutoSize = true;
            this.lblNumberOfUsersFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfUsersFound.Location = new System.Drawing.Point(193, 518);
            this.lblNumberOfUsersFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfUsersFound.Name = "lblNumberOfUsersFound";
            this.lblNumberOfUsersFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfUsersFound.TabIndex = 15;
            this.lblNumberOfUsersFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(5, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number Of Users Found :";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.BackgroundImage")));
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.Location = new System.Drawing.Point(742, 192);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(53, 55);
            this.btnAddNewUser.TabIndex = 13;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.Controls.Add(this.dtUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterByUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfUsersFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).EndInit();
            this.cmsManageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtUsers;
        private System.Windows.Forms.ContextMenuStrip cmsManageUser;
        private System.Windows.Forms.ToolStripMenuItem editeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callUserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterByUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfUsersFound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}