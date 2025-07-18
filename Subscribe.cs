using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Timers;

namespace UnitTestProject1
{
    [TestClass]
    public class Subscribe
    {

        [TestMethod]
        public void subscribe()
        {
            IWebDriver driver = new ChromeDriver();

            //open home page
            driver.Navigate().GoToUrl("https://template2.webbeesite.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".placeholder\\3Atext-\\[\\#FFFFFF\\]\\/70")).SendKeys("habib8@gmail.com");
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".xl\\3Agap-0:nth-child(1)")).Click();
            driver.FindElement(By.XPath("/html/body/app-root/div/app-footer/app-subscribe-button/app-temp7/section/div/div[2]/button")).Click();
            Thread.Sleep(2000);

            driver.Quit();

        }
    }
}
