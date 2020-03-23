using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clothery_Classes;

namespace Clothery_Test
{
    [TestClass]
    public class tstOrderLine
    {
       

        [TestMethod]
        public void InstanceOK()
        {
            //Creating the istance of a class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test that it exist
            Assert.IsNotNull(AnOrderLine);

        }
        [TestMethod]
        public void ShippedOk()
        {
            //
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean TestData = true;

            AnOrderLine.Shipped = TestData;

            Assert.AreEqual(AnOrderLine.Shipped, TestData);

        }
        [TestMethod]
        public void OrderLineIdOk()
        {
            //
            clsOrderLine AnOrderLine = new clsOrderLine();

            Int32 TestData = 1;

            AnOrderLine.OrderLineId = TestData;

            Assert.AreEqual(AnOrderLine.OrderLineId, TestData);

        }
        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }
        [TestMethod]
        public void ProductIdOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductId, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AnOrderLine.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Price, TestData);
        }
        [TestMethod]
        public void SizeOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String TestData = "L";
            //assign the data to the property
            AnOrderLine.Size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Size, TestData);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String TestData = "tshirt";
            //assign the data to the property
            AnOrderLine.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Description, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineId = 18;


            Found = AnOrderLine.Find(OrderLineId);

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderLineIdNoFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderLineId = 18;
            Found = AnOrderLine.Find(OrderLineId);

            if (AnOrderLine.OrderLineId != 18)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestOrderId()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderLineId = 18;
            Found = AnOrderLine.Find(OrderLineId);

            if (AnOrderLine.OrderId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }


        [TestMethod]
        public void TestProductId()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderLineId = 18;
            Found = AnOrderLine.Find(OrderLineId);

            if (AnOrderLine.ProductId != 10)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestShippedFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 18;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the property
            if (AnOrderLine.Shipped != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantity()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderLineId = 18;
            Found = AnOrderLine.Find(OrderLineId);

            if (AnOrderLine.Quantity != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestPrice()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 OrderLineId = 18;
            Found = AnOrderLine.Find(OrderLineId);

            if (AnOrderLine.Price != 10)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestDescription()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 18;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the property
            if (AnOrderLine.Description != "White Hoodie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Testsize()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 18;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the property
            if (AnOrderLine.Size != "Medium")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
