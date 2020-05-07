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
            Int32 TestData = 1;
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
        public void CustomerStatus()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);

        }


    }
}
