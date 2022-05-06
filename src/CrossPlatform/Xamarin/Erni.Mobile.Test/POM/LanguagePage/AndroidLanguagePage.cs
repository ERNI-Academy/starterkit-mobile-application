using Erni.Mobile.Test.POM.LanguagePage.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using TestWare.Engines.Appium.Extras;
using TestWare.Engines.Appium.Factory;
using TestWare.Engines.Appium.Pages;

namespace Erni.Mobile.Test.POM.LanguagePage
{
    internal class AndroidLanguagePage : MobilePage, IAndroidLanguagePage
    {
#nullable enable
        [FindsBy(How = How.AccessibilityId, Using = "ChangeLanguagePage_SaveButton")]
        private IWebElement SaveButton { get; set; }

        [FindsBy(How = How.AccessibilityId, Using = "ChangeLanguagePage_LanguagePicker_Container")]
        private IWebElement LanguagePicker { get; set; }
#nullable disable

        public AndroidLanguagePage(IAppiumDriver driver) : base(driver)
        {
            
        }

        public void ClickSaveButton()
            => ClickElement(SaveButton);

        public void UpdateLanguage(string language)
        {
            ClickElement(LanguagePicker);
            var items = this.Driver.FindElements(new ByClassName("android.widget.TextView"));
            ClickElement(items.FirstOrDefault(item => item.Text == language));
            ClickElement(SaveButton);
        }

        public void ClickPopupConfirmation()
        {
            var items = this.Driver.FindElements(new ByClassName("android.widget.Button"));
            ClickElement(items.FirstOrDefault(item => item.Text=="HECHO"));
        }
    }
}
