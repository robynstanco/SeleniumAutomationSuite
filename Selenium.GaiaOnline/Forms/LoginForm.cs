using Selenium.Framework.Forms;
using Selenium.Framework.Helpers;

namespace Selenium.GaiaOnline.Forms
{
    public class LoginForm : SimpleForm
    {
        public LoginForm WithUserName(string username)
        {
            ElementHelpers.SetFirstElementByCssSelector(".header-login-input-username", username);
            return this;
        }

        public LoginForm WithPassword(string password)
        {
            ElementHelpers.SetFirstElementByCssSelector(".header-login-input-password", password);
            return this;
        }

        protected override void OnSubmit()
        {
            ElementHelpers.ClickFirstElementByCssSelector(".header-login-input-submit");
        }

        protected override void OnAssertIsLoaded()
        {
            AssertionHelpers.AssertElementIsVisibleByCssSelector("#memberloginForm", TimeSpanHelpers.NormalWait);
        }

        protected override void OnAssertSubmissionFailed()
        {
            AssertionHelpers.AssertIsAtPage("Bad Login", TimeSpanHelpers.NormalWait);
        }

        protected override void OnAssertSubmissionSucceeded()
        {
            AssertionHelpers.AssertElementIsVisibleByCssSelector(".avatarName", TimeSpanHelpers.NormalWait);
        }
    }
}