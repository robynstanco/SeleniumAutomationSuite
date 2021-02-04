using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Framework.Models;
using System;
using System.Linq;
using System.Threading;

namespace Selenium.Framework.Helpers
{
    public class NavigationHelpers
    {
        public static string GetCurrentURL()
        {
            return Startup.Driver.Url;
        }

        private static Page GetSiteMapPage(string name)
        {
            return Startup.SiteMap.FirstOrDefault(smp => smp.Key.Equals(name, StringComparison.CurrentCultureIgnoreCase)).Value;
        }

        public static void GoBackAPage()
        {
            Startup.Driver.Navigate().Back();
        }

        public static void GoForwardAPage()
        {
            Startup.Driver.Navigate().Forward();
        }

        public static void GoToPage(string name)
        {
            Startup.Driver.Navigate().GoToUrl(Startup.SiteURL + GetSiteMapPage(name).RelativePath);
        }

        public static void GoToBrowserTabByIndex(int tabIndex)
        {
            Startup.Driver.SwitchTo().Window(Startup.Driver.WindowHandles[tabIndex]);
        }

        public static void GoToBrowserTabByNumber(int tabNumber)
        {
            GoToBrowserTabByIndex(tabNumber - 1);
        }

        public static void GoToFrameByElement(IWebElement iFrameElement)
        {
            Startup.Driver.SwitchTo().Frame(iFrameElement);
        }

        public static void GoToFrameByIndex(int iFrameIndex)
        {
            Startup.Driver.SwitchTo().Frame(iFrameIndex);
        }

        public static void GoToFrameByName(string iFrameName)
        {
            Startup.Driver.SwitchTo().Frame(iFrameName);
        }

        public static void GoToDefaultFrame()
        {
            Startup.Driver.SwitchTo().DefaultContent();
        }
        
        public static void ScrollDownByPixels(int pixels)
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("scroll(0, " + pixels.ToString() + ")");
        }

        public static void ScrollUpByPixels(int pixels)
        {
            ScrollDownByPixels(pixels * -1);
        }

        public static void ScrollToTop()
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
        }

        public static void ScrollToBottom()
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        public static void Refresh()
        {
            Startup.Driver.Navigate().Refresh();
        }

        public static void CloseCurrentTab()
        {
            Startup.Driver.Close();
        }

        public static void CloseAlert()
        {
            Startup.Driver.SwitchTo().Alert().Dismiss();
        }

        public static bool IsAtPage(string name, TimeSpan maxWait)
        {
            try
            {
                WaitForPage(name, maxWait);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AreThisManyTabsLoaded(int numberOfTabs, TimeSpan maxWait)
        {
            try
            {
                WaitForThisManyTabsToLoad(numberOfTabs, maxWait);
                
               return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void WaitForPage(string name, TimeSpan maxWait)
        {
            WebDriverWait waitForTitle = new WebDriverWait(Startup.Driver, maxWait);

            waitForTitle.Until(drv => drv.Title.Equals(GetSiteMapPage(name).Title));
        }

        public static void WaitForThisManyTabsToLoad(int numberOfTabs, TimeSpan maxWait)
        {
            WebDriverWait waitForTabs = new WebDriverWait(Startup.Driver, maxWait);

            waitForTabs.Until(drv => drv.WindowHandles.Count == numberOfTabs);
        }

        public static void ImplicitWait(TimeSpan wait)
        {
            Thread.Sleep((int)wait.TotalMilliseconds);
        }
    }
}