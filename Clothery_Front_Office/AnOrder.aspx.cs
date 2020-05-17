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
        //get the number of the Order to be processed 
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack ==false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //display the current data for the record 
                DisplayOrders();
            }
        }
    }
    

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtOrderId.Text = "";
        txtCustomerId.Text = "";
        txtOrderDate.Text = "";
        txtShippingAddress.Text = "";

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //Capture the Order Date
        string OrderDate = txtOrderDate.Text;
        //Capture the shipping address
        string ShippingAddress = txtShippingAddress.Text;
        //Capture the customer id 
        string CustomerId = txtCustomerId.Text;
        //variable to store an error message
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(ShippingAddress, OrderDate, CustomerId);
        if (Error == "")
        {
            //capture the order id 
            AnOrder.OrderId = OrderId;
        
        //capture the Order Date
        AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
        
        //Capture the Shipping Address
        AnOrder.ShippingAddress = ShippingAddress;

        //
        AnOrder.CustomerId = Convert.ToInt32(CustomerId);

        //Capture Is Paid 
        AnOrder.IsPaid = chkPaid.Checked;

        //Create a new instance of the Order collection
        clsOrderCollection OrderList = new clsOrderCollection();


            //if this is a new record i.e OrderId = -1 then add the data 
            if (OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            else
            {
                //find the record to update 
                OrderList.ThisOrder.Find(OrderId);
                //set the thisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record 
                OrderList.Update();
            }

        //redirect back to the listpage
        Response.Redirect("OrderList.aspx"); 
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 OrderId;

        Boolean Found = false;

        OrderId = Convert.ToInt32(txtOrderId.Text);

        Found = AnOrder.Find(OrderId);

        if (Found == true)
        {
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            //chkPaid = AnOrder.IsPaid.ToString();
        }
    }
        void DisplayOrders()
        {
            //create an instance of the Order book
            clsOrderCollection OrderBook = new clsOrderCollection();

            //find the record to update 
            OrderBook.ThisOrder.Find(OrderId);

            //display the data for the record 
            txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
            txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
            txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
            txtShippingAddress.Text = OrderBook.ThisOrder.ShippingAddress;
            chkPaid.Checked = OrderBook.ThisOrder.IsPaid;


        }
    
}