using SeleniumDemo.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Pages
{
    public class GoogleSearchResultsPage : Base.BasePage
    {
        BaseLocator resultsNavbar = new CSS("#top_nav");

        public void WaitForPageToLoad()
        {
            WaitForElementToBeVisible("Очікуємо, поки сторінка з результатами завантажиться...",
                resultsNavbar);
        }
    }
}
