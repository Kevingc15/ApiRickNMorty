using ApiRickNMorty.Contracts;
using ApiRickNMorty.Models;
using ApiRickNMorty.Services;
using DryIoc.Messages;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRickNMorty.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private ICharacterRepository characterRepository;
        //private SettingsService settingsService;

        public MainPageViewModel(INavigationService navigationService
            ,ICharacterRepository characterRepository
            )
            : base(navigationService)
        {
            Title = "Main Page";
            //this.settingsService = settingsService;
            this.characterRepository = characterRepository;
        }

        //List<Character> Characters { get; set; }

        //private async Task GetCharacter()
        //{
        //    var response = await characterRepository.GetCharacters();
        //    Characters =  response;
        //}
    }
}
