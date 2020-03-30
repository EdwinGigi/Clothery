﻿using System;
using Clothery_Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object 
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the Order book?
        clsOrderCollection OrderBook = new clsOrderCollection();

        //find the record to delete 
        OrderBook.ThisOrder.Find(OrderId);

        //delete the record 
        OrderBook.Delete();

        //redirect back to the main page 
        Response.Redirect("OrderList.aspx");
    }
}