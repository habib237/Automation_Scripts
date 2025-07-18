using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FooterLinks
    {
        private IWebDriver driver;

        [TestMethod]
        public void FooterLinking()
        {
            driver = new ChromeDriver();

            // HomePage
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Scroll to the bottom of the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            // Clicking tabs in footer
            ClickElement(driver, ".flex-wrap > .font-RubikRegular:nth-child(1)");
            Thread.Sleep(2000);
            ClickElement(driver, ".text-\\[\\#AFAFAF\\]:nth-child(2)");
            Thread.Sleep(2000);
            ClickElement(driver, ".flex-wrap > .font-RubikRegular:nth-child(3)");
            Thread.Sleep(2000);
            ClickElement(driver, ".font-RubikRegular:nth-child(4)");
            Thread.Sleep(2000);
            ClickElement(driver, ".font-RubikRegular:nth-child(5)");
            Thread.Sleep(2000);
            ClickElement(driver, ".relative:nth-child(1) > .text-xs > .whitespace-nowrap");
            Thread.Sleep(2000);

            // Close the browser
            driver.Quit();
        }

        // Custom method to click an element with retry logic
        private void ClickElement(IWebDriver driver, string selector, int maxAttempts = 5)
        {
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                try
                {
                    IWebElement element = driver.FindElement(By.CssSelector(selector));
                    if (element.Displayed && element.Enabled)
                    {
                        element.Click();
                        return; // Exit the loop if successfully clicked
                    }
                }
                catch (NoSuchElementException)
                {
                    // Element not found, retry after a short delay
                    Thread.Sleep(1000);
                }
                catch (ElementNotInteractableException)
                {
                    // Element found but not interactable, retry after a short delay
                    Thread.Sleep(1000);
                }
            }
            // If max attempts reached without success, throw an exception
            throw new ElementNotInteractableException($"Unable to click element with selector '{selector}' after {maxAttempts} attempts.");
        }
    }
}
