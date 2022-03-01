using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Erni.Mobile.Services.Configuration
{
    public interface IConfigurationFileProvider
    {
        Stream GetConfigurationStream();
    }
}
