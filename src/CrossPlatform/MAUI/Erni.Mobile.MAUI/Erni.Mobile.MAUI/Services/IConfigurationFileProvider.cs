namespace Erni.Mobile.MAUI.Services
{
    public interface IConfigurationFileProvider
    {
        Stream GetFileStream(string path);
    }
}
