using System;
using System.Linq;
using System.Windows.Forms;
using Bingo.Enums;
using Bingo.Events;

namespace Bingo.Interface
{
    public partial class MainForm : Form
    {
        private readonly int[] _extractedNumbers = new int[90];
        private int[] _sortedIndices;
        private int _extractedCount;
        
        private Randomizer _randomizer;
        private int _lastNumber;
        private Sequence _lastSequence;
        private Sort _sort;
        
        public MainForm()
        {
            InitializeComponent();
            _randomizer = new Randomizer(1, 90);
        }

        private void OnExtract(object sender, EventArgs e)
        {
            // Disable the button if no numbers left
            if (_randomizer.RemainingNumbers == 0)
            {
                billboard.Change(_lastNumber, CellState.Extracted);
                btnExtract.Enabled = false;
                MessageBox.Show("Non ci sono rimasti numeri da estrarre.", "Estrazione", MessageBoxButtons.OK);
                return;
            }
            
            // Change the last extracted cell to Extracted
            if (_lastNumber > 0)
                billboard.Change(_lastNumber, CellState.Extracted, false);

            // Extract a random number
            _lastNumber = _randomizer.Next;
            billboard.Change(_lastNumber, CellState.LastExtracted);
            txtLastExtracted.Text = _lastNumber.ToString("00");
        }
        
        private void OnExtracted(object sender, ExtractedEventArgs e)
        {
            ListNumber(_lastNumber);
            CheckForSequences(e.Column, e.Row);
        }
        
        private void CheckForSequences(int cellColumn, int cellRow)
        {
            if (_lastSequence < Sequence.Cinquina)
            {
                Sequence extractedInRow = 0;
                for (int i = 0; i < _extractedCount; i++)
                {
                    var number = _extractedNumbers[i];
                    var row = (number - 1) / 10 % 10;
                    if (cellRow == row)
                    {
                        var column = (number - 1) % 10;
                        if (column < cellColumn / 5 * 5 + 5 && column >= cellColumn / 5 * 5)
                            ++extractedInRow;
                    }
                }

                if (_lastSequence < extractedInRow)
                {
                    switch (extractedInRow)
                    {
                        case Sequence.Ambo:
                            MessageBox.Show($"{extractedInRow} estratto", "Estrazione", MessageBoxButtons.OK);
                            break;

                        case Sequence.Terna:
                        case Sequence.Quaterna:
                        case Sequence.Cinquina:
                            MessageBox.Show($"{extractedInRow} estratta", "Estrazione", MessageBoxButtons.OK);
                            break;
                    }

                    _lastSequence = extractedInRow;
                }
            }
            else if (_lastSequence < Sequence.Tombola)
            {
                Sequence extractedInCard = 0;
                for (int i = 0; i < _extractedCount; i++)
                {
                    var number = _extractedNumbers[i];
                    var row = (number - 1) / 10 % 10;
                    var column = (number - 1) % 10;
                    if (row    < cellRow    / 3 * 3 + 3 && row    >= cellRow    / 3 * 3 &&
                        column < cellColumn / 5 * 5 + 5 && column >= cellColumn / 5 * 5)
                        ++extractedInCard;
                }

                if (extractedInCard == Sequence.Tombola)
                {
                    MessageBox.Show($"{extractedInCard} estratta", "Estrazione", MessageBoxButtons.OK);
                    _lastSequence = extractedInCard;
                }
            }
        }

        private void ListNumber(int number)
        {
            var position = lstNumbers.TopIndex;

            switch (_sort)
            {
                case Sort.Number:
                    // Get index of insertion
                    var insertIndex = ~Utility.BinarySearch(_sortedIndices, _extractedNumbers, _extractedCount, number);
                    _sortedIndices.Insert(insertIndex, _extractedCount);
                    
                    // Insert the number in the ListBox
                    lstNumbers.Items.Insert(insertIndex, Utility.ExtractedString(_extractedCount, number));
                    
                    // Fixes auto-scrolling in ListBox
                    if (insertIndex < position)
                        position += 1;
                    lstNumbers.TopIndex = position;
                    break;
                
                case Sort.Extraction:
                    // Adds the number in the ListBox
                    lstNumbers.Items.Add(Utility.ExtractedString(_extractedCount, number));

                    // Auto-scrolls the ListBox
                    lstNumbers.TopIndex = _extractedCount;
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(_sort));
            }
            
            // Add the number to the array
            _extractedNumbers[_extractedCount] = number;
            
            // Update the extracted count
            ++_extractedCount;
        }


        private void OnSortChanged(object sender, EventArgs e)
        {
            _sort = sortExtraction.Checked ? Sort.Extraction : Sort.Number;

            lstNumbers.Items.Clear();
            switch (_sort)
            {
                case Sort.Number:
                    _sortedIndices = Enumerable.Range(0, 90).ToArray();
                    Utility.QuickSort(_sortedIndices, _extractedNumbers, 0, _extractedCount - 1, 45);
                
                    for (int i = 0; i < _extractedCount; i++)
                    {
                        var index = _sortedIndices[i];
                        lstNumbers.Items.Add(Utility.ExtractedString(index, _extractedNumbers[index]));
                    }
                    break;
                
                case Sort.Extraction:
                    for (int i = 0; i < _extractedCount; i++)
                        lstNumbers.Items.Add(Utility.ExtractedString(i, _extractedNumbers[i]));
                    break;
            }
        }

        private void OnRestore(object sender, EventArgs e)
        {
            _extractedCount = 0;
            _lastNumber = 0;
            _lastSequence = 0;
            _sort = 0;
            _sortedIndices = null;
            _randomizer = new Randomizer(1, 90);

            txtLastExtracted.Text = "00";
            billboard.Clear();
            lstNumbers.Items.Clear();
            sortNumber.Checked = false;
            sortExtraction.Checked = true;
            btnExtract.Enabled = true;
        }
    }
}
