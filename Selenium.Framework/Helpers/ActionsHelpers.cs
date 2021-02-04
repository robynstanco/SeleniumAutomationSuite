using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium.Framework.Helpers
{
    public class ActionsHelpers
    {
        public static void PerformHoverAction(IWebElement element)
        {
            Actions hoverAction = new Actions(Startup.Driver);

            hoverAction.MoveToElement(element).Perform();
        }

        public static void PerformKeyAction(int times, string key)
        {
            Actions keyAction = new Actions(Startup.Driver);

            for (int i = 0; i < times; i++)
            {
                keyAction.SendKeys(key).Perform();
            }
        }
        
        public static void KeyArrowUp(int times)
        {
            PerformKeyAction(times, Keys.ArrowUp);
        }

        public static void KeyArrowRight(int times)
        {
            PerformKeyAction(times, Keys.ArrowRight);
        }

        public static void KeyArrowDown(int times)
        {
            PerformKeyAction(times, Keys.ArrowDown);
        }

        public static void KeyArrowLeft(int times)
        {
            PerformKeyAction(times, Keys.ArrowLeft);
        }

        public static void KeyPageUp(int times)
        {
            PerformKeyAction(times, Keys.PageUp);
        }

        public static void KeyPageDown(int times)
        {
            PerformKeyAction(times, Keys.PageDown);
        }

        public static void KeyTab(int times)
        {
            PerformKeyAction(times, Keys.Tab);
        }
    }
}