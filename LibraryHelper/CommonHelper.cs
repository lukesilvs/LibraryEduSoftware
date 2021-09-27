using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelper
{
    /// <summary>
    /// This is a helper class for Generating Random Strings and Decimals 
    /// </summary>
    public static class CommonHelper
    {
        /// <summary>
        /// RandomString Generates 3 Digit Random String
        /// </summary>
        /// <param name="size">Its the size of string alphabets</param>
        /// <param name="random">To generate random numbers</param>
        /// <returns>Returns the randomly Generated string</returns>
        public static string RandomString(int size, Random random)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        /// <summary>
        /// NextDecimal generates the decimal number between minValue and maxValue
        /// </summary>
        /// <param name="random">To generate random numbers</param>
        /// <returns>Returns the randomly Generated decimal</returns>
        public static decimal NextDecimal(Random random)
        {
            double minValue = 0.01;
            double maxValue = 9.99;
            decimal val;
            int decimal_places = 2;
            val = Math.Round(new decimal(random.NextDouble() * (maxValue - minValue) + minValue), decimal_places);
            return val;
        }
    }
}
