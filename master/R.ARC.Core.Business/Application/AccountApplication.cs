using Microsoft.Extensions.DependencyInjection;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business.Application
{
    public class AccountApplication : ApplicationBase<AccountApplication>, IUserTaskApplication
    {
        private readonly IAddressDomain _addressDom;
        private readonly ITaskDomain _taskDom;

        public AccountApplication(IServiceProvider serviceProvider) : base(serviceProvider)
        {

            _addressDom = serviceProvider.GetService<IAddressDomain>();
            _taskDom = serviceProvider.GetService<ITaskDomain>();
        }



        public Task<PagedList<TaskBasicModel>> GetTasksAsync(int id, TaskModelType tip, TaskFilterType filter, PagedListParameters pagedListParameters)
        {
            return _taskDom.GetTasksAsync(id, tip, filter, pagedListParameters);
        }

        public Task<TaskModel> GetTaskAsync(int taskId)
        {
            return _taskDom.GetTaskAsync(taskId);
        }

        public Task<int> SaveTaskAsync(TaskModel model)
        {
            return _taskDom.SaveTaskAsync(model);
        }

        public Task<int> SaveTaskStatusAsync(TaskStatusModel model)
        {
            return _taskDom.SaveTaskStatusAsync(model);
        }

        public Task<int> SaveTaskPriortyAsync(TaskPriorityModel model)
        {
            return _taskDom.SaveTaskPriortyAsync(model);
        }

        public Task<int> DeleteTaskAsync(int taskId)
        {
            return _taskDom.DeleteTaskAsync(taskId);
        }


        public Task<IEnumerable<AddressBasicModel>> GetAddressesAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAddressAsync(AddressModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAddressAsync(int addressId)
        {
            throw new NotImplementedException();
        }
    }
}
