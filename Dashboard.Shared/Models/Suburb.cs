using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Suburb
    {
        public Suburb()
        {
            Extensions = new HashSet<Extension>();
        }
        public int SuburbId { get; set; }
        public string Name { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Extension> Extensions { get; set; }
    }
}
