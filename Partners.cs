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
    public class Partners
    {
        [TestMethod]
        public void SwipeActionTest()
        {
            IWebDriver driver = new ChromeDriver();



            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000); // Let the page load

            // Find the element to perform the swipe action
            IWebElement element = driver.FindElement(By.CssSelector(".ng-tns-c16-7:nth-child(10) > .w-full > .w-full"));

            // Perform swipe action using Actions class
            Actions builder = new Actions(driver);
            builder.MoveToElement(element)
                   .ClickAndHold()
                   .MoveByOffset(100, 0) // Adjust offset based on your swipe direction
                   .Release()
                   .Perform();

            // Wait for the swipe action to complete
            Thread.Sleep(3000);

            // Find the element to perform the swipe action
            element = driver.FindElement(By.CssSelector(".ng-tns-c16-7:nth-child(10) > .w-full > .w-full"));

            Thread.Sleep(1000);

            // Perform swipe action using Actions class
            builder = new Actions(driver);
            builder.MoveToElement(element)
                  .ClickAndHold()
                  .MoveByOffset(-100, 0) // Adjust offset based on your swipe direction
                  .Release()
                  .Perform();

            Thread.Sleep(3000);

            driver.Quit();
        }  

    }   
}   


