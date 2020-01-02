using R.ARC.Common.Helper.Enums;
using System;
using System.Collections.Generic;

namespace R.ARC.Common.Contract
{
    public class TaskModel : BaseModel
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

        public List<string> Responsibles { get; set; } = new List<string>();

    }
}
