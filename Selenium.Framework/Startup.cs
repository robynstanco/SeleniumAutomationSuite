using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Framework.Enums;
using Selenium.Framework.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Selenium.Framework
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public static Credentials Credentials { get; set; }

        public static IWebDriver Driver { get; set; }

        public static Dictionary<string, Page> SiteMap { get; set; }

        public static dynamic TestData { get; set; }

        public static BrowsersEnum Browser
        {
            get
            {
                return (BrowsersEnum)Enum.Parse(typeof(BrowsersEnum), Configuration[nameof(Browser)]);
            }
        }

        public static string _credentialsFile;
        public static string CredentialsFile
        {
            get
            {
                if (_credentialsFile == null)
                {
                    _credentialsFile = Configuration[nameof(CredentialsFile)];
                }

                return _credentialsFile;
            }
        }

        private static string _siteMapFile;
        public static string SiteMapFile
        {
            get
            {
                if (_siteMapFile == null)
                {
                    _siteMapFile = Configuration[nameof(SiteMapFile)];
                }

                return _siteMapFile;
            }
        }

        private static string _siteURL;
        public static string SiteURL
        {
            get
            {
                if (_siteURL == null)
                {
                    _siteURL = Configuration[nameof(SiteURL)];
                }

                return _siteURL;
            }
        }

        private static string _testDataFile;
        public static string TestDataFile
        {
            get
            {
                if (_testDataFile == null)
                {
                    _testDataFile = Configuration[nameof(TestDataFile)];
                }

                return _testDataFile;
            }
        }

        /// <summary>
        /// Configured the WebDriver according to the app settings json file in the test project using the Framework.
        /// </summary>
        public static void Configure()
        {
            //Construct the path to application settings
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentOne = Directory.GetParent(currentDirectory).FullName;
            string parentTwo = Directory.GetParent(parentOne).FullName;
            string basePath = Directory.GetParent(parentTwo).FullName;

            var builder = new ConfigurationBuilder().SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            ConfigureDriver();
            ConfigureSiteMap();

            if (!string.IsNullOrWhiteSpace(CredentialsFile))
            {
                ConfigureCredentials();
            }
            
            if(!string.IsNullOrWhiteSpace(TestDataFile))
            {
                ConfigureTestData();
            }
        }

        /// <summary>
        /// Dispose of driver instance to properly kill chromedriver.exe.
        /// </summary>
        public static void Dispose()
        {
            Driver.Quit();
            Driver.Dispose();
            Driver = null;
        }

        /// <summary>
        /// Configure the driver based on Browser selection. Headless browsing applies special characteristics.
        /// </summary>
        private static void ConfigureDriver()
        {
            if (Driver == null)
            {
                if (Browser == BrowsersEnum.ChromeHeadless)
                {
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("headless");
                    chromeOptions.AddArgument("start-maximized");
                    chromeOptions.AddArgument("window-size=1920,1080");

                    Driver = new ChromeDriver(chromeOptions);
                }
                else
                {
                    Driver = new ChromeDriver();
                }

                Driver.Manage().Window.Maximize();
            }
        }

        /// <summary>
        /// Deserialize the credentials from the given json file location.
        /// </summary>
        private static void ConfigureCredentials()
        {
            if (CredentialsFile != null)
            {
                string credentialsJSON = File.ReadAllText(CredentialsFile);

                Credentials = JsonConvert.DeserializeObject<Credentials>(credentialsJSON);
            }
        }

        /// <summary>
        /// Deserialize the site map from the given json file location.
        /// </summary>
        private static void ConfigureSiteMap()
        {
            SiteMap = new Dictionary<string, Page>();

            string siteMapJSON = File.ReadAllText(SiteMapFile);

            List<Page> pages = JsonConvert.DeserializeObject<List<Page>>(siteMapJSON);

            pages.ForEach(p => SiteMap[p.Name.ToLower()] = p); //add deserialized pages to sitemap
        }

        /// <summary>
        /// Parse the test data from the given json file location.
        /// </summary>
        private static void ConfigureTestData()
        {
            if (TestDataFile != null)
            {
                string testDataJSON = File.ReadAllText(TestDataFile);

                TestData = JToken.Parse(testDataJSON);
            }
        }
    }
}