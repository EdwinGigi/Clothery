using System.Linq;
using System.Text;


namespace tstCustomer
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomrID = value;
            }

        }
        private DateTime mCustomerDOB;
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
        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        private Int32 mCustomerHomeNumber;
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
        private mCustomerPostcode
        public string CustomerPostcode
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
        private Boolean mCustomerStatus;
        public bool CustomerStatus
        {
            get
            {
                return mCustomerStatus;
            }
            set
            {
                mCustomerStatus = value;
            }
        }


        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("spoc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.Dataable.rows[0]["CustomerId"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerHomeNumber = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerHomeNumber"]);
                mCustomerPostcode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mCustomerStatus = Convert.ToBoolean(DB.DataTable.Rows)[0]["CustomerStatus"]);
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}



