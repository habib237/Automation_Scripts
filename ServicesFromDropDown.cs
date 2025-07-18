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
    public class ServicesFromDropDown
    {
        [TestMethod]
        public void LinkingSevices()
        {
            IWebDriver driver = new ChromeDriver();

            //HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);


            //Services
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //First Service From DropDown
            driver.FindElement(By.CssSelector(".relative:nth-child(5) .px-4:nth-child(1)")).Click();
            Thread.Sleep(2000);

            //Services
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Second Service From DropDown
            driver.FindElement(By.CssSelector(".relative:nth-child(5) .px-4:nth-child(2)")).Click();
            Thread.Sleep(2000);

            //Services
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Third Service From DropDown
            driver.FindElement(By.CssSelector(".relative:nth-child(5) .px-4:nth-child(3)")).Click();
            Thread.Sleep(2000);

            //Services
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Forth Service From DropDown
            driver.FindElement(By.CssSelector(".relative:nth-child(5) .px-4:nth-child(4)")).Click();
            Thread.Sleep(2000);

            //Services
            driver.FindElement(By.CssSelector(".relative:nth-child(5) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}