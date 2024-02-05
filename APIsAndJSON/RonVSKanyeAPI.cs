using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void Kanye()
        {
            var client = new HttpClient();

            string kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: {kanyeQuote}.");
            Console.WriteLine();
        }
       
        public static void Ron()
        {
            var client = new HttpClient();

            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronReponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronReponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine();
        }
    }
}
