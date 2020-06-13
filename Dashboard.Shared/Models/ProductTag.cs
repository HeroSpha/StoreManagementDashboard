using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class ProductTag
    {
        public int ProductTagId { get; set; }
        public int ProductId { get; set; }
        public string Tag { get; set; }
        public virtual Product Product { get; set; }
    }
}
