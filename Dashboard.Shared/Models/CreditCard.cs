using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public string Number { get; set; }
        public string CVS { get; set; }
        public string MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}
