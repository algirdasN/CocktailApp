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

        public CocktailFormSteps(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            InitiateForms();
        }

        private void InitiateForms()
        {
            mainForm = new MainForm(driver);
        }

        [Given(@"I navigated to Cocktails window")]
        public void GivenINavigatedToCocktailsWindow()
        {
            mainForm.ClickCocktailsButton()
                    .AssertWindowChange();
        }

    }
}
