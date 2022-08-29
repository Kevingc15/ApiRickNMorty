using ApiRickNMorty.Contracts;
using ApiRickNMorty.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRickNMorty.ViewModels
{
    public class SelectCharacterPageViewModel : ViewModelBase
    {
        ICharacterRepository characterRepository;
        private Character character;

        public SelectCharacterPageViewModel(INavigationService navigationService
            , ICharacterRepository characterRepository): base(navigationService)
        {
            this.characterRepository = characterRepository;
        }

        public Character Character { get => character; set => SetProperty(ref character, value); }

        public async override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            await GetCharacter((int)parameters["Id"]);
        }

        private async Task GetCharacter(int id)
        {
            var response = await characterRepository.GetCharacter(id);
            Character = response;
        }

    }
}
