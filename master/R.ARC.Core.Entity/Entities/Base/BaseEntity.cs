using R.ARC.Common.Helper.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R.ARC.Core.Entity
{
    public class BaseEntity: SoftDeleteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [IgnoreMapping]
        [Required]
        public string CreatedBy { get; set; }

        [IgnoreMapping]
        [Required]
        public DateTime CreationTime { get; set; }

        [IgnoreMapping]
        public string UpdatedBy { get; set; }

        [IgnoreMapping]
        public DateTime? UpdateTime { get; set; }

    }
}
