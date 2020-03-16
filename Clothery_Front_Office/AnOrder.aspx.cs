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

        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.IsPaid = Convert.ToBoolean(chkPaid);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}