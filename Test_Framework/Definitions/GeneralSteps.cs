using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;
using Test_Framework.Forms;

namespace Test_Framework.Definitions
{
    [Binding]
    public class GeneralSteps
    {
        private WindowsDriver<WindowsElement> driver;

        private MainForm mainForm;
        private CocktailsForm cocktailsForm;
        private IngredientsForm ingredientsForm;
        private EditCocktailsForm editCocktailsForm;

        public GeneralSteps(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            InitiateForms();
        }

        private void InitiateForms()
        {
            mainForm = new MainForm(driver);
            cocktailsForm = new CocktailsForm(driver);
            ingredientsForm = new IngredientsForm(driver);
            editCocktailsForm = new EditCocktailsForm(driver);
        }

        [When(@"I click Back button")]
        public void WhenIClickBackButton()
        {
            mainForm.ClickBackButton();
        }

        [When(@"I click Exit button")]
        public void WhenIClickExitButton()
        {
            mainForm.ClickExitButton();
        }

        [Then(@"Only Main window should be displayed")]
        public void ThenOnlyMainWindowShouldBeDisplayed()
        {
            mainForm.AssertWindowChange();
        }

        [Then(@"Only Cocktails window should be displayed")]
        public void ThenCocktailsWindowShouldBeDisplayed()
        {
            cocktailsForm.AssertWindowChange();
        }

        [Then(@"Only Ingredients window should be displayed")]
        public void ThenIngredientsWindowsShouldBeDisplayed()
        {
            ingredientsForm.AssertWindowChange();
        }

        [Then(@"Only Edit Cocktails window should be displayed")]
        public void ThenEditCocktailsWindowShouldBeDisplayed()
        {
            editCocktailsForm.AssertWindowChange();
        }

        [Then(@"Application should close")]
        public void ThenApplicationShouldClose()
        {
            Assert.IsEmpty(driver.WindowHandles);
        }
    }
}