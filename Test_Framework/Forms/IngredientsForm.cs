using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class IngredientsForm : BaseForm
    {
        public IngredientsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }

        public void AssertWindowChange()
        {
            base.AssertWindowChange("IngredientsForm");
        }
    }
}
