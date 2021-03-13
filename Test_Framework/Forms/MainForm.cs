using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    public class MainForm : BaseForm
    {
        public MainForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {
        }

        protected override string ID => "MainForm";
        private WindowsElement cocktailsButton => driver.FindElementByAccessibilityId("CocktailsButton");
        private WindowsElement ingredientsButton => driver.FindElementByAccessibilityId("IngredientsButton");
        private WindowsElement editCocktailsButton => driver.FindElementByAccessibilityId("EditCocktailsButton");

        public void ClickCocktailsButton()
        {
            ClickButtonAndSwitchWindow(cocktailsButton.Click);
        }

        public void ClickIngredientsButton()
        {
            ClickButtonAndSwitchWindow(ingredientsButton.Click);
        }

        public void ClickEditCocktailButton()
        {
            ClickButtonAndSwitchWindow(editCocktailsButton.Click);
        }
    }
}