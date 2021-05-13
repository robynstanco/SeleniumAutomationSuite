using System;

namespace Selenium.Framework.Helpers
{
    public class TimeSpanHelpers
    {
        /// <summary>
        /// A small wait timespan of 2 seconds.
        /// </summary>
        public static TimeSpan SmallWait
        {
            get
            {
                return TimeSpan.FromSeconds(2);
            }
        }

        /// <summary>
        /// A normal wait timespan of 5 seconds.
        /// </summary>
        public static TimeSpan NormalWait
        {
            get
            {
                return TimeSpan.FromSeconds(5);
            }
        }

        /// <summary>
        /// A long wait timespan of 10 seconds.
        /// </summary>
        public static TimeSpan LongWait
        {
            get
            {
                return TimeSpan.FromSeconds(10);
            }
        }
    }
}