using Fluxor;
using MauiBlazor.Data;
using MauiBlazor.States.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using IDispatcher = Fluxor.IDispatcher;

namespace MauiBlazor.States.Effects
{
    internal class Effects
    {
        private readonly HttpClient Http;

        public Effects(HttpClient http)
        {
            Http = http;
        }

        [EffectMethod]
        public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");

            if (forecasts != null)
            {
                dispatcher.Dispatch(new FetchDataResultAction(forecasts));
            }
     
        }
    }
}
