﻿using System;
using System.Collections.Generic;

namespace Clothery_Classes
{
    public class clsOrderCollection
    {
        //private data member for the list 
        private List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisAddress 
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list 
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data   
                return mThisOrder;
            }
            set
            {
                //set the private data 
                mThisOrder = value;
            }
        }

        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        


        }

        public int Add()
        {
            //add a new record to the database based on the values of mThisOrder 
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);


            //return the primary key of the new record 
            return DB.Execute("sproc_tblOrder_Insert");



        }

        public void Delete()
        {
            //Deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("@OrderId", mThisOrder.OrderId);

            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);

            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //Filters the records based on a full or partial shipping address.
            //Connect to the database 
            clsDataConnection DB = new clsDataConnection();

            //Send the ShippingAddress parameter to the database 
            DB.AddParameter("@ShippingAddress", ShippingAddress);

            //Execute the store procedures
            DB.Execute("sproc_tblOrder_FilterByShippingAddress");

            //poopulate the array list with the data table 
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB

            //var for the index
            Int32 Index = 0;

            //var to store the record count 
            Int32 RecordCount;

            //get the count of records 
            RecordCount = DB.Count;

            //clear the private array list 
            mOrderList = new List<clsOrder>();

            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();

                //read in the fields from the current record 
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);

                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);

                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);

                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);

                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);

                //add the record to the private data member 
                mOrderList.Add(AnOrder);

                //point to the next record
                Index++;

            }

        }
    }
}