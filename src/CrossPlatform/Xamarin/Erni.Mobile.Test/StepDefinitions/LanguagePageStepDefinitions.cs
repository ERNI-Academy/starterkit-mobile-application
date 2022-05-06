using Erni.Mobile.Test.POM.LanguagePage.Interfaces;
using TestWare.Core;

namespace Erni.Mobile.Test.StepDefinitions
{
    [Binding]
    public sealed class LanguagePageStepDefinitions
    {
        private readonly ILanguagePage languagePage;

        public LanguagePageStepDefinitions(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            var tags = featureContext.FeatureInfo.Tags.Concat(scenarioContext.ScenarioInfo.Tags).Select(x => x.ToLower());
            var winAppDriver = TestWare.Engines.Appium.WinAppDriver.Factory.ConfigurationTags.winappdriver.ToString();
            var appium = TestWare.Engines.Appium.Factory.ConfigurationTags.appiumdriver.ToString();

            if (tags.Any(item => item == winAppDriver))
            {
                this.languagePage = ContainerManager.GetTestWareComponent<IWindowsLanguagePage>();
            }
            else if (tags.Any(item => item == appium) && tags.Any(item => item == "androiddriver"))
            {
                this.languagePage = ContainerManager.GetTestWareComponent<IAndroidLanguagePage>();
            }
            else if (tags.Any(item => item == appium) && tags.Any(item => item == "iosdriver"))
            {
                this.languagePage = ContainerManager.GetTestWareComponent<IIOsLanguagePage>();
            }
            else
            {
                throw new Exception(" No Page has been resolved");
            }
        }

        [When(@"user updates language to '([^']*)'")]
        public void WhenUserUpdatesLanguageTo(string language)
        {
            this.languagePage.UpdateLanguage(language);
        }

        [Then(@"language updated popup appears")]
        public void ThenLanguageUpdatedPopupAppears()
        {
            this.languagePage.ClickPopupConfirmation();
        }

    }
}