using Selenium.Framework.Forms;
using Selenium.Framework.Helpers;

namespace Selenium.MyPokedex.Forms
{
    public class AddPokemonForm : ComplexForm
    {
        /// <summary>
        /// Assert the add pokemon form is showing within a normal timespan.
        /// </summary>
        protected override void OnAssertIsLoaded()
        {
            AssertionHelpers.AssertElementIsVisibleByClass("form__container", TimeSpanHelpers.NormalWait);
        }

        protected override void OnAssertSubmissionFailed()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnAssertSubmissionFailedWithMessage(string message)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnAssertSubmissionSucceeded()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnAssertSubmissionSucceededWithMessage(string message)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnSubmit()
        {
            throw new System.NotImplementedException();
        }
    }
}