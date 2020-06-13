using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Extension
    {
        public Extension()
        {
            Branches = new HashSet<Branch>();
        }
        public int ExtentionId { get; set; }
        public string Name { get; set; }
        public virtual Suburb Suburb { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
