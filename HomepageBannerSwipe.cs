using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace UnitTestProject1
{
    [TestClass]
    public class HomepageBannerSwipe

    {
        private IWebDriver driver;

        [TestMethod]
        public void homeBanners()
        {
            // Replace this path with the actual path to your ChromeDriver executable
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();

            var element = driver.FindElement(By.CssSelector(".active > .xl\\3A-mr-24"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();

            // Get the size of the element
            var elementSize = element.Size;

            // Calculate the step size based on the element's size
            int stepSize = 9;

            // Perform crawling by moving the cursor in small steps
            //for (int i = 0; i < elementSize.Width; i += stepSize)
            for (int i = 0; i < elementSize.Width *5; i += stepSize)
            
            {
                builder.MoveByOffset(stepSize, 0).Perform();
                Thread.Sleep(50); // Add a small delay to make the crawling effect visible
            }

            builder.Release().Perform();
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}