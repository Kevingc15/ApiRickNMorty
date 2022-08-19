using ApiRickNMorty.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiRickNMorty.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly IJsonService jsonService;

        public HttpClientService(IJsonService jsonService)
        {
            this.jsonService = jsonService;
        }

        public async Task<HttpResponseMessage> GetAsync(string serviceUrl)
        {
            using (var client = new HttpClient())
            {
                return await client.GetAsync(serviceUrl);
            }
        }
    }
}
