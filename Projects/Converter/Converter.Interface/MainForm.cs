using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Converter.Core;

namespace Converter.Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLeftToRight(object sender, EventArgs e)
        {
            ulong fromBase = (ulong)fieldBaseLeft.Value;
            ulong toBase = (ulong)fieldBaseRight.Value;
            
            txtNumberRight.Text = BaseConverter.Convert(txtNumberLeft.Text, fromBase, toBase);
        }

        private void OnRightToLeft(object sender, EventArgs e)
        {
            ulong fromBase = (ulong)fieldBaseRight.Value;
            ulong toBase = (ulong)fieldBaseLeft.Value;

            txtNumberLeft.Text = BaseConverter.Convert(txtNumberRight.Text, fromBase, toBase);
        }

        private void OnValidatingLeft(object sender, EventArgs e)
        {
            var @base = (int)fieldBaseLeft.Value;
            var valid = !string.IsNullOrEmpty(txtNumberLeft.Text) &&
                        txtNumberLeft.Text.All(x => IsValid(x, @base));
            
            txtNumberLeft.ForeColor = valid ? Color.Black : Color.Red;
            btnLeftToRight.Enabled = valid;
        }
        
        private void OnValidatingRight(object sender, EventArgs e)
        {
            var @base = (int)fieldBaseRight.Value;
            var valid = !string.IsNullOrEmpty(fieldBaseRight.Text) &&
                        txtNumberRight.Text.All(x => IsValid(x, @base));
            
            txtNumberRight.ForeColor = valid ? Color.Black : Color.Red;
            btnRightToLeft.Enabled = valid;
        }

        private static bool IsValid(char c, int @base)
        {
            // Ascii Values
            // a  97 0x61 | z 122 0x7A | 122 - 97 = 25
            // A  65 0x41 | Z  90 0x5A |  90 - 65 = 25
            // 0  48 0x30 | 9  57 0x39 |  57 - 48 = 9
            if (c >= 48 && c <= 57) // If Digit
                return c - 48 < @base; // Check if digit is less than @base
            if (c >= 97 && c <= 122) // If UpperCase
                return c - 87 < @base; // Check if char value (from 'a' to c) is less than @base
            if (c >= 65 && c <= 90) // If LowerCase
                return c - 55 < @base; // Check if char value (from 'A' to c) is less than @base
            return false;
        }
    }
}
