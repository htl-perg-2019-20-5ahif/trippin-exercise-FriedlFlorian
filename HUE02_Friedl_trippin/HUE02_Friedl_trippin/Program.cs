using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HUE02_Friedl_trippin
{
    class Program
    {
        static async Task Main()
        {
            await Get();
        }

        List<People> allUsers;
        private static HttpClient HttpClient
            = new HttpClient() { BaseAddress = new Uri("https://services.odata.org/TripPinRESTierService/") };

        public static async Task Get()
        {
            var userResponse = await HttpClient.GetAsync("People");
            userResponse.EnsureSuccessStatusCode();
            var responseBody = await userResponse.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<Peoples>(responseBody);
            users.Results.ForEach(u => Console.WriteLine(u.UserName));
        }
    }
}
