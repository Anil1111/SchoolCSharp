using System;

namespace Converter.Core
{
    public static class BaseConverter
    {
        /// <summary>
        /// Converts any number to the specified base rappresentation.
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

            ulong output = 0;
            var weight = fromBase;
            while (num > 0)
            {
                output += (num /= toBase) % toBase * weight;
                weight *= fromBase;
            }
            
            return output;
        }
    }
}