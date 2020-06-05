using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace R.ARC.Core.Business
{
    public interface ITaskDomain
    {
        Task<PagedList<TaskBasicModel>> GetTasksAsync(Guid id, TaskModelType tip, TaskFilterType filter, PagedListParameters pagedListParameters);
        Task<Guid> SaveTaskAsync(TaskModel model);
        Task<Guid> DeleteTaskAsync(Guid taskId);
        Task<TaskModel> GetTaskAsync(Guid taskId);
        Task<Guid> SaveTaskStatusAsync(TaskStatusModel model);
        Task<Guid> SaveTaskPriortyAsync(TaskPriorityModel model);
    }
}
