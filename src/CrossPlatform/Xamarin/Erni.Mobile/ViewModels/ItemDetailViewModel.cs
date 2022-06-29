using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Erni.Mobile.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class ItemDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string itemId;

        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private string description;

        public string Id { get; set; }

        partial void OnItemIdChanged(string value)
        {
            LoadItem(value);
        }

        private void LoadItem(string itemId)
        {
            try
            {
                var item = DataStore.GetItemAsync(itemId).GetAwaiter().GetResult();
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
