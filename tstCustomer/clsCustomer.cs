﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstCustomer
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }


        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnCustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnCustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnCustomer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnAddress.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Town, TestData);
        }
    }

    internal class clsCustomer
    {
    }
}

