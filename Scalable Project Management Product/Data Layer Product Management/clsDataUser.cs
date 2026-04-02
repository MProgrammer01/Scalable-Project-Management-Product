using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Product_Management
{
    public class clsDataUser
    {
        static SqlConnection connection = new SqlConnection(clsconnectionToDB.ConnectionToDB);

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            string query = "Select * From Users;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error : ", ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtUsers;
        }

        public static int AddNewUser(string Username, string Email, string Phone_Number, string Address, DateTime Created_At)
        {
            int UserId = -1;
            string query = @"Insert Into Users (Username, Email, Phone_Number, Address, Created_At)
                            Values (@Username, @Email, @Phone_Number, @Address, @Created_At);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone_Number", Phone_Number);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Created_At", Created_At);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if ((result != null && int.TryParse(result.ToString(), out int UserIdReturned)))
                {
                    UserId = UserIdReturned;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return UserId;
        }

        public static bool UpdateUser(int User_ID, string Username, string Email, string Phone_Number, string Address, DateTime Created_At)
        {
            bool isUpdated = false;
            string query = @"Update Users Set
                            Username = @Username, 
                            Email = @Email,
                            Phone_Number = @Phone_Number, 
                            Address = @Address, 
                            Created_At = @Created_At
                            Where User_ID = @User_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone_Number", Phone_Number);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Created_At", Created_At);
            command.Parameters.AddWithValue("@User_ID", User_ID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch {}
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }

        public static bool DeleteUser(int User_ID)
        {
            bool isDeleted = false;

            string query = "Delete From Users Where User_ID = @User_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_ID", User_ID);

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
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

        public static bool FindUserByID(int User_ID, ref string Username, ref string Email, ref string Phone_Number, ref string Address, ref DateTime Created_At)
        {
            bool isFound = false;

            string query = "Select * From Users Where User_ID = @User_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_ID", User_ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    Username = (string)reader["Username"];
                    Email = (string)reader["Email"];
                    Phone_Number = (string)reader["Phone_Number"];
                    Address = (string)reader["Address"];
                    Created_At = (DateTime)reader["Created_At"];
                }
                reader.Close();
            }
            catch{}
            finally
            {
                connection.Close();
            }
            return isFound;
        }
    }
}
