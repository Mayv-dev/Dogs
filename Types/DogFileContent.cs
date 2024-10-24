using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dogs.Types;

public class DogFileContent
{
    [JsonPropertyName("imageurl")]
    public string ImageUrl { get; set; }
    [JsonPropertyName("fact")]
    public string Fact { get; set; }

    public DogFileContent(string ImageUrl, string Fact)
    {
        this.ImageUrl = ImageUrl;
        this.Fact = Fact;
    }
}