namespace Management_Product.Forms_Command
{
    partial class frmManageCommands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCommands));
            this.dtCommands = new System.Windows.Forms.DataGridView();
            this.cmsManageCommand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowInformationsOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowInformationsOfDelevryPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowInformationsOfProductUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfCommandsFound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommands)).BeginInit();
            this.cmsManageCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCommands
            // 
            this.dtCommands.BackgroundColor = System.Drawing.Color.White;
            this.dtCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCommands.ContextMenuStrip = this.cmsManageCommand;
            this.dtCommands.Location = new System.Drawing.Point(4, 251);
            this.dtCommands.Margin = new System.Windows.Forms.Padding(2);
            this.dtCommands.Name = "dtCommands";
            this.dtCommands.ReadOnly = true;
            this.dtCommands.RowHeadersWidth = 51;
            this.dtCommands.RowTemplate.Height = 24;
            this.dtCommands.Size = new System.Drawing.Size(792, 261);
            this.dtCommands.TabIndex = 28;
            this.dtCommands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCommands_CellClick);
            // 
            // cmsManageCommand
            // 
            this.cmsManageCommand.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsManageCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInformationsOfUserToolStripMenuItem,
            this.ShowInformationsOfDelevryPersonToolStripMenuItem,
            this.ShowInformationsOfProductUserToolStripMenuItem});
            this.cmsManageCommand.Name = "cmsManageUser";
            this.cmsManageCommand.Size = new System.Drawing.Size(296, 142);
            // 
            // ShowInformationsOfUserToolStripMenuItem
            // 
            this.ShowInformationsOfUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowInformationsOfUserToolStripMenuItem.Image")));
            this.ShowInformationsOfUserToolStripMenuItem.Name = "ShowInformationsOfUserToolStripMenuItem";
            this.ShowInformationsOfUserToolStripMenuItem.Size = new System.Drawing.Size(295, 46);
            this.ShowInformationsOfUserToolStripMenuItem.Text = "Show Informations Of User";
            this.ShowInformationsOfUserToolStripMenuItem.Click += new System.EventHandler(this.ShowInformationsOfUserToolStripMenuItem_Click);
            // 
            // ShowInformationsOfDelevryPersonToolStripMenuItem
            // 
            this.ShowInformationsOfDelevryPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowInformationsOfDelevryPersonToolStripMenuItem.Image")));
            this.ShowInformationsOfDelevryPersonToolStripMenuItem.Name = "ShowInformationsOfDelevryPersonToolStripMenuItem";
            this.ShowInformationsOfDelevryPersonToolStripMenuItem.Size = new System.Drawing.Size(295, 46);
            this.ShowInformationsOfDelevryPersonToolStripMenuItem.Text = "Show Informations Of Delevry Person";
            this.ShowInformationsOfDelevryPersonToolStripMenuItem.Click += new System.EventHandler(this.ShowInformationsOfDelevryPersonToolStripMenuItem_Click);
            // 
            // ShowInformationsOfProductUserToolStripMenuItem
            // 
            this.ShowInformationsOfProductUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowInformationsOfProductUserToolStripMenuItem.Image")));
            this.ShowInformationsOfProductUserToolStripMenuItem.Name = "ShowInformationsOfProductUserToolStripMenuItem";
            this.ShowInformationsOfProductUserToolStripMenuItem.Size = new System.Drawing.Size(295, 46);
            this.ShowInformationsOfProductUserToolStripMenuItem.Text = "Show Informations Of Products User";
            this.ShowInformationsOfProductUserToolStripMenuItem.Click += new System.EventHandler(this.ShowInformationsOfProductUserToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manage Commands";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilterByName.Location = new System.Drawing.Point(178, 205);
            this.txtFilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(148, 23);
            this.txtFilterByName.TabIndex = 32;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Filter By Username :";
            // 
            // lblNumberOfCommandsFound
            // 
            this.lblNumberOfCommandsFound.AutoSize = true;
            this.lblNumberOfCommandsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberOfCommandsFound.Location = new System.Drawing.Point(246, 518);
            this.lblNumberOfCommandsFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfCommandsFound.Name = "lblNumberOfCommandsFound";
            this.lblNumberOfCommandsFound.Size = new System.Drawing.Size(35, 20);
            this.lblNumberOfCommandsFound.TabIndex = 30;
            this.lblNumberOfCommandsFound.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(4, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Number Of Commands Found :";
            // 
            // frmManageCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.dtCommands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfCommandsFound);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageCommands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageCommands";
            this.Load += new System.EventHandler(this.frmManageCommands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCommands)).EndInit();
            this.cmsManageCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCommands;
        private System.Windows.Forms.ContextMenuStrip cmsManageCommand;
        private System.Windows.Forms.ToolStripMenuItem ShowInformationsOfUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowInformationsOfDelevryPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowInformationsOfProductUserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfCommandsFound;
        private System.Windows.Forms.Label label5;
    }
}