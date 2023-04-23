using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace Test_Framework.Forms
{
    public abstract class BaseForm
    {
        protected WindowsDriver<WindowsElement> driver;

        protected BaseForm(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        protected abstract string ID { get; }
        protected WindowsElement backButton => driver.FindElementByAccessibilityId("BackButton");
        protected WindowsElement exitButton => driver.FindElementByAccessibilityId("ExitButton");

        public void ClickBackButton()
        {
            ClickButtonAndSwitchWindow(backButton.Click);
        }

        public void ClickExitButton()
        {
            exitButton.Click();
        }

        protected void ClickButtonAndSwitchWindow(Action clickButton)
        {
            string winHandle = driver.CurrentWindowHandle;

            clickButton();

            try
            {
                Wait.Explicit(driver, 10).Until(d => !d.WindowHandles.Contains(winHandle));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new WebDriverTimeoutException("Origin form did not hide", ex);
            }

            SwitchToActiveWindow();
        }

        public void SwitchToActiveWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void AssertWindowChange()
        {
            Assert.IsTrue(driver.FindElementByAccessibilityId(ID).Displayed);
        }
    }
}