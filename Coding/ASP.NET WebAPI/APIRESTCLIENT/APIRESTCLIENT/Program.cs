using APIRESTCLIENT;
using System.Net.Http;
using System.Text.Json;
using (var client = new HttpClient())
{
    try
    {
        var response = client.GetAsync("https://jsonplaceholder.typicode.com/posts").Result;
        var responseStream = response.Content.ReadAsStreamAsync().Result;
        var responseData = JsonSerializer.DeserializeAsync<List<ApiResponse>>(responseStream).Result;
        foreach (var post in responseData)
        {
            Console.WriteLine("User Id: " + post.userId);
            Console.WriteLine("ID: " + post.id);
            Console.WriteLine("Title: " + post.title);
            Console.WriteLine("Body: " + post.body);
            Console.WriteLine("--------");

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error:"+ex.Message);
    }
}
