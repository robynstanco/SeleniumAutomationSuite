using Selenium.Framework;
using Selenium.Framework.Helpers;
using Selenium.GaiaOnline.Forms;
using System;

namespace Selenium.GaiaOnline.Pages
{
    public class LoginPage
    {
        /// <summary>
        /// Go to the login page.
        /// </summary>
        public static void GoTo()
        {
            NavigationHelpers.GoToPage(Constants.Login);
        }

        /// <summary>
        /// Assert you are at the login page within a normal timespan.
        /// </summary>
        public static void AssertIsAt()
        {
            AssertionHelpers.AssertIsAtPage(Constants.Login, TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Assert the logout succeeded within a normal timespan.
        /// </summary>
        public static void AssertLogoutSucceeded()
        {
            AssertionHelpers.AssertElementIsVisibleByCssSelector(".loginheader", TimeSpanHelpers.NormalWait);
        }

        /// <summary>
        /// Logout of Gaiaonline.
        /// </summary>
        public static void Logout()
        {
            ElementHelpers.HoverOverElementByCssSelector(".user-dropdown-arrow");

            ElementHelpers.ClickFirstElementByCssSelector(".user-dropdown-menu ul li:nth-child(3) a");
        }

        /// <summary>
        /// Try to logout of Gaiaonline.
        /// </summary>
        /// <returns>true if able to logout</returns>
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