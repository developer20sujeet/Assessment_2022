using System;
using System.Net.Http;
using PrjRestApi.John;
using Newtonsoft;
using System.Threading.Tasks;
using System.Text.Json;

namespace PrjRestApi.John
{
    public class RestCaller
    {
        public static string getPhoneNumber(string countryCode)
        {
            return CallApi_without_Newtonsoft(countryCode).Result;
        }
        /// <summary>
        /// Endpoint -https://jsonmock.hackerrank.com/api/countries?name=Afghanistan
        /// </summary>
        public static async Task<string> CallApi_with_Newtonsoft(string countryCode)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonmock.hackerrank.com/");
                HttpResponseMessage response = await client.GetAsync("api/countries?name=" + countryCode);
                if (response.IsSuccessStatusCode)
                {
                    string val = await response.Content.ReadAsStringAsync();
                    Root rt = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(val);
                    //(rt.@data[0]).callingCodes[0]
                    foreach (var item in rt.data)
                    {
                        foreach (string t in item.callingCodes)
                        {
                            return t;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            return "";
        }

        public static async Task<string> CallApi_without_Newtonsoft(string countryCode)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonmock.hackerrank.com/");
                HttpResponseMessage response = await client.GetAsync("api/countries?name=" + countryCode);

                if (response.IsSuccessStatusCode)
                {
                    string val = await response.Content.ReadAsStringAsync();

                    // simple using using System.Text.Json;
                    Root rt = JsonSerializer.Deserialize<Root>(val);

                    //(rt.@data[0]).callingCodes[0]
                    foreach (var item in rt.data)
                    {
                        foreach (string t in item.callingCodes)
                        {
                            return t;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            return "";
        }
    }
}
