using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayOrders();
        }
    }
        void DisplayOrders()
        {
            //create an instance of the Collection
            Clothery_Classes.clsOrderCollection Orders = new Clothery_Classes.clsOrderCollection();

        //set the data source to the list 
        lstOrders.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrders.DataValueField = "OrderId";
        //set the data field to display
        lstOrders.DataTextField = "ShippingAddress";
        //bind the data to the list 
        lstOrders.DataBind();

        }



    
      
   
}
