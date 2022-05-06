using Erni.Mobile.Test.POM.LanguagePage.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using TestWare.Engines.Appium.Extras;
using TestWare.Engines.Appium.WinAppDriver.Factory;
using TestWare.Engines.Appium.WinAppDriver.Pages;

namespace Erni.Mobile.Test.POM.LanguagePage
{
    internal class WindowsLanguagePage : WinAppDriverPage, IWindowsLanguagePage
    {
#nullable enable
        [FindsBy(How = How.AccessibilityId, Using = "ChangeLanguagePage_SaveButton")]
        private IWebElement SaveButton { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "ChangeLanguagePage_LanguagePicker")]
        private IWebElement LanguagePicker { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "SecondaryButton")]
        private IWebElement ConfirmationButton { get; set; }
#nullable disable

        public WindowsLanguagePage(IWindowsDriver driver) : base(driver)
        {
            
        }

        public void ClickSaveButton()
            => ClickElement(SaveButton);

        public void UpdateLanguage(string language)
        {
            ClickElement(LanguagePicker);
            var items = this.Driver.FindElements(new ByName(language));
            ClickElement(items.FirstOrDefault());
            ClickElement(SaveButton);
        }

        public void ClickPopupConfirmation()
        {
            ClickElement(ConfirmationButton);
        }
    }
}
