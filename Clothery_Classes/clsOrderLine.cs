using System;
namespace Clothery_Classes
{
    public class clsOrderLine
    {
        private Boolean mShipped;
        private String mDescription;
        private String mSize;
        private Double mPrice;
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
        public double Price
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



    }
}