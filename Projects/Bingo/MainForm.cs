using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Bingo
{
    public partial class MainForm : Form
    {
        private readonly int[] _extractedNumbers = new int[90];
        private int _extractedCount;
        
        private readonly Randomizer _randomizer;
        private int _lastNumber = -1;
        private bool _sort;
        
        public MainForm()
        {
            InitializeComponent();
            _randomizer = new Randomizer(1, 90);
        }

        private void OnExtract(object sender, EventArgs e)
        {
            if (_randomizer.RemainingNumbers == 0)
            {
                billboard.Change(_lastNumber, CellState.Extracted);
                btnExtract.Enabled = false;
                return;
            }
            
            if (_lastNumber != -1)
                billboard.Change(_lastNumber, CellState.Extracted, false);

            _lastNumber = _randomizer.Next;
            billboard.Change(_lastNumber, CellState.LastExtracted);
            txtLastExtracted.Text = _lastNumber.ToString("00");
            ListNumber(_lastNumber);
        }

        private void ListNumber(int number)
        {
            _extractedNumbers[_extractedCount++] = number;
            lstNumbers.Items.Insert(0, $"{_extractedCount:00} - {number,15}");
        }

        private void OnSortChanged(object sender, EventArgs e)
        {
            _sort = !_sort;
            QuickSort(_extractedNumbers, 0, _extractedCount - 1, 45);
            
            lstNumbers.Items.Clear();
            for (int i = 0; i < _extractedCount; i++)
                lstNumbers.Items.Add(_extractedNumbers[i]);
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
        
        private static void QuickSort(int[] array, int leftIndex, int rightIndex, int pivot)
        {
            if (leftIndex > rightIndex) return;

            int left = leftIndex;
            int right = rightIndex;
 
            while (left <= right)
            {
                while (left < rightIndex && array[left] < pivot)
                    left++;
                while (right > leftIndex && array[right] > pivot)
                    right--;

                if (left == right)
                {
                    left++;
                    right--;
                    continue;
                }

                if (left < right)
                    Swap(array, left++, right--);
            }

            if (leftIndex < right)
                QuickSort(array, leftIndex, right, array[leftIndex + (right      - leftIndex)]);
            if (left < rightIndex)
                QuickSort(array, left, rightIndex, array[left      + (rightIndex - left     )]);
        }

        private static void Swap(IList array, int first, int second)
        {
            var tmp = array[first];
            array[first] = array[second];
            array[second] = tmp;
        }
    }
}
