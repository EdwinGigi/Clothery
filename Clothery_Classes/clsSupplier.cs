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
                mSupplierAddress= value;
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
    }
}