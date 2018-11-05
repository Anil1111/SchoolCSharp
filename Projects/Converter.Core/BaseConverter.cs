using System;

namespace Converter.Core
{
    public static class BaseConverter
    {
        /// <summary>
        /// Multiplies every number by <see cref="@base"/> elevated at position
        /// </summary>
        /// <param name="num">Input in base <see cref="@base"/></param>
        /// <param name="base">Number base</param>
        /// <returns>Base 10 representation of <see cref="num"/></returns>
        /// <exception cref="ArgumentException">Cannot convert bases over 10</exception>
        public static int ToBase10(int num, int @base)
        {
            return Convert(num, @base, 10);
//            if (@base > 10)
//                throw new ArgumentException("Cannot convert base {0}: Cannot rappresent digits with letters.");
//            
//            var output = 0;
//            var length = (int) Math.Log10(num) + 1;
//            for (int i = length - 1; i >= 0; i--)
//            {
//                var numAtPos = num / (int) Math.Pow(10, i) % 10;
//                output += numAtPos * (int) Math.Pow(@base, i);
//            }
//            return output;
        }

        /// <summary>
        /// Divides every number by <see cref="@base"/> and writes the reminder.
        /// </summary>
        /// <param name="base10">Number to convert in base 10</param>
        /// <param name="base">Base to convert to</param>
        /// <returns>Number represented in the specified base</returns>
        /// <exception cref="ArgumentException">Cannot convert bases over 10</exception>
        public static int ToBase(int base10, int @base)
        {
            return Convert(base10, 10, @base);
//            if (@base > 10)
//                throw new ArgumentException("Cannot convert base {0}: Cannot represent digits with letters.");
//            
//            var output = 0;
//            int times = (int) Math.Log(base10, @base) + 1;
//            for (int i = times - 1; i >= 0; i--)
//            {
//                var num = base10 / (int) Math.Pow(@base, i) % @base;
//                output += num * (int) Math.Pow(10, i);
//            }
//            return output;
        }

        private static int Convert(int num, int fromBase, int toBase)
        {
            if (fromBase > 10 || toBase > 10)
                throw new ArgumentException("Cannot convert base {0}: Cannot represent digits with letters.");
            
            var output = 0;
            int times = (int) Math.Log(num, toBase) + 1;
            for (int i = times - 1; i >= 0; i--)
            {
                var a = num / (int) Math.Pow(toBase, i) % toBase;
                output += a * (int) Math.Pow(fromBase, i);
            }
            return output;
        }
    }
}