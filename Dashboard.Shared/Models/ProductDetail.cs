using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class ProductDetail
    {
        public ProductDetail()
        {
            OrderItems = new HashSet<OrderItem>();
        }
        public int ProductDetailId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
