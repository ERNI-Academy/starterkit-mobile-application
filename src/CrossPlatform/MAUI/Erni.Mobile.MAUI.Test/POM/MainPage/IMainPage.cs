using TestWare.Core.Interfaces;

namespace Erni.Mobile.MAUI.Test.POM.MainPage
{
    internal interface IMainPage : ITestWareComponent
    {
        void ClickAboutTab();
        void ClickBrowseTab();
        void ClickLanguageTab();
    }
}
