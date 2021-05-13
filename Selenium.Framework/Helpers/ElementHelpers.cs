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

        /// <summary>
        /// Get all web elements by given id.
        /// </summary>
        /// <param name="id">id to find element by</param>
        /// <returns>collection of elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsById(string id)
        {
            By elementLocator = By.Id(id);

            IReadOnlyCollection<IWebElement> elementsById = FindElements(elementLocator);

            return elementsById;
        }

        /// <summary>
        /// Get all web elements by given link text.
        /// </summary>
        /// <param name="linkText">link text to find element by</param>
        /// <returns>collection of elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByLinkText(string linkText)
        {
            By elementLocator = By.LinkText(linkText);

            IReadOnlyCollection<IWebElement> elementsByLinkText = FindElements(elementLocator);

            return elementsByLinkText;
        }

        /// <summary>
        /// Get all web elements by given name.
        /// </summary>
        /// <param name="name">name to find element by</param>
        /// <returns>collection of elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByName(string name)
        {
            By elementLocator = By.Name(name);

            IReadOnlyCollection<IWebElement> elementsByName = FindElements(elementLocator);

            return elementsByName;
        }

        /// <summary>
        /// Get all web elements by given partial link text.
        /// </summary>
        /// <param name="partialLinkText">partial link text to find element by</param>
        /// <returns>collection of elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByPartialLinkText(string partialLinkText)
        {
            By elementLocator = By.PartialLinkText(partialLinkText);

            IReadOnlyCollection<IWebElement> elementsByPartialLinkText = FindElements(elementLocator);

            return elementsByPartialLinkText;
        }

        /// <summary>
        /// Get all web elements by given tag name.
        /// </summary>
        /// <param name="tagName">tag name to find element by</param>
        /// <returns>collection of elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagName(string tagName)
        {
            By elementLocator = By.TagName(tagName);

            IReadOnlyCollection<IWebElement> elementsByTagName = FindElements(elementLocator);

            return elementsByTagName;
        }

        /// <summary>
        /// Get all web elements by given xpath.
        /// </summary>
        /// <param name="xPath">xpath to find element by</param>
        /// <returns>collection of elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByXPath(string xPath)
        {
            By elementLocator = By.XPath(xPath);

            IReadOnlyCollection<IWebElement> elementsByXPath = FindElements(elementLocator);

            return elementsByXPath;
        }

        #endregion

        #region Get First Element

        /// <summary>
        /// Find web element by given locator.
        /// </summary>
        /// <param name="elementLocator">element locator</param>
        /// <returns>found web element</returns>
        private static IWebElement FindElement(By elementLocator)
        {
            IWebElement elementByLocator = Startup.Driver.FindElement(elementLocator);

            return elementByLocator;
        }

        /// <summary>
        /// Get the first element by given class name.
        /// </summary>
        /// <param name="className">class name to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByClassName(string className)
        {
            By elementLocator = By.ClassName(className);

            IWebElement elementByClassName = FindElement(elementLocator);

            return elementByClassName;
        }

        /// <summary>
        /// Get the first element by given selector.
        /// </summary>
        /// <param name="selector">selector to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByCssSelector(string selector)
        {
            By elementLocator = By.CssSelector(selector);

            IWebElement elementByCssSelector = FindElement(elementLocator);

            return elementByCssSelector;
        }

        /// <summary>
        /// Get the first element by given id.
        /// </summary>
        /// <param name="id">id to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementById(string id)
        {
            By elementLocator = By.Id(id);

            IWebElement elementById = FindElement(elementLocator);

            return elementById;
        }

        /// <summary>
        /// Get the first element by given link text.
        /// </summary>
        /// <param name="linkText">link text to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByLinkText(string linkText)
        {
            By elementLocator = By.LinkText(linkText);

            IWebElement elementByLinkText = FindElement(elementLocator);

            return elementByLinkText;
        }

        /// <summary>
        /// Get the first element by given name.
        /// </summary>
        /// <param name="name">name to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByName(string name)
        {
            By elementLocator = By.Name(name);

            IWebElement elementByName = FindElement(elementLocator);

            return elementByName;
        }

        /// <summary>
        /// Get the first element by given partial link text.
        /// </summary>
        /// <param name="partialLinkText">partial link text to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByPartialLinkText(string partialLinkText)
        {
            By elementLocator = By.PartialLinkText(partialLinkText);

            IWebElement elementByLinkText = FindElement(elementLocator);

            return elementByLinkText;
        }

        /// <summary>
        /// Get the first element by given tag name.
        /// </summary>
        /// <param name="tagName">tage name to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByTagName(string tagName)
        {
            By elementLocator = By.TagName(tagName);

            IWebElement elementByTagName = FindElement(elementLocator);

            return elementByTagName;
        }

        /// <summary>
        /// Get the first element by given xPath.
        /// </summary>
        /// <param name="xPath">xpath to find</param>
        /// <returns>found web element</returns>
        public static IWebElement GetFirstElementByXPath(string xPath)
        {
            By elementLocator = By.XPath(xPath);

            IWebElement elementByxPath = FindElement(elementLocator);

            return elementByxPath;
        }

        #endregion

        #region Set First Element

        /// <summary>
        /// Set first element by given class name and keys.
        /// </summary>
        /// <param name="className">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByClassName(string className, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByClassName(className), keysToSend);
        }

        /// <summary>
        /// Set first element by given selector and keys.
        /// </summary>
        /// <param name="selector">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByCssSelector(string selector, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByCssSelector(selector), keysToSend);
        }

        /// <summary>
        /// Set first element by given id and keys.
        /// </summary>
        /// <param name="id">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementById(string id, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementById(id), keysToSend);
        }

        /// <summary>
        /// Set first element by given link text and keys.
        /// </summary>
        /// <param name="linkText">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByLinkText(string linkText, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByLinkText(linkText), keysToSend);
        }

        /// <summary>
        /// Set first element by given name and keys.
        /// </summary>
        /// <param name="name">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByName(string name, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByName(name), keysToSend);
        }

        /// <summary>
        /// Set first element by given partial link text and keys.
        /// </summary>
        /// <param name="partialLinkText">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByPartialLinkText(string partialLinkText, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByPartialLinkText(partialLinkText), keysToSend);
        }

        /// <summary>
        /// Set first element by given link text and keys.
        /// </summary>
        /// <param name="linkText">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByTagName(string tagName, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByTagName(tagName), keysToSend);
        }

        /// <summary>
        /// Set first element by given xpath and keys.
        /// </summary>
        /// <param name="xPath">element to set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void SetFirstElementByXPath(string xPath, string keysToSend)
        {
            ClearElementAndSendKeys(GetFirstElementByXPath(xPath), keysToSend);
        }

        #endregion

        #region Click First Element

        /// <summary>
        /// Click the first element by class name.
        /// </summary>
        /// <param name="className">class name to click</param>
        public static void ClickFirstElementByClassName(string className)
        {
            GetFirstElementByClassName(className).Click();
        }

        /// <summary>
        /// Click the first element by selector.
        /// </summary>
        /// <param name="selector">selector to click</param>
        public static void ClickFirstElementByCssSelector(string selector)
        {
            GetFirstElementByCssSelector(selector).Click();
        }

        /// <summary>
        /// Click the first element by id.
        /// </summary>
        /// <param name="id">id to click</param>
        public static void ClickFirstElementById(string id)
        {
            GetFirstElementById(id).Click();
        }

        /// <summary>
        /// Click the first element by link text.
        /// </summary>
        /// <param name="linkText">link text to click</param>
        public static void ClickFirstElementByLinkText(string linkText)
        {
            GetFirstElementByLinkText(linkText).Click();
        }

        /// <summary>
        /// Click the first element by name.
        /// </summary>
        /// <param name="name">name to click</param>
        public static void ClickFirstElementByName(string name)
        {
            GetFirstElementByName(name).Click();
        }

        /// <summary>
        /// Click the first element by partial link text.
        /// </summary>
        /// <param name="partialLinkText">partial link text to click</param>
        public static void ClickFirstElementByPartialLinkText(string partialLinkText)
        {
            GetFirstElementByPartialLinkText(partialLinkText).Click();
        }

        /// <summary>
        /// Click the first element by tag name.
        /// </summary>
        /// <param name="tagName">tagName to click</param>
        public static void ClickFirstElementByTagName(string tagName)
        {
            GetFirstElementByTagName(tagName).Click();
        }

        /// <summary>
        /// Click the first element by xpath.
        /// </summary>
        /// <param name="xPath">xpath to click</param>
        public static void ClickFirstElementByXPath(string xPath)
        {
            GetFirstElementByXPath(xPath).Click();
        }

        #endregion

        #region Hover Over First Element

        /// <summary>
        /// Hover over the first element by class name.
        /// </summary>
        /// <param name="className">class name to hover over</param>
        public static void HoverOverElementByClassName(string className)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByClassName(className));
        }

        /// <summary>
        /// Hover over the first element by selector.
        /// </summary>
        /// <param name="selector">selector to hover over</param>
        public static void HoverOverElementByCssSelector(string selector)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByCssSelector(selector));
        }

        /// <summary>
        /// Hover over the first element by id.
        /// </summary>
        /// <param name="id">id to hover over</param>
        public static void HoverOverElementById(string id)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementById(id));
        }

        /// <summary>
        /// Hover over the first element by link text.
        /// </summary>
        /// <param name="linkText">link text to hover over</param>
        public static void HoverOverElementByLinkText(string linkText)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByLinkText(linkText));
        }

        /// <summary>
        /// Hover over the first element by name.
        /// </summary>
        /// <param name="name">name to hover over</param>
        public static void HoverOverElementByName(string name)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByName(name));
        }

        /// <summary>
        /// Hover over the first element by partial link text.
        /// </summary>
        /// <param name="partialLinkText">partial link text to hover over</param>
        public static void HoverOverElementByPartialLinkText(string partialLinkText)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByPartialLinkText(partialLinkText));
        }

        /// <summary>
        /// Hover over the first element by tag name.
        /// </summary>
        /// <param name="tagName">tag to hover over</param>
        public static void HoverOverElementByTagName(string tagName)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByTagName(tagName));
        }

        /// <summary>
        /// Hover over the first element by xpath.
        /// </summary>
        /// <param name="xPath">xpath to hover over</param>
        public static void HoverOverElementByXPath(string xPath)
        {
            ActionsHelpers.PerformHoverAction(GetFirstElementByXPath(xPath));
        }

        #endregion

        #region Misc.

        /// <summary>
        /// Scroll to given web element.
        /// </summary>
        /// <param name="element"></param>
        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Startup.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        /// <summary>
        /// Clear given web element and send given keys.
        /// </summary>
        /// <param name="element">element to clear and set</param>
        /// <param name="keysToSend">keys to send</param>
        public static void ClearElementAndSendKeys(IWebElement element, string keysToSend)
        {
            ClearElement(element);
            SendKeysToElement(element, keysToSend);
        }

        /// <summary>
        /// Clear the web element's value.
        /// </summary>
        /// <param name="element">element to clear</param>
        public static void ClearElement(IWebElement element)
        {
            element.Clear();
        }

        /// <summary>
        /// Send given keys to given web element.
        /// </summary>
        /// <param name="element">element to send to</param>
        /// <param name="keysToSend">keys to send</param>
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

        #endregion
    }
}