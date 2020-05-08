using Clothery_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnSupplier : System.Web.UI.Page
{   
    //variable to store the primary key with page level scope
   Int32 Supplier_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void chkStockAvailable_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        //capture the Suplier ID
        AnSupplier.Supplier_ID = Convert.ToInt32(txtSupplierID.Text);
        AnSupplier.SupplierName = txtSupplierName.Text;
        AnSupplier.SupplierAddress = txtSupplierAddress.Text;
        AnSupplier.SupplierPostCode = txtSupplierPostCode.Text;
        AnSupplier.Description = txtDescription.Text;
        AnSupplier.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
       // AnSupplier.StockAvailable = Convert.ToBoolean(chkStockAvailable);
        //store the ID in the session object
        Session["AnSupplier"] = AnSupplier;
        //redirect to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
    }
}