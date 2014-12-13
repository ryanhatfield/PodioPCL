using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	[Obsolete("This class causes confusion with System.Threading.Tasks.Task. Start using PodioTaskReport instead.")]
	public class TaskReport : PodioTaskReport { }

	public class PodioTaskReport
	{
		[JsonProperty("reassigned")]
		public PodioTaskType Reassigned { get; set; }

		[JsonProperty("own")]
		public PodioTaskType Own { get; set; }
	}

	[Obsolete("This class causes confusion with System.Threading.Tasks.Task. Start using PodioTaskType instead.")]
	public class TaskType : PodioTaskType { }

	public class PodioTaskType
	{
		[JsonProperty("completed_yesterday")]
		public int CompletedYesterday { get; set; }

		[JsonProperty("upcoming")]
		public int Upcoming { get; set; }

		[JsonProperty("later")]
		public int Later { get; set; }

		[JsonProperty("tomorrow")]
		public int Tomorrow { get; set; }

		[JsonProperty("today")]
		public int Today { get; set; }

		[JsonProperty("overdue")]
		public int Overdue { get; set; }
	}
}
