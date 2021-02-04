using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Selenium.Framework.Helpers
{
    public class ElementHelpers
    {
        #region Get All Elements

        public static IReadOnlyCollection<IWebElement> GetElementsByClassName(string className)
        {
            return Startup.Driver.FindElements(By.ClassName(className));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByCssSelector(string selector)
        {
            return Startup.Driver.FindElements(By.CssSelector(selector));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsById(string id)
        {
            return Startup.Driver.FindElements(By.Id(id));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByLinkText(string linkText)
        {
            return Startup.Driver.FindElements(By.LinkText(linkText));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByName(string name)
        {
            return Startup.Driver.FindElements(By.Name(name));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByPartialLinkText(string partialLinkText)
        {
            return Startup.Driver.FindElements(By.PartialLinkText(partialLinkText));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByTagName(string tagName)
        {
            return Startup.Driver.FindElements(By.TagName(tagName));
        }

        public static IReadOnlyCollection<IWebElement> GetElementsByXPath(string xPath)
        {
            return Startup.Driver.FindElements(By.XPath(xPath));
        }

        #endregion

        #region Get First Element

        public static IWebElement GetFirstElementByClassName(string className)
        {
            return Startup.Driver.FindElement(By.ClassName(className));
        }

        public static IWebElement GetFirstElementByCssSelector(string selector)
        {
            return Startup.Driver.FindElement(By.CssSelector(selector));
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

        public static void WaitForElement(By elementLocator, TimeSpan maxWait)
        {
            WebDriverWait waitForElement = new WebDriverWait(Startup.Driver, maxWait);

            waitForElement.Until(drv => drv.FindElement(elementLocator));
        }
    }
}