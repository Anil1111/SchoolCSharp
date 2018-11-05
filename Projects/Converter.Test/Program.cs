using System;
using System.Diagnostics;
using System.Management.Instrumentation;
using System.Threading;
using Converter.Core;

namespace Converter.Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Number: ");
                if (!int.TryParse(Console.ReadLine(), out int fromNum))
                    continue;
                Console.Write("Base: ");
                if (!int.TryParse(Console.ReadLine(), out int fromBase))
                    continue;
                Console.Write("ToBase: ");
                if (!int.TryParse(Console.ReadLine(), out int toBase))
                    continue;

                var base10 = BaseConverter.ToBase10(fromNum, fromBase);
                var toNum = BaseConverter.ToBase(base10, toBase);
                
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Conversion from {0} (base {1}) to {2} (base {3})", 
                    fromNum, fromBase,
                    toNum, toBase);

                /*
                // Test to replace DivisibleBy
                var number = rand.Next(int.MaxValue);
                var divider = rand.Next(8) + 2;

                var a = (int) Math.Log(number, divider) + 1;
                var b = DivisibleBy(number, divider);
                
                Console.WriteLine("{0},{1} {2}=={3}", number, divider, a, b);
                Debug.Assert(a == b);
                */
            }
        }
        
        /*
        /// <summary>
        /// Divides <see cref="num1"/> by <see cref="num2"/> and then the outcome for <see cref="num2"/> until 0 is reached
        /// </summary>
        /// <param name="num1">Number to be checked</param>
        /// <param name="num2">Number to be checked with</param>
        /// <returns>How many times <see cref="num1"/> (and it's outcomes) were divided by <see cref="num2"/> before 0 was reached</returns>
        /// <exception cref="ArgumentException"><see cref="num2"/> is zero</exception>
        private static int DivisibleBy(int num1, int num2)
        {
            if (num2 == 0 || num2 == 1)
                throw new ArgumentException($"Divider cannot be {num2}");
            
            int counter = 0;
            while (num1 > 0)
            {
                num1 /= num2;
                counter++;
            }
            return counter;
        }
        */
    }
}