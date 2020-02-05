using System;
using Clothery_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothery_Test
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);  
        }
    }
}