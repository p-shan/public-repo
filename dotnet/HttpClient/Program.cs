using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientExampleDotNet
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: HttpClientExampleDotNet <url>");
                return;
            }

            string url = args[0];

            // Create an HttpClient instance
            using var httpClient = new HttpClient();

            try
            {
                // Send a GET request to the specified URL
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and display the response content
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response Body: " + responseBody);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve data. Status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
