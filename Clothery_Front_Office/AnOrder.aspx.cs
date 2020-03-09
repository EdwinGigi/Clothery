﻿using System;
using Clothery_Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;
    //Event handler for page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderId);
    }
    protected void Btn_OK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        
        AnOrder.OrderId = Convert.ToInt32(TxtOrderId);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.ShippingAddress = TxtShippingAddress.Text;
        AnOrder.CustomerId = Convert.ToInt32(TxtCustomerId);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }



    
}