using ApiRickNMorty.Contracts;
using ApiRickNMorty.Models;
using ApiRickNMorty.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRickNMorty.Repositories
{
    public class CharactersRepository : BaseRepository, ICharacterRepository
    {
        public CharactersRepository(IJsonService jsonService, 
            IHttpClientService httpClientService, 
            SettingsService settingsService) : 
            base(jsonService, httpClientService, settingsService)
        {
        }

        

        public async Task<List<Character>> GetCharacters() 
        {
            string url = "https://rickandmortyapi.com/api/character";
            var characters = new List<Character>();
            var nextPage = 0;
            var result = await httpClientService.GetAsync((nextPage == 0 ? url : $"{url}{(url.Contains("?") ? "&" : "?")}page={nextPage}"));
            var datos = await jsonService.GetSerializedResponse<Page<Character>>(result);
            do
            {
                result = await httpClientService.GetAsync(($"{url}{(url.Contains("?") ? "&" : "?")}page={nextPage}"));
                datos = await jsonService.GetSerializedResponse<Page<Character>>(result);
                characters.AddRange(datos.Results);
                nextPage += 1;

            } while (nextPage <= datos.Info.Pages);
            
            return characters;
       
        }

       
    }
}
