using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Properties
{
    //[TestClass]
    //public class FooterLinks
    //{
        //[TestMethod]
        //public void footerlinks()
        //{
            //IWebDriver driver = new ChromeDriver();
            //FooterLinks links = new FooterLinks();


        //}
    //}
//}

//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;



    class FooterLinks
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // Navigate to the website
            driver.Navigate().GoToUrl("https://template2.webbeesite.com");

            // Wait for the page to load
            System.Threading.Thread.Sleep(5000);

            // Find the footer element
            IWebElement footer = driver.FindElement(By.Id("footer"));

            // Find all the footer links
            var footerLinks = footer.FindElements(By.TagName("a"));

            // Click on each link
            foreach (var link in footerLinks)
            {
                link.Click();
                System.Threading.Thread.Sleep(3000);

                // Verify that the page has loaded by checking the title
                if (driver.Title != "Webbee")
                {
                    Console.WriteLine("Failed to load page with title: " + driver.Title);
                }
                else
                {
                    Console.WriteLine("Successfully loaded page with title: " + driver.Title);
                }

                // Go back to the homepage
                driver.Navigate().Back();
                System.Threading.Thread.Sleep(3000);
            }

            // Close the browser
            driver.Quit();
        }
    }
}