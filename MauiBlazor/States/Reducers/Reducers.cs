using Fluxor;
using MauiBlazor.States.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor.States.Reducers
{
    internal class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
            new(clickCount :state.ClickCount + 1);

        [ReducerMethod]
        public static CounterState ReduceResetCounterAction(CounterState state, DecrementCounterAction action) =>
            new(clickCount: state.ClickCount - 1);

        [ReducerMethod]
        public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction action) =>
            new(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
            new(isLoading: false, forecasts: action.Forecasts);
    }
}
