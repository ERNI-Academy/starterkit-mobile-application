using Erni.Mobile.MAUI.Helpers;
using Erni.Mobile.MAUI.Platforms;
using Erni.Mobile.MAUI.Services;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.ViewModels;
using Erni.Mobile.MAUI.Views;

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
                fonts.AddFont("fa-brands-400.ttf", "FAB");
                fonts.AddFont("fa-regular-400.ttf", "FAR");
                fonts.AddFont("fa-solid-900.ttf", "FAS");
                fonts.AddFont("GlyphIcons.ttf", "GlyphIcons");
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
            builder.Services.AddTransient<MockDataStore>();
            builder.Services.AddTransient<ILoggingService, AppCenterLoggingService>();
        }
        builder.Services.AddSingleton<AboutPage>();
        builder.Services.AddSingleton<AboutViewModel>();
        builder.Services.AddSingleton<ChangeLanguagePage>();
        builder.Services.AddSingleton<ChangeLanguageViewModel>();
        builder.Services.AddTransient<ItemDetailPage>();
        builder.Services.AddTransient<ItemDetailViewModel>();
        builder.Services.AddTransient<ItemsPage>();
        builder.Services.AddTransient<ItemsViewModel>();
        builder.Services.AddTransient<NewItemPage>();
        builder.Services.AddTransient<NewItemViewModel>();
        return builder.Build();
    }
}
