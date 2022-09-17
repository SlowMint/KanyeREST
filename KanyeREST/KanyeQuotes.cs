using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    public class KanyeQuotes
    {
        public KanyeQuotes()
        {

        }

        public static void QuoteKanye()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine(kanyeQuote);

        }
    }
}
