using Erni.Mobile.MAUI.Services.Configuration;

namespace Erni.Mobile.MAUI.Platforms
{
    internal class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            return Android.App.Application.Context.Assets.Open("appsettings.json");
        }
    }
}
