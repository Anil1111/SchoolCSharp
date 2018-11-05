using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (!ulong.TryParse(txtNumberLeft.Text, out ulong num))
                return;

            ulong fromBase = (ulong)fieldBaseLeft.Value;
            ulong toBase = (ulong)fieldBaseRight.Value;

            txtNumberRight.Text = BaseConverter.Convert(num, fromBase, toBase).ToString();
        }

        private void OnRightToLeft(object sender, EventArgs e)
        {
            if (!ulong.TryParse(txtNumberRight.Text, out ulong num))
                return;

            ulong fromBase = (ulong)fieldBaseRight.Value;
            ulong toBase = (ulong)fieldBaseLeft.Value;

            txtNumberLeft.Text = BaseConverter.Convert(num, fromBase, toBase).ToString();
        }

        private void OnValidatingLeft(object sender, EventArgs e)
        {
            var @base = (ulong)fieldBaseLeft.Value;
            var valid = ulong.TryParse(txtNumberLeft.Text, out ulong num);

            while (valid && num > 0)
            {
                if (num % 10 >= @base)
                    valid = false;
                
                num /= 10;
            }

            txtNumberLeft.ForeColor = valid ? Color.Black : Color.Red;
            btnLeftToRight.Enabled = valid;
        }
        
        private void OnValidatingRight(object sender, EventArgs e)
        {
            var @base = (ulong)fieldBaseRight.Value;
            var valid = ulong.TryParse(txtNumberRight.Text, out ulong num);

            while (valid && num > 0)
            {
                if (num % 10 >= @base)
                    valid = false;
                
                num /= 10;
            }

            txtNumberRight.ForeColor = valid ? Color.Black : Color.Red;
            btnRightToLeft.Enabled = valid;
        }
    }
}
