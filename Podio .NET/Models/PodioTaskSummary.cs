using Newtonsoft.Json;
using System;

namespace PodioAPI.Models
{
	[Obsolete("This class causes confusion with System.Threading.Tasks.Task. Start using PodioTaskSummary instead.")]
	public class TaskSummary : PodioTaskSummary { }

	public class PodioTaskSummary
	{
		[JsonProperty("other")]
		public PodioTaskCollection Other { get; set; }

		[JsonProperty("today")]
		public PodioTaskCollection Today { get; set; }

		[JsonProperty("overdue")]
		public PodioTaskCollection Overdue { get; set; }
	}
}
