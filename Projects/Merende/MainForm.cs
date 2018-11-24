using System;
using System.Text;
using System.Windows.Forms;

namespace Merende
{
    public partial class MainForm : Form
    {
        private const decimal CoffeePrice = 1.00m;
        private const decimal CappuccinoPrice = 1.50m;
        private const decimal BriochePrice = 1.10m;
        private const decimal SaltyBriochePrice = 1.20m;
        private const decimal JuicePrice = 2.50m;
        
        private decimal _price;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnSelectionChange(object sender, EventArgs e)
        {
            _price = 0;

            if (chkBrioche.Checked)
                _price += BriochePrice;
            if (chkCappuccino.Checked)
                _price += CappuccinoPrice;
            if (chkCoffee.Checked)
                _price += CoffeePrice;
            if (chkJuice.Checked)
                _price += JuicePrice;
            if (chkSaltyBrioche.Checked)
                _price += SaltyBriochePrice;

            lblPrice.Text = _price.ToString("C2");
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            const string title = "Colazione Scelta";

            StringBuilder message = new StringBuilder();
            if (_price > 0)
            {
                message.AppendLine("Hai scelto:");
                if (chkCoffee.Checked)
                    message.AppendFormat(" • Caffè: {0:C2}\n",
                        CoffeePrice); // Should use Environment.NewLine but in the end it's the same
                if (chkCappuccino.Checked)
                    message.AppendFormat(" • Cappuccino: {0:C2}\n", CappuccinoPrice);
                if (chkBrioche.Checked)
                    message.AppendFormat(" • Brioche: {0:C2}\n", BriochePrice);
                if (chkSaltyBrioche.Checked)
                    message.AppendFormat(" • Brioche salata: {0:C2}\n", SaltyBriochePrice);
                if (chkJuice.Checked)
                    message.AppendFormat(" • Spremuta: {0:C2}\n", JuicePrice);
            }
            else
            {
                message.AppendLine("Non hai scelto nessun prodotto.");
            }

            message.AppendFormat("\nTotale: {0:C2}", _price);
            
            groupPanel.Enabled = false;
            MessageBox.Show(message.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
