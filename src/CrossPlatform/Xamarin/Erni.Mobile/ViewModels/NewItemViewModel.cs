using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Erni.Mobile.Models;
using System;
using Xamarin.Forms;

namespace Erni.Mobile.ViewModels
{
    public partial class NewItemViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private string description;

        public NewItemViewModel()
        {
            this.PropertyChanged +=
                (_, __) => SaveCommand.NotifyCanExecuteChanged();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        [ICommand]
        private async void Cancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        [ICommand(CanExecute = nameof(ValidateSave))]
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
