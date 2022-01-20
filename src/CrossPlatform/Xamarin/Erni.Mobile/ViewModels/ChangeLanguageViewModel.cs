using Erni.Mobile.Helpers;
using Erni.Mobile.Models;
using Erni.Mobile.Resources;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Erni.Mobile.ViewModels
{
    public class ChangeLanguageViewModel : BaseViewModel
    {
        public ObservableCollection<Language> Languages { get; set; }
        public Language SelectedLanguage { get; set; }

        public ICommand ChangeLangugeCommand { get; set; }

        public ChangeLanguageViewModel()
        {
            LoadLanguage();
            ChangeLangugeCommand = new Command(async () =>
            {
                await LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));
                LoadLanguage();
                await App.Current.MainPage.DisplayAlert(AppResources.LanguageChanged, "", AppResources.Done);
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
