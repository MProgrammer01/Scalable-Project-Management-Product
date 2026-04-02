using Data_Layer_Product_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_Management_Product
{
    public class clsProduct
    {
        enum enMode { AddNewProduct = 0, UpdateProduct = 1 }
        enMode Mode = enMode.AddNewProduct;
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int StockQuantity {  get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime Create_At { get; set; }
        public clsProduct()
        {
            ProductID = -1;
            ProductName = "";
            ProductDescription = "";
            ProductPrice = -1;
            StockQuantity = -1;
            Create_At = DateTime.Now;
            Mode = enMode.AddNewProduct;
        }
        clsProduct(int productID, string productName, string productDescription, 
            decimal productPrice, int stockQuantity, DateTime create_At)
        {
            ProductID = productID;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            StockQuantity = stockQuantity;
            Create_At = create_At;
            Mode = enMode.UpdateProduct;
        }

        public static clsProduct FindProductByID(int productID)
        {
            string ProductName = "";
            string ProductDescription = "";
            decimal ProductPrice = -1;
            int StockQuantity = -1;
            DateTime Create_At = DateTime.Now;

            if(clsDataProduct.FindProductByID(productID,
            ref ProductName, ref ProductDescription,
            ref ProductPrice, ref StockQuantity,
            ref Create_At))
            {
                return new clsProduct(productID,
                            ProductName, ProductDescription,
                            ProductPrice, StockQuantity,
                            Create_At);
            }
            return null;
        }

        bool _AddNewProduct()
        {
            this.ProductID = clsDataProduct.AddNewProduct(this.ProductName, 
                this.ProductDescription, this.ProductPrice, this.StockQuantity,
                this.Create_At);

            return (this.ProductID != -1);
        }

        bool _UpdateProduct()
        {
            return (clsDataProduct.UpdateProduct(this.ProductID, this.ProductName, this.ProductDescription,
                this.ProductPrice, this.StockQuantity, this.Create_At));
        }

        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.AddNewProduct:
                    {
                        if (_AddNewProduct())
                        {
                            this.Mode = enMode.UpdateProduct;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.UpdateProduct:
                    {
                        return _UpdateProduct();
                    }
            }
            return false;
        }

        public static bool DeleteProduct(int productID)
        {
            return (clsDataProduct.DeleteProduct(productID));
        }

        public static DataTable GetAllDataOfProducts()
        {
            return (clsDataProduct.GetAllProducts());
        }
    }
}
