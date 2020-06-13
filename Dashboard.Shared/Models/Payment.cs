using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int CreditCardId { get; set; }
        public virtual Order Order { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
