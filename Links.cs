using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class Links
    {
        [TestMethod]
        public void Linking()
        {

            IWebDriver driver = new ChromeDriver();

            //HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //About Us
            driver.FindElement(By.CssSelector(".relative:nth-child(2) > .text-xs")).Click();
            Thread.Sleep(2000);

            //Packages
            driver.FindElement(By.CssSelector(".relative:nth-child(3) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Appointment
            driver.FindElement(By.CssSelector(".relative:nth-child(4) > .text-xs > .whitespace-nowrap")).Click();
            Thread.Sleep(2000);

            //Services
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Contact Us
            driver.FindElement(By.CssSelector(".h-\\[43px\\]")).Click();
            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}