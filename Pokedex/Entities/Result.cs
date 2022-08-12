using Newtonsoft.Json;

namespace Pokedex.Entities
{
    public class Result
    {
        [JsonProperty("name")]
        public string namePokemon { get; set; }
        [JsonProperty("url")]
        public string link { get; set; }
    }
}
