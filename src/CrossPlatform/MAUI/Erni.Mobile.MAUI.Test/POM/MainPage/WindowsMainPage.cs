using Erni.Mobile.MAUI.Test.POM.MainPage.Interfaces;
using OpenQA.Selenium;
using TestWare.Engines.Appium.Extras;
using TestWare.Engines.Appium.WinAppDriver.Factory;
using TestWare.Engines.Appium.WinAppDriver.Pages;

namespace Erni.Mobile.MAUI.Test.POM.MainPage
{
    internal class WindowsMainPage : WinAppDriverPage, IWindowsMainPage
    {
#nullable enable
        [FindsBy(How = How.Name, Using = "About")]
        private IWebElement AboutTab { get; set; }

        [FindsBy(How = How.Name, Using = "Browse")]
        private IWebElement BrowseTab { get; set; }

        [FindsBy(How = How.Name, Using = "Language")]
        private IWebElement LanguageTab { get; set; }
#nullable disable

        public WindowsMainPage(IWindowsDriver driver) : base(driver)
        {
        }

        public void ClickAboutTab() 
            => ClickElement(AboutTab);

        public void ClickBrowseTab() 
            => ClickElement(BrowseTab);

        public void ClickLanguageTab()
            => ClickElement(LanguageTab);
    }
}
