using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Erni.Mobile.Models;
using Erni.Mobile.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Erni.Mobile.ViewModels
{
    public partial class ItemsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Item _selectedItem;

        public ObservableCollection<Item> Items { get; }
        public Command<Item> ItemTapped { get; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();

            ItemTapped = new Command<Item>(async (value) => await OnItemSelected(value).ConfigureAwait(false));
        }

        [ICommand]
        async Task ExecuteLoadItems()
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