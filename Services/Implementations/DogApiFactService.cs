using RestSharp;
using System.Text.Json;
using Dogs.Types;

namespace Dogs.Services.Implementations;
public class DogApiFactSercie : IDogFactService
{
    static readonly string DOG_FACT_URL = "https://dogapi.dog/api/v2/facts";
    public string GetFact()
    {
        var client = new RestClient(DOG_FACT_URL);
        var req = new RestRequest();

        var res = client.Execute(req);

        var content = JsonSerializer.Deserialize<DogFactResponseWrapper>(res.Content);
        return content.Data[0].Attirbutes.Body;
    }
}