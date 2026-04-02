namespace Management_Product.Forms_Employee
{
    partial class frmShowAccountsOfEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowAccountsOfEmployees));
            this.dtAccountsOfEmployees = new System.Windows.Forms.DataGridView();
            this.cmsManageAccountEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowInformationsEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfAccountsEmployeesFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccountsOfEmployees)).BeginInit();
            this.cmsManageAccountEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAccountsOfEmployees
            // 
            this.dtAccountsOfEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dtAccountsOfEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAccountsOfEmployees.ContextMenuStrip = this.cmsManageAccountEmployees;
            this.dtAccountsOfEmployees.Location = new System.Drawing.Point(4, 248);
            this.dtAccountsOfEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.dtAccountsOfEmployees.Name = "dtAccountsOfEmployees";
            this.dtAccountsOfEmployees.ReadOnly = true;
            this.dtAccountsOfEmployees.RowHeadersWidth = 51;
            this.dtAccountsOfEmployees.RowTemplate.Height = 24;
            this.dtAccountsOfEmployees.Size = new System.Drawing.Size(792, 261);
            this.dtAccountsOfEmployees.TabIndex = 50;
            // 
            // cmsManageAccountEmployees
            // 
            this.cmsManageAccountEmployees.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageAccountEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInformationsEmployeeToolStripMenuItem,
            this.editPasswordToolStripMenuItem});
            this.cmsManageAccountEmployees.Name = "cmsManageUser";
            this.cmsManageAccountEmployees.Size = new System.Drawing.Size(254, 96);
            // 
            // ShowInformationsEmployeeToolStripMenuItem
            // 
            this.ShowInformationsEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowInformationsEmployeeToolStripMenuItem.Image")));
            this.ShowInformationsEmployeeToolStripMenuItem.Name = "ShowInformationsEmployeeToolStripMenuItem";
            this.ShowInformationsEmployeeToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.ShowInformationsEmployeeToolStripMenuItem.Text = "Show Informations Employee";
            this.ShowInformationsEmployeeToolStripMenuItem.Click += new System.EventHandler(this.ShowInformationsEmployeeToolStripMenuItem_Click);
            // 
            // editPasswordToolStripMenuItem
            // 
            this.editPasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPasswordToolStripMenuItem.Image")));
            this.editPasswordToolStripMenuItem.Name = "editPasswordToolStripMenuItem";
            this.editPasswordToolStripMenuItem.Size = new System.Drawing.Size(253, 46);
            this.editPasswordToolStripMenuItem.Text = "Edit Password";
            this.editPasswordToolStripMenuItem.Click += new System.EventHandler(this.editPasswordToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(2, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Accounts Login Of Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByName.Location = new System.Drawing.Point(152, 202);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByName.TabIndex = 54;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Filter By Name :";
            // 
            // lblNumberOfAccountsEmployeesFound
            // 
            this.lblNumberOfAccountsEmployeesFound.AutoSize = true;
            this.lblNumberOfAccountsEmployeesFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfAccountsEmployeesFound.Location = new System.Drawing.Point(310, 511);
            this.lblNumberOfAccountsEmployeesFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfAccountsEmployeesFound.Name = "lblNumberOfAccountsEmployeesFound";
            this.lblNumberOfAccountsEmployeesFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfAccountsEmployeesFound.TabIndex = 52;
            this.lblNumberOfAccountsEmployeesFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(4, 511);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Number Of Accounts Employees Found :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmShowAccountsOfEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.dtAccountsOfEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfAccountsEmployeesFound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowAccountsOfEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowAccountsOfEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAccountsOfEmployees)).EndInit();
            this.cmsManageAccountEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtAccountsOfEmployees;
        private System.Windows.Forms.ContextMenuStrip cmsManageAccountEmployees;
        private System.Windows.Forms.ToolStripMenuItem ShowInformationsEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPasswordToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfAccountsEmployeesFound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}