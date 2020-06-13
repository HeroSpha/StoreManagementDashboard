using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string MemberId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal Amount { get; set; }
        public virtual Member Member { get; set; }
    }
}
