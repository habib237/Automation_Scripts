using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class NewsAndEventsShowAll
    {
        [TestMethod]
        public void newsandeventsshowall()
        {
            IWebDriver driver = new ChromeDriver();

            // HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Find and click the Show All button for News and Events using CSS selector
            IWebElement showAllButton = driver.FindElement(By.CssSelector("body > app-root > div > div > app-home > app-temp7 > app-news > app-temp1 > div > app-feed-list > section > div.flex.mt-4.text-sm.font-RubikSemiBold.justify-start.text-white.ng-star-inserted > button"));
            Thread.Sleep(3000);

            // Scroll the button into view if needed
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", showAllButton);
            Thread.Sleep(3000);

            // Click the Show All button for News and Events
            showAllButton.Click();

            Thread.Sleep(5000);

            // Close the browser
            driver.Quit();
        }
    }
}
