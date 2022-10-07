using Fluxor;
using MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor.States
{   
    [FeatureState]
    internal class WeatherState
    {
        public bool IsLoading { get; }
        public WeatherForecast[] Forecasts { get; }
        
        private WeatherState() { }

        public WeatherState(bool isLoading, WeatherForecast[] forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
        }
    }
}
