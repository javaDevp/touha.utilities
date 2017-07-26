using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace touha.utilities.test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task<string> task = HttpHelper.DoPost("https://tcc.taobao.com/cc/json/mobile_tel_segment.htm", new Dictionary<string, string>()
            //{
            //    {"tel", "15850781443"}
            //});
            //try
            //{
            //    Task<string> task = HttpHelper.DoPost(_address, new Dictionary<string, string>());
            //    Console.Write(task.Result);
                
            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.Read();

        }

        

        static string _address = "http://api.worldbank.org/countries?format=json";

        //static async void Run()
        //{
        //    // Create an HttpClient instance
        //    HttpClient client = new HttpClient();

        //    // Send a request asynchronously continue when complete
        //    HttpResponseMessage response = await client.GetAsync(_address);

        //    // Check that response was successful or throw exception
        //    response.EnsureSuccessStatusCode();

        //    // Read response asynchronously as JsonValue and write out top facts for each country
        //    JsonArray content = await response.Content.ReadAsAsync<JsonArray>();

        //    Console.WriteLine("First 50 countries listed by The World Bank...");
        //    foreach (var country in content[1])
        //    {
        //        Console.WriteLine("   {0}, Country Code: {1}, Capital: {2}, Latitude: {3}, Longitude: {4}",
        //            country.Value["name"],
        //            country.Value["iso2Code"],
        //            country.Value["capitalCity"],
        //            country.Value["latitude"],
        //            country.Value["longitude"]);
        //    }
        //}
    }
}
