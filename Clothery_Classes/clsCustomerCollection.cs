namespace Clothery_Classes
{
    public class clsCustomerCollection
    {
        public int Count { get; set; }
        public global::tstCustomer.clsCustomer ThisCustomer { get; set; }
        internal global::tstCustomer.List<global::tstCustomer.clsCustomer> CustomerList { get; public set; }
    }
}