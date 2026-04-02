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

namespace Management_Product.Forms_Delivery_Person
{
    public partial class frmManageDeliveryPerson : Form
    {
        DataTable dataDeliveryPersons;
        DataView dvDeliveryPerson;

        static int DeliveryPerosnIDSelected = -1;

        public frmManageDeliveryPerson()
        {
            InitializeComponent();
        }
        void _LoadData()
        {
            dataDeliveryPersons = clsDeliveryPerson.GetAllDeliveryPersons();
            dvDeliveryPerson = dataDeliveryPersons.DefaultView;
            dtDeliveryPerson.DataSource = dvDeliveryPerson;
            lblNumberOfDeliveryPersonsFound.Text = dvDeliveryPerson.Count.ToString();
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            string valueOfFilter = txtFilterByName.Text.ToString();

            if (string.IsNullOrEmpty(valueOfFilter))
            {
                dvDeliveryPerson.RowFilter = string.Empty;
                dtDeliveryPerson.DataSource = dvDeliveryPerson;
                lblNumberOfDeliveryPersonsFound.Text = dvDeliveryPerson.Count.ToString();
                return;
            }
            string query = $"Name like '%{valueOfFilter}%'";
            try
            {
                dvDeliveryPerson.RowFilter = query;
                dtDeliveryPerson.DataSource = dvDeliveryPerson;
                lblNumberOfDeliveryPersonsFound.Text = dvDeliveryPerson.Count.ToString();
            }
            catch { }
        }

        private void dtDeliveryPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtDeliveryPerson.Rows[e.RowIndex];
            DeliveryPerosnIDSelected = int.Parse(row.Cells["Delivery_Person_ID"].Value.ToString());
        }

        private void ShowInformationsDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInformationDeliveryPerson showInformationDeliveryPerson = new frmShowInformationDeliveryPerson(DeliveryPerosnIDSelected);
            showInformationDeliveryPerson.ShowDialog();
            _LoadData();
        }

        private void EditDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditDeliveryPerson addOrEditDeliveryPerson = new frmAddOrEditDeliveryPerson(DeliveryPerosnIDSelected);
            addOrEditDeliveryPerson.ShowDialog();
            _LoadData();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddOrEditDeliveryPerson addOrEditDeliveryPerson = new frmAddOrEditDeliveryPerson();
            addOrEditDeliveryPerson.ShowDialog();
            _LoadData();
        }

        private void DeleteDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Delete This Delivery Person Have ID {DeliveryPerosnIDSelected}",
                "Conferm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsDeliveryPerson.DeleteDeliveryPerson(DeliveryPerosnIDSelected))
                {
                    MessageBox.Show("Delivery Person Is Deleted Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("Delivery Person Is Not Deleted Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendMessageToDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplemented Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void callDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplemented Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showInformationOfCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInformationsOfCommand showInformationsOfCommand = new frmShowInformationsOfCommand(DeliveryPersonID: DeliveryPerosnIDSelected);
            showInformationsOfCommand.ShowDialog();
            _LoadData();
        }

        private void frmManageDeliveryPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
