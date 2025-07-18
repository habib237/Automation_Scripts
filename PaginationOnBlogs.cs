using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class PaginationOnBlogs
    {
        [TestMethod]
        public void Paginationonblogs()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");

            using (IWebDriver driver = new ChromeDriver(options))
            {
                try
                {
                    driver.Navigate().GoToUrl("https://template1.demowbs.com/");
                    System.Threading.Thread.Sleep(3000); // Wait for the page to load

                    // Wait for and click the Show All button
                    IWebElement showAllButton = WaitForElement(driver, By.XPath("//button[contains(text(), 'Show All')]"));
                    ScrollIntoViewAndClick(driver, showAllButton);

                    System.Threading.Thread.Sleep(5000); // Wait for the blogs to load

                    // Find the next page button
                    IWebElement nextPageButton = driver.FindElement(By.XPath("/html/body/app-root/div/div/app-blogs/app-temp6/div/div[2]/div[2]/pagination/div/nav/button[2]"));

                    // Loop through pagination until next button is disabled
                    while (nextPageButton.Enabled)
                    {
                        HighlightElement(driver, nextPageButton);
                        Console.WriteLine("Next page button found.");

                        ScrollIntoViewAndClick(driver, nextPageButton);

                        // Wait for the next page of blogs to load
                        System.Threading.Thread.Sleep(5000); // Adjust if needed based on the page load time

                        // Find the next page button again
                        nextPageButton = driver.FindElement(By.XPath("/html/body/app-root/div/div/app-blogs/app-temp6/div/div[2]/div[2]/pagination/div/nav/button[2]"));
                    }

                    // Log when reached the last page
                    Console.WriteLine("Reached the last page.");

                    // Find the previous page button
                    IWebElement prevPageButton = driver.FindElement(By.XPath("/html/body/app-root/div/div/app-blogs/app-temp6/div/div[2]/div[2]/pagination/div/nav/button[1]"));

                    // Check if the previous button is enabled
                    if (prevPageButton.Enabled)
                    {
                        HighlightElement(driver, prevPageButton);
                        Console.WriteLine("Previous page button found.");

                        // Scroll and click the previous button
                        ScrollIntoViewAndClick(driver, prevPageButton);

                        // Wait for the previous page of blogs to load
                        System.Threading.Thread.Sleep(5000); // Adjust if needed based on the page load time
                    }
                    else
                    {
                        // Log a message indicating that the previous button is disabled
                        Console.WriteLine("Previous page button is disabled on the first page.");
                    }
                }
                finally
                {
                    // Close the browser
                    driver.Quit();
                }
            }
        }

        private IWebElement WaitForElement(IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            IWebElement element = null;
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                try
                {
                    element = driver.FindElement(by);
                    if (element.Displayed && element.Enabled)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Ignore, wait and retry
                }
                System.Threading.Thread.Sleep(1000);
            }
            if (element == null)
            {
                throw new NoSuchElementException($"Element not found: {by}");
            }
            return element;
        }

        private void ScrollIntoViewAndClick(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", element);
            System.Threading.Thread.Sleep(1000); // Give time for scroll to complete

            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // If element click is intercepted, try using JavaScript click as a fallback
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
            }
        }

        private void HighlightElement(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }
    }
}
