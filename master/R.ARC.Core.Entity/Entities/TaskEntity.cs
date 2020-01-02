using R.ARC.Common.Helper.Attributes;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace R.ARC.Core.Entity
{
    public class TaskEntity : BaseExtendedEntity<TaskExt>
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string AdditionalInfo { get; set; }

        public TaskPriority TaskPriority { get; set; }

        public TaskType TaskType { get; set; }

        public TaskStatus TaskStatus { get; set; }

        public TaskModelType TaskModelType { get; set; }

    }
}
