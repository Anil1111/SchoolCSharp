using System;
using System.Drawing;
using System.Windows.Forms;

namespace Merende
{
    public partial class Authenticator : Form
    {
        private const string Password = "12345";
        private const int Tries = 3;
        
        private string _password = string.Empty;
        private int _tries = Tries;
        
        public Authenticator()
        {
            InitializeComponent();
        }

        private void OnNumpadClick(object sender, EventArgs e)
        {
            var number = ((Button) sender).Text;

            if (_password.Length == 0)
                lblInfo.Text = string.Empty;
            
            if (_password.Length < Password.Length)
            {
                _password += number;
                lblInfo.Text += '*';
                lblInfo.ForeColor = Color.Black;
            }

            if (_password.Length == Password.Length)
            {
                _tries--;
                if (string.Equals(_password, Password, StringComparison.Ordinal))
                {
                    const string output = "Password corretta.";
                    lblInfo.Text = output;
                    lblInfo.ForeColor = Color.Green;
                    MessageBox.Show(output, "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnAuthenticated(true);
                }
                else if (_tries > 0)
                {
                    lblInfo.Text = $"Password errata. {_tries} tentativi rimasti.";
                    lblInfo.ForeColor = Color.Red;
                }
                else
                {
                    lblInfo.Text = "Hai sbagliato troppe volte.";
                    lblInfo.ForeColor = Color.Red;
                    MessageBox.Show("Troppi tentativi sbagliati. L'applicazione sara' ora terminata.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OnAuthenticated(false);
                }
                _password = string.Empty;
            }
        }

        public event EventHandler<AuthEventArgs> Authenticated;
        private void OnAuthenticated(bool successful)
        {
            Authenticated?.Invoke(this, new AuthEventArgs(successful));
        }
    }
}
