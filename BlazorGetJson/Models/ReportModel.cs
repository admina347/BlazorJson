namespace BlazorGetJson.Models;

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public partial class ReportsModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("request")]
    public Request Request { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("records")]
    public Dictionary<string, Record> Records { get; set; }
    //public Dictionary<string, Dictionary<string, Record>> Records { get; set; }
    //public Dictionary<string, Dictionary<string, int>> Records { get; set; }
}

public partial class Record
{
    [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
    public long? Total { get; set; }

    [JsonProperty("agents_chatting_duration", NullValueHandling = NullValueHandling.Ignore)]
    public long? AgentsChattingDuration { get; set; }

    [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
    public long? Count { get; set; }

    [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
    public long? Duration { get; set; }

    [JsonProperty("bad", NullValueHandling = NullValueHandling.Ignore)]
    public long? Bad { get; set; }

    [JsonProperty("chats", NullValueHandling = NullValueHandling.Ignore)]
    public long? Chats { get; set; }

    [JsonProperty("good", NullValueHandling = NullValueHandling.Ignore)]
    public long? Good { get; set; }

    [JsonProperty("response_time", NullValueHandling = NullValueHandling.Ignore)]
    public double? ResponseTime { get; set; }

    public Dictionary<string, int>? Tag { get; set; }
}


public partial class Request
{
    [JsonProperty("distribution")]
    public string Distribution { get; set; }

    [JsonProperty("filters")]
    public Filters Filters { get; set; }
}

public partial class Filters
{
    [JsonProperty("from")]
    public DateTimeOffset From { get; set; }

    [JsonProperty("to")]
    public DateTimeOffset To { get; set; }

    [JsonProperty("groups")]
    public Groups Groups { get; set; }
}

public partial class Groups
{
    [JsonProperty("values")]
    public List<long> Values { get; set; }
}
