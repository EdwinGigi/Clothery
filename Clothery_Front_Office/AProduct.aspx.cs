using System;
using Clothery_Classes;

using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AProduct : System.Web.UI.Page
{
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);

        if (IsPostBack == false)
        {
            if (ProductId != -1)
            {
                DisplayProduct();
            }



        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();

        int Product_ID = Convert.ToInt32(TxtID.Text);
        string Name = TxtName.Text;
        string Type = TxtType.Text;
        string Colour = TxtColour.Text;
        int Cost = Convert.ToInt32(TxtCost.Text);
        int Stock_Count = Convert.ToInt32(TxtStock_Count.Text);
        string Next_Delivery = TxtNext_Delivery.Text;

        string Error = "";
        Error = AProduct.Valid(Product_ID, Name, Type, Colour, Cost, Stock_Count, Next_Delivery);
        if (Error =="")
        {
            AProduct.Product_ID = ProductId;

           AProduct.Name = TxtName.Text;
            AProduct.Type = TxtType.Text;
            AProduct.Colour = TxtColour.Text;
            AProduct.Cost = Convert.ToInt32(TxtCost.Text);
            AProduct.Stock_Count = Convert.ToInt32(TxtStock_Count.Text);
            AProduct.Is_Available = Convert.ToBoolean(ChkAvailable.Checked);
            AProduct.Next_Delivery = Convert.ToDateTime(TxtNext_Delivery.Text);

            clsProductCollection ProductList = new clsProductCollection();

            if (ProductId == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(ProductId);
                ProductList.ThisProduct = AProduct;

                Response.Redirect("ProductList.aspx");
            }


            

            Response.Redirect("ProductViewer.aspx");
        }
        else
        {
            LblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();

        Int32 Product_ID;

        Boolean Found = false;

        Product_ID = Convert.ToInt32(TxtID.Text);

        Found = AProduct.Find(Product_ID);

        if (Found == true)
        {
            TxtName.Text = AProduct.Name;
            TxtType.Text = AProduct.Type;
            TxtColour.Text = AProduct.Colour;
            TxtCost.Text = AProduct.Cost.ToString();
            TxtStock_Count.Text = AProduct.Stock_Count.ToString();
            ChkAvailable.Checked = AProduct.Is_Available;
            TxtNext_Delivery.Text = AProduct.Next_Delivery.ToString();
        }

     }

    void DisplayProduct()
    {
        clsProductCollection ProductList = new clsProductCollection();
        ProductList.ThisProduct.Find(ProductId);

        TxtName.Text = ProductList.ThisProduct.Name;
        TxtType.Text = ProductList.ThisProduct.Type;
        TxtColour.Text = ProductList.ThisProduct.Colour;
        TxtCost.Text = ProductList.ThisProduct.Cost.ToString();
        TxtStock_Count.Text = ProductList.ThisProduct.Stock_Count.ToString();
        ChkAvailable.Checked = ProductList.ThisProduct.Is_Available;
        TxtNext_Delivery.Text = ProductList.ThisProduct.Next_Delivery.ToString();



    }








}