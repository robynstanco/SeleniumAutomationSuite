using System;

namespace Selenium.Framework.Helpers
{
    public class InputHelpers
    {
        private const string DateFormat = "MM/dd/yyyy";
        private const int OneMillion = 1000000;

        private static Random r = new Random();

        /// <summary>
        /// Generates a random number between one and a million.
        /// </summary>
        public static string RandomNumber
        {
            get
            {
                return r.Next(1, OneMillion).ToString();
            }
        }

        /// <summary>
        /// Generates a random currency (double) value between one and a million.
        /// </summary>
        public static string RandomCurrency
        {
            get
            {
                return (r.NextDouble() * OneMillion).ToString();
            }
        }

        /// <summary>
        /// Generates a random ten digit phone number, unformatted.
        /// </summary>
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

        /// <summary>
        /// Generates a random zip code, unformatted. 
        /// </summary>
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

        /// <summary>
        /// Generates a random percent zero to one hundred.
        /// </summary>
        public static string RandomPercent
        {
            get
            {
                return r.Next(0, 100).ToString();
            }
        }

        /// <summary>
        /// Generates a random standard format email with numbers.
        /// </summary>
        public static string RandomEmail
        {
            get
            {
                return RandomNumber + "@" + RandomNumber + ".com";
            }
        }

        /// <summary>
        /// Generates a random future date by adding a random number of days to today.
        /// </summary>
        public static string RandomFutureDate
        {
            get
            {
                double days = double.Parse(RandomNumber);

                return DateTime.Today.AddDays(days).ToString(DateFormat);
            }
        }

        /// <summary>
        /// Generates a random past date by subtracting a random number of days to today.
        /// </summary>
        public static string RandomPastDate
        {
            get
            {
                double days = double.Parse(RandomNumber) * -1; //add negative days

                return DateTime.Today.AddDays(days).ToString(DateFormat);
            }
        }

        /// <summary>
        /// Gets todays date in specific date format.
        /// </summary>
        public static string TodaysDate
        {
            get
            {
                return DateTime.Now.ToString(DateFormat);
            }
        }
    }
}