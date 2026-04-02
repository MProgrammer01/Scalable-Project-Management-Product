namespace Management_Product.Forms_Employee
{
    partial class frmManageEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageEmployees));
            this.dtEmployees = new System.Windows.Forms.DataGridView();
            this.cmsManageEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowInformationsEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callDeliveryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfEmployeesFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployees)).BeginInit();
            this.cmsManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEmployees
            // 
            this.dtEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dtEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmployees.ContextMenuStrip = this.cmsManageEmployees;
            this.dtEmployees.Location = new System.Drawing.Point(4, 250);
            this.dtEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.dtEmployees.Name = "dtEmployees";
            this.dtEmployees.ReadOnly = true;
            this.dtEmployees.RowHeadersWidth = 51;
            this.dtEmployees.RowTemplate.Height = 24;
            this.dtEmployees.Size = new System.Drawing.Size(792, 261);
            this.dtEmployees.TabIndex = 45;
            this.dtEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmployees_CellClick);
            // 
            // cmsManageEmployees
            // 
            this.cmsManageEmployees.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInformationsEmployeeToolStripMenuItem,
            this.EditEmployeesToolStripMenuItem,
            this.DeleteEmployeesToolStripMenuItem,
            this.sendMessageToDeliveryPersonToolStripMenuItem,
            this.callDeliveryPersonToolStripMenuItem});
            this.cmsManageEmployees.Name = "cmsManageUser";
            this.cmsManageEmployees.Size = new System.Drawing.Size(254, 234);
            // 
            // ShowInformationsEmployeeToolStripMenuItem
            // 
            this.ShowInformationsEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowInformationsEmployeeToolStripMenuItem.Image")));
            this.ShowInformationsEmployeeToolStripMenuItem.Name = "ShowInformationsEmployeeToolStripMenuItem";
            this.ShowInformationsEmployeeToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.ShowInformationsEmployeeToolStripMenuItem.Text = "Show Informations Employee";
            this.ShowInformationsEmployeeToolStripMenuItem.Click += new System.EventHandler(this.ShowInformationsEmployeeToolStripMenuItem_Click);
            // 
            // EditEmployeesToolStripMenuItem
            // 
            this.EditEmployeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditEmployeesToolStripMenuItem.Image")));
            this.EditEmployeesToolStripMenuItem.Name = "EditEmployeesToolStripMenuItem";
            this.EditEmployeesToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.EditEmployeesToolStripMenuItem.Text = "Edit Employee";
            this.EditEmployeesToolStripMenuItem.Click += new System.EventHandler(this.EditEmployeesToolStripMenuItem_Click);
            // 
            // DeleteEmployeesToolStripMenuItem
            // 
            this.DeleteEmployeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteEmployeesToolStripMenuItem.Image")));
            this.DeleteEmployeesToolStripMenuItem.Name = "DeleteEmployeesToolStripMenuItem";
            this.DeleteEmployeesToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.DeleteEmployeesToolStripMenuItem.Text = "Delete Employee";
            this.DeleteEmployeesToolStripMenuItem.Click += new System.EventHandler(this.DeleteEmployeesToolStripMenuItem_Click);
            // 
            // sendMessageToDeliveryPersonToolStripMenuItem
            // 
            this.sendMessageToDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendMessageToDeliveryPersonToolStripMenuItem.Image")));
            this.sendMessageToDeliveryPersonToolStripMenuItem.Name = "sendMessageToDeliveryPersonToolStripMenuItem";
            this.sendMessageToDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.sendMessageToDeliveryPersonToolStripMenuItem.Text = "Send Message To Employee";
            this.sendMessageToDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToDeliveryPersonToolStripMenuItem_Click);
            // 
            // callDeliveryPersonToolStripMenuItem
            // 
            this.callDeliveryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callDeliveryPersonToolStripMenuItem.Image")));
            this.callDeliveryPersonToolStripMenuItem.Name = "callDeliveryPersonToolStripMenuItem";
            this.callDeliveryPersonToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.callDeliveryPersonToolStripMenuItem.Text = "Call Employee";
            this.callDeliveryPersonToolStripMenuItem.Click += new System.EventHandler(this.callDeliveryPersonToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(682, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowAccountsOfEmployees_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewEmployee.BackgroundImage")));
            this.btnAddNewEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(748, 196);
            this.btnAddNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(48, 48);
            this.btnAddNewEmployee.TabIndex = 50;
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(2, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Manage Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByName.Location = new System.Drawing.Point(152, 204);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByName.TabIndex = 49;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Filter By Name :";
            // 
            // lblNumberOfEmployeesFound
            // 
            this.lblNumberOfEmployeesFound.AutoSize = true;
            this.lblNumberOfEmployeesFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfEmployeesFound.Location = new System.Drawing.Point(237, 513);
            this.lblNumberOfEmployeesFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfEmployeesFound.Name = "lblNumberOfEmployeesFound";
            this.lblNumberOfEmployeesFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfEmployeesFound.TabIndex = 47;
            this.lblNumberOfEmployeesFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(4, 513);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Number Of Employees Found :";
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 545);
            this.Controls.Add(this.dtEmployees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfEmployeesFound);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployees)).EndInit();
            this.cmsManageEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtEmployees;
        private System.Windows.Forms.ContextMenuStrip cmsManageEmployees;
        private System.Windows.Forms.ToolStripMenuItem ShowInformationsEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callDeliveryPersonToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfEmployeesFound;
        private System.Windows.Forms.Label label5;
    }
}