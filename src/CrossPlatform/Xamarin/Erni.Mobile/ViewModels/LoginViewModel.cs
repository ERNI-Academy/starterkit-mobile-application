using CommunityToolkit.Mvvm.Input;
using Erni.Mobile.Views;
using Xamarin.Forms;

namespace Erni.Mobile.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ICommand]
        private async void Login(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
