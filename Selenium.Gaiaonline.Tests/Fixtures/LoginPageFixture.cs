using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Framework;
using Selenium.GaiaOnline.Pages;

namespace Tests.Selenium.GaiaOnline.Fixtures
{
    [TestClass]
    public class LoginPageFixture
    {
        [TestInitialize]
        public void Initialize()
        {
            LoginPage.GoTo();

            LoginPage.TryLogout();
        }

        [TestMethod]
        public void GoToLoginPageIsSuccessful()
        {
            LoginPage.AssertIsAt();
        }

        [TestMethod]
        public void GoToLoginFormIsSuccessful()
        {
            LoginPage.Logon();

            LoginPage.CurrentLoginForm.AssertIsLoaded();
        }

        [TestMethod]
        public void LogonIsSuccessful()
        {
           LoginPage.Logon()
                .WithUserName(Startup.Credentials.Username)
                .WithPassword(Startup.Credentials.Password)
                .Submit();

            LoginPage.CurrentLoginForm.AssertSubmissionSucceeded();

            LoginPage.Logout();
        }

        [TestMethod]
        public void LogonWithInvalidCredentialsFails()
        {
            LoginPage.Logon()
                .WithUserName("badusername")
                .WithPassword(Startup.Credentials.Password)
                .Submit();

            LoginPage.CurrentLoginForm.AssertSubmissionFailed();
        }

        [TestMethod]
        public void LogoutIsSuccessful()
        {
            LoginPage.Logon()
                .WithUserName(Startup.Credentials.Username)
                .WithPassword(Startup.Credentials.Password)
                .Submit();

            LoginPage.CurrentLoginForm.AssertSubmissionSucceeded();

            LoginPage.Logout();

            LoginPage.AssertLogoutSucceeded();
        }
    }
}