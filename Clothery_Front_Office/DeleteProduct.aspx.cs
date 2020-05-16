using Clothery_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteProduct : System.Web.UI.Page
{
    Int32 ProductId;



    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsProductCollection ProductList = new clsProductCollection();
        ProductList.ThisProduct.Find(ProductId);
        ProductList.Delete();
        Response.Redirect("ProductList");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {

    }
}