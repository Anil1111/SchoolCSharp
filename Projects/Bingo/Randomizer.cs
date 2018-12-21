using System;

namespace Bingo
{
    public class Randomizer
    {
        private readonly Random _rand = new Random();
        
        private readonly int[] _array;
        private int _length;
        
        public Randomizer(int min, int max)
        {
            _length = max - min + 1;
            _array = new int[_length];

            for (int i = 0; i < _length; i++)
                _array[i] = i + min;
        }

        public int RemainingNumbers => _length;
        
        public int Next
        {
            get
            {
                if (_length == 0)
                    throw new IndexOutOfRangeException("Array is empty");

                var index = _rand.Next(_length);

                if (index == _length - 1)
                {
                    _length--;
                    return _array[index];
                }

                var number = _array[index];
                _array[index] = _array[--_length];
                return number;
            }
        }
    }
}