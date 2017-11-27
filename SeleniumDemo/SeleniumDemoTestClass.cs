using NUnit.Framework;
using System.Threading;
using SeleniumDemo.Pages;

namespace SeleniumDemo
{
    [TestFixture]
    public class SeleniumDemoTestClass : Base.BaseTest
    {
        [Test]
        public void GoogleSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Pages.Pages.GoogleSearchPage().WaitForPageToLoad();
            Pages.Pages.GoogleSearchPage().TypeGoogleInputQuery("ПолтНТУ");
            Pages.Pages.GoogleSearchResultsPage().WaitForPageToLoad();
            Assert.IsTrue(driver.Title.StartsWith("ПолтНТУ"),
                "Сторінка пошуку видала невірні результати.");
            Thread.Sleep(5000);
        }
    }
}
