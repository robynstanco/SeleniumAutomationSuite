using System;

namespace Selenium.Framework.Helpers
{
    public class InputHelpers
    {
        private const string DateFormat = "MM/dd/yyyy";
        private const int OneMillion = 1000000;

        private static Random r = new Random();

        public static string RandomNumber
        {
            get
            {
                return r.Next(1, OneMillion).ToString();
            }
        }

        public static string RandomCurrency
        {
            get
            {
                return (r.NextDouble() * OneMillion).ToString();
            }
        }

        public static string RandomPhone
        {
            get
            {
                string phone = "";

                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        phone += r.Next(1, 9);
                    }
                    else
                    {
                        phone += r.Next(0, 9);
                    }
                }

                return phone;
            }
        }

        public static string RandomZipCode
        {
            get
            {
                string zip = "";

                for (int i = 0; i < 5; i++)
                {
                    zip += r.Next(0, 9);
                }

                return zip;
            }
        }

        public static string RandomPercent
        {
            get
            {
                return r.Next(0, 100).ToString();
            }
        }

        public static string RandomEmail
        {
            get
            {
                return RandomNumber + "@" + RandomNumber + ".com";
            }
        }

        public static string RandomFutureDate
        {
            get
            {
                return DateTime.Today.AddDays(double.Parse(RandomNumber)).ToString(DateFormat);
            }
        }

        public static string RandomPastDate
        {
            get
            {
                return DateTime.Today.AddDays(double.Parse(RandomNumber) * -1).ToString(DateFormat);
            }
        }

        public static string TodaysDate
        {
            get
            {
                return DateTime.Now.ToString(DateFormat);
            }
        }
    }
}