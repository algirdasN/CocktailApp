using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;
using Test_Framework.Forms;

namespace Test_Framework.Definitions
{
    [Binding]
    public sealed class CocktailFormSteps
    {
        private WindowsDriver<WindowsElement> driver;

        private MainForm mainForm;
        private CocktailsForm cocktailsForm;

        public CocktailFormSteps(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            InitiateForms();
        }

        private void InitiateForms()
        {
            mainForm = new MainForm(driver);
            cocktailsForm = new CocktailsForm(driver);
        }

        [Given(@"I navigated to Cocktails window")]
        public void GivenINavigatedToCocktailsWindow()
        {
            mainForm.ClickCocktailsButton();
            cocktailsForm.AssertWindowChange();
        }

        [When(@"I select a random Cocktail in Cocktail window")]
        public void WhenISelectARandomCocktailInCocktailWindow()
        {
            cocktailsForm.SelectRandomCocktail();
        }
               
        [When(@"I tick Show Only Available checkbox")]
        public void WhenITickShowOnlyAvailableCheckbox()
        {
            cocktailsForm.ClickAvailableCheckBox();
        }        
        
        [When(@"I tick Show Only Favourite checkbox")]
        public void WhenITickShowOnlyFavouriteCheckbox()
        {
            cocktailsForm.ClickFavouriteCheckbox();
        }

        [Then(@"Selected Cocktail details should be displayed")]
        public void ThenSelectedCocktailDetailsShouldBeDisplayed()
        {
            cocktailsForm.AssertCocktailInfoIsDisplayed();
        }
        
        [Then(@"Only available Cocktails should be displayed")]
        public void ThenOnlyAvailableCocktailsShouldBeDisplayed()
        {
            cocktailsForm.AssertOnlyAvailableDisplayed();
        }
        
        [Then(@"Only favourited Cocktails should be displayed")]
        public void ThenOnlyFavouritedCocktailsShouldBeDisplayed()
        {
            cocktailsForm.AssertOnlyFavouritedDisplayed();
        }
    }
}