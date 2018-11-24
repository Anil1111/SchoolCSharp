using System;
using System.Runtime.InteropServices;
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

            lblPrice.Text = _price.ToString("C");
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            const string title = "Colazione Scelta";

            string message = "Hai scelto:\n"; // I want to use StringBuilder .-.
            if (chkCoffee.Checked)
                message += $" • Caffè: {CoffeePrice:C2}\n";
            if (chkCappuccino.Checked)
                message += $" • Cappuccino: {CappuccinoPrice:C2}\n";
            if (chkBrioche.Checked)
                message += $" • Brioche: {BriochePrice:C2}\n";
            if (chkSaltyBrioche.Checked)
                message += $" • Brioche salata: {SaltyBriochePrice:C2}\n";
            if (chkJuice.Checked)
                message += $" • Spremuta: {JuicePrice:C2}\n";
            message += '\n';
            message += $"Totale: {_price:C2}";
            
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
