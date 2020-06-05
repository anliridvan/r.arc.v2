using R.ARC.Common.Helper.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R.ARC.Core.Entity
{
    public class SoftDeleteEntity
    {
        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
