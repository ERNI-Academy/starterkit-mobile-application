using Erni.Mobile.Test.POM.MainPage.Interfaces;
using OpenQA.Selenium;
using TestWare.Engines.Appium.Extras;
using TestWare.Engines.Appium.Factory;
using TestWare.Engines.Appium.Pages;

namespace Erni.Mobile.Test.POM.MainPage
{
    internal class AndroidMainPage : MobilePage, IAndroidMainPage
    {
#nullable enable
        [FindsBy(How = How.AccessibilityId, Using = "About")]
        private IWebElement AboutTab { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "Browse")]
        private IWebElement BrowseTab { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "Language")]
        private IWebElement LanguageTab { get; set; }
#nullable disable

        public AndroidMainPage(IAppiumDriver driver) : base(driver)
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
