using Selenium.Framework;
using Selenium.Framework.Forms;
using Selenium.Framework.Helpers;

namespace Selenium.MyPokedex.Forms
{
    public class AddPokemonForm : SimpleForm
    {
        /// <summary>
        /// Sets the nickname field to a given nickname.
        /// </summary>
        /// <param name="nickName">nickname to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithNickname(string nickName)
        {
            ElementHelpers.SetFirstElementById("Nickname", nickName);

            return this;
        }

        /// <summary>
        /// Sets the Pokemon field to a given pokemon.
        /// </summary>
        /// <param name="pokemon">pokemon to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithPokemon(string pokemon)
        {
            ElementHelpers.ClickFirstElementById("SelectedNationalDexPokemonId");

            ElementHelpers.ClickFirstElementByXPath(string.Format(Constants.OptionWithTextXPath, pokemon));

            return this;
        }

        /// <summary>
        /// Sets the Pokeball field to a given pokeball.
        /// </summary>
        /// <param name="pokeball">pokeball to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithPokeball(string pokeball)
        {
            ElementHelpers.ClickFirstElementById("SelectedPokeballId");

            ElementHelpers.ClickFirstElementByXPath(string.Format(Constants.OptionWithTextXPath, pokeball));

            return this;
        }

        /// <summary>
        /// Sets the capture date field to a given date.
        /// </summary>
        /// <param name="date">date to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithCaptureDate(string date)
        {
            ElementHelpers.SetFirstElementById("Date", date);

            return this;
        }

        /// <summary>
        /// Sets the location field to a given location.
        /// </summary>
        /// <param name="location">location to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithLocation(string location)
        {
            ElementHelpers.SetFirstElementById("Location", location);

            return this;
        }

        /// <summary>
        /// Sets the level field to a given level.
        /// </summary>
        /// <param name="level">level to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithLevel(string level)
        {
            ElementHelpers.SetFirstElementById("Level", level);

            return this;
        }

        /// <summary>
        /// Sets the sex field to a given sex.
        /// </summary>
        /// <param name="sex">sex to use</param>
        /// <returns>current add form for chaining</returns>
        public AddPokemonForm WithSex(string sex)
        {
            ElementHelpers.ClickFirstElementById("SelectedSexId");

            ElementHelpers.ClickFirstElementByXPath(string.Format(Constants.OptionWithTextXPath, sex));

            return this;
        }

        /// <summary>
        /// Assert the add pokemon form is showing within a normal timespan.
        /// </summary>
        protected override void OnAssertIsLoaded()
        {
            AssertionHelpers.AssertElementIsVisibleByClass("form__container", TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Assert the submission failed within a normal timespan.
        /// </summary>
        protected override void OnAssertSubmissionFailed()
        {
            AssertionHelpers.AssertElementIsVisibleByClass("validation-summary-errors", TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Assert the submission succeeded within a normal timespan.
        /// </summary>
        protected override void OnAssertSubmissionSucceeded()
        {
            AssertionHelpers.AssertElementIsVisibleByXPath(string.Format(Constants.HeaderWithTextXPath, 
                "The addition was successful!"), TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Click the submit button by xpath.
        /// </summary>
        protected override void OnSubmit()
        {
            ElementHelpers.ClickFirstElementByXPath(Constants.SubmitXPath);
        }
    }
}