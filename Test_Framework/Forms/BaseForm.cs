using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    abstract class BaseForm
    {
        protected WindowsDriver<WindowsElement> driver;

        protected Wait wait;
        protected WindowsElement backButton => driver.FindElementByAccessibilityId("BackButton");
        protected WindowsElement exitButton => driver.FindElementByAccessibilityId("ExitButton");

        protected BaseForm(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            wait = new Wait(driver);
        }

        protected void SwitchDriverToActiveWindow(string winHandle)
        {
            try
            {
                wait.Explicit(1000).Until(d => !d.WindowHandles.Contains(winHandle));
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("Main form did not hide");
            }
            
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        protected virtual void AssertWindowChange(string accessId)
        {
            Assert.IsTrue(driver.FindElementByAccessibilityId(accessId).Displayed);
        }
    }
}
