using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Product_Management
{
    public class clsDataPayment
    {
        static SqlConnection connection = new SqlConnection(clsconnectionToDB.ConnectionToDB);

        public static DataTable GetAllPaymentData()
        {
            DataTable dtPaymentData = new DataTable();

            string query = @"Select Payment.Payment_ID, Count(Payment.Command_ID) as NumberOfCommand,
                Users.Username, Payment.Payment_Method,
                Payment.Payment_Status, Command.Status, Payment.Amount, 
                Payment.Payment_Date
                From Payment
                inner join Command on Command.Command_ID = Payment.Command_ID
                inner join Users on Users.User_ID = Command.User_ID
                inner join Command_Product on Command_Product.Command_ID = Command.Command_ID
                Group By
                	Payment.Payment_ID,
                	Users.Username, 
                	Payment.Payment_Method,
                	Payment.Payment_Status, 
                	Command.Status, Payment.Amount, 
                	Payment.Payment_Date;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtPaymentData.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtPaymentData;
        }

        public static int GetDeliveryPersonIDByPaymentID(int PaymentID)
        {
            int DeliveryPersonID = -1;

            string query = @"Select Command.Delivery_Person_ID From Payment
                inner join Command on Command.Command_ID = Payment.Command_ID
                where Payment.Payment_ID = @Payment_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Payment_ID", PaymentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int DeliveryPersonIDReturned))
                {
                    DeliveryPersonID = DeliveryPersonIDReturned;

                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return DeliveryPersonID;
        }

        public static int GetCommandIDByPaymentID(int PaymentID)
        {
            int CommandID = -1;

            string query = @"Select Payment.Command_ID From Payment
                where Payment.Payment_ID = @Payment_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Payment_ID", PaymentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int CommandIDReturned))
                {
                    CommandID = CommandIDReturned;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return CommandID;
        }
    }
}
