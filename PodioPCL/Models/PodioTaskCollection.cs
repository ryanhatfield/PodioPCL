using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	[Obsolete("This class causes confusion with System.Threading.Tasks.Task. Start using PodioTaskCollection instead.")]
	public class TaskCollection : PodioTaskCollection { }

	public class PodioTaskCollection
	{
		[JsonProperty("total")]
		public int Total { get; set; }

		[JsonProperty("tasks")]
		public List<PodioTask> Tasks { get; set; }
	}
}
