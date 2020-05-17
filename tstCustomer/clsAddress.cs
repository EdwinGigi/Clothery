using System;

namespace tstCustomer
{
    internal class clsAddress
    {
        public string AddressNo { get; internal set; }

        public static implicit operator clsAddress(clsCustomer v)
        {
            throw new NotImplementedException();
        }

        internal string Valid(Func<string> customerHomeNumber, object customerPostCode, Action customerDOB, Action customerAddress)
        {
            throw new NotImplementedException();
        }
    }
}