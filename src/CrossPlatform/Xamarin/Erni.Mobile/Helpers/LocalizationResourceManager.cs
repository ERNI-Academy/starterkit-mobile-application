﻿using Erni.Mobile.Extensions;
using Erni.Mobile.Models;
using Erni.Mobile.Resources;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Erni.Mobile.Helpers
{
    public class LocalizationResourceManager : INotifyPropertyChanged
    {
        private const string LanguageKey = nameof(LanguageKey);

        public static LocalizationResourceManager Instance { get; } = new LocalizationResourceManager();

        private LocalizationResourceManager()
        {
            SetCulture(new CultureInfo(Preferences.Get(LanguageKey, CurrentCulture.TwoLetterISOLanguageName))).GetAwaiter().GetResult();
        }

        public string this[string text]
        {
            get
            {
                return AppResources.ResourceManager.GetString(text, AppResources.Culture);
            }
        }

        public async Task SetCulture(CultureInfo language)
        {
            await MainThread.InvokeOnMainThreadAsync(() =>
            {
                Thread.CurrentThread.CurrentUICulture = language;
                Thread.CurrentThread.CurrentCulture = language;
                AppResources.Culture = language;
                Preferences.Set(LanguageKey, language.TwoLetterISOLanguageName);
                App.Current.MainPage = new AppShell();
            });

            Invalidate();
        }

        public string GetValue(string text, string ResourceId)
        {
            ResourceManager resourceManager = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);
            return resourceManager.GetString(text, CultureInfo.CurrentCulture);
        }

        public CultureInfo CurrentCulture => AppResources.Culture ?? Thread.CurrentThread.CurrentUICulture;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
