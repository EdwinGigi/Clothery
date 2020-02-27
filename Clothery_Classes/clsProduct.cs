using System;

namespace Clothery_Classes
{
    public class clsProduct
    {

        private Int32 mProduct_ID;
        public Int32 Product_ID
        {
            get
            {
                return mProduct_ID;
            }

            set
            {
                mProduct_ID = value;
            }

        }
        private string mName;
        public string Name {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
           }
        private string mType;
        public string Type
        {
            get
            {
                return mType;
            }

            set
            {
                mType = value;
            }
        }
        private string mColour;
        public string Colour
        {
            get
            {
                return mColour;
            }

            set
            {
                mColour = value;
            }
        }
        private int mCost;
        public int Cost
        {
            get
            {
                return mCost;
            }

            set
            {
                mCost = value;
            }
        }
        private int mStock_Count;
        public int Stock_Count
        {
            get
            {
                return mStock_Count;
            }

            set
            {
                mStock_Count = value;
            }
        }
        private bool mIs_Available;
        public bool Is_Available
        {
            get
            {
                return mIs_Available;
            }

            set
            {
                mIs_Available = value;
            }
        }
        private DateTime mNext_Delivery;
        public DateTime Next_Delivery
        {
            get
            {
                return mNext_Delivery;
            }

            set
            {
                mNext_Delivery = value;
            }
        }

        public bool Find(int product_ID)
        {
            mProduct_ID = 21;
            mName = "Dave";
            mType = "Cape";
            mColour = "yellow";
            mCost = 12;
            mStock_Count = 12;
            mIs_Available = false;
            mNext_Delivery = Convert.ToDateTime("27/02/2021");
            //always return true
            return true;

        }
    }
}