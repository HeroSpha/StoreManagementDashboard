using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dashboard.Shared.Models
{
    public class Brand
    {
        public Brand()
        {
            ProductDetails = new HashSet<ProductDetail>();
            
        }   
        public int BrandId { get; set; }
        public string Name { get; set; }
        public virtual  ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
