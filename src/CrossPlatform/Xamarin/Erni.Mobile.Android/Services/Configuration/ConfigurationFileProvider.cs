using Erni.Mobile.Droid.Services.Configuration;
using Erni.Mobile.Services.Configuration;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigurationFileProvider))]
namespace Erni.Mobile.Droid.Services.Configuration
{
    public class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetConfigurationStream()
        {
            return Android.App.Application.Context.Assets.Open("appsettings.json");
        }
    }
}
