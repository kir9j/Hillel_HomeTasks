using System;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Threading.Tasks;

public class HttpClientWrapper
{
    public async Task<string> Get(string url)
    {
        using (var httpClient = new HttpClient()) 
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Помилка під час виконання запиту {ex.Message}");
            }
            finally 
            { 
                httpClient.Dispose();
            }
            
            return null;
        }
        
    }

    public async Task<string> Post(string url, string content)
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(url, new StringContent(content));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Помилка під час виконання запиту {ex.Message}");
            }
            finally
            {
                httpClient.Dispose();
            }

            return null;
        }
    }

    public async Task<string> Put(string url, string content)
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsync(url, new StringContent(content));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Помилка під час виконання запиту {ex.Message}");
            }
            finally
            {
                httpClient.Dispose();
            }

            return null;
        }
    }

    public async Task<string> Delete(string url)
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Помилка під час виконання запиту {ex.Message}");
            }
            finally
            {
                httpClient.Dispose();
            }

            return null;
        }
    }
}