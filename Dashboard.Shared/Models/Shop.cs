using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string HeadQuarters { get; set; }
        public string Address { get; set; }
        public string BusinessPhone { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
