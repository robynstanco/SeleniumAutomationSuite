using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.MyPokedex.Pages;

namespace Selenium.MyPokedex.Tests.Fixtures
{
    [TestClass]
    public class AddPokemonPageFixture
    {
        [TestInitialize]
        public void Initialize()
        {
            AddPokemonPage.GoTo();
        }

        [TestMethod]
        public void GoingToAddPokemonPageIsSuccessful()
        {
            AddPokemonPage.AssertIsAt();
        }

        [TestMethod]
        public void LoadingAddPokemonFormIsSuccessful()
        {
            AddPokemonPage.AssertIsAt();

            AddPokemonPage.Add();

            AddPokemonPage.CurrentAddPokemonForm.AssertIsLoaded();
        }

        [TestMethod]
        public void AddingPokemonIsSuccessful()
        {
            AddPokemonPage.AssertIsAt();

            AddPokemonPage.Add();//todo
        }
    }
}