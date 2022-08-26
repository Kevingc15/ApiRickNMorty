using ApiRickNMorty.Contracts;
using ApiRickNMorty.Helpers;
using ApiRickNMorty.Models;
using ApiRickNMorty.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ApiRickNMorty.ViewModels
{
    public class MainCharactersPageViewModel : ViewModelBase
    {
        private ICharacterRepository characterRepository;
        private SettingsService settingsService;
        public MainCharactersPageViewModel(INavigationService navigationService
            , ICharacterRepository characterRepository
            , SettingsService settingsService
            ): base(navigationService)
        {
            this.settingsService = settingsService;
            this.characterRepository = characterRepository;

            GetCharacters();
            Character = new Character();
            Characters = new List<Character>();
        }

        private List<Character> characters;

        public List<Character> Characters
        {
            get { return characters; }
            set { SetProperty(ref characters, value); }
        }

        public Character Character { get; set; }

        private async void GetCharacters()
        {
            var response = await characterRepository.GetCharacters();
            Characters = response ;
        }
        public ICommand SelectedCharacterCommand => new DelegateCommand<Character>(SelectedCharacter);
        public async void SelectedCharacter(Character character)
        {
            var parameters = new NavigationParameters();
            parameters.Add("Id", character.Id);
            await NavigationService.NavigateAsync(NavigationConstants.SelectCharacterPage, parameters);
        }
    }
}
