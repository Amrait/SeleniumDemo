using System;
using OpenQA.Selenium;

namespace SeleniumDemo.Locators
{
    public class BaseLocator
    {
        public string pattern = String.Empty;
        public LocatorType type = LocatorType.XPath;

        /// <summary>
        /// Конструктор для створення локатора.
        /// </summary>
        /// <param name="_pattern">Базовий шаблон пошуку для обраного локатора</param>
        public BaseLocator(string _pattern)
        {
            pattern = _pattern;
        }

        /// <summary>
        /// Метод для отримання відповідного типу локатора для знаходження елементів.
        /// </summary>
        /// <param name="args">Опціональний параметр для специфікації динамічних умов пошуку</param>
        /// <returns>Стратегія пошуку локатора</returns>
        public By GetLocator(params string[] args)
        {
            switch (this.type)
            {
                case LocatorType.CSS:
                    {
                        if (args != null)
                            this.pattern = String.Format(pattern, args);
                        return By.CssSelector(pattern);
                    }
                case LocatorType.XPath:
                    {
                        if (args != null)
                            this.pattern = String.Format(pattern, args);
                        return By.XPath(pattern);
                    }
                default:
                    {
                        if (args != null)
                            this.pattern = String.Format(pattern, args);
                        return By.XPath(pattern);
                    }
            }
        }
    }
    /// <summary>
    /// Перелічення типів локаторів.
    /// </summary>
    public enum LocatorType
    {
        CSS,
        XPath
    }
}
