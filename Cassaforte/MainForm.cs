using System;
using System.Windows.Forms;

namespace Cassaforte
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string _password = string.Empty;
        private string _guess = string.Empty;
        private int _tries = 3;

        private void OnDigit(object sender, EventArgs e)
        {
            var number = ((Button) sender).Text; // Can be achieved using 9 methods.
            if (_password.Length < 5)
            {
                _password += number;
                if (_password.Length == 5)
                    txtOutput.Text = "Password impostata!";
            }
            else if (_guess.Length < 5)
            {
                txtOutput.UseSystemPasswordChar = true;

                _guess += number;
                if (_guess.Length == 5)
                {
                    txtOutput.UseSystemPasswordChar = false;
                    if (string.Equals(_password, _guess, StringComparison.Ordinal))
                    {
                        txtOutput.Text = "Cassaforte aperta";
                        btnNum1.Enabled = false;
                        btnNum2.Enabled = false;
                        btnNum3.Enabled = false;
                        btnNum4.Enabled = false;
                        btnNum5.Enabled = false;
                        btnNum6.Enabled = false;
                        btnNum7.Enabled = false;
                        btnNum8.Enabled = false;
                        btnNum9.Enabled = false;
                    }
                    else
                    {
                        if (_tries <= 1)
                        {
                            txtOutput.Text = "Cassaforte bloccata";
                            btnNum1.Enabled = false;
                            btnNum2.Enabled = false;
                            btnNum3.Enabled = false;
                            btnNum4.Enabled = false;
                            btnNum5.Enabled = false;
                            btnNum6.Enabled = false;
                            btnNum7.Enabled = false;
                            btnNum8.Enabled = false;
                            btnNum9.Enabled = false;
                        }
                        else
                        {
                            txtOutput.Text = $"Errore, hai ancora {_tries - 1} tentativi";
                            _tries--;
                        }
                    }
                    
                    _guess = string.Empty;
                }
            }
        }
    }
}
