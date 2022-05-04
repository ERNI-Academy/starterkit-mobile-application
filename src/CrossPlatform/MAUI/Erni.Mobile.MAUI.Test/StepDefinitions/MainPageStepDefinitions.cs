using Erni.Mobile.MAUI.Test.POM.MainPage;
using TestWare.Core;

namespace Erni.Mobile.MAUI.Test.StepDefinitions
{
    [Binding]
    public sealed class MainPageStepDefinitions
    {
        private readonly IMainPage mainPage;

        public MainPageStepDefinitions()
        {
            this.mainPage = ContainerManager.GetTestWareComponent<IMainPage>();            
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