using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class City
    {
        public City()
        {
            Suburbs = new HashSet<Suburb>();
        }
        public int CityId { get; set; }
        public string Name { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Suburb> Suburbs { get; set; }
    }
}
