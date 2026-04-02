using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsForSavingEmployeeDataLoginInFile
    {
        static string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login Employee.txt");
        static void AddDataLineToFile(string DataLine)
        {
            try
            {
                Console.WriteLine(FilePath);
                File.WriteAllText(FilePath, DataLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        static void DeleteLoginFromFile()
        {
            try
            {
                File.WriteAllText(FilePath, string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void DeleteLogin()
        {
            DeleteLoginFromFile();

        }

        public static void AddLoginForEmployeeToFile(string email, string password)
        {
            string loginEmployeeDataLine = $"{email}/{password}";
            AddDataLineToFile(loginEmployeeDataLine);

        }

        public static bool FindLoginForEmployee(ref string email, ref string password)
        {
            bool isFound = false;
            try
            {
                string line = File.ReadAllText(FilePath);
                if (!string.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split('/');
                    email = parts[0];
                    password = parts[1];
                    isFound = true;
                }
            }
            catch (Exception ex) { }
            return isFound;
        }

        public static bool IsExistLoginForEmployee(string email, string password)
        {
            bool isFound = false;
            try
            {
                string line = File.ReadAllText(FilePath);
                if (!string.IsNullOrEmpty(line))
                {
                    isFound = true;
                }
            }
            catch (Exception ex) { }
            return isFound;
        }
    }
}
