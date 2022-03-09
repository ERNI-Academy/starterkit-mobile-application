using Erni.Mobile.MAUI.Services;
using Foundation;

namespace Erni.Mobile.MAUI.Platforms
{
    internal class ConfigurationFileProvider : IConfigurationFileProvider
    {
        public Stream GetFileStream(string path)
        {
            return File.OpenRead(NSBundle.MainBundle.PathForResource(path, null));
        }
    }
}
