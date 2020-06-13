using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class MemberFavorite
    {
        public int MemberFavoriteId { get; set; }
        public string MemberId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Member Member { get; set; }
    }
}
