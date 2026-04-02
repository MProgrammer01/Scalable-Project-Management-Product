using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Product_Management
{
    public class clsDataCommand
    {
        static SqlConnection connection = new SqlConnection(clsconnectionToDB.ConnectionToDB);

        public static DataTable GetAllCommands()
        {
            DataTable dtCommands = new DataTable();

            string query = @"SELECT 
                    Command.Command_ID, 
                    Users.Username, 
                    Delivery_Person.Name AS Delivery_Person_Name,
                    COUNT(Command_Product.Product_ID) AS NumberOfProducts,
                    Command.Command_Date, 
                    Command.Status, 
                    Command.Total_Amount
                FROM 
                    Command
                INNER JOIN 
                    Users ON Users.User_ID = Command.User_ID
                INNER JOIN 
                    Delivery_Person ON Delivery_Person.Delivery_Person_ID = Command.Delivery_Person_ID
                INNER JOIN 
                    Command_Product ON Command.Command_ID = Command_Product.Command_ID
                GROUP BY 
                    Command.Command_ID, 
                    Users.Username, 
                    Delivery_Person.Name, 
                    Command.Command_Date, 
                    Command.Status, 
                    Command.Total_Amount;";

            SqlCommand command = new SqlCommand(query, connection);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtCommands.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCommands;
        }

        public static int GetIDOfUser(int Command_ID)
        {
            int User_ID = -1;

            string query = @"Select Command.User_ID
                    From Command 
                    Where Command.Command_ID = @Command_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Command_ID", Command_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int SelectedUserID))
                {
                    User_ID = SelectedUserID;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return User_ID;
        }

        public static DataTable ShowProductsOfUser(int Command_ID)
        {
            DataTable dtProductsOfUser = new DataTable();

            string query = @"Select Users.Username, Products.Product_Name, Command_Product.Quantity, Products.Price
                From Command 
                inner join Command_Product on Command_Product.Command_ID = Command.Command_ID
                inner join Users on Users.User_ID = Command.User_ID
                inner join Products on Products.Product_ID = Command_Product.Product_ID
                Where Command.Command_ID = @Command_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Command_ID", Command_ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtProductsOfUser.Load(reader);
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dtProductsOfUser;
        }

        public static DataTable ShowProductsOfUserByCommandProductID(int Command_Product_ID)
        {
            DataTable dtProductsOfUser = new DataTable();

            string query = @"Select Users.Username, Products.Product_Name, Command_Product.Quantity, Products.Price
                From Command 
                inner join Command_Product on Command_Product.Command_ID = Command.Command_ID
                inner join Users on Users.User_ID = Command.User_ID
                inner join Products on Products.Product_ID = Command_Product.Product_ID
                Where Command_Product.Command_Product_ID = @Command_Product_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Command_Product_ID", Command_Product_ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtProductsOfUser.Load(reader);
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dtProductsOfUser;
        }

        public static int GetIDOfDelevryPerson(int Command_ID)
        {
            int Delevry_Person_ID = -1;

            string query = @"Select Command.Delivery_Person_ID
                From Command 
                Where Command.Command_ID = @Command_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Command_ID", Command_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int SelectedDelevryPersonID))
                {
                    Delevry_Person_ID = SelectedDelevryPersonID;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return Delevry_Person_ID;
        }

        public static DataTable GetNumberOfCommands(int Command_ID)
        {
            DataTable dtCommands = new DataTable();

            string query = @"Select Command_Product.Command_Product_ID, Users.Username, Users.Phone_Number,
                Users.Address, Products.Product_Name, Command.Command_Date,
				Delivery_Person.Delivery_Person_ID
                From Command
                inner join Command_Product on Command.Command_ID = Command_Product.Command_ID
                inner join Users on Users.User_ID = Command.User_ID
                inner join Products on Products.Product_ID = Command_Product.Product_ID
				inner join Delivery_Person on Delivery_Person.Delivery_Person_ID = Command.Delivery_Person_ID
                Where Command.Command_ID = @Command_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Command_ID", Command_ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtCommands.Load(reader);
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dtCommands;
        }
    }
}
