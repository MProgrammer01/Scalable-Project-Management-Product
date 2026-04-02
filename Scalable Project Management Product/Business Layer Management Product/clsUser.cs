using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsUser
    {
        enum enMode { AddNewUser = 0, UpdateUser = 1 }

        enMode Mode = enMode.AddNewUser;

        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public DateTime Created_At { get; set; }

        public clsUser()
        {
            this.User_ID = -1;
            this.Username = "";
            this.Email = "";
            this.Phone_Number = "";
            this.Address = "";
            this.Created_At = DateTime.Now;
            Mode = enMode.AddNewUser;
        }

        clsUser(int User_ID, string username, string email, string phone_Number, string address, DateTime created_At)
        {
            this.User_ID = User_ID;
            this.Username = username;
            this.Email = email;
            this.Phone_Number = phone_Number;
            this.Address = address;
            this.Created_At = created_At;
            Mode = enMode.UpdateUser;
        }

        bool _AddNewUser()
        {
            this.User_ID = clsDataUser.AddNewUser(this.Username, 
                this.Email, this.Phone_Number, this.Address, this.Created_At);

            return(this.User_ID != -1);
        }

        bool _UpdateUser()
        {
            return (clsDataUser.UpdateUser(this.User_ID, this.Username,
                this.Email, this.Phone_Number, this.Address, this.Created_At));
        }

        public static clsUser FindUserByID(int User_ID)
        {
            string Username = "";
            string Email = "";
            string Phone_Number = "";
            string Address = "";
            DateTime Created_At = DateTime.Now;

            if(clsDataUser.FindUserByID(User_ID, ref Username, ref Email, ref Phone_Number, ref Address, ref Created_At))
            {
                return new clsUser(User_ID, Username, Email, Phone_Number, Address, Created_At);
            }
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewUser:
                    {
                        if (_AddNewUser())
                        {
                            Mode = enMode.UpdateUser;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.UpdateUser:
                    {
                        return _UpdateUser();
                    }
            }
            return false;
        }

        public static DataTable GetAllDataOfUsers()
        {
            return (clsDataUser.GetAllUsers());
        }

        public static bool DeleteUser(int User_ID)
        {
            return (clsDataUser.DeleteUser(User_ID));
        }
    }
}
