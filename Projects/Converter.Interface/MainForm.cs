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

        private void OnCompute(object sender, EventArgs e)
        {
            if (sender is NumericUpDown box)
            {
                ulong num, fromBase, toBase;
                NumericUpDown targetNum;
                if (box.Name.EndsWith("1"))
                {
                    num = (ulong) fieldNum1.Value;
                    fromBase = (ulong) fieldBase1.Value;
                    targetNum = fieldNum2;
                    toBase = (ulong) fieldBase2.Value;
                }
                else
                {
                    num = (ulong)fieldNum2.Value;
                    fromBase = (ulong)fieldBase2.Value;
                    targetNum = fieldNum1;
                    toBase = (ulong) fieldBase1.Value;
                }

                targetNum.Text = BaseConverter.Convert(num, fromBase, toBase).ToString();
            }
        }
    }
}
