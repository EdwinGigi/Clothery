using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the Supplier ID no.
        AnSupplier.SupplierId = intSupplierId.Int32;
        //store the id in the session object
        Session["AnSupllier"] = AnSupplier;
        //redirect to the viewer page
        Response.Redirect("AddressViewer.aspx");
    }
}