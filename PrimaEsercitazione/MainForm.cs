using System.Windows.Forms;

namespace PrimaEsercitazione
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnButton(object sender, System.EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
