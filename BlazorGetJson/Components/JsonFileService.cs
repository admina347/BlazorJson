using BlazorGetJson.Models;
using Newtonsoft.Json;

namespace BlazorGetJson.Components;

public class JsonFileService
{
    public ReportsModel ReadJsonFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<ReportsModel>(json);
    }
}
