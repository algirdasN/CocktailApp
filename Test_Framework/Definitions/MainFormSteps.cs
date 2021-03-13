using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;
using Test_Framework.Forms;

namespace Test_Framework.Definitions
{
    [Binding]
    public sealed class MainFormSteps
    {
        private WindowsDriver<WindowsElement> driver;

        private MainForm mainForm;

        public MainFormSteps(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            InitiateForms();
        }

        private void InitiateForms()
        {
            mainForm = new MainForm(driver);
        }


        [When(@"I click Cocktails button")]
        public void WhenIClickCocktailsButton()
        {
            mainForm.ClickCocktailsButton();
        }

        [When(@"I click Ingredients button")]
        public void WhenIClickIngredientsButton()
        {
            mainForm.ClickIngredientsButton();
        }

        [When(@"I click Edit Cocktails button")]
        public void WhenIClickEditCocktailsButton()
        {
            mainForm.ClickEditCocktailButton();
        }
    }
}
