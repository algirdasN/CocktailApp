using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;
using System.IO;

namespace Test_Framework.Tests
{
    class BaseTest
    {
        WindowsDriver<WindowsElement> driver;

        [SetUp]
        public void BaseSetup()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            var relativePath = @"..\..\..\..\CocktailApp\bin\Debug\CocktailApp.exe";
            var path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, relativePath));

            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", path);
            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
        }

        [Test]
        public void Test()
        {
            Assert.IsNotNull(driver);
        }

        [TearDown]
        public void BaseTeardown()
        {
            Array.ForEach(Process.GetProcessesByName("WinAppDriver"), p => p.Kill());
        }
    }
}
