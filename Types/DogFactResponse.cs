using System.Text.Json.Serialization;

namespace Dogs.Types;
public class DogFactResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("attributes")]
    public required DogFact Attirbutes { get; set; }
}