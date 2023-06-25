using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HomeTask_19;

public class Program 
{
    public static async Task Main()
    {
        HttpClientWrapper client = new HttpClientWrapper();

        string response = await client.Get("https://api.example.com/data");
        Console.WriteLine(response);

        string postData = "Some data to be posted";
        response = await client.Post("https://api.example.com/data", postData);
        Console.WriteLine(response);

        string putData = "Some data to be put";
        response = await client.Put("https://api.example.com/data/1", putData);
        Console.WriteLine(response);

        response = await client.Delete("https://api.example.com/data/1");
        Console.WriteLine(response);
    }
}
