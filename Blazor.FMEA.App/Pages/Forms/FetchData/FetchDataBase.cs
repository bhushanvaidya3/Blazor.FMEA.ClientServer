using Blazor.FMEA.App.Services.Other;
using Blazor.FMEA.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FMEA.Client.Pages.FetchData
{
    public class FetchDataBase: ComponentBase
    {
        [Inject]
        private IWeatherForecastDataService weatherForecastDataService { get; set; }

        public List<WeatherForecast> forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = (await weatherForecastDataService.GetWeatherForecasts()).ToList();
        }
    }
}
