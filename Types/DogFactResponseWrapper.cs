using System.Text.Json.Serialization;

namespace Dogs.Types;
public class DogFactResponseWrapper
{
    [JsonPropertyName("data")]
    public List<DogFactResponse>? Data { get; set; }
}