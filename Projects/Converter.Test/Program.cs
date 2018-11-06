using System;

namespace Converter.Test
{
    internal static class Program
    {
        // a 97  0x61
        // z 122 0x7A
        // A 65  0x41
        // Z 90  0x5A
        // 0 48  0x30
        // 9 57  0x39
        private static bool IsValid(char a, int @base)
        {
            if (a >= 48 && a - 48 < @base)
                return true;
            if (a >= 65 && a - 65 < @base - 10)
                return true;
            if (a >= 97 && a - 97 < @base - 10)
                return true;
            return false;
        }
        
        public static void Main(string[] args)
        {
            while (true)
            {
                // IsValid test
                var c = Console.ReadKey().KeyChar;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine("{0} {1}", c, IsValid(c, 3), (int) c);
                Console.WriteLine();
                
                /*
                // Converter tests
                Console.SetCursorPosition(0, 0);
                Console.Write("Number: ");
                if (!ulong.TryParse(Console.ReadLine(), out ulong fromNum))
                    continue;
                Console.Write("Base: ");
                if (!ulong.TryParse(Console.ReadLine(), out ulong fromBase))
                    continue;
                Console.Write("ToBase: ");
                if (!ulong.TryParse(Console.ReadLine(), out ulong toBase))
                    continue;

                var toNum = BaseConverter.Convert(fromNum, fromBase, toBase);
                
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Conversion from {0} (base {1}) to {2} (base {3})", 
                    fromNum, fromBase,
                    toNum, toBase);
                */

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