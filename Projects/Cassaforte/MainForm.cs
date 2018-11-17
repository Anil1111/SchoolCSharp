using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cassaforte
{
    public partial class MainForm : Form
    {
        private const int DefaultMaxLength = 32767;
        private string _password = string.Empty;
        private string _guess = string.Empty;
        private int _tries = 3;
        private int _index;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnDigit(object sender, EventArgs e)
        {
            var number = ((Button) sender).Text; // Can be achieved using 9 methods.
            if (_index == 0)
                txtInputOutput.Text = string.Empty;
            
            if (_index < 5)
            {
                txtInputOutput.UseSystemPasswordChar = true;
                txtInputOutput.Text += ' '; // No need to append the real value, it would be displayed as * anyways

                _guess += number;
                _index++;
                if (_index == 5)
                {
                    txtInputOutput.UseSystemPasswordChar = false;
                    if (string.Equals(_password, _guess, StringComparison.Ordinal))
                    {
                        txtInputOutput.Text = "Cassaforte aperta";
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
                        _tries--;
                        if (_tries <= 0)
                        {
                            txtInputOutput.Text = "Cassaforte bloccata";
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
                            txtInputOutput.Text = $"Errore, hai ancora {_tries} tentativi";
                        }
                    }
                    
                    _guess = string.Empty;
                    _index = 0;
                }
            }
        }

        private void OnTextboxSelected(object sender, MouseEventArgs e)
        {
            if (!txtInputOutput.ReadOnly)
            {
                txtInputOutput.Text = string.Empty;
                txtInputOutput.TextAlign = HorizontalAlignment.Left;
                txtInputOutput.MaxLength = 5;
            }
        }

        private void OnValidatingTextbox(object sender, CancelEventArgs e)
        {
            e.Cancel = txtInputOutput.TextLength < 5 || !Regex.IsMatch(txtInputOutput.Text, @"[1-9]{5}");
        }

        private void OnConfirmCombination(object sender, EventArgs e)
        {
            _password = txtInputOutput.Text;
            btnConfirmCombination.Enabled = false;
            txtInputOutput.ReadOnly = true;
            txtInputOutput.TextAlign = HorizontalAlignment.Center;
            txtInputOutput.MaxLength = DefaultMaxLength;
            txtInputOutput.Text = "Inserire la combinazione";

            btnNum1.Enabled = true;
            btnNum2.Enabled = true;
            btnNum3.Enabled = true;
            btnNum4.Enabled = true;
            btnNum5.Enabled = true;
            btnNum6.Enabled = true;
            btnNum7.Enabled = true;
            btnNum8.Enabled = true;
            btnNum9.Enabled = true;
        }
    }
}
