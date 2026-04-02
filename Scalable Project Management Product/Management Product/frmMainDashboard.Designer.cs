namespace Management_Product
{
    partial class frmMainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainDashboard));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDeliveryPersonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.manageCommandsToolStripMenuItem,
            this.managePaymentsToolStripMenuItem,
            this.manageDeliveryPersonsToolStripMenuItem,
            this.commandDetailsToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1208, 58);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "MainMenu";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageUsersToolStripMenuItem.Image")));
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(143, 54);
            this.manageUsersToolStripMenuItem.Text = "Manage &Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageProductsToolStripMenuItem.Image")));
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(162, 54);
            this.manageProductsToolStripMenuItem.Text = "Manage &Products";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // manageCommandsToolStripMenuItem
            // 
            this.manageCommandsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageCommandsToolStripMenuItem.Image")));
            this.manageCommandsToolStripMenuItem.Name = "manageCommandsToolStripMenuItem";
            this.manageCommandsToolStripMenuItem.Size = new System.Drawing.Size(177, 54);
            this.manageCommandsToolStripMenuItem.Text = "Manage &Commands";
            this.manageCommandsToolStripMenuItem.Click += new System.EventHandler(this.manageCommandsToolStripMenuItem_Click);
            // 
            // managePaymentsToolStripMenuItem
            // 
            this.managePaymentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("managePaymentsToolStripMenuItem.Image")));
            this.managePaymentsToolStripMenuItem.Name = "managePaymentsToolStripMenuItem";
            this.managePaymentsToolStripMenuItem.Size = new System.Drawing.Size(167, 54);
            this.managePaymentsToolStripMenuItem.Text = "Manage &Payments";
            this.managePaymentsToolStripMenuItem.Click += new System.EventHandler(this.managePaymentsToolStripMenuItem_Click);
            // 
            // manageDeliveryPersonsToolStripMenuItem
            // 
            this.manageDeliveryPersonsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDeliveryPersonsToolStripMenuItem.Image")));
            this.manageDeliveryPersonsToolStripMenuItem.Name = "manageDeliveryPersonsToolStripMenuItem";
            this.manageDeliveryPersonsToolStripMenuItem.Size = new System.Drawing.Size(201, 54);
            this.manageDeliveryPersonsToolStripMenuItem.Text = "Manage Delivery &Persons";
            this.manageDeliveryPersonsToolStripMenuItem.Click += new System.EventHandler(this.manageDeliveryPersonsToolStripMenuItem_Click);
            // 
            // commandDetailsToolStripMenuItem
            // 
            this.commandDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commandDetailsToolStripMenuItem.Image")));
            this.commandDetailsToolStripMenuItem.Name = "commandDetailsToolStripMenuItem";
            this.commandDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 54);
            this.commandDetailsToolStripMenuItem.Text = "Command &Details";
            this.commandDetailsToolStripMenuItem.Click += new System.EventHandler(this.commandDetailsToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageEmployeeToolStripMenuItem.Image")));
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(167, 54);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // frmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 560);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainDashboard";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDeliveryPersonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
    }
}

