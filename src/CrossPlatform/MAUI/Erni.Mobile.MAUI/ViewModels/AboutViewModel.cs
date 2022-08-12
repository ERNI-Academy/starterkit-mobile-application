using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using CommunityToolkit.Mvvm.Input;

namespace Erni.Mobile.MAUI.ViewModels
{
    public partial class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
            Title = "About";
        }

        [RelayCommand]
        public async Task Browse()
        {
            await Browser.OpenAsync("https://dotnet.microsoft.com/en-us/apps/maui");
        }
    }
}
