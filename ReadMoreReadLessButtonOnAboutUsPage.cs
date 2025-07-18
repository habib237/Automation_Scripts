using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class ReadMoreReadLessButtonOnAboutUsPage
    {
        [TestMethod]
        public void aboutusreadmorereadless()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //About Us
            driver.FindElement(By.CssSelector(".relative:nth-child(2) > .text-xs")).Click();
            Thread.Sleep(2000);

            // Click on the Read More button using JavaScript
            IWebElement readMoreButton = driver.FindElement(By.XPath("//button[contains(text(), 'Read More')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", readMoreButton);
            Thread.Sleep(2000);

            // Click on the Read Less button using JavaScript
            IWebElement readLessButton = driver.FindElement(By.XPath("//button[contains(text(), 'Read Less')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", readLessButton);
            Thread.Sleep(2000);

            driver.Quit();

        }
    }
}
