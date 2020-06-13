using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Product
    {
        public Product()
        {
            ProductTags = new HashSet<ProductTag>();
            ProductDetails = new HashSet<ProductDetail>();
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
        public DateTime DateModified { get; set; }
        public virtual Branch Branch { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
