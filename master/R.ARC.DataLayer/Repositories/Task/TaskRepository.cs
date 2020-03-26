using R.ARC.Core.DataLayer.Context;
using R.ARC.Core.Entity;
using R.ARC.Util.Session;
using System;

namespace R.ARC.Core.DataLayer.Repositories
{
    public sealed class TaskRepository : BaseRepository<TaskEntity>, ITaskRepository
    {
        public TaskRepository(PostgreSContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) { }

    }
}
