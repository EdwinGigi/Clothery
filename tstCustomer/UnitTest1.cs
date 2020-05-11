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
            string TestData = "some street";
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
        [TestMethod]
        public void CustomerStatus()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsAddress();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustoerAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomersID);
            if (AnCustomer.Town != "Test Town")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerHomeNumber()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPostcode()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.PostCode != "XXX XXX")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerStatus()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerHomeNumberMin()
        {
            clsAddress AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerHomeNumber() = "a";
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerHomeNumberMinPlusOne()
        {
            clsAddress AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerHomeNumber() = "aa";
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerHomeNumberMaxLessOne()
        {
            clsAddress AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerHomeNumber() = "aaaa";
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerHomeNumberMax()
        {
            clsAddress AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerHomeNumber() = "aaaaaa";
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerHomeNumberMid()
        {
            clsAddress AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerHomeNumber() = "aaa";
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string CustomerDOB = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqaul(Error, "");

        }
        [TestMethod]
        public void CustomerDOBMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string CustomerDOB = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqaul(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqaul(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMinPlusOne ()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqaul(Error, "");
        }
        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqaul(Error, "");
        }
        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerHomeNumber = "22";
            string CustomerPostCode = "le3 5rz";
            string DateAdded = "this is not the date";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "a";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "aa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "aaaaaa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "aaaaaaaaa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "aaaaaaaa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPostCode = "aa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "a";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aa";
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aa";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxPlusMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "aa";
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            Error = AnCsutomer.Valid(CustomerHomeNumber, CustomerPostCode, CustomerDOB, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }

    }

}
