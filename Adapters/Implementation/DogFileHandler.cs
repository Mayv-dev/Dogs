using System.Text.Json;
using Dogs.Types;

namespace Dogs.Adapters.Implementations;

public class DogFileHandler : IFileAdapter
{
    public void WriteToFile(DogFileContent content)
    {
        var contentStr = JsonSerializer.Serialize(content);
        var path = "./";

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "Dogs.json")))
        {
            outputFile.WriteLine(contentStr);
        }
    }

    public DogFileContent ReadFromFile()
    {
        using StreamReader reader = new("Dogs.json");
        string content = reader.ReadToEnd();

        return JsonSerializer.Deserialize<DogFileContent>(content);
    }
}