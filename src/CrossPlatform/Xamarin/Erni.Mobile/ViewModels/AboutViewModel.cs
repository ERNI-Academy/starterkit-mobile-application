using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using CommunityToolkit.Mvvm.Input;

namespace Erni.Mobile.ViewModels
{
    public partial class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
        }

        [ICommand]
        public async Task Browse()
        {
            await Browser.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}