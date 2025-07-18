using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class AppointmentForm
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();


            // Open homepage
            driver.Navigate().GoToUrl("https://template1.demowbs.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
/*
            //Appointment Button
            driver.FindElement(By.CssSelector(".relative:nth-child(4) > .text-xs > .whitespace-nowrap")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(2000);

            //Form Fields
            driver.FindElement(By.CssSelector("input[formcontrolname='Name']")).SendKeys("Habib");

            driver.FindElement(By.CssSelector("input[formcontrolname='Email']")).SendKeys("habib@gmail.com");

            driver.FindElement(By.CssSelector("input[formcontrolname='PhoneNumber']")).SendKeys("+924456789332");

            driver.FindElement(By.CssSelector("input[formcontrolname='Company']")).SendKeys("Technomites");

            js.ExecuteScript("arguments[0].value = arguments[1];", driver.FindElement(By.CssSelector("input[formcontrolname='dateTime']")),"2024-03-08T23:21");

            driver.FindElement(By.CssSelector(".py-\\[18px\\]")).SendKeys("Just For Testing");



            Thread.Sleep(2000);

            //driver.FindElement(By.XPath("/html/body/app-root/div/div/app-appoinment/app-temp7/section/div[2]/form/div[2]/button")).Click();
           
            Thread.Sleep(5000);

            //driver.Quit();
            */
        }
    }
}