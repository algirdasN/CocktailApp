using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class EditCocktailsForm : BaseForm
    {
        protected override string ID => "EditCocktailsForm";
        public EditCocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }
    }
}
