using System;

namespace Clothery_Classes
{
    public class clsSupplier
    {
        private Int32 mSupplier_ID;
        private DateTime mDeliveryDate;
        private String mSupplierName;
        private Boolean mStockAvailable;
        private String mSupplierAddress;
        private String mSupplierPostCode;
        private String mDescription;

        public int Supplier_ID {
            get
            {
                return mSupplier_ID;
            }
            set
            {
                mSupplier_ID = value;
            }
        }

        public string SupplierName {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        public string SupplierAddress {
            get
            {
                return mSupplierAddress;
            }
            set
            {
                mSupplierAddress = value;
            }
        }
        public string SupplierPostCode {
            get
            {
                return mSupplierPostCode;
            }
            set
            {
                mSupplierPostCode = value;
            }
        }
        public string Description {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value; ;
            }
        }

        public bool StockAvailable {
            get
            {
                return mStockAvailable;
            }
            set
            {
                mStockAvailable = value;
            }
        }
        public DateTime DeliveryDate {
            get
            {
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }

        public bool Find(int Supplier_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the supplier id to search for
            DB.AddParameter("@Supplier_ID", Supplier_ID);
            //execute the store procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplier_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_ID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierPostCode = Convert.ToString(DB.DataTable.Rows[0]["SupplierPostCode"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mStockAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailable"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                // return everything that worked as true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }


}