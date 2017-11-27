using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumDemo.Base
{
    public class BaseTest
    {
        //Екземпляр браузеру найбільш загального типу
        public static IWebDriver driver = null;

        /// <summary>
        /// Метод, який буде виконуватись перед кожним тестовим методом
        /// </summary>
        [SetUp]
        public void BeforeTestSetup()
        {
            this.StartChromeBrowser();
        }

        /// <summary>
        /// Метод який буде виконуватись після кожного тестового методу
        /// </summary>
        [TearDown]
        public void AfterTestTearDown()
        {
            //Відключення від драйверу та закриття вікон браузеру
            driver.Close();
        }

        /// <summary>
        /// Метод для запуску браузеру Google Chrome
        /// </summary>
        private void StartChromeBrowser()
        {
            //Привласнення базовому драйверу типу драйверу для браузеру Google Chrome
            driver = new ChromeDriver();
            //Збільшення розміру вікна браузеру до максимуму
            driver.Manage().Window.Maximize();
        }
    }
}
