using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Testimonials
    {
        [TestMethod]
        public void testimonial()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                // HomePage
                driver.Navigate().GoToUrl("https://template2.webbeesite.com");
                driver.Manage().Window.Maximize();

                // Add a short wait after page load
                System.Threading.Thread.Sleep(2000);

                // Scroll to the middle of the page
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight / 2)");

                // Add a short wait after scrolling
                System.Threading.Thread.Sleep(1000);

                // Retry logic for clicking next testimonial button
                if (!RetryClick(driver, By.CssSelector("#testimonial_container .owl-next")))
                    throw new NoSuchElementException("Next testimonial button not found or clickable.");

                System.Threading.Thread.Sleep(2000);

                // Retry logic for clicking previous testimonial button
                if (!RetryClick(driver, By.CssSelector("#testimonial_container .owl-prev")))
                    throw new NoSuchElementException("Previous testimonial button not found or clickable.");

                System.Threading.Thread.Sleep(2000);

                // Retry logic for clicking specific testimonial dot
                if (!RetryClick(driver, By.CssSelector(".owl-dot:nth-child(3) > span")))
                    throw new NoSuchElementException("Specific testimonial dot not found or clickable.");

                System.Threading.Thread.Sleep(2000);

                // Retry logic for clicking next testimonial button again
                if (!RetryClick(driver, By.CssSelector("#testimonial_container .owl-next")))
                    throw new NoSuchElementException("Next testimonial button (second attempt) not found or clickable.");
            }
        }

        // Retry logic for clicking an element
        private bool RetryClick(IWebDriver driver, By locator, int attempts = 3)
        {
            for (int i = 0; i < attempts; i++)
            {
                try
                {
                    // Find the element
                    IWebElement element = driver.FindElement(locator);

                    // Check if the element is visible and enabled
                    if (element.Displayed && element.Enabled)
                    {
                        // Click the element
                        element.Click();
                        return true;
                    }
                }
                catch (Exception) { }

                // If element is not clickable, wait for a short duration before retrying
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
    }
}
