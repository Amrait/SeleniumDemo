using SeleniumDemo.Pages;

namespace SeleniumDemo.Pages
{
    public static class Pages
    {
        private static GoogleSearchPage googleSearchPage = null;
        private static GoogleSearchResultsPage googleSearchResultsPage = null;

        public static GoogleSearchPage GoogleSearchPage()
        {
            if (googleSearchPage == null)
                googleSearchPage = new GoogleSearchPage();
            return googleSearchPage;
        }

        public static GoogleSearchResultsPage GoogleSearchResultsPage()
        {
            if (googleSearchResultsPage == null)
                googleSearchResultsPage = new GoogleSearchResultsPage();
            return googleSearchResultsPage;
        }
    }
}
