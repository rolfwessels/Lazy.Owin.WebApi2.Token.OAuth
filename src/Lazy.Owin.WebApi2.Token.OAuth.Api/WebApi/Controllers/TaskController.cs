using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Lazy.Owin.WebApi2.Token.OAuth.Api.WebApi.Controllers
{
	/// <summary>
	///     Api controller for managing all the tasks
	/// </summary>
	public class TaskController : ApiController

	{
		private readonly List<TaskModel> _taskModels;

		public TaskController()
		{
			_taskModels = new List<TaskModel>();
			Post(new TaskModel {Name = "Add type scripts"});
		}

		/// <summary>
		///     Returns list of all the tasks
		/// </summary>
		/// <returns>
		/// </returns>
		[Route(RouteHelper.TaskController)]
		public List<TaskModel> Get()
		{
			return _taskModels;
		}

		/// <summary>
		///     Updates an instance of the task item
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <param name="model">The model.</param>
		/// <returns>
		/// </returns>
		[Route(RouteHelper.TaskController)]
		public TaskModel Put(int id, TaskModel model)
		{
			TaskModel taskModels = _taskModels.FirstOrDefault(x => x.Id == id);

			if (taskModels != null)
			{
				taskModels.Name = model.Name;
			}
			return taskModels;
		}

		/// <summary>
		///     Create an instance of an item
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns>
		/// </returns>
		[Route(RouteHelper.TaskController)]
		public TaskModel Post(TaskModel model)
		{
			model.Id = _taskModels.Count;
			_taskModels.Add(model);
			return model;
		}

		/// <summary>
		///     Deletes the specified task.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>
		/// </returns>
		[Route(RouteHelper.TaskController)]
		public int Delete(int id)
		{
			TaskModel[] taskModels = _taskModels.Where(x => x.Id == id).ToArray();
			foreach (var taskModel in taskModels)
			{
				_taskModels.Remove(taskModel);
			}
			return taskModels.Count();
		}

		#region Nested type: TaskModel

		public class TaskModel
		{
			public int Id { get; set; }
			public string Name { get; set; }
		}

		#endregion
	}
}