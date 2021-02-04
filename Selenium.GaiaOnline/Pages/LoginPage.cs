using Selenium.Framework.Helpers;
using Selenium.GaiaOnline.Forms;
using System;

namespace Selenium.GaiaOnline.Pages
{
    public class LoginPage
    {
        public static void GoTo()
        {
            NavigationHelpers.GoToPage("Login");
        }

        public static void AssertIsAt()
        {
            AssertionHelpers.AssertIsAtPage("Login", TimeSpanHelpers.NormalWait);
        }

        public static void AssertLogoutSucceeded()
        {
            AssertionHelpers.AssertElementIsVisibleByCssSelector(".loginheader", TimeSpanHelpers.NormalWait);
        }

        public static void Logout()
        {
            ElementHelpers.HoverOverElementByCssSelector(".user-dropdown-arrow");

            ElementHelpers.ClickFirstElementByCssSelector(".user-dropdown-menu ul li:nth-child(3) a");
        }

        public static bool TryLogout()
        {
            try
            {
                Logout();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static LoginForm CurrentLoginForm { get; private set; }
        public static LoginForm Logon()
        {
            ElementHelpers.ClickFirstElementByCssSelector(".header-login-tab-login");

            CurrentLoginForm = new LoginForm();

            return CurrentLoginForm;
        }
    }
}