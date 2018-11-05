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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnCompute(object sender, EventArgs e)
        {
            if (sender is NumericUpDown box)
            {
                int num, fromBase, toBase;
                NumericUpDown targetNum;
                if (box.Name.EndsWith("1"))
                {
                    num = (int) fieldNum1.Value;
                    fromBase = (int) fieldBase1.Value;
                    targetNum = fieldNum2;
                    toBase = (int) fieldBase2.Value;
                }
                else
                {
                    num = (int)fieldNum2.Value;
                    fromBase = (int)fieldBase2.Value;
                    targetNum = fieldNum1;
                    toBase = (int) fieldBase1.Value;
                }

                var base10 = BaseConverter.ToBase10(num, fromBase);
                targetNum.Text = BaseConverter.ToBase(base10, toBase).ToString();
            }
        }
    }
}
