using BlazorGetJson.Models;
using Newtonsoft.Json;

namespace BlazorGetJson.Components;

public class JsonFileService
{
    public TotalChatsModel ReadJsonFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<TotalChatsModel>(json);
    }
}
