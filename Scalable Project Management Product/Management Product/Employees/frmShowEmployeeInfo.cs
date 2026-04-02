using Management_Product.CTRL_Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Product.Forms_Employee
{
    public partial class frmShowEmployeeInfo : Form
    {
        public frmShowEmployeeInfo(int employeeID = -1)
        {
            InitializeComponent();

            ctrlShowEmployeeInfo showEmployeeInfo = new ctrlShowEmployeeInfo(employeeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
