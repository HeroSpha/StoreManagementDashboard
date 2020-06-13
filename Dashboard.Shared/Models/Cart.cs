using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string MemberId { get; set; }
        public int ProductDetailId { get; set; }
        public int Quantity { get; set; }
        public virtual Member Member { get; set; }
    }
}
