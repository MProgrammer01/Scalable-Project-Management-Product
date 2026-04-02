using Business_Layer_Management_Product;
using Management_Product.Forms_Delivery_Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.CTRL_Delevry_Person
{
    public partial class ctrlShowInformationDeliveryPerson : UserControl
    {
        static int deliveryPersonID = -1;

        clsDeliveryPerson deliveryPerson;
        public ctrlShowInformationDeliveryPerson()
        {
            InitializeComponent();
        }
        public ctrlShowInformationDeliveryPerson(int DeliveryPersonID)
        {
            deliveryPersonID = DeliveryPersonID;
        }
        void _LoadData()
        {
            if(deliveryPersonID == -1)
            {
                return;
            }
            deliveryPerson = clsDeliveryPerson.FindDeliveryPersonByID(deliveryPersonID);

            if(deliveryPerson == null )
            {
                MessageBox.Show($"The Window Will Be Close Because No Delevry Person Have ID {deliveryPersonID}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FindForm().Close();
                return;
            }

            lblDeliveryPersonID.Text = deliveryPersonID.ToString();
            txtName.Text = deliveryPerson.Name.ToString();
            txtPhoneNumber.Text = deliveryPerson.PhoneNumber.ToString();
            txtEmail.Text = deliveryPerson.Email.ToString();
            txtStatus.Text = deliveryPerson.Status.ToString();
        }

        private void ctrlShowInformationDeliveryPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrEditDeliveryPerson addOrEditDeliveryPerson = new frmAddOrEditDeliveryPerson(deliveryPersonID);
            addOrEditDeliveryPerson.ShowDialog();
            _LoadData();
        }
    }
}
