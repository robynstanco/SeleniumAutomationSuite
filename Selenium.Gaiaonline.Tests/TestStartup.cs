using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Framework;

namespace Tests.Selenium.GaiaOnline
{
    [TestClass]
    public class TestStartup
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