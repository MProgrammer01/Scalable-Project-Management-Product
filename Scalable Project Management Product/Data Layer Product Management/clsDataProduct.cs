using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Product_Management
{
    public class clsDataProduct
    {
        static SqlConnection connection = new SqlConnection(clsconnectionToDB.ConnectionToDB);

        public static DataTable GetAllProducts()
        {
            DataTable dtProducts = new DataTable();

            string query = "Select * From Products;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtProducts.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dtProducts;
        }

        public static bool FindProductByID(int ProductID,
            ref string ProductName, ref string ProductDescription,
            ref decimal ProductPrice, ref int StockQuantity,
            ref DateTime CreateAt)
        {
            bool isFound = false;

            string query = "Select * From Products Where Product_ID = @Product_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Product_ID", ProductID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ProductName = (string)reader["Product_Name"];
                    ProductDescription = (string)reader["Description"];
                    ProductPrice = (decimal)reader["Price"];
                    StockQuantity = (int)reader["Stock_Quantity"];
                    CreateAt = (DateTime)reader["Created_At"];
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

        public static int AddNewProduct(string productName, string productDescription,
            decimal productPrice, int stockQuantity, DateTime create_At)
        {
            int ProductIDAdded = -1;

            string query = "Insert Into Products(Product_Name," +
                "Description, Price, Stock_Quantity, Created_At) " +
                "Values(@Product_Name, @Description, @Price, " +
                "@Stock_Quantity, @Created_At);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Product_Name", productName);
            command.Parameters.AddWithValue("@Description", productDescription);
            command.Parameters.AddWithValue("@Price", productPrice);
            command.Parameters.AddWithValue("@Stock_Quantity", stockQuantity);
            command.Parameters.AddWithValue("@Created_At", create_At);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int NewProductID))
                {
                    ProductIDAdded = NewProductID;
                }
            }
            catch { }
            finally { 
                connection.Close(); 
            }
            return ProductIDAdded;
        }

        public static bool UpdateProduct(int ProductID, string productName, string productDescription,
            decimal productPrice, int stockQuantity, DateTime create_At)
        {
            bool isUpdated = false;

            
            string query = "Update Products Set " +
                "Product_Name = @Product_Name, " +
                "Description = @Description, " +
                "Price = @Price, " +
                "Stock_Quantity = @Stock_Quantity, " +
                "Created_At = @Created_At " +
                "Where Product_ID = @Product_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Product_Name", productName);
            command.Parameters.AddWithValue("@Description", productDescription);
            command.Parameters.AddWithValue("@Price", productPrice);
            command.Parameters.AddWithValue("@Stock_Quantity", stockQuantity);
            command.Parameters.AddWithValue("@Created_At", create_At);

            command.Parameters.AddWithValue("@Product_ID", ProductID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                isUpdated = (rowAffected > 0);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            
            return isUpdated;
        }

        public static bool DeleteProduct(int ProductID)
        {
            bool isDeleted = false;

            string query = "Delete From Products Where Product_ID = @Product_ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Product_ID", ProductID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                isDeleted = (rowAffected > 0);
            }
            catch { }
            finally { connection.Close(); }
            return isDeleted;
        }
    }
}
