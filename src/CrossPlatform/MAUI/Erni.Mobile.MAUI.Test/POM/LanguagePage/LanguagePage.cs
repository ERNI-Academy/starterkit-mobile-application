using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using TestWare.Engines.Appium.Extras;
using TestWare.Engines.Appium.WinAppDriver.Factory;
using TestWare.Engines.Appium.WinAppDriver.Pages;

namespace Erni.Mobile.MAUI.Test.POM.LanguagePage
{
    internal class LanguagePage : WinAppDriverPage, ILanguagePage
    {
#nullable enable
        [FindsBy(How = How.AccessibilityId, Using = "ChangeLanguagePage_SaveButton")]
        private IWebElement SaveButton { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "ChangeLanguagePage_LanguagePicker")]
        private IWebElement LanguagePicker { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "SecondaryButton")]
        private IWebElement PopupConfirmButton { get; set; }
#nullable disable

        public LanguagePage(IWindowsDriver driver) : base(driver)
        {
        }

        public void ClickSaveButton() 
            => ClickElement(SaveButton);

        public void UpdateLanguage(string language)
        {
            ClickElement(LanguagePicker);
            ClickElement(this.Driver.FindElement(MobileBy.Name(language)));
            ClickElement(SaveButton);
        }

        public void ClickPopupConfirmation()
            => ClickElement(PopupConfirmButton);
    }
}
