using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    public class EditCocktailsForm : BaseForm
    {
        public EditCocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {
        }

        protected override string ID => "EditCocktailsForm";
    }
}