using Erni.Mobile.MAUI.Models;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Erni.Mobile.MAUI.ViewModels
{
    public partial class ItemsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Item _selectedItem;

        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();
        public Command<Item> ItemTapped { get; }

        public ItemsViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
            Title = "Browse";

            ItemTapped = new Command<Item>(async (value)=> await OnItemSelected(value).ConfigureAwait(false));
        }

        [ICommand]
        public async Task ExecuteLoadItems()
        {
            await GetLoadItems().ConfigureAwait(false);
        }

        [ICommand]
        public async Task AddItem()
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;

            GetLoadItems().GetAwaiter().GetResult();
        }

        partial void OnSelectedItemChanged(Item value)
        {
            OnItemSelected(value).GetAwaiter().GetResult();
        }

        async Task GetLoadItems()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task OnItemSelected(Item item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}