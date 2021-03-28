using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;
using System.Threading;

namespace BlazorFinanceNews.Data
{
    public class FinanceNewsService
    {

        

        public async Task<FinanceNews[]> GetFinanceNewsAsync()
        { 

            var requestUri = new Uri("https://yahoo-finance15.p.rapidapi.com/api/yahoo/ne/news");
            var client = new HttpClient();

            // IMPORTANT! Go here first to get your own x-rapidapi-key: https://rapidapi.com/apidatacenter-api-data/api/yahoo-finance15

            client.DefaultRequestHeaders.Add("x-rapidapi-key", "c9fa1e73ddmshe7b02f8018130b4p164618jsn88999a8a0cad");
            
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance15.p.rapidapi.com");

            

            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
           

           var response = await HttpClientJsonExtensions.GetFromJsonAsync<FinanceNews[]>(client, requestUri, token);



            return response;

        }
    }
}
