using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class promotionalvideo
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [TestMethod]
        public void missionvisionandvalues()
        {
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Wait for the play button to be present
            IWebElement playButton = WaitForElement(By.CssSelector(".animate-ping"));
            Thread.Sleep(2000);

            // Scroll to the play button
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", playButton);
            Thread.Sleep(2000);

            // Simulate a mouse click on the play button using Actions
            new Actions(driver).MoveToElement(playButton).Click().Build().Perform();
            Thread.Sleep(2000);

            // Wait for the stop button to be present
            IWebElement stopButton = WaitForElement(By.CssSelector(".xl\\3Arounded-3xl"));
            Thread.Sleep(2000);

            // Scroll to the stop button
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", stopButton);
            Thread.Sleep(2000);

            // Simulate a mouse click on the stop button using Actions
            new Actions(driver).MoveToElement(stopButton).Click().Build().Perform();
            Thread.Sleep(2000);

        }

        private IWebElement WaitForElement(By by)
        {
            return wait.Until(driver => driver.FindElement(by));
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Close the browser after the test
            driver.Quit();
        }
    }
}
