using System;
using System.Net.Http;
using System.Threading.Tasks;

public class RestClient
{
    private readonly HttpClient _httpClient;

    public RestClient(string baseUri)
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(baseUri);
    }

    public async Task<string> GetAsync(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    // You can add other methods like Post, Put, Delete as needed
}
public class Program
{
    static async Task Main(string[] args)
    {
        // Replace "https://api.example.com" with your actual API base URL
        var restClient = new RestClient("https://api.example.com");

        // Replace "/endpoint" with your actual API endpoint
        var result = await restClient.GetAsync("/endpoint");

        Console.WriteLine(result);
    }
}
