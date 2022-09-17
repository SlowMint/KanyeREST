using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    public class SwansonQuotes
    {
        public SwansonQuotes()
        {

        }

        public static void QuoteSwanson()
        {
            var client = new HttpClient();

            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var swansonResponse = client.GetStringAsync(swansonURL).Result;

            var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine(swansonQuote);
        }

    }
}
