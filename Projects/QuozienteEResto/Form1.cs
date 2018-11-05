using System;
using System.Windows.Forms;

namespace QuozienteEResto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnCompute(object sender, EventArgs e)
        {
            lblQuotient.Visible = lblRemainder.Visible = true;

            var num1 = numberField1.Value;
            var num2 = numberField2.Value;

            if (num2 == 0)
            {
                if (num1 == 0)
                {
                    lblQuotient.Text = @"La divisione è Indeterminata";
                    lblRemainder.Visible = false;
                    return;
                }

                lblQuotient.Text = @"La divisione è Impossibile";
                lblRemainder.Visible = false;
                return;
            }

            var count = 0;
            while (num1 >= num2)
            {
                num1 -= num2;
                count++;
            }

            lblQuotient.Text = $@"Il quoziente è {count}";
            lblRemainder.Text = $@"Il resto è {num1}";
        }
    }
}
