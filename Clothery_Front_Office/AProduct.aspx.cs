﻿using System;
using Clothery_Classes;

using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        AProduct = (clsProduct)Session["AProduct"];
        Response.Write(AProduct.Product_ID);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();

        AProduct.Product_ID = Convert.ToInt32(TxtID.Text);
        AProduct.Name = TxtName.Text;
        AProduct.Type = TxtType.Text;
        AProduct.Colour = TxtColour.Text;
        AProduct.Cost = Convert.ToDecimal(TxtCost.Text);
        AProduct.Stock_Count = Convert.ToInt32(TxtStock_Count.Text);
        AProduct.Is_Available = Convert.ToBoolean(ChkAvailable);
        AProduct.Next_Delivery = Convert.ToDateTime(TxtNext_Delivery.Text);

        Session["AProduct"] = AProduct;
        Response.Redirect("ProductViewer.aspx");
    }


    }