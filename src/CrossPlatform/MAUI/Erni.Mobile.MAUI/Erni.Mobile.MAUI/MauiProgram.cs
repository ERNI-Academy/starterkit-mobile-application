using Erni.Mobile.MAUI.Platforms;
using Erni.Mobile.MAUI.Services;

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

		return builder.Build();
	}
}
