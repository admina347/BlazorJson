namespace BlazorGetJson.Models;

using System.Collections.Generic;
using Newtonsoft.Json;

public class Record
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