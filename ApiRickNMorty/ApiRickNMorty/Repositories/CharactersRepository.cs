using ApiRickNMorty.Contracts;
using ApiRickNMorty.Models;
using ApiRickNMorty.Services;
using System;
using System.Collections.Generic;
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
            var result = await httpClientService.GetAsync(url);
            
            var datos = await jsonService.GetSerializedResponse<List<Character>>(result);
            return datos;
       
        }
    }
}
