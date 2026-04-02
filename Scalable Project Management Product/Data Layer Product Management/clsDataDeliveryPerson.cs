using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Product_Management
{
    public class clsDataDeliveryPerson
    {
        static SqlConnection connection = new SqlConnection(clsconnectionToDB.ConnectionToDB);

        public static bool FindDeliveryPersonByID(int DeliveryPersonID, 
            ref string Name, ref string PhoneNumber, ref string Email,
            ref string Status)
        {
            bool isFound = false;

            string query = "Select * From Delivery_Person Where Delivery_Person_ID = @Delivery_Person_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Delivery_Person_ID", DeliveryPersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["Name"];
                    PhoneNumber = (string)reader["Phone_Number"];
                    Email = (string)reader["Email"];
                    Status = (string)reader["Status"];
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewDeliveryPerson(string Name, string PhoneNumber, string Email,
            string Status)
        {
            int DeliveryPerson = -1;

            string query = @"Insert Into Delivery_Person (
                    Name, Phone_Number, Email, Status)
                    Values(@Name, @Phone_Number, @Email, @Status);
                    SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone_Number", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Status", Status);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int DeliveryPersonReturned))
                {
                    DeliveryPerson = DeliveryPersonReturned;
                }
            }
            catch {}

            finally { connection.Close(); }

            return DeliveryPerson;
        }

        public static bool UpdateDeliveryPerson(int DeliveryPersonID, string Name, 
            string PhoneNumber, string Email, string Status)
        {
            bool isUpdated = false;

            string query = @"Update Delivery_Person Set
                        Name = @Name, 
                        Phone_Number = @Phone_Number, 
                        Email = @Email, 
                        Status = @Status
                        Where Delivery_Person_ID = @Delivery_Person_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone_Number", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@Delivery_Person_ID", DeliveryPersonID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch{}
            finally { connection.Close(); }
            return isUpdated;
        }

        public static bool DeleteDeliveryPerson(int DeliveryPersonID)
        {
            bool isDeleted = false;

            string query = "Delete From Delivery_Person Where Delivery_Person_ID = @Delivery_Person_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Delivery_Person_ID", DeliveryPersonID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery(); 
                if(rowAffected > 0)
                {
                    isDeleted = true;
                }

            }
            catch{}
            finally { connection.Close(); }
            return isDeleted;
        }

        public static DataTable GetAllDeliveryPersons()
        {
            DataTable dtDeliveryPersons = new DataTable();
            string query = @"select Delivery_Person.Delivery_Person_ID, 
                Delivery_Person.Name, Delivery_Person.Phone_Number,
                Delivery_Person.Email, Delivery_Person.Status, 
                Count(Command.Delivery_Person_ID) as NumberOfCommand 
                from Delivery_Person
                left join Command on Command.Delivery_Person_ID = Delivery_Person.Delivery_Person_ID
                group by 
                	Delivery_Person.Delivery_Person_ID,
                	Delivery_Person.Name,
                	Delivery_Person.Phone_Number,
                	Delivery_Person.Email,
                	Delivery_Person.Status;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtDeliveryPersons.Load(reader);
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
            return dtDeliveryPersons;
        }

        public static DataTable GetInformationOfCommand(int DeliveryPersonID)
        {
            DataTable dtInformationOfCommand = new DataTable();

            string query = @"Select Command.Command_ID, Users.Username, Users.Phone_Number,
                Users.Address, COUNT(Products.Product_ID) as NumberOfProduct, Command.Command_Date
                From Command_Product
                inner join Command on Command.Command_ID = Command_Product.Command_ID
                inner join Users on Users.User_ID = Command.User_ID
                inner join Products on Products.Product_ID = Command_Product.Product_ID
                
                Group By 
                	Command.Command_ID, 
                	Command.Delivery_Person_ID,
                	Users.Username, 
                	Users.Phone_Number,
                	Users.Address,
					Command.Command_Date
                Having Command.Delivery_Person_ID = @Delivery_Person_ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Delivery_Person_ID", DeliveryPersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dtInformationOfCommand.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dtInformationOfCommand;
        }
    }
}
