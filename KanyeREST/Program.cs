using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Kanye:");
    KanyeREST.KanyeQuotes.QuoteKanye();
    Console.WriteLine("Ron Swanson:");
    KanyeREST.SwansonQuotes.QuoteSwanson();
}
