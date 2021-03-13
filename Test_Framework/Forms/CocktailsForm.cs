using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class CocktailsForm : BaseForm
    {
        protected override string ID => "CocktailsForm";

        public CocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }

    }
}
