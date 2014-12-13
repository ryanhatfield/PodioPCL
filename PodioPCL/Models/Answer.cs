using Newtonsoft.Json;

namespace PodioPCL.Models
{
    public class Answer
    {
        [JsonProperty("question_option_id")]
        public int questionOptionId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
