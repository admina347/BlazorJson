namespace BlazorGetJson.Models;

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class TagsModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("request")]
    public Request Request { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("records")]
    public Dictionary<string, Dictionary<string, int>> Records { get; set; }
}
