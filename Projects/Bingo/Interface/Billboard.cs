using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bingo.Enums;
using Bingo.Events;

namespace Bingo.Interface
{
    public partial class Billboard : Control
    {
        private readonly CellState[] _cells = new CellState[90];

        private int _cellSize    = 25;
        private int _cellSpacing = 10;

        private Color _free      = Color.Green;
        private Color _lastShown = Color.Yellow;
        private Color _shown     = Color.Red;

        public Billboard()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // We compute brushes only once as they are quite expensive
            SolidBrush green = new SolidBrush(_free);
            SolidBrush yellow = new SolidBrush(_lastShown);
            SolidBrush red = new SolidBrush(_shown);
            SolidBrush textColor = new SolidBrush(ForeColor);
            
            var g = pe.Graphics;
            for (int i = 0; i < _cells.Length; i++)
            {
                SolidBrush brush;
                switch (_cells[i])
                {
                    default:
                        brush = green;
                        break;

                    case CellState.LastExtracted:
                        brush = yellow;
                        break;

                    case CellState.Extracted:
                        brush = red;
                        break;
                }

                int spacing = (Size.Height - (9 * _cellSize + 6 * _cellSpacing)) / 2;
                var position = new PointF(
                        (_cellSize + _cellSpacing) * (i % 10)      + (spacing - _cellSpacing) * (i % 10 / 5),
                        (_cellSize + _cellSpacing) * (i / 10 % 10) + (spacing - _cellSpacing) * (i / 10 / 3));

                g.FillRectangle(brush, position.X, position.Y, CellSize, CellSize);

                var text = (i + 1).ToString();
                var textSize = g.MeasureString(text, Font);
                g.DrawString(text, Font, textColor, new PointF(position.X + _cellSize / 2f - textSize.Width / 2f, position.Y + _cellSize / 2f - textSize.Height / 2f));
            }
        }

        public void Change(int number, CellState state, bool invalidate = true)
        {
            --number;
            
            _cells[number] = state;
            if (invalidate)
                Invalidate();

            if (state == CellState.LastExtracted)
                OnExtracted(number);
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CellSize
        {
            get => _cellSize;
            set
            {
                if (!Equals(value, _cellSize))
                {
                    _cellSize = value;
                    Invalidate();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CellSpacing
        {
            get => _cellSpacing;
            set
            {
                if (!Equals(value, _cellSpacing))
                {
                    _cellSpacing = value;
                    Invalidate();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color Free
        {
            get => _free;
            set
            {
                if (!Equals(value, _free))
                {
                    _free = value;
                    Invalidate();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color LastShown
        {
            get => _lastShown;
            set
            {
                if (!Equals(value, _lastShown))
                {
                    _lastShown = value;
                    Invalidate();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color Shown
        {
            get => _shown;
            set
            {
                if (!Equals(value, _shown))
                {
                    _shown = value;
                    Invalidate();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public event EventHandler<ExtractedEventArgs> Extracted;

        private void OnExtracted(int position)
        {
            Extracted?.Invoke(this, new ExtractedEventArgs(position));
        }
    }
}
