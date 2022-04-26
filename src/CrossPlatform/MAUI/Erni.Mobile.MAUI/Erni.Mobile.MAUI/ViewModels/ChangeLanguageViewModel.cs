using Erni.Mobile.MAUI.Helpers;
using Erni.Mobile.MAUI.Models;
using Erni.Mobile.MAUI.Resources;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace Erni.Mobile.MAUI.ViewModels
{
    internal class ChangeLanguageViewModel : BaseViewModel
    {
        public ObservableCollection<Language> Languages { get; set; }

        public Language SelectedLanguage { get; set; }

        public ICommand ChangeLanguageCommand { get; set; }

        public ChangeLanguageViewModel(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
            : base(loggingService, applicationSettingsService)
        {
            LoadLanguage();
            ChangeLanguageCommand = new Command(async () =>
            {
                if (SelectedLanguage != null)
                {
                    await LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));
                    LoadLanguage();
                    await App.Current.MainPage.DisplayAlert(AppResources.LanguageChanged, "", AppResources.Done);
                }
            });

        }

        void LoadLanguage()
        {
            Languages = new ObservableCollection<Language>()
            {
                {new Language(AppResources.English, "en") },
                {new Language(AppResources.Filipino, "fil") },
                {new Language(AppResources.German, "de") },
                {new Language(AppResources.Romanian, "ro")} ,
                {new Language(AppResources.Slovak, "sk")} ,
                {new Language(AppResources.Spanish, "es") }
            };
            SelectedLanguage = Languages.FirstOrDefault(pro => pro.CI == LocalizationResourceManager.Instance.CurrentCulture.ThreeLetterISOLanguageName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
