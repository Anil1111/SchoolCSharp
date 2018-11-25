using System;
using System.Text;
using System.Windows.Forms;

namespace Merende
{
    /// <summary>
    /// The main application form
    /// </summary>
    /// <seealso cref="T:Merende.Authenticator" />
    /// <inheritdoc />
    public partial class MainForm : Form
    {
        /// <summary>The price of a Coffee</summary>
        private const decimal CoffeePrice = 1.00m;
        
        /// <summary>The price of a Cappuccino</summary>
        private const decimal CappuccinoPrice = 1.50m;
        
        /// <summary>The price of a Brioche</summary>
        private const decimal BriochePrice = 1.10m;
        
        /// <summary>The price of a Salty Brioche</summary>
        private const decimal SaltyBriochePrice = 1.20m;
        
        /// <summary>The price of a Juice Glass</summary>
        private const decimal JuicePrice = 2.50m;
        
        /// <summary>
        /// The price of all the selected products summed.
        /// </summary>
        private decimal _price;
        
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called everytime a <see cref="CheckBox"/>'s <see cref="CheckBox.Checked"/> property changes.
        /// </summary>
        /// <param name="sender">The object that fired this event</param>
        /// <param name="e">The event args</param>
        private void OnSelectionChange(object sender, EventArgs e)
        {
            // Reset the price to 0
            _price = 0;

            // Add every selected product price to the total price
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

            // Output the price in real time
            lblPrice.Text = _price.ToString("C2");
        }

        /// <summary>
        /// Called when the submit button is pressed.
        /// </summary>
        /// <param name="sender">The button <see cref="btnSubmit"/></param>
        /// <param name="e">The event args</param>
        private void OnSubmit(object sender, EventArgs e)
        {
            const string title = "Colazione Scelta";

            StringBuilder message = new StringBuilder();
            // Build the message containing the selected products.
            if (_price > 0)
            {
                message.AppendLine("Hai scelto:");
                if (chkCoffee.Checked)
                    // Should use Environment.NewLine but in the end it's the same
                    message.AppendFormat(" • Caffè: {0:C2}\n", CoffeePrice);
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

            // Append the total cost at the end of the message.
            message.AppendFormat("\nTotale: {0:C2}", _price);
            
            // Prevent any more interaction with the user
            groupPanel.Enabled = false;
            
            // Show the message box containing the product list
            MessageBox.Show(message.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
