﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstCustomer
{
    [TestMethod]
    public void FindMethodOk()
    {
        clsCustomer AnCustomer = new clsCustomer();
        Boolean Found = false;
        Int32 CustomerId = 1;
        Found = AnCustomer.Find(CustomerId);
        Assert.IsTrue(Found);
    }
    [TestMethod]
    public void TestCustomerIdFound()
    {
        clsCustomer AnCustomer = new clsCustomer();
        Boolean Found = false;
        Boolean OK = true;
        Int32 CustomerId = 1;
        Found = AnCustomer.Find(CustomerId);
        if (AnCustomer.CustomerId !=1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }

        
    
}
