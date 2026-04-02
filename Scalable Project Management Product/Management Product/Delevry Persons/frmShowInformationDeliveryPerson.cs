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
    public partial class frmShowInformationDeliveryPerson : Form
    {
        public frmShowInformationDeliveryPerson(int DeliveryPersonID = -1)
        {
            InitializeComponent();

            ctrlShowInformationDeliveryPerson showInformationDeliveryPerson = new ctrlShowInformationDeliveryPerson(DeliveryPersonID);

        }
    }
}
