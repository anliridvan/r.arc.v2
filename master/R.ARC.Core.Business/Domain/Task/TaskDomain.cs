using AgileObjects.AgileMapper.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using R.ARC.Common.Helper.Enums;
using R.ARC.Common.Helper.Models.Exceptions;
using R.ARC.Common.Helper.Paging;
using R.ARC.Core.DataLayer.Repositories;
using R.ARC.Core.DataLayer.UnitOfWork;
using R.ARC.Core.Entity;
using R.ARC.Common.Contract;
using R.ARC.Util.Mapping;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace R.ARC.Core.Business
{
    public class TaskDomain : DomainBase<TaskDomain>, ITaskDomain
    {
        private readonly IDatabaseUnitOfWork _uow;
        private readonly ITaskRepository _taskRep;

        public TaskDomain(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _uow = serviceProvider.GetService<IDatabaseUnitOfWork>();
            _taskRep = serviceProvider.GetService<ITaskRepository>();
        }

        public async Task<PagedList<TaskBasicModel>> GetTasksAsync(Guid id, TaskModelType tip,
                                                                TaskFilterType filter, PagedListParameters pagedListParameters)
        {
            IQueryable<TaskEntity> querable = _taskRep.Queryable;

            if (tip > 0)
            {
                querable = querable.Where(m => m.TaskModelType == tip);
            }

            if (id != null && id != Guid.Empty && tip != TaskModelType.Default)
            {
                switch (tip)
                {
                    //case TaskModelType.Analysis:
                    //    querable = querable.Where(m => m.AccountId == id);
                    //    break;
                    //case TaskModelType.Development: 
                    //    querable = querable.Where(m => m.OpportunityId == id);
                    //    break;
                    //case TaskModelType.Issue:  
                    //    querable = querable.Where(m => m.IssueId == id);
                    //    break;
                    //default:
                    //    break;
                }
            }
            else
            {
                // Ihtiyac yok su an icin
            }

            switch (filter)
            {
                //case TaskFilterType.AllTasks:
                //    break;
                //case TaskFilterType.UserTasks:
                //    // querable = querable.Where(m => EF.Functions.Like("," + m.ResponsiblesStr + ",", "," + SessionManager.UserName + ",")); ? 
                //    querable = querable.Where(m => ( "," + m.ResponsiblesStr + ",").Contains("," + SessionManager.UserName + ","));
                //    break;
                //case TaskFilterType.Completed:
                //    querable = querable.Where(m => m.TaskStatus == Common.Helper.Enums.TaskStatus.Tamamlandi);
                //    break;
                //case TaskFilterType.Waiting:
                //    querable = querable.Where(m => m.TaskStatus == Common.Helper.Enums.TaskStatus.Baslamadi);
                //    break;
                //case TaskFilterType.InProggress:
                //    querable = querable.Where(m => m.TaskStatus == Common.Helper.Enums.TaskStatus.DevamEdiyor);
                //    break;
                //case TaskFilterType.WaitingForAnotherTask:
                //    querable = querable.Where(m => m.TaskStatus == Common.Helper.Enums.TaskStatus.Bekleniyor);
                //    break;
                //case TaskFilterType.Postphoned:
                //    querable = querable.Where(m => m.TaskStatus == Common.Helper.Enums.TaskStatus.Ertelendi);
                //    break;
            }

            return await Task.FromResult(new PagedList<TaskBasicModel>(querable.Project<TaskEntity, TaskBasicModel>(), pagedListParameters));
        }


        public async Task<TaskModel> GetTaskAsync(Guid taskId)
        {
            return await _taskRep.FirstOrDefaultAsync<TaskModel>(m => m.Id == taskId);
        }

        public async Task<Guid> SaveTaskAsync(TaskModel model)
        {
            TaskEntity taskEntity = await _taskRep.FirstOrDefaultWithDeletedAsync(m => m.Id == model.Id);

            using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction trs = await _uow.BeginTransactionAsync())
            {
                if (taskEntity == null)
                {
                    //yeni kayit
                    taskEntity = Mapper.Map<TaskModel, TaskEntity>(model);

                    await _taskRep.AddAsync(taskEntity);
                    await _uow.SaveChangesAsync();

                    trs.Commit();
                }
                else
                {
                    //güncelleme
                    Mapper.Map(model, taskEntity);

                    taskEntity.IsDeleted = false;

                    await _taskRep.UpdateAsync(taskEntity);
                    await _uow.SaveChangesAsync();

                    trs.Commit();
                }
            }

            return taskEntity.Id;
        }

        public async Task<Guid> SaveTaskStatusAsync(TaskStatusModel model)
        {
            TaskEntity taskEntity = await _taskRep.FirstOrDefaultWithDeletedAsync(m => m.Id == model.Id);

            using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction trs = await _uow.BeginTransactionAsync())
            {

                if (taskEntity != null)
                {
                    //güncelleme
                    Mapper.Map(model, taskEntity);
                    taskEntity.TaskStatus = model.TaskStatus;
                    taskEntity.IsDeleted = false;

                    await _taskRep.UpdateAsync(taskEntity);
                    await _uow.SaveChangesAsync();

                    trs.Commit();
                }
                else
                {
                    throw new NotFoundException("Task", model.Id);
                }
            }

            return taskEntity.Id;
        }

        public async Task<Guid> SaveTaskPriortyAsync(TaskPriorityModel model)
        {
            TaskEntity taskEntity = await _taskRep.FirstOrDefaultWithDeletedAsync(m => m.Id == model.Id);

            using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction trs = await _uow.BeginTransactionAsync())
            {

                if (taskEntity != null)
                {
                    //güncelleme
                    Mapper.Map(model, taskEntity);
                    taskEntity.TaskPriority = model.TaskPriority;
                    taskEntity.IsDeleted = false;

                    await _taskRep.UpdateAsync(taskEntity);
                    await _uow.SaveChangesAsync();

                    trs.Commit();
                }
                else
                {
                    throw new NotFoundException("Task", model.Id);
                }
            }

            return taskEntity.Id;
        }

        public async Task<Guid> DeleteTaskAsync(Guid taskId)
        {
            TaskEntity taskEntity = await _taskRep.FirstOrDefaultAsync(m => m.Id == taskId);

            if (taskEntity != null)
            {
                await _taskRep.DeleteAsync(m => m.Id == taskId);
                await _uow.SaveChangesAsync();
                return taskEntity.Id;
            }

            return Guid.Empty;
        }
    }
}
