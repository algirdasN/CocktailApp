using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;

namespace Test_Framework
{
    public static class Wait
    {
        public static void Implicit(WindowsDriver<WindowsElement> driver, int time_sec)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time_sec);
        }

        public static DefaultWait<WindowsDriver<WindowsElement>> Explicit(WindowsDriver<WindowsElement> driver, int time_ms)
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