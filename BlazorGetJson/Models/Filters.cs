namespace BlazorGetJson.Models;

using System;
using Newtonsoft.Json;

public class Filters
{
    [JsonProperty("from")]
    public DateTimeOffset From { get; set; }

    [JsonProperty("to")]
    public DateTimeOffset To { get; set; }

    [JsonProperty("groups")]
    public Groups Groups { get; set; }
}