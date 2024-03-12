namespace BlazorGetJson.Models;

using Newtonsoft.Json;

public class Request
{
    [JsonProperty("distribution")]
    public string Distribution { get; set; }

    [JsonProperty("filters")]
    public Filters Filters { get; set; }
}