using Newtonsoft.Json;
using Pokedex.Entities;

public class Root
{
    [JsonProperty("count")]
    public int quantidade { get; set; }

    [JsonProperty("next")]
    public object proximo { get; set; }

    [JsonProperty("previous")]
    public object anterior { get; set; }

    [JsonProperty("results")]
    public List<Result> resultado { get; set; }
}