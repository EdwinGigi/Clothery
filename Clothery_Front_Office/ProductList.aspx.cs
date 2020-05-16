using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clothery_Classes;

public partial class ProductList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }


    void DisplayProducts()
    {
        Clothery_Classes.clsProductCollection Products = new Clothery_Classes.clsProductCollection();
        LstProductList.DataSource = Products.ProductsList;
        LstProductList.DataValueField = "ProductID";
        LstProductList.DataTextField = "Name";
        LstProductList.DataBind();

    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;

        Response.Redirect("AProduct.aspx");
    }






    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductID;

        if (LstProductList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(LstProductList.SelectedValue);

            Session["ProductID"] = ProductID;

            Response.Redirect("DeleteProduct.aspx");
        }
        else
        {
            LblError.Text = "Please select a record to delete form the list ";
        }

    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductId;

        if (LstProductList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(LstProductList.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("AProduct.aspx");

        }

        else
        {
            LblError.Text = "Please select a record to delete from the list";
        }


    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();
        Products.ReportByType(TxtType.Text);

        LstProductList.DataSource = Products.ProductsList;
        LstProductList.DataTextField = "Type";
        LstProductList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();
        Products.ReportByType("");

        TxtType.Text = "";

        LstProductList.DataSource = Products.ProductsList;
        LstProductList.DataTextField = "Type";
        LstProductList.DataBind();
    }
}