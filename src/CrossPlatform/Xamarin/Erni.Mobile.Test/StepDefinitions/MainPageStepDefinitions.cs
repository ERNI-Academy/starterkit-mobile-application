using Erni.Mobile.Test.POM.MainPage.Interfaces;
using TestWare.Core;

namespace Erni.Mobile.Test.StepDefinitions
{
    [Binding]
    public sealed class MainPageStepDefinitions
    {
        private readonly IMainPage mainPage;

        public MainPageStepDefinitions(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            var tags = featureContext.FeatureInfo.Tags.Concat(scenarioContext.ScenarioInfo.Tags).Select(x => x.ToLower());
            var winAppDriver = TestWare.Engines.Appium.WinAppDriver.Factory.ConfigurationTags.winappdriver.ToString();
            var appium = TestWare.Engines.Appium.Factory.ConfigurationTags.appiumdriver.ToString();

            if (tags.Any(item => item == winAppDriver))
            {
                this.mainPage = ContainerManager.GetTestWareComponent<IWindowsMainPage>();
            }
            else if (tags.Any(item => item == appium) && tags.Any(item => item == "androiddriver"))
            {
                this.mainPage = ContainerManager.GetTestWareComponent<IAndroidMainPage>();
            }
            else if (tags.Any(item => item == appium) && tags.Any(item => item == "iosdriver"))
            {
                this.mainPage = ContainerManager.GetTestWareComponent<IIOsMainPage>();
            }
            else
            {
                throw new Exception(" No Page has been resolved");
            }
        }

        [Given(@"the user navigates to '([^']*)' page")]
        public void GivenTheUserNavigatesToPage(string page)
        {
            switch (page.ToLowerInvariant())
            {
                case "about":
                    this.mainPage.ClickAboutTab();
                    break;
                
                case "browse":
                    this.mainPage.ClickBrowseTab();
                    break;

                case "language":
                    this.mainPage.ClickLanguageTab();
                    break;

                default:
                    throw new ArgumentException("Wrong page name.");
            }
        }
    }
}