using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class AboutUsReadMoreButtononhomepage
    {
        [TestMethod]
        public void AboutUsLinking()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement readMoreButton = driver.FindElement(By.CssSelector("button.bg-white.text-gk-main-blue.font-MitrSemiBold.text-xs.xl\\:text-base.rounded-full.px-4.py-2.xl\\:px-7.xl\\:py-3"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", readMoreButton);
            Thread.Sleep(2000);
            readMoreButton.Click();
            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
