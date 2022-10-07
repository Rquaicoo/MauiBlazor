using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor.States
{
    [FeatureState]
    internal class CounterState
    {
        public int ClickCount { get; }
        
        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }

        public CounterState() { }
    }
}
