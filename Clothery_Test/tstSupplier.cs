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
        public void Supplier_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.Supplier_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Supplier_ID, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Tops4Cheap";
            //assign the data to the property
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void SupplierAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Rawson St, Leicester, Leicestershire";
            //assign the data to the property
            AnSupplier.SupplierAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }

        [TestMethod]
        public void SupplierPostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "LE2 6TB";
            //assign the data to the property
            AnSupplier.SupplierPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierPostCode, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "The cheapest t-shirts in town";
            //assign the data to the property
            AnSupplier.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Description, TestData);
        }

        [TestMethod]
        public void DeliveryDatePropertyOK()
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
        public void StockAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.StockAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.StockAvailable, TestData);
        }

        [TestMethod]
        public void CheckStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSupplier.CheckStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.CheckStock, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //test data to use the method
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //test to see that result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSupplier_IDFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier id no
            if (AnSupplier.Supplier_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1 ;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier name
            if (AnSupplier.SupplierName != "Toys")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierPostCodeFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier post code
            if (AnSupplier.SupplierPostCode != "LE2 6TB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier address
            if (AnSupplier.SupplierAddress != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAvailableFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier stock available
            if (AnSupplier.StockAvailable != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCheckStockFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier stock available
            if (AnSupplier.CheckStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier description
            if (AnSupplier.Description != "We are the best")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data
            Int32 Supplier_ID = 1;
            //invoke the method
            Found = AnSupplier.Find(Supplier_ID);
            //check the supplier date
            if (AnSupplier.DeliveryDate != Convert.ToDateTime("05/05/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
}
