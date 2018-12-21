using System;
using System.Collections.Generic;

namespace Test
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {10, 20, 30, 40};
            Console.WriteLine(BinarySearch(arr, 20));
        }
        
        private static int BinarySearch(IList<int> array, int key)
        {
            int left = 0;
            int right = array.Count - 1;
            while (left < right)
            {
                int index = left + (right - left) / 2;
                var middle = array[index];

                switch (middle.CompareTo(key))
                {
                    case 0: // index == key
                        return -1;

                    case 1: // index > key
                        right = index - 1;
                        continue;

                    case -1: // index < key
                        left = index + 1;
                        continue;
                }
            }
            return left;
        }

    }
}