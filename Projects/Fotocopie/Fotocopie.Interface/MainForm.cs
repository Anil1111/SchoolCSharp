using Fotocopie.Logic;
using System.Windows.Forms;

namespace Fotocopie.Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnCompute(object sender, System.EventArgs e)
        {
            var whiteBlacks = (int) whiteBlacksPhotocopies.Value;
            var colored = (int) coloredPhotocopies.Value;

            var photocopies = colored + whiteBlacks;
            var whiteBlackPrice = whiteBlacks * Printer.WhiteAndBlackPrice;
            var coloredPrice = colored * Printer.ColorPrintPrice;

            var totalPrice = whiteBlackPrice + coloredPrice;
            if (photocopies > 0 && totalPrice < Printer.FreeBindingStartPrice)
                totalPrice += Printer.BindingPrice;

            lblPhotocopies.Text = $"Numero fotocopie: {photocopies}";
            lblWhiteAndBlackPrice.Text = $"Prezzo fotocopie bianco nero: {Utility.EuroCentToEuro(whiteBlackPrice)}";
            lblColoredPrice.Text = $"Prezzo fotocopie a colori: {Utility.EuroCentToEuro(coloredPrice)}";
            lblTotalPrice.Text = $"Prezzo totale con rilegatura: {Utility.EuroCentToEuro(totalPrice)}";
        }
    }
}
