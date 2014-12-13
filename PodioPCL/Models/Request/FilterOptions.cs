using Newtonsoft.Json;

namespace PodioPCL.Models.Request
{
    public class FilterOptions: FilterBase
    {
        /// <summary>
        /// True if the view should be remembered, false otherwise
        /// </summary>
        [JsonProperty("remember", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Remember { get; set; }
    }
}
