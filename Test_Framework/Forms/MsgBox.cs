﻿using OpenQA.Selenium.Appium.Windows;

namespace Test_Framework.Forms
{
    public class MsgBox
    {
        private WindowsDriver<WindowsElement> driver;

        public MsgBox(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        private WindowsElement messageTitle => driver.FindElementByAccessibilityId("TitleBar");
        private WindowsElement messageText => driver.FindElementByAccessibilityId("65535");
        private WindowsElement okButton => driver.FindElementByAccessibilityId("2");

        public void SwitchFocusToMsgBox()
        {
            Wait.Explicit(driver, 5000).Until(d => d.WindowHandles.Count > 1);

            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void ClickOkButton()
        {
            okButton.Click();
        }

        public string GetMessageTitle()
        {
            return messageTitle.Text;
        }

        public string GetMessageText()
        {
            return messageText.Text;
        }
    }
}
