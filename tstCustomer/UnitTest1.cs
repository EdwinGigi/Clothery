using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace tstCustomer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }
        [TestMethod]
        public void CustomerID()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 1;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        [TestMethod]
        public void CustomerDOB()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
    
            }
        [TestMethod]
        public void CustomerAddress()
        {
            clsAddress AnCustomer = new clsCustomer();
            string TestData = "some street";
            AnCustomer.AddressNo = TestData;
            Assert.AreEqual(AnCustomer.AddressNo, TestData);
        }
        [TestMethod]
        public void CustomerHomeNumber()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 1;
            AnCustomer.CustomerHomeNumber = TestData;
            Assert.AreEqual(AnCustomer.CustomerHomeNumber, TestData);
        }
        [TestMethod]
        public void CustomerPostcode()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "LE1 4AB";
            AnCustomer.PostCode = TestData;
            Assert.AreEqual(AnAddress.PostCode, TestData);
        }
        [TestMethod]
        public void CustomerStatus()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsAddress();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustoerAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomersID);
            if (AnCustomer.Town != "Test Town")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerHomeNumber()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPostcode()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.PostCode != "XXX XXX")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerStatus()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }

}
