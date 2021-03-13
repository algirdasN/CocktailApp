using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class MainForm : BaseForm
    {
        protected override string ID => "MainForm";
        private WindowsElement cocktailsButton => driver.FindElementByAccessibilityId("CocktailsButton");
        private WindowsElement ingredientsButton => driver.FindElementByAccessibilityId("IngredientsButton");
        private WindowsElement editCocktailsButton => driver.FindElementByAccessibilityId("EditCocktailsButton");

        public MainForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }

        public CocktailsForm ClickCocktailsButton()
        {
            ClickButtonAndSwitchWindow(cocktailsButton.Click);

            return new CocktailsForm(driver);
        }

        public IngredientsForm ClickIngredientsButton()
        {
            ClickButtonAndSwitchWindow(ingredientsButton.Click);

            return new IngredientsForm(driver);
        }

        public EditCocktailsForm ClickEditCocktailButton()
        {
            ClickButtonAndSwitchWindow(editCocktailsButton.Click);

            return new EditCocktailsForm(driver);
        }
    }
}
