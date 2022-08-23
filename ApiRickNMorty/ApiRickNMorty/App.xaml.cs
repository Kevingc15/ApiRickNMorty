using ApiRickNMorty.Contracts;
using ApiRickNMorty.Repositories;
using ApiRickNMorty.Services;
using ApiRickNMorty.ViewModels;
using ApiRickNMorty.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace ApiRickNMorty
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();


            containerRegistry.Register<IJsonService, JsonService>();
            containerRegistry.Register<IHttpClientService, HttpClientService>();
            containerRegistry.Register<SettingsService>();
            containerRegistry.Register<ICharacterRepository, CharactersRepository>();
            containerRegistry.RegisterForNavigation<MainCharactersPage, MainCharactersPageViewModel>();
        }
    }
}
