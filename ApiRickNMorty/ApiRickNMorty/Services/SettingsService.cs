using ApiRickNMorty.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRickNMorty.Services
{
    public class SettingsService
    {
        public string GetApi()
        {
            return "https://rickandmortyapi.com/api/";
        }

        public string GetCharacter()
        {
            return "/character";
        }
    }
}
