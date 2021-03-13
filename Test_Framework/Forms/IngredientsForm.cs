using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace Test_Framework.Forms
{
    public class IngredientsForm : BaseForm
    {
        public IngredientsForm(WindowsDriver<WindowsElement> driver) : base(driver)
        {
        }

        protected override string ID => "IngredientsForm";
    }
}