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
            Double TestData = 10.99;
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



    }
}
