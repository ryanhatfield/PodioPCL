using Newtonsoft.Json;
namespace PodioPCL.Models
{
    public class Tag
    {
        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
