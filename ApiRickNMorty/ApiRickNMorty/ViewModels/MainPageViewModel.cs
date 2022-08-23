using ApiRickNMorty.Helpers;
using DryIoc.Messages;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApiRickNMorty.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public ICommand ContinuePageCommand => new DelegateCommand(ContinuePage); 
        private async void ContinuePage()
        {
            await NavigationService.NavigateAsync(NavigationConstants.CharactersPage);
        }
    }
}
