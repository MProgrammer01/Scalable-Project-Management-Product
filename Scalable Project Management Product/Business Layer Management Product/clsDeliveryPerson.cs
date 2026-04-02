using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsDeliveryPerson
    {
        enum enMode { AddNewDelevryPerson = 0, UpdateDelevryPerson = 1 };

        enMode Mode = enMode.AddNewDelevryPerson;
        public int DeliveryPersonID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public clsDeliveryPerson()
        {
            DeliveryPersonID = -1;
            Name = "";
            PhoneNumber = "";
            Email = "";
            Status = "";
            Mode = enMode.AddNewDelevryPerson;
        }

        public clsDeliveryPerson(int deliveryPersonID, string name, string phoneNumber, string email, string status)
        {
            DeliveryPersonID = deliveryPersonID;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Status = status;
            Mode = enMode.UpdateDelevryPerson;
        }

        public static clsDeliveryPerson FindDeliveryPersonByID(int DeliveryPersonID)
        {
            string Name = "";
            string PhoneNumber = "";
            string Email = "";
            string Status = "";

            if (clsDataDeliveryPerson.FindDeliveryPersonByID(DeliveryPersonID, ref Name, ref PhoneNumber, ref Email, ref Status))
            {
                return new clsDeliveryPerson(DeliveryPersonID, Name, PhoneNumber, Email, Status);
            }
            return null;
        }

        bool _AddNewDeliveryPerson()
        {
            this.DeliveryPersonID = clsDataDeliveryPerson.AddNewDeliveryPerson(
                this.Name, this.PhoneNumber, this.Email, this.Status);
            return (this.DeliveryPersonID != -1);
        }

        bool _UpdateDeliveryPerson()
        {
            return (clsDataDeliveryPerson.UpdateDeliveryPerson(
                this.DeliveryPersonID, this.Name, this.PhoneNumber,
                this.Email, this.Status));
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNewDelevryPerson:
                    {
                        if(_AddNewDeliveryPerson())
                        {
                            this.Mode = enMode.UpdateDelevryPerson;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.UpdateDelevryPerson:
                    {
                        return _UpdateDeliveryPerson();
                    }
            }
            return false;
        }

        public static bool DeleteDeliveryPerson(int DeliveryPersonID)
        {
            return (clsDataDeliveryPerson.DeleteDeliveryPerson(DeliveryPersonID));
        }
        public static DataTable GetAllDeliveryPersons()
        {
            return (clsDataDeliveryPerson.GetAllDeliveryPersons());
        }

        public static DataTable GetInformationOfCommand (int DeliveryPersonID)
        {
            return (clsDataDeliveryPerson.GetInformationOfCommand(DeliveryPersonID));
        }
    }
}
