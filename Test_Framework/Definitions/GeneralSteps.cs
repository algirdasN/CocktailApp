using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using System.Diagnostics;
using TechTalk.SpecFlow;
using Test_Framework.Forms;

namespace Test_Framework.Definitions
{


    [Binding]
    class GeneralSteps
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
            Assert.IsTrue(Process.GetProcessesByName("CocktailApp").Length == 0);
        }
    }
}
