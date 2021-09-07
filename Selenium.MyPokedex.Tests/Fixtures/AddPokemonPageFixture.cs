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
        public void AddingAndReleasingPokemonIsSuccessful()
        {
            AddPokemonPage.AssertIsAt();

            AddPokemonPage.Add()
                .WithNickname("charchar")
                .WithPokemon("Charizard")
                .WithPokeball("Net Ball")
                .WithCaptureDate("01/01/2000")
                .WithLocation("Automation Station")
                .WithLevel("33")
                .WithSex("Female")
                .Submit();

            AddPokemonPage.CurrentAddPokemonForm.AssertSubmissionSucceeded();

            MyPokedexPage.GoTo();

            MyPokedexPage.ViewPokemonByNickname("charchar");

            MyPokedexPage.ReleaseCurrentPokemon();

            MyPokedexPage.AssertReleaseIsSuccessful();
        }

        [TestMethod]
        public void AddingPokemonWithoutDateDisplaysErrorMessage()
        {
            AddPokemonPage.AssertIsAt();

            AddPokemonPage.Add()
                .WithNickname("charchar")
                .WithPokemon("Charizard")
                .WithPokeball("Net Ball")
                .WithLocation("Automation Station")
                .WithLevel("33")
                .WithSex("Female")
                .Submit();

            AddPokemonPage.CurrentAddPokemonForm.AssertSubmissionFailed();
        }
    }
}