using Erni.Mobile.MAUI.Test.POM.LanguagePage;
using TestWare.Core;

namespace Erni.Mobile.MAUI.Test.StepDefinitions
{
    [Binding]
    public sealed class LanguagePageStepDefinitions
    {
        private readonly ILanguagePage languagePage;

        public LanguagePageStepDefinitions()
        {
            this.languagePage = ContainerManager.GetTestWareComponent<ILanguagePage>();
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