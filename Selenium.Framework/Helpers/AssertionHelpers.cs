using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Selenium.Framework.Helpers
{
    public class AssertionHelpers
    {
        /// <summary>
        /// Assert driver is at the given page.
        /// </summary>
        /// <param name="pageName">page name to be at</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void AssertIsAtPage(string pageName, TimeSpan maxWait)
        {
            bool isAtPage = NavigationHelpers.IsAtPage(pageName, maxWait);

            Assert.IsTrue(isAtPage);
        }

        /// <summary>
        /// Assert the given css selector is visible.
        /// </summary>
        /// <param name="selector">selector to be visible</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void AssertElementIsVisibleByCssSelector(string selector, TimeSpan maxWait)
        {
            By elementLocator = By.CssSelector(selector);

            AssertElementIsVisible(maxWait, elementLocator);
        }

        /// <summary>
        /// Assert the given class name is visible.
        /// </summary>
        /// <param name="className">class name to be visible</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void AssertElementIsVisibleByClass(string className, TimeSpan maxWait)
        {
            By elementLocator = By.ClassName(className);

            AssertElementIsVisible(maxWait, elementLocator);
        }

        /// <summary>
        /// Assert the given xpath is visible.
        /// </summary>
        /// <param name="xpath">xpath to be visible</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void AssertElementIsVisibleByXPath(string xpath, TimeSpan maxWait)
        {
            By elementLocator = By.XPath(xpath);

            AssertElementIsVisible(maxWait, elementLocator);
        }

        /// <summary>
        /// Assert the given element is visible.
        /// </summary>
        /// <param name="maxWait">maximum time to wait</param>
        /// <param name="elementLocator">by element locator</param>
        public static void AssertElementIsVisible(TimeSpan maxWait, By elementLocator)
        {
            bool isElementVisible = ElementHelpers.IsElementVisible(elementLocator, maxWait);

            Assert.IsTrue(isElementVisible);
        }
    }
}