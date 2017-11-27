using SeleniumDemo.Locators;
using SeleniumDemo.Base;

namespace SeleniumDemo.Pages
{
    public class GoogleSearchPage : BasePage
    {
        BaseLocator pageContainer = new CSS("#viewport");
        BaseLocator searchInputField = new CSS("#lst-ib");
        BaseLocator submitSearchButton = new XPath("//input[@name='btnK']");

        public void WaitForPageToLoad()
        {
            WaitForElementToBeVisible("Очікування завантаження сторінки пошуку...",
                pageContainer);
        }
        public void TypeGoogleInputQuery(string query)
        {
            TypeAndSubmit("Вводимо повідомлення у поле пошуку пошукової сторінки Google...",
                query, searchInputField);
        }

        public void ClickSearchButton()
        {
            WaitForElementToBeClickable("Очікуємо того, поки кнопка 'Пошук' буде доступною для кліку...",
                submitSearchButton);
            Click("Натискаємо кнопку 'Пошук'",
                submitSearchButton);
        }
    }
}
