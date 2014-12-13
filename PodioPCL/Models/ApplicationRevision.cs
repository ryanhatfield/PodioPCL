using Newtonsoft.Json;

namespace PodioPCL.Models
{
    public class ApplicationRevision
    {
        [JsonProperty("revision")]
        public string Revision { get; set; }
    }
}
