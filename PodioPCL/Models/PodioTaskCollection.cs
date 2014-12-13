using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class PodioTaskCollection.
	/// </summary>
	public class PodioTaskCollection
	{
		/// <summary>
		/// Gets or sets the total.
		/// </summary>
		/// <value>The total.</value>
		[JsonProperty("total")]
		public int Total { get; set; }

		/// <summary>
		/// Gets or sets the tasks.
		/// </summary>
		/// <value>The tasks.</value>
		[JsonProperty("tasks")]
		public List<PodioTask> Tasks { get; set; }
	}
}
