using System.Text.Json.Serialization;

namespace Dogs.Types;
public class DogFact
{
    [JsonPropertyName("body")]
    public required string Body { get; set; }
}