using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace UnitTestProject1
{
    [TestClass]
    public class ServicesFromSection
    {
        [TestMethod]
        public void SevicesSection()
        {
            IWebDriver driver = new ChromeDriver();

            //HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".w-full:nth-child(1) > .ng-star-inserted .MsoNormal")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}