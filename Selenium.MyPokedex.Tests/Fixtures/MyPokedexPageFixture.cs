using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.MyPokedex.Pages;

namespace Selenium.MyPokedex.Tests.Fixtures
{
    [TestClass]
    public class MyPokedexPageFixture
    {
        [TestInitialize]
        public void Initialize()
        {
            MyPokedexPage.GoTo();
        }

        [TestMethod]
        public void GoToMyPokedexPageIsSuccessful()
        {
            MyPokedexPage.AssertIsAt();
        }
    }
}