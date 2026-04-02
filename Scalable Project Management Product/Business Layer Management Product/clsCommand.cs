using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsCommand
    {
        public static DataTable GetAllDataOfCommands()
        {
            return (clsDataCommand.GetAllCommands());
        }

        public static DataTable ShowProductsOfUser(int Command_ID)
        {
            return (clsDataCommand.ShowProductsOfUser(Command_ID));
        }

        public static DataTable ShowProductsOfUserByCommandProductID(int Command_Product_ID)
        {
            return (clsDataCommand.ShowProductsOfUserByCommandProductID(Command_Product_ID));
        }

        public static int GetIDOfUser(int Command_ID)
        {
            return (clsDataCommand.GetIDOfUser(Command_ID));
        }

        public static int GetDeliveryPersonID(int Command_ID)
        {
            return (clsDataCommand.GetIDOfDelevryPerson(Command_ID));
        }

        public static DataTable GetNumberOfCommands(int Command_ID)
        {
            return (clsDataCommand.GetNumberOfCommands(Command_ID));
        }
    }
}
