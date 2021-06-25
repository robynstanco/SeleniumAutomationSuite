using Selenium.Framework.Helpers;
using Selenium.MyPokedex.Forms;

namespace Selenium.MyPokedex.Pages
{
    public class AddPokemonPage
    {
        private const string AddPokemon = nameof(AddPokemon);

        /// <summary>
        /// Go to the Add a Pokemon page.
        /// </summary>
        public static void GoTo()
        {
            NavigationHelpers.GoToPage(AddPokemon);
        }

        /// <summary>
        /// Assert you are at the add pokemon page within a normal timespan.
        /// </summary>
        public static void AssertIsAt()
        {
            AssertionHelpers.AssertIsAtPage(AddPokemon, TimeSpanHelpers.NormalWait);
        }
        
        public static AddPokemonForm CurrentAddPokemonForm { get; private set; }
        /// <summary>
        /// Initiate add pokemon form chaining.
        /// </summary>
        /// <returns>login form for chaining</returns>
        public static AddPokemonForm Add()
        {
            CurrentAddPokemonForm = new AddPokemonForm();

            return CurrentAddPokemonForm;
        }
    }
}