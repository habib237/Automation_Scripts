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
    public class Contact_Us_Form
    {

        [TestMethod]
        public void ContactUs()
        {
            IWebDriver driver = new ChromeDriver();

            //open home page
            driver.Navigate().GoToUrl("https://template2.webbeesite.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            //Contact Us Button
            driver.FindElement(By.CssSelector(".h-\\[43px\\]")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(2000);

            //Form Fields
            driver.FindElement(By.CssSelector("input[formcontrolname='Name']")).SendKeys("Habib");

            driver.FindElement(By.CssSelector("input[formcontrolname='Email']")).SendKeys("habib@gmail.com");

            driver.FindElement(By.CssSelector("input[formcontrolname='PhoneNumber']")).SendKeys("+924456789332");

            driver.FindElement(By.CssSelector("input[formcontrolname='Company']")).SendKeys("Technomites");

            driver.FindElement(By.CssSelector(".py-\\[18px\\]")).SendKeys("Just For Testing");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/app-root/div/div/app-contact/app-temp7/section/div[3]/form/div[2]/button")).Click();

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}