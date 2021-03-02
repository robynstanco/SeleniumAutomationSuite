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
        /// <summary>
        /// Gets the current driver url.
        /// </summary>
        /// <returns>driver url</returns>
        public static string GetCurrentURL()
        {
            return Startup.Driver.Url;
        }

        /// <summary>
        /// Gets the first page in the site map matching the given name, case incensitive,
        /// </summary>
        /// <param name="name">name of page to get from site map</param>
        /// <returns>page from site map</returns>
        private static Page GetSiteMapPage(string name)
        {
            return Startup.SiteMap.FirstOrDefault(smp => smp.Key.Equals(name, StringComparison.CurrentCultureIgnoreCase)).Value;
        }

        /// <summary>
        /// Navigate back one page.
        /// </summary>
        public static void GoBackAPage()
        {
            Startup.Driver.Navigate().Back();
        }

        /// <summary>
        /// Navigate forward one page.
        /// </summary>
        public static void GoForwardAPage()
        {
            Startup.Driver.Navigate().Forward();
        }

        /// <summary>
        /// Navigates to page given a page name. Page url constructred from site map instance.
        /// </summary>
        /// <param name="name">name of page to go to</param>
        public static void GoToPage(string name)
        {
            string url = Startup.SiteURL + GetSiteMapPage(name).RelativePath;

            Startup.Driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Switches to tab by a given index.
        /// </summary>
        /// <param name="tabIndex">tab index to switch to</param>
        public static void GoToBrowserTabByIndex(int tabIndex)
        {
            string windowName = Startup.Driver.WindowHandles[tabIndex];

            Startup.Driver.SwitchTo().Window(windowName);
        }

        /// <summary>
        /// Switches to tab by given tab number.
        /// </summary>
        /// <param name="tabNumber">tab number to switch to</param>
        public static void GoToBrowserTabByNumber(int tabNumber)
        {
            GoToBrowserTabByIndex(tabNumber - 1);
        }

        /// <summary>
        /// Switches to frame in current page by given element.
        /// </summary>
        /// <param name="iFrameElement">frame element to switch to</param>
        public static void GoToFrameByElement(IWebElement iFrameElement)
        {
            Startup.Driver.SwitchTo().Frame(iFrameElement);
        }

        /// <summary>
        /// Switches to frame in current page by given index.
        /// </summary>
        /// <param name="iFrameIndex">index of frame to switch to</param>
        public static void GoToFrameByIndex(int iFrameIndex)
        {
            Startup.Driver.SwitchTo().Frame(iFrameIndex);
        }

        /// <summary>
        /// Switches to frame in current page by given name.
        /// </summary>
        /// <param name="iFrameName">name of frame to switch to</param>
        public static void GoToFrameByName(string iFrameName)
        {
            Startup.Driver.SwitchTo().Frame(iFrameName);
        }

        /// <summary>
        /// Switches to the main document content in current page.
        /// </summary>
        public static void GoToDefaultFrame()
        {
            Startup.Driver.SwitchTo().DefaultContent();
        }
        
        /// <summary>
        /// Scroll down by a given number of pixels.
        /// </summary>
        /// <param name="pixels">pixels to scroll down by</param>
        public static void ScrollDownByPixels(int pixels)
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("scroll(0, " + pixels.ToString() + ")");
        }

        /// <summary>
        /// Scrolls ups by a given number of pixels.
        /// </summary>
        /// <param name="pixels">pixels to scroll up by</param>
        public static void ScrollUpByPixels(int pixels)
        {
            ScrollDownByPixels(pixels * -1);
        }

        /// <summary>
        /// Scrolls to the top of the document page.
        /// </summary>
        public static void ScrollToTop()
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
        }

        /// <summary>
        /// Scrolls to the bottom of the document page.
        /// </summary>
        public static void ScrollToBottom()
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        /// <summary>
        /// Refreshes the current page.
        /// </summary>
        public static void Refresh()
        {
            Startup.Driver.Navigate().Refresh();
        }

        /// <summary>
        /// Closes the current open tab.
        /// </summary>
        public static void CloseCurrentTab()
        {
            Startup.Driver.Close();
        }

        /// <summary>
        /// Closes the active alert modal.
        /// </summary>
        public static void CloseAlert()
        {
            Startup.Driver.SwitchTo().Alert().Dismiss();
        }

        /// <summary>
        /// Explicitly waits & checks if a given page name is open.
        /// </summary>
        /// <param name="name">page name to wait for</param>
        /// <param name="maxWait">maximum time to wait.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Explcitly waits & checks if a given number of tabs are open.
        /// </summary>
        /// <param name="numberOfTabs">number of tabs to check if open</param>
        /// <param name="maxWait">maximum time to wait</param>
        /// <returns>true if given number of tabs are open</returns>
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

        /// <summary>
        /// Explicitly wait for a page with a given name.
        /// </summary>
        /// <param name="name">name of page to wait for</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void WaitForPage(string name, TimeSpan maxWait)
        {
            WebDriverWait waitForTitle = new WebDriverWait(Startup.Driver, maxWait);

            waitForTitle.Until(drv => drv.Title.Equals(GetSiteMapPage(name).Title));
        }

        /// <summary>
        /// Explicitly wait for a given number of tabs to be open.
        /// </summary>
        /// <param name="numberOfTabs">number of tabs to wait for</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void WaitForThisManyTabsToLoad(int numberOfTabs, TimeSpan maxWait)
        {
            WebDriverWait waitForTabs = new WebDriverWait(Startup.Driver, maxWait);

            waitForTabs.Until(drv => drv.WindowHandles.Count == numberOfTabs);
        }

        /// <summary>
        /// Implicit wait using standard threading for a given timespan.
        /// </summary>
        /// <param name="wait">time span to wait</param>
        public static void ImplicitWait(TimeSpan wait)
        {
            Thread.Sleep((int)wait.TotalMilliseconds);
        }
    }
}