namespace BlazorGetJson.Models;

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class DurationModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("request")]
    public Request Request { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("records")]
    public Dictionary<string, Record> Records { get; set; }

    public class Record
    {
        [JsonProperty("agents_chatting_duration")]
        public long AgentsChattingDuration { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }

    public class Request
    {
        [JsonProperty("distribution")]
        public string Distribution { get; set; }

        [JsonProperty("filters")]
        public Filters Filters { get; set; }
    }

    public class Filters
    {
        [JsonProperty("from")]
        public DateTimeOffset From { get; set; }

        [JsonProperty("to")]
        public DateTimeOffset To { get; set; }

        [JsonProperty("groups")]
        public Groups Groups { get; set; }
    }

    public class Groups
    {
        [JsonProperty("values")]
        public List<long> Values { get; set; }
    }
}
