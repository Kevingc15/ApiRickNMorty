using ApiRickNMorty.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiRickNMorty.Contracts
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetCharacters();
    }
}
