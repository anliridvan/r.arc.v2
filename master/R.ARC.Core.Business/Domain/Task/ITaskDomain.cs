using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business
{
    public interface ITaskDomain
    {
        Task<PagedList<TaskBasicModel>> GetTasksAsync(int id, TaskModelType tip, TaskFilterType filter, PagedListParameters pagedListParameters);
        Task<int> SaveTaskAsync(TaskModel model);
        Task<int> DeleteTaskAsync(int taskId);
        Task<TaskModel> GetTaskAsync(int taskId);
        Task<int> SaveTaskStatusAsync(TaskStatusModel model);
        Task<int> SaveTaskPriortyAsync(TaskPriorityModel model);
    }
}
