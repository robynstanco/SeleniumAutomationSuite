using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Selenium.Framework.Helpers
{
    public class ElementHelpers
    {
        #region Get All Elements

        /// <summary>
        /// Find all web elements by a given element locator.
        /// </summary>
        /// <param name="elementLocator">element locator to find elements by</param>
        /// <returns>collection of found web elements</returns>
        private static IReadOnlyCollection<IWebElement> FindElements(By elementLocator)
        {
            IReadOnlyCollection<IWebElement> elementsByLocator = Startup.Driver.FindElements(elementLocator);

            return elementsByLocator;
        }

        /// <summary>
        /// Find all elements by a given class name.
        /// </summary>
        /// <param name="className">class name to find elements by</param>
        /// <returns>collection of found web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByClassName(string className)
        {
            By elementLocator = By.ClassName(className);

            IReadOnlyCollection<IWebElement> elementsByClassName = FindElements(elementLocator);

            return elementsByClassName;
        }

        /// <summary>
        /// Find all elements by a given css selector.
        /// </summary>
        /// <param name="selector">css selector to find elements by</param>
        /// <returns>collection of found web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByCssSelector(string selector)
        {
            By elementLocator = By.CssSelector(selector);

            IReadOnlyCollection<IWebElement> elementsByCssSelector = FindElements(elementLocator);

            return elementsByCssSelector;
        }

        public static IReadOnlyCollection<IWebElement> GetElementsById(string id)
        {
            By elementLocator = By.Id(id);

            IReadOnlyCollection<IWebElement> elementsById = FindElements(elementLocator);

            return elementsById;
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByLinkText(string linkText)
        {
            By elementLocator = By.LinkText(linkText);

            IReadOnlyCollection<IWebElement> elementsByLinkText = FindElements(elementLocator);

            return elementsByLinkText;
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByName(string name)
        {
            By elementLocator = By.Name(name);

            IReadOnlyCollection<IWebElement> elementsByName = FindElements(elementLocator);

            return elementsByName;
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByPartialLinkText(string partialLinkText)
        {
            By elementLocator = By.PartialLinkText(partialLinkText);

            IReadOnlyCollection<IWebElement> elementsByPartialLinkText = FindElements(elementLocator);

            return elementsByPartialLinkText;
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagName(string tagName)
        {
            By elementLocator = By.TagName(tagName);

            IReadOnlyCollection<IWebElement> elementsByTagName = FindElements(elementLocator);

            return elementsByTagName;
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByXPath(string xPath)
        {
            By elementLocator = By.XPath(xPath);

            IReadOnlyCollection<IWebElement> elementsByXPath = FindElements(elementLocator);

            return elementsByXPath;
        }

        #endregion

        #region Get First Element

        private static IWebElement FindElement(By elementLocator)
        {
            IWebElement elementByLocator = Startup.Driver.FindElement(elementLocator);

            return elementByLocator;
        }

        public static IWebElement GetFirstElementByClassName(string className)
        {
            By elementLocator = By.ClassName(className);

            IWebElement elementByClassName = FindElement(elementLocator);

            return elementByClassName;
        }

        public static IWebElement GetFirstElementByCssSelector(string selector)
        {
            By elementLocator = By.CssSelector(selector);

            IWebElement elementByCssSelector = FindElement(elementLocator);

            return elementByCssSelector;
        }

        public static IWebElement GetFirstElementById(string id)
        {
            return Startup.Driver.FindElement(By.Id(id));
        }

        public static IWebElement GetFirstElementByLinkText(string linkText)
        {
            return Startup.Driver.FindElement(By.LinkText(linkText));
        }

        public static IWebElement GetFirstElementByName(string name)
        {
            return Startup.Driver.FindElement(By.Name(name));
        }

        public static IWebElement GetFirstElementByPartialLinkText(string partialLinkText)
        {
            return Startup.Driver.FindElement(By.PartialLinkText(partialLinkText));
        }

        public static IWebElement GetFirstElementByTagName(string tagName)
        {
            return Startup.Driver.FindElement(By.TagName(tagName));
        }

        public static IWebElement GetFirstElementByXPath(string xPath)
        {
            return Startup.Driver.FindElement(By.XPath(xPath));
        }

        #endregion

        #region Set First Element

        public static void SetFirstElementByClassName(string className, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByClassName(className), keysToSend);
        }

        public static void SetFirstElementByCssSelector(string selector, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByCssSelector(selector), keysToSend);
        }

        public static void SetFirstElementById(string id, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementById(id), keysToSend);
        }

        public static void SetFirstElementByLinkText(string linkText, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByLinkText(linkText), keysToSend);
        }

        public static void SetFirstElementByName(string name, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByName(name), keysToSend);
        }

        public static void SetFirstElementByPartialLinkText(string partialLinkText, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByPartialLinkText(partialLinkText), keysToSend);
        }

        public static void SetFirstElementByTagName(string tagName, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByTagName(tagName), keysToSend);
        }

        public static void SetFirstElementByXPath(string xPath, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByXPath(xPath), keysToSend);
        }

        #endregion

        #region Click First Element

        public static void ClickFirstElementByClassName(string className)
        {
            GetFirstElementByClassName(className).Click();
        }

        public static void ClickFirstElementByCssSelector(string selector)
        {
            GetFirstElementByCssSelector(selector).Click();
        }

        public static void ClickFirstElementById(string id)
        {
            GetFirstElementById(id).Click();
        }

        public static void ClickFirstElementByLinkText(string linkText)
        {
            GetFirstElementByLinkText(linkText).Click();
        }

        public static void ClickFirstElementByName(string name)
        {
            GetFirstElementByName(name).Click();
        }

        public static void ClickFirstElementByPartialLinkText(string partialLinkText)
        {
            GetFirstElementByPartialLinkText(partialLinkText).Click();
        }

        public static void ClickFirstElementByTagName(string tagName)
        {
            GetFirstElementByTagName(tagName).Click();
        }

        public static void ClickFirstElementByXPath(string xPath)
        {
            GetFirstElementByXPath(xPath).Click();
        }

        #endregion

        #region Hover Over First Element

        public static void HoverOverElementByClassName(string className)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByClassName(className));
        }

        public static void HoverOverElementByCssSelector(string selector)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByCssSelector(selector));
        }

        public static void HoverOverElementById(string id)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementById(id));
        }

        public static void HoverOverElementByLinkText(string linkText)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByLinkText(linkText));
        }

        public static void HoverOverElementByName(string name)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByName(name));
        }

        public static void HoverOverElementByPartialLinkText(string partialLinkText)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByPartialLinkText(partialLinkText));
        }

        public static void HoverOverElementByTagName(string tagName)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByTagName(tagName));
        }

        public static void HoverOverElementByXPath(string xPath)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByXPath(xPath));
        }

        #endregion

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void ClearElementAndSendKeys(IWebElement element, string keysToSend)
        {
            ClearElement(element);
            SendKeysToElement(element, keysToSend);
        }

        public static void ClearElement(IWebElement element)
        {
            element.Clear();
        }

        public static void SendKeysToElement(IWebElement element, string keysToSend)
        {
            element.SendKeys(keysToSend);
        }

        /// <summary>
        /// Explicitly wait & check to see if element is visibly by a given locator within a timespan.
        /// </summary>
        /// <param name="elementLocator">element locator</param>
        /// <param name="maxWait">maximum time to wait</param>
        /// <returns>true if element is located within timespan</returns>
        public static bool IsElementVisible(By elementLocator, TimeSpan maxWait)
        {
            try
            {
                WaitForElement(elementLocator, maxWait);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Explicitly wait for a given element by locator within a given timespan.
        /// </summary>
        /// <param name="elementLocator">use to locate element</param>
        /// <param name="maxWait">maximum time to wait</param>
        public static void WaitForElement(By elementLocator, TimeSpan maxWait)
        {
            WebDriverWait waitForElement = new WebDriverWait(Startup.Driver, maxWait);

            waitForElement.Until(drv => drv.FindElement(elementLocator));
        }
    }
}