using Newtonsoft.Json;

namespace PodioPCL.Models
{
    public class Seat
    {
        [JsonProperty("employee")]
        public string Employee { get; set; }

        [JsonProperty("external")]
        public string External { get; set; }
    }
}
