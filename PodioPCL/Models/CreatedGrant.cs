using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
    public class CreatedGrant
    {
        [JsonProperty("invitable")]
        public List<User> Profiles { get; set; }
    }
}
