using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsLoginEmployees
    {
        public static bool CorrectEmailAndPassword(string email, string password)
        {
            return (clsDataEmployees.CorrectEmailAndPassword(email, password));
        }

        public static int GetPermissionOfEmployeeByEmailAndPassword(string email, string password)
        {
            return (clsDataEmployees.GetPermissionOfEmployeeByEmailAndPassword(email, password));
        }
    }
}
