using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;

namespace Erni.Mobile.MAUI.ViewModels
{
    internal class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
            Title = "About";
        }
    }
}
