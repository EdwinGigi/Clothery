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
    }
}
