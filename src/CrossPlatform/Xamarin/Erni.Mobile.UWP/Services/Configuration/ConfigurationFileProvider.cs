using Erni.Mobile.Services.Configuration;
using Erni.Mobile.UWP.Services.Configuration;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigurationFileProvider))]
namespace Erni.Mobile.UWP.Services.Configuration
{
    public class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            return File.OpenRead(@"Assets\appsettings.json");
        }
    }
}
