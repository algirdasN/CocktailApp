using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class MainForm : BaseForm
    {
        private WindowsElement cocktailsButton => driver.FindElementByAccessibilityId("CocktailsButton");
        private WindowsElement ingredientsButton => driver.FindElementByAccessibilityId("IngredientsButton");
        private WindowsElement editCocktailsButton => driver.FindElementByAccessibilityId("EditCocktailsButton");

        public MainForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }

        public void AssertWindowChange()
        {
            base.AssertWindowChange("MainForm");
        }

        public void ClickCocktailsButton()
        {
            string winHandle = driver.CurrentWindowHandle;

            cocktailsButton.Click();

            SwitchDriverToActiveWindow(winHandle);
        }

        public void ClickIngredientsButton()
        {
            string winHandle = driver.CurrentWindowHandle;

            ingredientsButton.Click();

            SwitchDriverToActiveWindow(winHandle);
        }

        public void ClickEditCocktailButton()
        {
            string winHandle = driver.CurrentWindowHandle;

            editCocktailsButton.Click();

            SwitchDriverToActiveWindow(winHandle);
        }

        public void ClickExitButton()
        {
            exitButton.Click();
        }
    }
}
