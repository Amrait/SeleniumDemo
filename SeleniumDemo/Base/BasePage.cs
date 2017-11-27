using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumDemo.Locators;
using System;
using System.Threading;

namespace SeleniumDemo.Base
{
    public class BasePage
    {
        protected IWebElement GetElement(BaseLocator locator, params string [] args)
        {
            By strategy = locator.GetLocator(args);
            return BaseTest.driver.FindElement(strategy);
        }
        protected void TypeAndSubmit(string logMessage, string input, BaseLocator locator, params string[] args)
        {
            WriteLogMessage(logMessage);
            IWebElement element = GetElement(locator, args);
            element.Clear();
            element.SendKeys(input);
            element.Submit();
        }

        protected void Click(string logMessage, BaseLocator locator, params string[] args)
        {
            WriteLogMessage(logMessage);
            IWebElement element = GetElement(locator, args);
            element.Click();
        }

        protected void WaitForElementToBeVisible(string logMessage, BaseLocator locator, params string[] args)
        {
            WriteLogMessage(logMessage);
            IWebElement element = new WebDriverWait(BaseTest.driver, TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementIsVisible(locator.GetLocator(args)));
        }

        protected void WaitForElementToBeClickable(string logMessage, BaseLocator locator, params string[] args)
        {
            WriteLogMessage(logMessage);
            IWebElement element = new WebDriverWait(BaseTest.driver, TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementToBeClickable(locator.GetLocator(args)));
        }

        protected void Wait(string logMessage, int seconds)
        {
            WriteLogMessage(logMessage);
            Thread.Sleep(seconds * 1000);
        }

        protected void WriteLogMessage(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
