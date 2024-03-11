using Newtonsoft.Json;

namespace BlazorGetJson.Models;

public partial class TotalChatsModel
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

public partial class Record
{
    [JsonProperty("total")]
    public long Total { get; set; }
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

