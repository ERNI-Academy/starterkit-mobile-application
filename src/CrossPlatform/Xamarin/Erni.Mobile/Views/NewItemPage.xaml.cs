using Erni.Mobile.Models;
using Erni.Mobile.ViewModels;
using Xamarin.Forms;

namespace Erni.Mobile.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}