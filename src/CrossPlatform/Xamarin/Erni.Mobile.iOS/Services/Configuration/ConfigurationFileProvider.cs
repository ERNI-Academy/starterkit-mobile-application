using Erni.Mobile.iOS.Services.Configuration;
using Erni.Mobile.Services.Configuration;
using Foundation;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigurationFileProvider))]
namespace Erni.Mobile.iOS.Services.Configuration
{
    public class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            var path = NSBundle.MainBundle.PathForResource("appsettings.json", null);
            return File.OpenRead(path);
        }
    }
}