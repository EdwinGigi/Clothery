using System;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothery_Test
{
    [TestClass]
    public class TstProduct
    {
        int Product_ID = 1;
        string Name = "Dave";
        string Type = "Dave";
        string Colour = "Dave";
        int Cost = 1;
        int Stock_Count = 1;
        string Next_Delivery = DateTime.Now.Date.ToString();

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

            Int32 Product_ID = 1;
        
            Found = AProduct.Find(Product_ID);

            if (AProduct.Product_ID != 1)
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

            Int32 Product_ID = 1;

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

            Int32 Product_ID = 1;

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

            Int32 Product_ID = 1;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Colour != "Yellow")
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

            Int32 Product_ID = 1;

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

            Int32 Product_ID = 1;

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

            Int32 Product_ID = 1;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Is_Available != true)
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

            Int32 Product_ID = 1;

            Found = AProduct.Find(Product_ID);

            if (AProduct.Next_Delivery != Convert.ToDateTime("27/02/2021"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMehodOK()
        {
            clsProduct AProduct = new clsProduct();


            String Error = "";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "A";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "Jo";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "PPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "PPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "PPPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "PPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Name = "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void TypeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "P";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "PPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "PPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "PPPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TypeMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "PPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TypeExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Type = "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }




        

        [TestMethod]
        public void ColourMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "P";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "PPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "PPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "PPPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "PPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Colour = "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP";

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }





      

        [TestMethod]
        public void CostMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Cost = -1;

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Cost = 0;

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Cost = 1;

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        

        [TestMethod]
        public void CostMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Cost = (300);

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }







        [TestMethod]
        public void Stock_CountMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Stock_Count = -1;

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_CountMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Stock_Count = 0;

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_CountMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Stock_Count = 1;

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void Stock_CountMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            int Stock_Count = (300);

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void Next_DeliveryExtremeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";

            DateTime testdate;
            testdate = DateTime.Now.Date;
            testdate = testdate.AddYears(-100);

            string Next_Delivery = testdate.ToString();

            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }








    }
}
