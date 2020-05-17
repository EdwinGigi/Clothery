using System;
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
        private int mCustomrID;
        private string mCustomerPostcode;
        internal int Active;

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

        public DateTime DateTemp { get; private set; }
        public DateTime DateAdded { get; internal set; }
        public string PostCode { get; internal set; }
        public string Town { get; internal set; }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("spoc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.rows[0]["CustomerId"]);
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
        public string Valid(string CustomerHomeNumber, string CustomerPostCode, string CustomerDOB, string CustomerAddress)
        {
            string Error = "";
            if (CustomerHomeNumber.Length == 0)
            {
                Error = Error + "the house number may not be blank;";
            }
            if (CustomerHomeNumber.Length > 6)
            {
                Error = Error + "the house number must be less than 6 numbers;";
            }
            DateTemp = Convert.ToDateTime(CustomerDOB);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "the date cannot be in the past: ";
            }
            if (DateTemp> DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (CustomerPostCode.Length == 0)
            {
                Error = Error + "The post code may not be blank : ";
            }
            if (CustomerAddress.Length == 0)
            {
                Error = Error + "The street may not be blank : ";
            }
            if (CustomerAddress.Length > 50)
            {
                Error = Error + "The street must be less than 50 characters : ";
            }
                return Error; 
        }

        internal bool Find(object customersID)
        {
            throw new NotImplementedException();
        }

        public static implicit operator clsCustomer(clsAddress v)
        {
            throw new NotImplementedException();
        }

        internal string Valid(Action customerHomeNumber, object customerPostCode, string customerDOB, Action customerAddress)
        {
            throw new NotImplementedException();
        }

        internal string Valid(Action customerHomeNumber, object customerPostCode, Action customerDOB, Action customerAddress)
        {
            throw new NotImplementedException();
        }
    }
    
    public clsCustomerCollection()
    {
        clsCustomer TestItem = new clsCustomer();
        TestItem.CustomerStatus = true;
        TestItem.CustomerID = 1;
        TestItem.CustomerDOB = DateTime.Now.Date;
        TestItem.CustomerAddress = "aaaaaaa";
        TestItem.CustomerHomeNumber = "323w";
        TestItem.CustomerPostcode = "le4 5es";
        mCustomerList.(TestItem);
        TestItem = new clsCustomer();
        TestItem.CustomerStatus = true;
        TestItem.CustomerID = 1;
        TestItem.CustomerDOB = DateTime.Now.Date;
        TestItem.CustomerAddress = "aaaaaaa";
        TestItem.CustomerHomeNumber = "323w";
        TestItem.CustomerPostcode = "le4 5es";
        mCustomerList.(TestItem);
    }

    internal class mCustomerList
    {
    }

}



