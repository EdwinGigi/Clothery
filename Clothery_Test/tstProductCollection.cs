using System;
using System.Collections.Generic;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothery_Test
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            Assert.IsNotNull(AllProducts);

        }

        [TestMethod]
        public void ProductListOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();

            TestItem.Product_ID = 1;
            TestItem.Name = "Dave";
            TestItem.Type = "Dave";
            TestItem.Colour = "Dave";
            TestItem.Cost = 1;
            TestItem.Stock_Count = 1;
            TestItem.Is_Available = true;
            TestItem.Next_Delivery = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllProducts.ProductsList = TestList;
            Assert.AreEqual(AllProducts.ProductsList, TestList);

        }

        

        [TestMethod]
        public void ThisProductOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            
            clsProduct TestProduct = new clsProduct();

            TestProduct.Product_ID = 1;
            TestProduct.Name = "Dave";
            TestProduct.Type = "Dave";
            TestProduct.Colour = "Dave";
            TestProduct.Cost = 1;
            TestProduct.Stock_Count = 1;
            TestProduct.Is_Available = true;
            TestProduct.Next_Delivery = DateTime.Now.Date;

            

            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();

            TestItem.Product_ID = 1;
            TestItem.Name = "Dave";
            TestItem.Type = "Dave";
            TestItem.Colour = "Dave";
            TestItem.Cost = 1;
            TestItem.Stock_Count = 1;
            TestItem.Is_Available = true;
            TestItem.Next_Delivery = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllProducts.ProductsList = TestList;
            Assert.AreEqual(AllProducts.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            Int32 PrimaryKey = 0;
            TestItem.Product_ID = 1;
            TestItem.Name = "Dave";
            TestItem.Type = "Dave";
            TestItem.Colour = "Dave";
            TestItem.Cost = 1;
            TestItem.Stock_Count = 1;
            TestItem.Is_Available = true;
            TestItem.Next_Delivery = DateTime.Now.Date;

            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();

            TestItem.Product_ID = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            Int32 PrimaryKey = 0;
            TestItem.Product_ID = 1;
            TestItem.Name = "Dave";
            TestItem.Type = "Dave";
            TestItem.Colour = "Dave";
            TestItem.Cost = 1;
            TestItem.Stock_Count = 1;
            TestItem.Is_Available = true;
            TestItem.Next_Delivery = DateTime.Now.Date;

            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();

            TestItem.Product_ID = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);

            AllProducts.Delete();

            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();

            Int32 PrimaryKey = 0;
            
            TestItem.Name = "Dave";
            TestItem.Type = "Dave";
            TestItem.Colour = "Dave";
            TestItem.Cost = 1;
            TestItem.Stock_Count = 1;
            TestItem.Is_Available = true;
            TestItem.Next_Delivery = DateTime.Now.Date;

            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();

            TestItem.Product_ID = PrimaryKey;

            
            TestItem.Name = "Joe";
            TestItem.Type = "Joe";
            TestItem.Colour = "Joe";
            TestItem.Cost = 21;
            TestItem.Stock_Count = 12;
            TestItem.Is_Available = false;
            TestItem.Next_Delivery = DateTime.Now.Date;

            AllProducts.ThisProduct = TestItem;
            AllProducts.Update();


            AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);

        }

        [TestMethod]
        public void ReportByTypeMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProductCollection FilteredProducts = new clsProductCollection();

            FilteredProducts.ReportByType("");

            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);


        }

        [TestMethod]
        public void ReportByTypeNoneFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByType("Jeff");

            Assert.AreEqual(0, FilteredProducts.Count);

        }


        [TestMethod]
        public void ReportByTypeDataFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();

            Boolean OK = true;
            FilteredProducts.ReportByType("Cape");
            if (FilteredProducts.Count == 2)
            {

                if (FilteredProducts.ProductsList[0].Product_ID != 1)
                {
                    OK = false;
                }
                if (FilteredProducts.ProductsList[1].Product_ID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }



    }
}
