using R.ARC.Common.Helper.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R.ARC.Core.Entity
{
    public class BaseEntity : SoftDeleteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        
        [Required]
        public Guid CreatedBy { get; set; }


        [Required]
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;


        public Guid UpdatedBy { get; set; }

       
        public DateTime? UpdateTime { get; set; }

    }
}
