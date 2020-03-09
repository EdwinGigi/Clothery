using System;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothery_Test
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }


        [TestMethod]
        public void SupplierIdOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }

        [TestMethod]
        public void SupplierNameOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "ClotherySupplier";
            //assign the data to the property
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void SupplierAddressOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "37 Factory Street, Leicester";
            //assign the data to the property
            AnSupplier.SupplierAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }

        [TestMethod]
        public void SupplierPostCodeOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "LE3 0JA";
            //assign the data to the property
            AnSupplier.SupplierPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierPostCode, TestData);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Desc...";
            //assign the data to the property
            AnSupplier.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Description, TestData);
        }

        [TestMethod]
        public void DeliveryDateOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnSupplier.DeliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }

        [TestMethod]
        public void StockAvailableOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSupplier.StockAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.StockAvailable, TestData);
        }



    }
}
