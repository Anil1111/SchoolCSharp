using System;
using System.Windows.Forms;

namespace NeperoNumber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnIterationsChanged(object sender, EventArgs evt)
        {
            var iterations = (int) fieldIterations.Value;

            double e = 0;
            for (var i = 0; i < iterations; i++)
                e += 1f / Factorial(i);

            lblValue.Text = "e: " + e;
        }

        private static int Factorial(int b)
        {
            if (b == 0)
                return 1;

            return Factorial(b - 1) * b;
        }
    }
}
