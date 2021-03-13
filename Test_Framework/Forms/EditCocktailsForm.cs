using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class EditCocktailsForm : BaseForm
    {
        public EditCocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }

        public void AssertWindowChange()
        {
            base.AssertWindowChange("EditCocktailsForm");
        }
    }
}
