using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    abstract class BaseForm
    {
        protected delegate void ClickButton();
        protected abstract string ID { get; }
        
        protected WindowsDriver<WindowsElement> driver;

        protected Wait wait;

        protected WindowsElement backButton => driver.FindElementByAccessibilityId("BackButton");
        protected WindowsElement exitButton => driver.FindElementByAccessibilityId("ExitButton");

        protected BaseForm(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;

            wait = new Wait(driver);
        }

        protected void ClickButtonAndSwitchWindow(ClickButton clickButton)
        {
            string winHandle = driver.CurrentWindowHandle;

            clickButton();

            try
            {
                wait.Explicit(1000).Until(d => !d.WindowHandles.Contains(winHandle));
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("Origin form did not hide");
            }
            
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void AssertWindowChange()
        {
            Assert.IsTrue(driver.FindElementByAccessibilityId(ID).Displayed);
        }

        public void ClickBackButton()
        {
            ClickButtonAndSwitchWindow(backButton.Click);
        }

        public void ClickExitButton()
        {
            exitButton.Click();
        }
    }
}
