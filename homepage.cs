using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class homepage
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Navigate to Home page
                driver.Navigate().GoToUrl("https://template2.webbeesite.com");
                driver.Manage().Window.Maximize();

                // Wait for a few seconds (adjust the time as needed)
                Thread.Sleep(2000);

            }
            finally
            {
                // Close the browser window
                driver.Quit();
            }
        }
    }
}
