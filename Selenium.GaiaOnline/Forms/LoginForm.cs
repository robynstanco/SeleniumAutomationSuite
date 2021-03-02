using Selenium.Framework;
using Selenium.Framework.Forms;
using Selenium.Framework.Helpers;

namespace Selenium.GaiaOnline.Forms
{
    public class LoginForm : SimpleForm
    {
        private const string HeaderLoginInputSelector = ".header-login-input-";

        /// <summary>
        /// Sets the username field to a given username by css selector.
        /// </summary>
        /// <param name="username">username to enter</param>
        /// <returns>current login form for method chaining</returns>
        public LoginForm WithUsername(string username)
        {
            string selector = HeaderLoginInputSelector + nameof(username);

            ElementHelpers.SetFirstElementByCssSelector(selector, username);

            return this;
        }

        /// <summary>
        /// Sets the password field to a given password by css selector.
        /// </summary>
        /// <param name="password">password to enter</param>
        /// <returns>current login form for method chaining</returns>
        public LoginForm WithPassword(string password)
        {
            string selector = HeaderLoginInputSelector + nameof(password);

            ElementHelpers.SetFirstElementByCssSelector(selector, password);

            return this;
        }

        /// <summary>
        /// Click the submit button by css selector.
        /// </summary>
        protected override void OnSubmit()
        {
            string selector = HeaderLoginInputSelector + "submit";

            ElementHelpers.ClickFirstElementByCssSelector(selector);
        }

        /// <summary>
        /// Assert the member login form is showing within a normal timespan.
        /// </summary>
        protected override void OnAssertIsLoaded()
        {
            AssertionHelpers.AssertElementIsVisibleByCssSelector("#memberloginForm", TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Assert the login submission failed within a normal timespan.
        /// </summary>
        protected override void OnAssertSubmissionFailed()
        {
            AssertionHelpers.AssertIsAtPage("Bad " + Constants.Login, TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Assert the submission succeeded within a normal timespan.
        /// </summary>
        protected override void OnAssertSubmissionSucceeded()
        {
            AssertionHelpers.AssertElementIsVisibleByCssSelector(".avatarName", TimeSpanHelpers.NormalWait);
        }
    }
}