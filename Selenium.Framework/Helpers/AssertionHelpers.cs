using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Selenium.Framework.Helpers
{
    public class AssertionHelpers
    {
        public static void AssertIsAtPage(string pageName, TimeSpan maxWait)
        {
            Assert.IsTrue(NavigationHelpers.IsAtPage(pageName, maxWait));
        }

        public static void AssertElementIsVisibleByCssSelector(string selector, TimeSpan maxWait)
        {
            Assert.IsTrue(ElementHelpers.IsElementVisible(By.CssSelector(selector), maxWait));
        }
    }
}