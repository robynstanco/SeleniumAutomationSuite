using Selenium.Framework.Helpers;

namespace Selenium.MyPokedex.Pages
{
    public class MyPokedexPage
    {
        private const string MyPokedex = nameof(MyPokedex);

        /// <summary>
        /// Go to the MyPokedex (Home) page.
        /// </summary>
        public static void GoTo()
        {
            NavigationHelpers.GoToPage(MyPokedex);
        }

        /// <summary>
        /// Assert you are at the mypokedex page within a normal timespan.
        /// </summary>
        public static void AssertIsAt()
        {
            AssertionHelpers.AssertIsAtPage(MyPokedex, TimeSpanHelpers.NormalWait);
        }
    }
}