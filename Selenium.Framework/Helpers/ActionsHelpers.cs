using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium.Framework.Helpers
{
    public class ActionsHelpers
    {
        /// <summary>
        /// Hovers over the given web element by moving mouse.
        /// </summary>
        /// <param name="element">element to hover over</param>
        public static void PerformHoverAction(IWebElement element)
        {
            Actions hoverAction = new Actions(Startup.Driver);

            hoverAction.MoveToElement(element).Perform();
        }

        /// <summary>
        /// Sends given Key (arrow up, tab, etc) a number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        /// <param name="key">key to send</param>
        public static void PerformKeyAction(int times, string key)
        {
            Actions keyAction = new Actions(Startup.Driver);

            for (int i = 0; i < times; i++)
            {
                keyAction.SendKeys(key).Perform();
            }
        }
        
        /// <summary>
        /// Send ArrowUp key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyArrowUp(int times)
        {
            PerformKeyAction(times, Keys.ArrowUp);
        }

        /// <summary>
        /// Send ArrowRight key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyArrowRight(int times)
        {
            PerformKeyAction(times, Keys.ArrowRight);
        }

        /// <summary>
        /// Send ArrowDown key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyArrowDown(int times)
        {
            PerformKeyAction(times, Keys.ArrowDown);
        }

        /// <summary>
        /// Send ArrowLeft key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyArrowLeft(int times)
        {
            PerformKeyAction(times, Keys.ArrowLeft);
        }

        /// <summary>
        /// Send PageUp key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyPageUp(int times)
        {
            PerformKeyAction(times, Keys.PageUp);
        }

        /// <summary>
        /// Send PageDown key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyPageDown(int times)
        {
            PerformKeyAction(times, Keys.PageDown);
        }

        /// <summary>
        /// Send Tab key any given number of times.
        /// </summary>
        /// <param name="times">times to send key</param>
        public static void KeyTab(int times)
        {
            PerformKeyAction(times, Keys.Tab);
        }
    }
}