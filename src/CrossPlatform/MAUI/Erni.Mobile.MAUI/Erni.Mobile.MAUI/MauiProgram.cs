using Erni.Mobile.MAUI.Helpers;
using Erni.Mobile.MAUI.Platforms;
using Erni.Mobile.MAUI.Services;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;

namespace Erni.Mobile.MAUI;

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

		builder.Services.AddTransient<IConfigurationFileProvider, ConfigurationFileProvider>();
		builder.Services.AddTransient<IApplicationSettingsService, ApplicationSettingsService>();

		if (ApplicationMode.UseDebugLogging)
        {
			builder.Services.AddTransient<MockDataStore>();
			builder.Services.AddTransient<ILoggingService, MockLoggingService>();
		}
        else 
		{ 
			builder.Services.AddTransient<ILoggingService, AppCenterLoggingService>();
		}
		return builder.Build();
	}
}
