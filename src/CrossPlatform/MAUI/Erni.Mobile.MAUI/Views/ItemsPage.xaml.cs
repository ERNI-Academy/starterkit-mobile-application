using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class ItemsPage : ContentPage
{
    ItemsViewModel _viewModel;

    public ItemsPage(ItemsViewModel itemsViewModel)
    {
		InitializeComponent();
        BindingContext = _viewModel = itemsViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }
}