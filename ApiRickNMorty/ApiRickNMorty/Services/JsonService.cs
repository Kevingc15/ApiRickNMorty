using ApiRickNMorty.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiRickNMorty.Services
{
    public class JsonService : IJsonService
    {
        public T Deserialize<T>(string text)
        {
            T deserializedObject = JsonConvert.DeserializeObject<T>(text);
            return deserializedObject;
        }

        public async Task<TResponse> GetSerializedResponse<TResponse>(HttpResponseMessage result)
        {
            string response = await result.Content.ReadAsStringAsync();
            TResponse serializedResponse = JsonConvert.DeserializeObject<TResponse>(response);
            return serializedResponse;
        }

        public string Serialize<T>(T entity)
        {
            return JsonConvert.SerializeObject(entity);
        }
    }
}
