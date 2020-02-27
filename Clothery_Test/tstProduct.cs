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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean Found = false;

            Int32 Product_ID = 1;

            Found = AProduct.Find(Product_ID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProduct_IDFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;
        
            Found = AProduct.Find(Product_ID);

            if (AProduct.Product_ID != 21)
                {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Name != "Dave")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTypeFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Type != "Cape")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Colour != "yellow")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCostFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Cost != 12)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStock_CountFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Stock_Count != 12)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIs_AvailableFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Is_Available != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNext_DeliveryFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();

            Boolean Found = false;
            Boolean OK = true;

            Int32 Product_ID = 21;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Next_Delivery != Convert.ToDateTime("27/02/2021"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
