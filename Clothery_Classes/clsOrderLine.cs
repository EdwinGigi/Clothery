using System;
namespace Clothery_Classes
{
    public class clsOrderLine
    {
        private Boolean mShipped;
        private String mDescription;
        private String mSize;
        private Int32 mPrice;
        private Int32 mQuantity;
        private Int32 mProductId;
        private Int32 mOrderId;
        private Int32 mOrderLineId;

        public bool Shipped
        {
            get
            {
                return mShipped;
            }
            set
            {
                mShipped = value;
            }
        }

        public string Description
        {
            get 
            {
                return mDescription;

            }
            set
            {
                mDescription = value;
            }
        }
        public string Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }
        public Int32 Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public Int32 ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
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
        public Int32 OrderLineId
        {
            get
            {
                return mOrderLineId;
            }
            set
            {
                mOrderLineId = value;
            }
        }

        public bool Find(int OrderLineId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineId", OrderLineId);
            DB.Execute("sproc_tbl_OrderLine_FilterByOrderLineId");

            if (DB.Count == 1)
            {
                mOrderLineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quanity"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["Shipped"]);
              
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}