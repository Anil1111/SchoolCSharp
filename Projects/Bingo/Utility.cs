using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Bingo
{
    internal static class Utility
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ExtractedString(int extractedAt, int number) => $"{extractedAt + 1:00} - {number:00}";
        
        public static void Insert(this int[] array, int index, int value)
        {
            Array.Copy(
                sourceArray: array, 
                sourceIndex: index, 
                destinationArray: array, 
                destinationIndex: index + 1, 
                length: array.Length - index - 1);

            array[index] = value;
        }

        public static void QuickSort(IList<int> indices, IReadOnlyList<int> array, int leftIndex, int rightIndex, int pivot)
        {
            if (leftIndex > rightIndex) return;
        
            int left = leftIndex;
            int right = rightIndex;
        
            while (left <= right)
            {
                while (left < rightIndex && array[indices[left]] < pivot)
                    left++;
                while (right > leftIndex && array[indices[right]] > pivot)
                    right--;
        
                if (left == right)
                {
                    left++;
                    right--;
                    continue;
                }
        
                if (left < right)
                    Swap(indices, left++, right--);
            }
        
            if (leftIndex < right)
                QuickSort(indices, array, leftIndex, right, array[indices[leftIndex + (right - leftIndex >> 1)]]);
            if (left < rightIndex)
                QuickSort(indices, array, left, rightIndex, array[indices[left + (rightIndex - left >> 1)]]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void Swap(IList<int> array, int first, int second)
        {
            var tmp = array[first];
            array[first] = array[second];
            array[second] = tmp;
        }
        
        public static int BinarySearch(IList<int> indices, IReadOnlyList<int> elements, int length, int value)
        {
            int left = 0;
            int right = length - 1;
            while (left <= right)
            {
                int median = left + (right - left >> 1);
                
                var cmp = elements[indices[median]].CompareTo(value);
                if (cmp == 0)
                    return median;
                if (cmp < 0)
                    left = median + 1;
                else
                    right = median - 1;
            }
        
            return ~left;
        }
    }
}