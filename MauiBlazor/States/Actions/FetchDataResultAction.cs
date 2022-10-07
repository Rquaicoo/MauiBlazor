using MauiBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor.States.Actions
{
    internal class FetchDataResultAction
    {
        public WeatherForecast[] Forecasts { get; }

        public FetchDataResultAction(WeatherForecast[] forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
