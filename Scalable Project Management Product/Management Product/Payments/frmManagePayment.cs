using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer_Management_Product;
using Management_Product.Forms_Delivery_Person;

namespace Management_Product.Forms_Payment
{
    public partial class frmManagePayment : Form
    {
        DataTable dataPeyment;
        DataView dvPayment;

        static int PaymentIDSelected = -1;

        public frmManagePayment()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            dataPeyment = clsPayment.GetAllPaymentData();
            dvPayment = dataPeyment.DefaultView;
            dtPaymentData.DataSource = dvPayment;
            lblNumberOfPaymentFound.Text = dvPayment.Count.ToString();
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            string valueOfFilter = txtFilterByName.Text.ToString();

            if (string.IsNullOrEmpty(valueOfFilter))
            {
                dvPayment.RowFilter = string.Empty;
                dtPaymentData.DataSource = dvPayment;
                lblNumberOfPaymentFound.Text = dvPayment.Count.ToString();
                return;
            }
            string query = $"Username like '%{valueOfFilter}%'";
            try
            {
                dvPayment.RowFilter = query;
                dtPaymentData.DataSource = dvPayment;
                lblNumberOfPaymentFound.Text = dvPayment.Count.ToString();
            }
            catch { }
        }

        private void dtPaymentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtPaymentData.Rows[e.RowIndex];
            PaymentIDSelected = int.Parse(row.Cells["Payment_ID"].Value.ToString());
        }

        private void showInformationOfCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CommandID = clsPayment.GetCommandIDByPaymentID(PaymentIDSelected);

            if (CommandID == -1)
            {
                MessageBox.Show($"No Command Have {CommandID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowInformationsOfCommand showInformationsOfCommand = new frmShowInformationsOfCommand(CommandID: CommandID);
            showInformationsOfCommand.ShowDialog();
            _LoadData();
        }

        private void frmManagePayment_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
