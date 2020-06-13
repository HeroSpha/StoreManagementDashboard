using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dashboard.Shared.Models
{
    public class BranchRating
    {
        [Key]
        public int BranchRatingId { get; set; }
        public int Rating { get; set; }
        public int BranchId { get; set; }
        public string Comment { get; set; }
        public virtual Branch Branch { get; set; }
        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual Member Member { get; set; }
    }
}
