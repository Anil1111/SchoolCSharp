using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bingo
{
    public partial class MainForm : Form
    {
        private readonly BindingList<int> _extractedNumbers = new BindingList<int>();
        private readonly Randomizer _randomizer;
        private int _lastNumber = -1;
        private bool _sort;
        
        public MainForm()
        {
            InitializeComponent();
            _randomizer = new Randomizer(1, 90);
            lstNumbers.DataSource = _extractedNumbers;
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
            var position = lstNumbers.TopIndex;
            
            if (_sort)
            {
                var insertIndex = ~BinarySearch(_extractedNumbers, number);
                _extractedNumbers.Insert(insertIndex, number);
                if (insertIndex < position)
                    position += 1;
                
                // Fixes list random scrolling
                lstNumbers.TopIndex = position;
                return;
            }
            
            _extractedNumbers.Insert(0, number);
            if (position > 0)
                position += 1;
            
            // Fixes list random scrolling
            lstNumbers.TopIndex = position;
        }

        private void OnSortChanged(object sender, EventArgs e)
        {
            _sort = !_sort;
            
            if (_sort)
                QuickSort(_extractedNumbers, 0, _extractedNumbers.Count - 1, 45);
        }

        private static int BinarySearch(IReadOnlyList<int> array, int value)
        {
            int left = 0;
            int right = array.Count - 1;
            while (left <= right)
            {
                int median = left + (right - left >> 1);
                
                var cmp = array[median].CompareTo(value);
                if (cmp == 0)
                    return median;
                if (cmp < 0)
                    left = median + 1;
                else
                    right = median - 1;
            }

            return ~left;
        }

        private static void QuickSort(IList<int> array, int leftIndex, int rightIndex, int pivot)
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
                QuickSort(array, leftIndex, right, array[leftIndex + (right - leftIndex >> 1)]);
            if (left < rightIndex)
                QuickSort(array, left, rightIndex, array[left + (rightIndex - left >> 1)]);
        }

        private static void Swap(IList<int> array, int first, int second)
        {
            var tmp = array[first];
            array[first] = array[second];
            array[second] = tmp;
        }
    }
}
