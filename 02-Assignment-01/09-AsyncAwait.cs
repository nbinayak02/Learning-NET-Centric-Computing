using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIHandling
{
    class Test
    {
       public static async Task Main()
        {
            string url = "https://api.github.com/users/nbinayak02";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "CSharpApp");

            try
            {
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();
                string responseBody = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured: {0}", ex.Message);
            }
        }
    }
}