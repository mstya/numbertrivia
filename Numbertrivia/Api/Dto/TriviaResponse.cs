using Newtonsoft.Json;

namespace Api.Controllers
{
    public class TriviaResponse 
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}