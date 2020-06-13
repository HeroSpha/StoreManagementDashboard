using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class Member
    {
        public string MemberId { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
