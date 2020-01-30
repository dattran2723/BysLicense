using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class LoginDetail
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }

        public string UserName { get; set; }

        public string IPAddress { get; set; }

        public string PCName { get; set; }
        
        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}
