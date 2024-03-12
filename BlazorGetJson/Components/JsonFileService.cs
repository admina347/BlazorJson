using System.IO;
using Newtonsoft.Json;

namespace BlazorGetJson.Components
{
    public class JsonFileService
    {
        public T ReadJsonFile<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
