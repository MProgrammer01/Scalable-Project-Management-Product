using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsPayment
    {
        public static DataTable GetAllPaymentData()
        {
            return (clsDataPayment.GetAllPaymentData());
        }

        public static int GetDeliveryPersonIDByPaymentID(int PaymentID)
        {
            return (clsDataPayment.GetDeliveryPersonIDByPaymentID(PaymentID));
        }

        public static int GetCommandIDByPaymentID(int PaymentID)
        {
            return (clsDataPayment.GetCommandIDByPaymentID((int)PaymentID));
        }
    }
}
