using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Framework;

namespace Tests.Selenium.GaiaOnline
{
    [TestClass]
    public class TestInitialize
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Startup.Configure();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Startup.Dispose();
        }
    }
}