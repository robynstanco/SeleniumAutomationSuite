using Selenium.Framework;
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

        /// <summary>
        /// Assert the release of the pokemon from the mypokedex page succeeds within a normal timespan.
        /// </summary>
        public static void AssertReleaseIsSuccessful()
        {
            AssertionHelpers.AssertElementIsVisibleByXPath(string.Format(Constants.HeaderWithTextXPath, 
                "The release was successful!"), TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// View the Pokemon from Pokedex by given nickname.
        /// </summary>
        /// <param name="nickName">nickname to view</param>
        public static void ViewPokemonByNickname(string nickName)
        {
            ElementHelpers.ClickFirstElementByXPath("//h4[text()='Nickname: " + nickName + "']");
        }

        /// <summary>
        /// Release the current Pokemon.
        /// </summary>
        public static void ReleaseCurrentPokemon()
        {
            ElementHelpers.ClickFirstElementByXPath("//a[contains(@href, 'Delete')]");
        }
    }
}