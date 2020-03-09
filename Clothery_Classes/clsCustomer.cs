using Clothery_Classes;
using System;

namespace tstCustomer
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        private string mCustomerName;
        private DateTime mCustomerDOB;
        private Boolean mCustomerOnlineStatus;
        private int mCustomerHomeNumber;
        private int mCustomerPostcode;

        public bool CustomerOnlineStatus
        {
            get
            {
                return mCustomerOnlineStatus;
            }
            set
            {
                mCustomerOnlineStatus = value;
            }
        }
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
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

        public int CustomerHomeNumber
        {
            get
            {
                return mCustomerHomeNumber;
            }
            set
            {
                mCustomerHomeNumber = value;
            }
        }
        public int CustomerPostcode
        {
            get
            {
                return mCustomerPostcode;
            }
            set
            {
                mCustomerPostcode = value;
            }
        }
        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tbl_Order_FilterByCustomerId");

            if (DB.Count == 1)

            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerOnlineStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerOnlineStatus"]);
                mCustomerHomeNumber = Convert.ToInt16(DB.DataTable.Rows[0]["CustomerHomeNumber"]);
                mCustomerPostcode = Convert.ToInt16(DB.DataTable.Rows[0]["CustomerPostcode"]);
                return true;
            }
            else
            {
                return false;
            }
        }
  
    }
}