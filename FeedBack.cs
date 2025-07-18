using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class FeedBack
    {
        [TestMethod]
        public void Feedback()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("https://template2.webbeesite.com/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(3000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                Thread.Sleep(2000);

                // Click on the feedback button
                driver.FindElement(By.CssSelector(".feed-btn")).Click();
                Thread.Sleep(2000);

                // Locate the email input field in the pop-up and enter the email
                IWebElement emailInput = driver.FindElement(By.CssSelector(".border-gk-black"));
                emailInput.SendKeys("habib@gmail.com");
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("/html/body/app-root/div/app-footer/app-temp7/div/feedback/section/div/div/div[2]/div[2]/img[4]")).Click();
                Thread.Sleep(2000);

                // Click on the submit button
                IWebElement submitButton = driver.FindElement(By.CssSelector(".font-Manrope"));
                submitButton.Click();
                Thread.Sleep(2000);
            }
            finally
            {
                // Always quit the driver to ensure browser closure
                driver.Quit();
            }
        }
    }
}
