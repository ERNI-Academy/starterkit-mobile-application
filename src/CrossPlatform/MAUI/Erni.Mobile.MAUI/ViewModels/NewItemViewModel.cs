using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Erni.Mobile.MAUI.Models;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;

namespace Erni.Mobile.MAUI.ViewModels
{
    public partial class NewItemViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private string description;

        public NewItemViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
            this.PropertyChanged +=
                (_, __) => SaveCommand.NotifyCanExecuteChanged();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        [RelayCommand]
        private async void Cancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand(CanExecute = nameof(ValidateSave))]
        private async void Save()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
