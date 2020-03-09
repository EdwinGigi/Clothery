using System;

namespace Clothery_Classes
{
    public class clsSupplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPostCode { get; set; }
        public string Description { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool StockAvailable { get; set; }
    }
}