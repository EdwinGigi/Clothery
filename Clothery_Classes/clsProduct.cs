using System;

namespace Clothery_Classes
{
    public class clsProduct
    {
        public int Product_ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Colour { get; set; }
        public int Cost { get; set; }
        public int Stock_Count { get; set; }
        public bool Is_Available { get; set; }
        public DateTime Next_Delivery { get; set; }
    }
}