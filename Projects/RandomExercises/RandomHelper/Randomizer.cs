using System;

namespace RandomHelper
{
    public static class Randomizer
    {
        public static readonly Random Random = new Random();

        public static int Number(int min, int max)
        {
            return min + Random.Next(max - min + 1);
        }

        public static int[] NumericArray(int length, int min, int max)
        {
            var array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = Number(min, max);
            return array;
        }

        public static int[] CompleteArray(int first, int last)
        {
            var length = last - first + 1;

            var array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = first + i;

            return array;
        }

        public static void Shuffle(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                var index = Random.Next(array.Length);

                var temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }

        public static int[] UnordinatedCompleteArray(int first, int last)
        {
            var array = CompleteArray(first, last);
            Shuffle(array);
            return array;
        }
    }
}