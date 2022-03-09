using Erni.Mobile.MAUI.Services;

namespace Erni.Mobile.MAUI.Platforms
{
    internal class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetFileStream(string path)
        {
            return Android.App.Application.Context.Assets.Open(path);
        }
    }
}
