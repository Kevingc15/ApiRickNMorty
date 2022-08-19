using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiRickNMorty.Contracts
{
    public interface IHttpClientService
    {
        Task<HttpResponseMessage> GetAsync(string serviceUrl);
    }
}
