using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cassaforte
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Default <see cref="TextBoxBase.MaxLength"/> of <see cref="TextBox"/> object
        /// </summary>
        private const int DefaultMaxLength = 32767;
        
        /// <summary>
        /// The correct password
        /// </summary>
        private string _password = string.Empty;
        
        /// <summary>
        /// The number of tries remaining before the locker locks itself
        /// </summary>
        private int _tries = 3;
        
        /// <summary>
        /// The length of the string
        /// </summary>
        private int _length;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when we click whichever numeric button
        /// </summary>
        /// <param name="sender">Object who fired this event</param>
        /// <param name="e">Event arguments</param>
        private void OnDigit(object sender, EventArgs e)
        {
            // Get the string contained in the button (1-9)
            var number = ((Button) sender).Text; // Can be achieved using 9 methods.
            
            // Delete the message currently displaying
            if (_length == 0)
                txtInputOutput.Text = string.Empty;
            
            // While the _length is less than 5 (we didn't reach password length)
            if (_length < 5)
            {
                // Enable password character replacement
                txtInputOutput.UseSystemPasswordChar = true;
                // Append the clicked button text to the password guess
                txtInputOutput.Text += number;
                // Increment the current string length
                _length++;
                
                if (_length == 5)
                {
                    // Disable password character replacement in order to show output messages
                    txtInputOutput.UseSystemPasswordChar = false;
                    
                    // Verifies whether the guessed password is correct; Same as _password == txtInputOutput.Text 
                    if (string.Equals(_password, txtInputOutput.Text, StringComparison.Ordinal))
                    {
                        // If they are equal, display "Cassaforte aperta" and prevent any more input to be registered.
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
                        // Decrement the number of tries remaining
                        _tries--;
                        if (_tries <= 0)
                        {
                            // If no tries are left, display "Cassaforte bloccata" and prevent any more input to be registered.
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
                            // If _tries > 0, display the number of tries remaining
                            txtInputOutput.Text = $"Errore, hai ancora {_tries} tentativi";
                        }
                    }
                    
                    // Reset the password guess length to 0
                    _length = 0;
                }
            }
        }

        /// <summary>
        /// Called when we left click on the TextBox
        /// </summary>
        /// <param name="sender">Object who fired this event</param>
        /// <param name="e">Event arguments</param>
        private void OnTextboxSelected(object sender, MouseEventArgs e)
        {
            // If box is not readonly
            if (!txtInputOutput.ReadOnly)
            {
                // Prepare to receive the right password as input
                txtInputOutput.Text = string.Empty;
                txtInputOutput.TextAlign = HorizontalAlignment.Left;
                txtInputOutput.MaxLength = 5;
                txtInputOutput.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Validates the TextBox content
        /// </summary>
        /// <param name="sender">Object who fired this event</param>
        /// <param name="e">Event arguments</param>
        private void OnValidatingTextbox(object sender, CancelEventArgs e)
        {
            // Se la TextBox e' readonly non validare l'input (l'utente non ne ha controllo)
            if (txtInputOutput.ReadOnly)
                return;
            
            // Verifico che l'input sia valido
            // Uso Regex anche se non ancora spiegate siccome e' una parte opzionale del programma
            e.Cancel = txtInputOutput.TextLength < 5 || !Regex.IsMatch(txtInputOutput.Text, @"[1-9]{5}"); 
        }

        /// <summary>
        /// Saves the password and enables user to guess it
        /// </summary>
        /// <param name="sender">Object who fired this event</param>
        /// <param name="e">Event arguments</param>
        private void OnConfirmCombination(object sender, EventArgs e)
        {
            // Get the password from the TextBox
            _password = txtInputOutput.Text;
            
            // Prevents this button from being pressed again
            btnConfirmCombination.Enabled = false;
            
            // Makes TextBox output "Inserire la combinazione"
            txtInputOutput.ReadOnly = true;
            txtInputOutput.TextAlign = HorizontalAlignment.Center;
            txtInputOutput.MaxLength = DefaultMaxLength;
            txtInputOutput.Text = "Inserire la combinazione";
            txtInputOutput.UseSystemPasswordChar = false;

            // Enables numeric buttons
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
