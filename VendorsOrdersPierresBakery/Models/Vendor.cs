using System.Collections.Generic;

namespace VendorsOrdersPierresBakery.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int VendorId { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            // VendorId = _instances.Count;
            // Orders = new List<Order> { };
        }

    }
}