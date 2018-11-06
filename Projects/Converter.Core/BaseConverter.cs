using System;
using System.Text;

namespace Converter.Core
{
    public static class BaseConverter
    {
        /// <summary>
        /// Converts any number to the specified base representation.
        /// </summary>
        /// <param name="num">Number to convert to base <i><see cref="toBase"/></i></param>
        /// <param name="fromBase">Original base of <i><see cref="num"/></i></param>
        /// <param name="toBase">Base the number gets converted to</param>
        /// <returns>Number represented in base <i><see cref="toBase"/></i></returns>
        /// <exception cref="ArgumentException">Bases must be within 2 and 10</exception>
        public static ulong Convert(ulong num, ulong fromBase, ulong toBase)
        {
            if (fromBase < 2 || fromBase > 10 ||
                toBase < 2 || toBase > 10)
                throw new ArgumentException($"Cannot convert from base {fromBase} to base {toBase}: Bases must be within 2 and 10");

            var output = 0UL;
            var weight = 1UL;
            while (num > 0)
            {
                output += num % toBase * weight;
                num /= toBase;
                weight *= fromBase;
            }

            return output;
        }

        /// <summary>
        /// Converts any number to the specified base representation.
        /// </summary>
        /// <param name="num">Positive number in base <i><see cref="fromBase"/></i></param>
        /// <param name="fromBase">Base the <i><see cref="num"/></i> is represented</param>
        /// <param name="toBase">Base to get converted to</param>
        /// <returns>Number represented in base <i><see cref="toBase"/></i></returns>
        /// <exception cref="ArgumentException">Bases must be within 2 and 36</exception>
        public static string Convert(string num, ulong fromBase, ulong toBase)
        {
            if (fromBase < 2 || fromBase > 36 ||
                toBase < 2 || toBase > 36)
                throw new ArgumentException($"Cannot convert from base {fromBase} to base {toBase}: Bases must be within 2 and 36");
            
            var weight = 1UL;
            var base10 = 0UL;
            for (var index = num.Length - 1; index >= 0; index--)
            {
                base10 += num[index].ToValue() * weight;
                weight *= fromBase;
            }

            StringBuilder output = new StringBuilder();
            while (base10 > 0)
            {
                output.Insert(0, (base10 % toBase).ToChar()); // I don't like insert tbh
                base10 /= toBase;
            }
            return output.ToString();
        }

        private static char ToChar(this ulong value)
        {
            if (value < 10)
                return (char) (48 + value);
            if (value <= 36)
                return (char) (55 + value);
            
            throw new InvalidCastException($"Cannot convert number {value} to hex.");
        }

        private static ulong ToValue(this char hex)
        {
            var value = (ulong) hex;
            if (value >= 48 && value <= 57) // If Number
                return value - 48; // Return Number

            if (value >= 97 && value <= 122) // If LowerCase
                value -= 32; // Make UpperCase
            if (value >= 65 && value <= 90) // If UpperCase
                return value - 55; // Return HexValue

            throw new InvalidCastException($"Cannot convert from char {hex} to an hex value.");
        }
    }
}