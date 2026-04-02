using Business_Layer_Management_Product;
using Management_Product.CTRL_Delevry_Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.Forms_Delivery_Person
{
    public partial class frmAddOrEditDeliveryPerson : Form
    {
        static int deliveryPersonID = -1;

        clsDeliveryPerson deliveryPerson;

        public frmAddOrEditDeliveryPerson(int DeliveryPersonID = -1)
        {
            InitializeComponent();

            deliveryPersonID = DeliveryPersonID;
        }

        void _LoadData()
        {
            if (deliveryPersonID == -1)
            {
                deliveryPerson = new clsDeliveryPerson();
                lblAddOrEditDeliveryPerson.Text = "Add Delivery Person";
                return;
            }
            deliveryPerson = clsDeliveryPerson.FindDeliveryPersonByID(deliveryPersonID);
            if (deliveryPerson == null)
            {
                MessageBox.Show($"The Form Will Be Closed Because No Delivery Person With This ID {deliveryPersonID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();

                return;
            }
            lblAddOrEditDeliveryPerson.Text = "Update Delivery Person";
            lblDeliveryPersonID.Text = deliveryPersonID.ToString();
            txtName.Text = deliveryPerson.Name.ToString();
            txtPhoneNumber.Text = deliveryPerson.PhoneNumber.ToString();
            txtEmail.Text = deliveryPerson.Email.ToString();
            txtStatus.Text = deliveryPerson.Status.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            deliveryPerson.Name = txtName.Text.ToString();
            deliveryPerson.PhoneNumber = txtPhoneNumber.Text.ToString();
            deliveryPerson.Email = txtEmail.Text.ToString();
            deliveryPerson.Status = txtStatus.Text.ToString();

            if (deliveryPerson.Save())
            {
                MessageBox.Show("Data Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAddOrEditDeliveryPerson.Text = "Update Delivery Person";
                lblDeliveryPersonID.Text = deliveryPerson.DeliveryPersonID.ToString();
            }
            else
            {
                MessageBox.Show("Data Not Saved Successfuly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddOrEditDeliveryPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
