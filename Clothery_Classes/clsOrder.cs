using System;

namespace Clothery_Classes
{
    public class clsOrder
    {
        private Int32 mOrderId;
        private DateTime mOrderDate;
        private Int32 mCustomerId;
        private Boolean mIsPaid;
        private String mShippingAddress;


        public bool IsPaid
        {
            get
            {
                return mIsPaid;
            }
            set
            {
                mIsPaid = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        
        public Int32 OrderId
        {
               get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }

        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        public string ShippingAddress
        {
            get
            {
                return mShippingAddress;
            }
            set
            {
                mShippingAddress = value;
            }
        }


        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tbl_Order_FilterByOrderId");

            if(DB.Count ==1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                return true;
            }
            else
            {
                return false;
            }
        }
       public string Valid(string Shippingaddress, string Orderdate, string Customerid)
                           
            ///this function accepts 3 parameters for validation 
            ///this function returns a string containing error message 
            ///if no errors found, blank string is returned
        {
            //string variable to store the error
            String Error = "";
            //temporary variable to store date values
            DateTime DateTemp;

            if (Shippingaddress.Length ==0)
            {
                Error = Error + "Shipping Address can not be blank : ";
            }
            if (Shippingaddress.Length > 50)
            {
                Error = Error + "Shipping Address should be less than 50characters";
            }

            try
            {
                DateTemp = Convert.ToDateTime(Orderdate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            //Return any error messages
            return Error;
        }

   

    }
  
    
}