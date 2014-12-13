using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
    public class AppValues
    {
        [JsonProperty(PropertyName = "fields")]
        public List<ItemField> Fields { get; set; }

        [JsonProperty(PropertyName = "created_bys")]
        public List<ByLine> CreatedBys { get; set; }

        [JsonProperty(PropertyName = "created_vias")]
        public List<Via> CreatedVias { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; }
    }
}
