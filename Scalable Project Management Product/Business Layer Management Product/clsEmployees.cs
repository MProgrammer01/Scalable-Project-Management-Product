using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsEmployees
    {
        enum enMode { AddNewEmployee = 0, UpdateEmployee = 1 }

        enMode Mode = enMode.AddNewEmployee;

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public clsEmployees()
        {
            EmployeeID = -1;
            EmployeeName = string.Empty;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Status = string.Empty;
            Mode = enMode.AddNewEmployee;
        }

        clsEmployees(int employeeID, string name, string phone_number, string email, string password, string status)
        {
            EmployeeID = employeeID;
            EmployeeName = name;
            PhoneNumber = phone_number;
            Email = email;
            Password = password;
            Status = status;
            Mode = enMode.UpdateEmployee;
        }

        public static clsEmployees FindEmployeeByID(int employeeID)
        {
            string EmployeeName = string.Empty;
            string PhoneNumber = string.Empty;
            string Email = string.Empty;
            string Password = string.Empty;
            string Status = string.Empty;

            if(clsDataEmployees.FindEmployeeByID(employeeID, ref EmployeeName, ref PhoneNumber,
                ref Email, ref Password, ref Status))
            {
                return new clsEmployees(employeeID, EmployeeName, PhoneNumber, Email, Password, Status);
            }
            return null;
        }

        bool _AddNewEmployee()
        {
            this.EmployeeID = clsDataEmployees.AddNewEmployee(this.EmployeeName, 
                this.PhoneNumber, this.Email, this.Password, this.Status);

            return (this.EmployeeID != -1);
        }

        bool _UpdateEmployee()
        {
            return (clsDataEmployees.UpdateEmployee(this.EmployeeID, this.EmployeeName,
                this.PhoneNumber, this.Email, this.Password, this.Status));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNewEmployee:
                    {
                        if(_AddNewEmployee())
                        {
                            this.Mode = enMode.UpdateEmployee;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.UpdateEmployee:
                    {
                        return (_UpdateEmployee());
                    }
            }
            return false;
        }

        public static DataTable GetAllEmployees()
        {
            return (clsDataEmployees.GetAllEmployees());
        }

        public static bool DeleteEmployee(int employeeID)
        {
            return (clsDataEmployees.DeleteEmployee(employeeID));
        }

        public static DataTable GetAccountsOfEmployees()
        {
            return (clsDataEmployees.GetAccountsOfEmployees());
        }
    }
}
