using System;
using Clothery_Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
     //   AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        Response.Write(AnOrderLine.OrderLineId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();

        AnOrderLine.OrderLineId = Convert.ToInt32(txtOrderLineId.Text);
        AnOrderLine.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrderLine.ProductId = Convert.ToInt32(txtProductId.Text);
        AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnOrderLine.Price = Convert.ToDecimal(txtPrice.Text);
        AnOrderLine.Size = txtSize.Text;
        AnOrderLine.Description = txtDescription.Text;
        AnOrderLine.Shipped = Convert.ToBoolean(chkShipped);
        Session["AnOrderLine"] = AnOrderLine;
        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}