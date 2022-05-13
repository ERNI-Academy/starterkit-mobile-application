using CommunityToolkit.Mvvm.ComponentModel;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using System.Diagnostics;

namespace Erni.Mobile.MAUI.ViewModels
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

        public ItemDetailViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
        }

        public string Id { get; set; }

        partial void OnItemIdChanged(string value)
        {
            LoadItem(value).GetAwaiter().GetResult();
        }

        private async Task LoadItem(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
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
