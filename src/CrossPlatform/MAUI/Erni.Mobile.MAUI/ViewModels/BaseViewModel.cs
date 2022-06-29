using CommunityToolkit.Mvvm.ComponentModel;
using Erni.Mobile.MAUI.Models;
using Erni.Mobile.MAUI.Services;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;

namespace Erni.Mobile.MAUI.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public readonly ILoggingService LoggingService;
        public readonly IApplicationSettingsService ApplicationSettingsService;

        public BaseViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
        {
            this.LoggingService = loggingService;
            this.ApplicationSettingsService = applicationSettingsService;
        }

        [ObservableProperty]
        bool isBusy = false;

        [ObservableProperty]
        string title = string.Empty;
    }
}
