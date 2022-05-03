using TestWare.Core.Interfaces;

namespace Erni.Mobile.MAUI.Test.POM.LanguagePage
{
    internal interface ILanguagePage : ITestWareComponent
    {
        void ClickSaveButton();
        void UpdateLanguage(string language);
        void ClickPopupConfirmation();
    }
}
