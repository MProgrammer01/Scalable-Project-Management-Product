using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Product_Management
{
    public class clsDataEmployees
    {
        static SqlConnection connection = new SqlConnection(clsconnectionToDB.ConnectionToDB);

        public static bool FindEmployeeByID(int employeeID, ref string name,
            ref string phone_number, ref string email, ref string password, ref string status)
        {
            bool isFound = false;

            string query = @"Select Employees.Name, Employees.Phone_Number,
                 Employees.Email, Employees.Password, Employees.Status
				From Employees Where Employee_ID = @Employee_ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Employee_ID", employeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    name = (string)reader["Name"];
                    phone_number = (string)reader["Phone_Number"];
                    email = (string)reader["Email"];
                    password = (string)reader["Password"];
                    status = (string)reader["Status"];
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

        public static int AddNewEmployee(string name,
            string phone_number, string email, string password, 
            string status)
        {
            int EmployeeID = -1;

            string query = @"INSERT INTO Employees
                    (Name,
                    Email,
                    Phone_Number,
                    Password,
                    Status,
                    Created_At)
                VALUES
                    (@Name,
                    @Email,
                    @Phone_Number,
                    @Password,
                    @Status,
                    @Created_At);
	            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone_Number", phone_number);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Created_At", DateTime.Now);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int EmployeeIDAdded))
                {
                    EmployeeID = EmployeeIDAdded;
                }
            }
            catch { }
            finally { connection.Close(); }
            return EmployeeID;
        }

        public static bool UpdateEmployee(int EmployeeID, string name,
            string phone_number, string email, string password,
            string status)
        {
            bool isUpdated = false;

            string query = @"UPDATE Employees
                SET Name = @Name,
                   Email = @Email,
                   Password = @Password,
                   Phone_Number = @Phone_Number,
                   Status = @Status,
                   Updated_At = @Updated_At
                WHERE Employee_ID = @Employee_ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Phone_Number", phone_number);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Updated_At", DateTime.Now);
            command.Parameters.AddWithValue("@Employee_ID", EmployeeID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch { }
            finally { connection.Close(); }
            return isUpdated;
        }

        public static bool CorrectEmailAndPassword(string email, string password)
        {
            bool isCorrect = false;

            string query = @"Select Found = 1 From Employees
                Where Email = @Email and Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isCorrect = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isCorrect;
        }

        public static int GetPermissionOfEmployeeByEmailAndPassword(string email, string password)
        {
            int permission = -1;

            string query = @"Select Employees.Permession From
                Employees Where Email = @Email and Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int PermissionReturned))
                {
                    permission = PermissionReturned;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return permission;
        }

        public static DataTable GetAllEmployees()
        {
            DataTable dtEmployees = new DataTable();

            string query = @"Select Employees.Employee_ID, Employees.Name, Employees.Email, Employees.Phone_Number,
                Employees.Status, Employees.Created_At, Employees.Updated_At
                From Employees;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtEmployees.Load(reader);
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
            return dtEmployees;
        }

        public static bool DeleteEmployee(int EmployeeID)
        {
            bool isDeleted = false;

            string query = @"DELETE FROM Employees WHERE Employee_ID = @Employee_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Employee_ID", EmployeeID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    isDeleted = true;
                }
            }
            catch(Exception ex) { }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

        public static DataTable GetAccountsOfEmployees()
        {
            DataTable dtAccounts = new DataTable();

            string query = @"Select Employees.Employee_ID, Employees.Name, Employees.Email,
                Employees.Password, Employees.Status
                From Employees;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtAccounts.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }
            return dtAccounts;
        }
    }
}
