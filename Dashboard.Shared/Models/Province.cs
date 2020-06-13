using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
    }
}
