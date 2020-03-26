using System;
using R.ARC.Core.Business.Application;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using R.ARC.Common.Contract;
using AgileObjects.AgileMapper.Extensions;
using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Helper.Enums;

namespace R.ARC.Web.Api.Controllers
{
    public class TaskController : BaseController<TaskController>
    {
        private readonly IUserTaskApplication _accountApp;

        public TaskController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _accountApp = serviceProvider.GetService<IUserTaskApplication>();
        }

        //[Route("[action]/{id}")]
        //[HttpGet]
        //public async Task<IActionResult> Taskler(int id, [FromQuery]TaskModelType tip, [FromQuery]TaskFilterType filter, [FromQuery]ListParameterModel listParams)
        //{
        //    return Ok(await _accountApp.GetTasksAsync(id, tip, filter, listParams.Map().ToANew<PagedListParameters>()));
        //}

        [Route("{taskId}")]
        [HttpGet]
        public async Task<IActionResult> Get(int taskId)
        {
            return Ok(await _accountApp.GetTaskAsync(taskId));
        }

        [HttpPost]
        public async Task<IActionResult> Post(TaskModel model)
        {
            return Ok(await _accountApp.SaveTaskAsync(model));
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> statu(TaskStatusModel model)
        {
            return Ok(await _accountApp.SaveTaskStatusAsync(model));
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> priority(TaskPriorityModel model)
        {
            return Ok(await _accountApp.SaveTaskPriortyAsync(model));
        }

        [Route("{taskId}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int taskId)
        {
            return Ok(await _accountApp.DeleteTaskAsync(taskId));
        }

    }
}