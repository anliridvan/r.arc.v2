using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business.Application
{
    public interface IUserTaskApplication
    {
        Task<IEnumerable<AddressBasicModel>> GetAddressesAsync(Guid userId);
        Task<Guid> SaveAddressAsync(AddressModel model);
        Task<Guid> DeleteAddressAsync(Guid addressId);

        Task<PagedList<TaskBasicModel>> GetTasksAsync(Guid id, TaskModelType tip, TaskFilterType filter, PagedListParameters pagedListParameters);
        Task<Guid> SaveTaskAsync(TaskModel model);
        Task<Guid> DeleteTaskAsync(Guid taskId);
        Task<Guid> SaveTaskStatusAsync(TaskStatusModel model);
        Task<Guid> SaveTaskPriortyAsync(TaskPriorityModel model);

        Task<TaskModel> GetTaskAsync(Guid taskId);
    }
}
