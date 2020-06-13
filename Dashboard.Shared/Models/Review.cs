using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
