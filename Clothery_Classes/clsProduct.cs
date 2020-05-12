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
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mCost = Convert.ToInt32(DB.DataTable.Rows[0]["Cost"]);
                mStock_Count = Convert.ToInt32(DB.DataTable.Rows[0]["StockCount"]);
                mIs_Available = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mNext_Delivery = Convert.ToDateTime(DB.DataTable.Rows[0]["NextDelivery"]);
                return true;
            }

            else {
                return false;
            }


        }

        public string Valid(int product_ID,string name,string type,string colour,int cost,int stock_Count,string next_Delivery)
        {
            String Error = "";
            DateTime DateTemp;

            if (name.Length == 0)
            {
                Error = Error + "Name cannot be blank   : ";
            }
            if (name.Length > 20)
            {
                Error = Error + "Name Is too long   : ";
            }
            if (type.Length > 20)
            {
                Error = Error + "Type Is too long   : ";
            }
            if (colour.Length > 20)
            {
                Error = Error + "Colour Is too long   : ";
            }

            if (cost < 0)
            { 
                Error = Error + "Cost cannot be negative    : ";
            }
            if (stock_Count < 0)
            {
                Error = Error + "Stock Count cannot be negative   : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(next_Delivery);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past   : ";
                }


            }
            catch
            {
                Error = Error + "The date was not a valid date   : ";
            }
            return Error;
        }
        



        
    }
}