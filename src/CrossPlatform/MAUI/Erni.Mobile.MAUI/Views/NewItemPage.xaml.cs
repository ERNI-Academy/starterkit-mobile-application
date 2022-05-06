using Erni.Mobile.MAUI.Models;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class NewItemPage : ContentPage
{
    public Item Item { get; set; }

    public NewItemPage(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
    {
        InitializeComponent();
        BindingContext = new NewItemViewModel(loggingService, applicationSettingsService);
    }
}