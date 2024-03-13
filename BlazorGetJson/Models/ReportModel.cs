namespace BlazorGetJson.Models;

using System.Collections.Generic;
using Newtonsoft.Json;

public class ReportsModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("request")]
    public Request Request { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("records")]
    public Dictionary<string, Record> Records { get; set; }
}