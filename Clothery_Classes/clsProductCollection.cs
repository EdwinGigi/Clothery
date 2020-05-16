using System;
using System.Collections.Generic;
using Clothery_Classes;


namespace Clothery_Classes
{
    public class clsProductCollection
    {


        List<clsProduct> mProductsList = new List<clsProduct>();
        public List<clsProduct> ProductsList
        {
            get
            {
                return mProductsList;
            }

            set
            {
                mProductsList = value;
            }

        }


        public int Count
        {
            get
            {
                return mProductsList.Count;
            }
            set
            {
                //Not done yet
            }
        }
        
        private clsProduct mThisProduct;
        public clsProduct ThisProduct
        {
            get
            {
                return mThisProduct;
            }

            set
            {
                mThisProduct = value;
            }
        }



        public void clsAddressCollection()
        {

            
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProduct_SelectAll");

            PopulateArray(DB);



        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Type", mThisProduct.Type);
            DB.AddParameter("@Cost", mThisProduct.Cost);
            DB.AddParameter("@Colour", mThisProduct.@Colour);
            DB.AddParameter("@StockCount", mThisProduct.Stock_Count);
            DB.AddParameter("@IsAvailable", mThisProduct.Is_Available);
            DB.AddParameter("@NextDelivery", mThisProduct.Next_Delivery);


            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductID", mThisProduct.Product_ID);

            DB.Execute("sproc_tblProduct_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", mThisProduct.Product_ID);
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Type", mThisProduct.Type);
            DB.AddParameter("@Cost", mThisProduct.Cost);
            DB.AddParameter("@Colour", mThisProduct.@Colour);
            DB.AddParameter("@StockCount", mThisProduct.Stock_Count);
            DB.AddParameter("@IsAvailable", mThisProduct.Is_Available);
            DB.AddParameter("@NextDelivery", mThisProduct.Next_Delivery);

            DB.Execute("sproc_tblProduct_Update");
        }

        public void ReportByType(string Type)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Type", Type);

            DB.Execute("sproc_tblProduct_FilterByType");
            PopulateArray(DB);

        }




        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;

            RecordCount = DB.Count;

            mProductsList = new List<clsProduct>();


            while (Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();

                AProduct.Product_ID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                AProduct.Name = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                AProduct.Type = Convert.ToString(DB.DataTable.Rows[0]["Type"]);
                AProduct.Colour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                AProduct.Cost = Convert.ToInt32(DB.DataTable.Rows[0]["Cost"]);
                AProduct.Stock_Count = Convert.ToInt32(DB.DataTable.Rows[0]["StockCount"]);
                AProduct.Is_Available = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                AProduct.Next_Delivery = Convert.ToDateTime(DB.DataTable.Rows[0]["NextDelivery"]);

                mProductsList.Add(AProduct);

                Index++;

            }

        }







    }



}

