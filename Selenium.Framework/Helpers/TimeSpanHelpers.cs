using System;

namespace Selenium.Framework.Helpers
{
    public class TimeSpanHelpers
    {
        public static TimeSpan SmallWait
        {
            get
            {
                return TimeSpan.FromSeconds(2);
            }
        }

        public static TimeSpan NormalWait
        {
            get
            {
                return TimeSpan.FromSeconds(5);
            }
        }

        public static TimeSpan LongWait
        {
            get
            {
                return TimeSpan.FromSeconds(10);
            }
        }
    }
}