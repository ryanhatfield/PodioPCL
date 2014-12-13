using Newtonsoft.Json;

namespace PodioPCL.Models
{
    public class Range
    {
        [JsonProperty("max")]
        public float Min { get; set; }
        [JsonProperty("min")]
        public float Max { get; set; }  
    }
}
