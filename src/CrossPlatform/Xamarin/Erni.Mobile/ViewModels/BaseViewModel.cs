using CommunityToolkit.Mvvm.ComponentModel;
using Erni.Mobile.Models;
using Erni.Mobile.Services;
using Erni.Mobile.Services.Configuration;
using Erni.Mobile.Services.Logging;
using Xamarin.Forms;

namespace Erni.Mobile.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public ILoggingService LoggingService => DependencyService.Get<ILoggingService>();
        public IApplicationSettingsService ApplicationSettingsService => DependencyService.Get<IApplicationSettingsService>();

        [ObservableProperty]
        bool isBusy = false;

        [ObservableProperty]
        string title = string.Empty;
    }
}
