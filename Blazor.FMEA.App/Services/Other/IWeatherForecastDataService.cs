using Blazor.FMEA.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.FMEA.App.Services.Other
{
    public interface IWeatherForecastDataService
    {
        Task <IEnumerable<WeatherForecast>> GetWeatherForecasts();
    }
}
