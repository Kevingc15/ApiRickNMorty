using ApiRickNMorty.Contracts;
using ApiRickNMorty.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRickNMorty.Repositories
{
    public class BaseRepository
    {
        protected SettingsService settingsService;
        protected IJsonService jsonService;
        protected IHttpClientService httpClientService;

        protected string apiUrl = string.Empty;
        public BaseRepository(
            IJsonService jsonService,
            IHttpClientService httpClientService,
            SettingsService settingsService
            )
        {
            this.settingsService = settingsService;
            this.jsonService = jsonService;
            this.httpClientService = httpClientService;

            apiUrl = settingsService.GetApi();
        }


    }
}
