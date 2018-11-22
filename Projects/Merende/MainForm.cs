using System;
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
            var checkbox = (CheckBox) sender;

            switch (checkbox.Name)
            {
                case nameof(chkBrioche):
                    if (checkbox.Checked)
                        _price += BriochePrice;
                    else
                        _price -= BriochePrice;
                    break;
                
                case nameof(chkCappuccino):
                    if (checkbox.Checked)
                        _price += CappuccinoPrice;
                    else
                        _price -= CappuccinoPrice;
                    break;
                
                case nameof(chkCoffee):
                    if (checkbox.Checked)
                        _price += CoffeePrice;
                    else
                        _price -= CoffeePrice;
                    break;
                
                case nameof(chkJuice):
                    if (checkbox.Checked)
                        _price += JuicePrice;
                    else
                        _price -= JuicePrice;
                    break;
                
                case nameof(chkSaltyBrioche):
                    if (checkbox.Checked)
                        _price += SaltyBriochePrice;
                    else
                        _price -= SaltyBriochePrice;
                    break;
                
                default:
                    return;
            }

            lblPrice.Text = _price.ToString("C2");
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
