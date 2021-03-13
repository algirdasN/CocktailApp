using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class CocktailsForm : BaseForm
    {
        public CocktailsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }

        public void AssertWindowChange()
        {
            base.AssertWindowChange("CocktailsForm");
        }
    }
}
