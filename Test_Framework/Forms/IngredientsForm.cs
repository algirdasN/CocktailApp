using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    class IngredientsForm : BaseForm
    {
        protected override string ID => "IngredientsForm";
        public IngredientsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {

        }
    }
}
