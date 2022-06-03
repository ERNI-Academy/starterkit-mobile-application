using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using System.Windows.Input;

namespace Erni.Mobile.MAUI.ViewModels
{
    public partial class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://dotnet.microsoft.com/en-us/apps/maui"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
