using OpenQA.Selenium.Appium.Windows;
using System;
using System.Text;

namespace Test_Framework.Forms
{
    public class OpenFolderDialog
    {
        private WindowsDriver<WindowsElement> driver;

        public OpenFolderDialog(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        private WindowsElement okButton => driver.FindElementByAccessibilityId("1");

        public void OpenFolderByPath(string destinationPath)
        {
            StringBuilder xPathBuilder = new StringBuilder("//TreeItem[@Name='This PC']");

            string[] path = destinationPath.Split('\\', StringSplitOptions.RemoveEmptyEntries);

            driver.FindElementByXPath(xPathBuilder.ToString()).Click();

            foreach (var item in path)
            {
                if (item.Contains(':'))
                {
                    xPathBuilder.Append($"/TreeItem[contains(@Name,'({item})')]");
                }
                else
                {
                    xPathBuilder.Append($"/TreeItem[@Name='{item}']");
                }

                driver.FindElementByXPath(xPathBuilder.ToString()).Click();
            }

            okButton.Click();
        }
    }
}
