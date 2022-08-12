using Erni.Mobile.Helpers;
using Erni.Mobile.Models;
using Erni.Mobile.Resources;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Erni.Mobile.ViewModels
{
    public partial class ChangeLanguageViewModel : BaseViewModel
    {
        public ObservableCollection<Language> Languages { get; set; }
        public Language SelectedLanguage { get; set; }

        public ChangeLanguageViewModel()
        {
            LoadLanguage();
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

        [RelayCommand]
        private async Task ChangeLanguage()
        {
            await LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));
            LoadLanguage();
            await App.Current.MainPage.DisplayAlert(AppResources.LanguageChanged, "", AppResources.Done);
        }
    }
}
