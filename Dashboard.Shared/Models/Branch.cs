using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WhatsappNumner { get; set; }
        public virtual Extension Extension { get; set; }
        public virtual ICollection<BranchPhoneNumber> BranchPhoneNumbers  { get; set; }
    }
}
