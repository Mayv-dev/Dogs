using System.Text.Json.Serialization;

namespace Dogs.Types;
class DogImageResponse
{
    [JsonPropertyName("fileSizeBytes")]
    public int FileSize { get; set; }
    [JsonPropertyName("url")]
    public required string ImageUrl { get; set; }
}