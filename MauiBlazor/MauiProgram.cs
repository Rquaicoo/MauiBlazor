using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiBlazor.Data;
using Fluxor;
using Android.Renderscripts;

namespace MauiBlazor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services.AddFluxor(o =>
        {
            o.ScanAssemblies(typeof(MauiProgram).Assembly);
            /*o.UseReduxDevTools(rdt =>
            {
                rdt.Name = "MauiBlazor";
            });*/
        });
        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
