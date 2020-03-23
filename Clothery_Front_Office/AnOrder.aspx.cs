using System;
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
        //AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderId);
    }
    

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        string OrderDate = txtOrderDate.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string CustomerId = txtCustomerId.Text;
        //variable to store an error message
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
        if (Error == "")
        {
            AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.IsPaid = Convert.ToBoolean(chkPaid);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx"); 
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 OrderId;

        Boolean Found = false;

        OrderId = Convert.ToInt32(txtOrderId.Text);

        Found = AnOrder.Find(OrderId);

        if (Found == true)
        {
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            //chkPaid = AnOrder.IsPaid.ToString();
        }
    }
}