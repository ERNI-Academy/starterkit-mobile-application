using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class ItemsPage : ContentPage
{
    ItemsViewModel _viewModel;

    public ItemsPage(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
    {
		InitializeComponent();
        BindingContext = _viewModel = new ItemsViewModel(loggingService, applicationSettingsService);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }
}