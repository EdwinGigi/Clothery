using System;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothery_Test
{
    [TestClass]
    public class tstOrder
    {

        // Good test data
        // Create some data to pass to the method
        string ShippingAddress = "London";
        string OrderDate = DateTime.Now.Date.ToString();
        string CustomerId = "1234";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);  
        }

        [TestMethod]
        public void isPaidPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.IsPaid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void ShippingAddressOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;


            Found = AnOrder.Find(OrderId);

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIdNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderId !=1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestOrderDate()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("02/02/2020"))
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestCustomerId()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.CustomerId != 10)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }


        [TestMethod]
        public void TestShippingAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.ShippingAddress != "Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsPaidFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.IsPaid != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        //Validation
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";

            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);

            Assert.AreEqual(Error, "");
            
        }


        [TestMethod]
        //Testing ShippingAddress Min - 1
        public void ShippingAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //Testing ShippingAddress Min
        public void ShippingAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "a";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreEqual(Error, "");
        }

      

        [TestMethod]
        //Testing ShippingAddress Min + 1
        public void ShippingAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "aa";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //Testing ShippingAddress Max - 1 
        public void ShippingAddressMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        //Testing ShippingAddress Max
        public void ShippingAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        //Testing ShippingAddress Max + 1
        public void ShippingAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //Testing ShippingAddress Mid
        public void ShippingAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String ShippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        //testing ShippingAddress extreme max values
        public void ShippingAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(200, 'a');
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing OrderDate extreme min
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string OrderDate = TestDate.ToString();

            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing OrderDate min -1 
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress,OrderDate,CustomerId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //Testing OrderDate min
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress,OrderDate,CustomerId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        //Testing OrderDate min + 1
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress,OrderDate,CustomerId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //Testing Orderdate Extreme Max 
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate; 
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing OrderDate invalid data
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";
           
            string OrderDate = "this is not a date!";

            Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);

            Assert.AreNotEqual(Error, "");
        }

        
    }
}