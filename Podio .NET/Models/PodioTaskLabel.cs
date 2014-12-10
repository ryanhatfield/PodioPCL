using Newtonsoft.Json;
using System;

namespace PodioAPI.Models
{
	[Obsolete("This class causes confusion with System.Threading.Tasks.Task. Start using PodioTaskLabel instead.")]
	public class TaskLabel : PodioTaskLabel { }

	public class PodioTaskLabel
	{
		[JsonProperty("label_id")]
		public int LabelId { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }

		[JsonProperty("color")]
		public string Color { get; set; }
	}
}
