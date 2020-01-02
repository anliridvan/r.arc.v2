using R.ARC.Core.DataAccess.Context;
using R.ARC.Core.Entity;
using R.ARC.Util.Session;
using System;

namespace R.ARC.Core.DataAccess.Repositories
{
    public sealed class TaskRepository : BaseRepository<TaskEntity>, ITaskRepository
    {
        public TaskRepository(DatabaseContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) { }

    }
}
