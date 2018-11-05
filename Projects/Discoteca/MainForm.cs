using System;
using System.Windows.Forms;

namespace Discoteca
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OnCompute(object sender, EventArgs e)
        {
            lblTotalCount.Visible = lblUnderagePrice.Visible = lblAdultPrice.Visible = true;

            var adults = (int) adultField.Value;
            var underages = (int) underageField.Value;
            var total = adults + underages;

            lblTotalCount.Text = $"Numero totale ingressi: {total}";
            lblUnderagePrice.Text = $"Incasso per minorenni: {underages * Pricing.UnderagePricing:C}";
            lblAdultPrice.Text = $"Incasso per adulti: {adults * Pricing.AdultPricing:C}";
        }
    }
}
