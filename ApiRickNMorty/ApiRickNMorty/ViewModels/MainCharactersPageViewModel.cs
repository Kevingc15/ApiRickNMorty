using ApiRickNMorty.Contracts;
using ApiRickNMorty.Models;
using ApiRickNMorty.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiRickNMorty.ViewModels
{
    public class MainCharactersPageViewModel : BindableBase
    {
        private ICharacterRepository characterRepository;
        private SettingsService settingsService;
        public MainCharactersPageViewModel(INavigationService navigationService
            , ICharacterRepository characterRepository
            , SettingsService settingsService
            )
        {
            this.settingsService = settingsService;
            this.characterRepository = characterRepository;

            GetCharacters();
        }

        public List<Character> Characters { get; set; }

        private async void GetCharacters()
        {
            var response = await characterRepository.GetCharacters();
            Characters = response;
        }
    }
}
