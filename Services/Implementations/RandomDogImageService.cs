using System.Text.Json;
using Dogs.Types;
using RestSharp;

namespace Dogs.Services.Implementations;
public class RandomDogImageService : IDogImageService
{
    static readonly string DOG_IMAGE_URL = "https://random.dog/woof.json?filter=mp4,webm";

    public string GetImage()
    {
        var client = new RestClient(DOG_IMAGE_URL);
        var req = new RestRequest();

        var res = client.Execute(req);
        var content = JsonSerializer.Deserialize<DogImageResponse>(res.Content);

        return content.ImageUrl;
    }
}