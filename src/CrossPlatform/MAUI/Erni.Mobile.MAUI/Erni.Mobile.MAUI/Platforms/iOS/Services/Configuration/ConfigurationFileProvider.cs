using Erni.Mobile.MAUI.Services.Configuration;
using Foundation;

namespace Erni.Mobile.MAUI.Platforms
{
    internal class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            return File.OpenRead(NSBundle.MainBundle.PathForResource("appsettings.json", null));
        }
    }
}
