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


        public bool Find(int Product_ID)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductID", Product_ID);

            DB.Execute("sproc_tblProduct_FilterByProductID");

            if (DB.Count == 1)
            {
                mProduct_ID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mType = Convert.ToString(DB.DataTable.Rows[0]["Type"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Cost"]);
                mCost = Convert.ToInt32(DB.DataTable.Rows[0]["Colour"]);
                mStock_Count = Convert.ToInt32(DB.DataTable.Rows[0]["StockCount"]);
                mIs_Available = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mNext_Delivery = Convert.ToDateTime(DB.DataTable.Rows[0]["NextDelivery"]);
                return true;
            }

            else { 
                return false;
            }

        }
        
    }
}