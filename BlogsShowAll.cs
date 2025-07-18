using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class BlogsShowAll
    {
        [TestMethod]
        public void blogsshowall()
        {
            IWebDriver driver = new ChromeDriver();

            // HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Find and click the Show All button
            IWebElement showAllButton = driver.FindElement(By.XPath("//button[contains(text(), 'Show All')]"));
            Thread.Sleep(3000);

            // Scroll the button into view if needed
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", showAllButton);
            Thread.Sleep(3000);

            // Click the Show All button
            showAllButton.Click();

            Thread.Sleep(5000);

            // Close the browser
            driver.Quit();




        }
    }
}
