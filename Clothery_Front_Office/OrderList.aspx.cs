using System;
using Clothery_Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this a new record 
        Session["OrderId"] = -1;

        //Redirect to the data entry page 
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);

            Session["OrderId"] = OrderId;


            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderId;

        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);

            //store the data in the session object 
            Session["OrderId"] = OrderId;

            //Redirect to the edit page 
            Response.Redirect("AnOrder.aspx");

        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection 
        clsOrderCollection ShipAddress = new clsOrderCollection();

        ShipAddress.ReportByShippingAddress(txtShippinAddress.Text);
        lstOrderList.DataSource = ShipAddress.OrderList;

        //set the name of the primary key 
        lstOrderList.DataValueField = "OrderId";

        //set the name of the field to display 
        lstOrderList.DataTextField = "ShippingAddress";

        //bind the data to the list 
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection 
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress("");

        //clear any existing filter to tidy up the interface 
        txtShippinAddress.Text = "";
        lstOrderList.DataSource = Orders.OrderList;

        //set the name of the primary key 
        lstOrderList.DataValueField = "OrderId";

        //set the name of the field to display 
        lstOrderList.DataTextField = "ShippingAddress";

        //bind the data to the list
        lstOrderList.DataBind();
    }
}