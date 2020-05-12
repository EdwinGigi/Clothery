using System;
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
        //AProduct = (clsProduct)Session["AProduct"];
        Response.Write(AProduct.Product_ID);
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
            AProduct.Product_ID = Convert.ToInt32(TxtID.Text);
            AProduct.Name = TxtName.Text;
            AProduct.Type = TxtType.Text;
            AProduct.Colour = TxtColour.Text;
            AProduct.Cost = Convert.ToInt32(TxtCost.Text);
            AProduct.Stock_Count = Convert.ToInt32(TxtStock_Count.Text);
            AProduct.Is_Available = Convert.ToBoolean(ChkAvailable);
            AProduct.Next_Delivery = Convert.ToDateTime(TxtNext_Delivery.Text);

            Session["AProduct"] = AProduct;
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

}