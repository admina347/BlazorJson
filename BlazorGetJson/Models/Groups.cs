namespace BlazorGetJson.Models;

using System.Collections.Generic;
using Newtonsoft.Json;

public class Groups
{
    [JsonProperty("values")]
    public List<long> Values { get; set; }
}
