using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class DevOps
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            // List of URLs to open
            string[] urls = new string[]
            {
                "https://demo.fougito.com",
                "https://tikkapaaji.com",
                "https://spicedelirestaurant.com",
                "https://prabhusvegrestaurant.com",
                "https://relishuae.com",
                "https://r32sushi.com",
                "https://amrirestaurant.com",
                "https://www.yummyhouseuae.com",
                "https://chowchinese.com/",
                "https://thechocolatere.com/",
                "https://chachafluffy.com/"
            };

            // Open the first URL in the initial tab
            driver.Navigate().GoToUrl(urls[0]);
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

            // Open remaining URLs in new tabs
            for (int i = 1; i < urls.Length; i++)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                var tabs = driver.WindowHandles;
                driver.SwitchTo().Window(tabs[i]);
                driver.Navigate().GoToUrl(urls[i]);
                driver.Manage().Window.Maximize();
                Thread.Sleep(5000);
            }

            // Optional: Switch back to the first tab if needed
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            // Close the browser
            driver.Quit();
        }
    }
}
