using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Utils
{
	/// <summary>
	/// Class PodioCollection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public class PodioCollection<T>
    {
        /// <summary>
        /// Total number of items in the app
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        /// <summary>
        /// Count of items with the current filter applied
        /// </summary>
        [JsonProperty(PropertyName = "filtered")]
        public int Filtered { get; set; }

		/// <summary>
		/// Gets or sets the items.
		/// </summary>
		/// <value>The items.</value>
        [JsonProperty(PropertyName = "items")]
        public IEnumerable<T> Items { get; set; }
    }
}
