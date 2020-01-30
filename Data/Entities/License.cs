using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class License
    {
        [Key]
        public Guid ProjectId { get; set; }

        public bool IsActive { get; set; }

        public int WorkingMode { get; set; }

        public long TransactionTime { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}
