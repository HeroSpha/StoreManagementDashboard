using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products  { get; set; }
    }
}
