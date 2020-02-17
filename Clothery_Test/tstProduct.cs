using System;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothery_Test
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();

            Assert.IsNotNull(AProduct);
        }

    
        [TestMethod]
        public void Product_IDOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.Product_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Product_ID, TestData);
        }


        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "WWW";
            //assign the data to the property
            AProduct.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Name, TestData);
        }

        [TestMethod]
        public void TypeOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "WWW";
            //assign the data to the property
            AProduct.Type = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Type, TestData);
        }

        [TestMethod]
        public void ColourOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "21b";
            //assign the data to the property
            AProduct.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Colour, TestData);
        }

        [TestMethod]
        public void CostOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.Cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Cost, TestData);
        }

        [TestMethod]
        public void Stock_CountOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.Stock_Count = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Stock_Count, TestData);
        }

        [TestMethod]
        public void Is_AvailableOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean Testdata = true;
            //assign the data to the property
            AProduct.Is_Available = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Is_Available, Testdata);
        }
        [TestMethod]
        public void Next_DeliveryOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AProduct.Next_Delivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Next_Delivery, TestData);
        }

    }
}
