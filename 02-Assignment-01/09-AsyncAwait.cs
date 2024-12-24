//this program runs only in Visual Studio by creating a console project
using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace UseOfAsyncAwait
{
    public class FetchAPI
    {
        public static async Task Main()
        {
            string url = "https://api.github.com/users/nbinayak02";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Csharp-App");

            try
            {
                HttpResponseMessage message = await client.GetAsync(url);
                message.EnsureSuccessStatusCode();
                string response = await message.Content.ReadAsStringAsync();

                var jsonDocument = JsonDocument.Parse(response);
                var rootElement = jsonDocument.RootElement;


                string name = rootElement.GetProperty("name").GetString()??"Unknown";
                string location = rootElement.GetProperty("location").GetString() ?? "Unknown";
                int followers = rootElement.GetProperty("followers").GetInt32();
                string profileurl = rootElement.GetProperty("html_url").GetString() ?? "Unknown";

                Console.WriteLine("Name: " + name);
                Console.WriteLine("Address: " + location);
                Console.WriteLine("Followers: " + followers);
                Console.WriteLine("Profile: " + profileurl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

// Output:
// Name: Binayak Niraula
// Address: Jhapa, Nepal
// Followers: 7
// Profile: https://github.com/nbinayak02
