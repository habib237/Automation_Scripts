using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class Clicking_packages
    {
        [TestMethod]
        public void packages()
        {

            IWebDriver driver = new ChromeDriver();

            //HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //About Us
            driver.FindElement(By.CssSelector(".relative:nth-child(2) > .text-xs")).Click();
            Thread.Sleep(2000);

            //Packages
            driver.FindElement(By.CssSelector(".relative:nth-child(3) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Select Basic Package from Dropdown
            driver.FindElement(By.CssSelector(".px-4:nth-child(1)")).Click();
            Thread.Sleep(2000);

            //Packages
            driver.FindElement(By.CssSelector(".relative:nth-child(3) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Select Standaed Package from Dropdown
            driver.FindElement(By.CssSelector(".px-4:nth-child(2)")).Click();
            Thread.Sleep(2000);

            //Packages
            driver.FindElement(By.CssSelector(".relative:nth-child(3) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Select Advanced Package from Dropdown
            driver.FindElement(By.CssSelector(".px-4:nth-child(3)")).Click();
            Thread.Sleep(2000);

            //Packages
            driver.FindElement(By.CssSelector(".relative:nth-child(3) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Select Premium Package from Dropdown
            driver.FindElement(By.CssSelector(".px-4:nth-child(4)")).Click();
            Thread.Sleep(2000);

            //Packages
            driver.FindElement(By.CssSelector(".relative:nth-child(3) > .flex > .text-xs")).Click();
            Thread.Sleep(2000);

            //Select Premium Plus Package from Dropdown
            driver.FindElement(By.CssSelector(".px-4:nth-child(5)")).Click();
            Thread.Sleep(2000);

            driver.Quit();


        }
    }
}
