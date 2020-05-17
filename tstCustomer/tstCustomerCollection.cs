using System;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace tstCustomer
{
    [TestClass]
    public class tstCustomerCollection
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }
    }
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
    }
    public List<clsCustomer> CustomerList
    {
        get
        {
            return mCustomerList;
        }
        set
        {
            mCustomerList = value;
        }
    }


}
