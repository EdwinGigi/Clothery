using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstCustomer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);



        }
    }
}
