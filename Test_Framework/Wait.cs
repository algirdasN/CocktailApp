using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;

namespace Test_Framework
{
    public class Wait
    {
        private WindowsDriver<WindowsElement> driver;

        public Wait(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public void ImplicitZero()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
        }

        public void ImplicitFiveSeconds()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public DefaultWait<WindowsDriver<WindowsElement>> Explicit(int time_ms)
        {
            var wait = new DefaultWait<WindowsDriver<WindowsElement>>(driver)
            {
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Timeout = TimeSpan.FromMilliseconds(time_ms)
            };

            return wait;
        }
    }
}
