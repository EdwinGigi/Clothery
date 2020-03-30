using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clothery_Classes;
using System.Collections.Generic;

namespace Clothery_Test
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create the instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();

            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void OrderListOK()
        {
            //create the instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();
            //set it's properties 

            TestItem.IsPaid = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderId = 1;
            TestItem.ShippingAddress = "Street";
            TestItem.CustomerId = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that two values are the same;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create the instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data 
            clsOrder TestOrder = new clsOrder();
            //properties of the set test objects
            TestOrder.IsPaid = true;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderId = 1;
            TestOrder.ShippingAddress = "Street";
            TestOrder.CustomerId = 10;
            //assign data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that two values are the same;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create the instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();
            //set it's properties 
            TestItem.IsPaid = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderId = 1;
            TestItem.ShippingAddress = "Street";
            TestItem.CustomerId = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that two values are the same;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create the item of the test data 
            clsOrder TestItem = new clsOrder();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties 
            TestItem.OrderId = 1;
            TestItem.CustomerId = 10;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShippingAddress = "Street";
            TestItem.IsPaid = true;

            //set ThisOrder 
            AllOrders.ThisOrder = TestItem;

            //add the record 
            PrimaryKey = AllOrders.Add();

            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);

            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create the item of the test data 
            clsOrder TestItem = new clsOrder();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties 
            TestItem.OrderId = 1;
            TestItem.CustomerId = 10;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShippingAddress = "Street";
            TestItem.IsPaid = true;

            //set ThisOrder 
            AllOrders.ThisOrder = TestItem;

            //add the record 
            PrimaryKey = AllOrders.Add();

            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);

            //Delete the record 
            AllOrders.Delete();

            //Now find the record 
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            //test to see that the two values are the same 
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create an instance of the filtered data
            clsOrderCollection FilteredShippingAddress = new clsOrderCollection();

            //apply a blank string (should return all records)
            FilteredShippingAddress.ReportByShippingAddress("");

            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, FilteredShippingAddress.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FiltredShippingAddress = new clsOrderCollection();

            //apply a shipping address that doesn't exist
            FiltredShippingAddress.ReportByShippingAddress("Larnaca");

            //test to see that there are no records
            Assert.AreEqual(0, FiltredShippingAddress.Count);

        }

        [TestMethod]
        public void ReportByShippingAddressTestDataFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            //var to store the outcome 
            Boolean OK = true;

            //apply a Shipping Address that doesn't exist
            FilteredOrders.ReportByShippingAddress("Moscow");

            //Check that the correct number of records are found 
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 
                if (FilteredOrders.OrderList[0].OrderId != 9)
                {
                    OK = false;
                }
                //check that the first record is ID 
                if (FilteredOrders.OrderList[1].OrderId != 18)
                {
                    OK = false;
                }
            }
            else
            {
                //test to see that there are no records 
                Assert.IsTrue(OK);
            }
        }
    }
}
