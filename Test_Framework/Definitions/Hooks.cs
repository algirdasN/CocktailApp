using BoDi;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;
using System.IO;
using TechTalk.SpecFlow;

namespace Test_Framework.Definitions
{
    [Binding]
    public sealed class Hooks
    {
        private IObjectContainer objectContainer;

        private WindowsDriver<WindowsElement> driver;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void StartWinAppDriver()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
        }

        [AfterTestRun]
        public static void KillWinAppDriver()
        {
            Array.ForEach(Process.GetProcessesByName("WinAppDriver"), p => p.Kill());
        }

        [BeforeScenario]
        public void OpenApplication()
        {
            var relativePath = @"..\..\..\..\CocktailApp\bin\Debug\CocktailApp.exe";
            var path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, relativePath));

            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", path);
            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void CloseApplication()
        {
            driver.Quit();
        }
    }
}
