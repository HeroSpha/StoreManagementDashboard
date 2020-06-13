using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class OrderItem
    {
        public int OrderItemrId { get; set; }
        public int Quantity { get; set; }
        public int ProductDetailId { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
