using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UnitTestProject1
{

    [TestClass]
    public class WhatsApp_QR_Chat
    {
        
        [TestMethod]
        public void whatsAppQRChat()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".joinchat__button")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".joinchat__button__send")).Click();
            Thread.Sleep(2000);

            driver.Quit();

        }
    }
}