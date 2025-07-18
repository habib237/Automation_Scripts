using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class Designationscrollbar
    {

        [TestMethod]
        public void DesignationScrollbar()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // About Us
            driver.FindElement(By.CssSelector(".relative:nth-child(2) > .text-xs")).Click();
            Thread.Sleep(2000);

            // Scroll down to the message box
            IWebElement scrollableContainer = driver.FindElement(By.CssSelector(".font-MitrRegular.italic.text-white.text-justify.text-xl"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(scrollableContainer);
            actions.SendKeys(Keys.ArrowDown);
            actions.Perform();
            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
