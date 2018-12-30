namespace Bingo
{
    public class ExtractedEventArgs
    {
        private readonly int _row;
        private readonly int _column;
        
        public ExtractedEventArgs(int position)
        {
            _column = position % 10;
            _row = position / 10 % 10;
        }

        public int Row => _row;
        public int Column => _column;
    }
}