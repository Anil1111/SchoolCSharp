using System;
using System.Drawing;
using System.Windows.Forms;

namespace Merende
{
    /// <summary>
    /// The first form showing, asking for a password before showing <see cref="MainForm"/> 
    /// </summary>
    /// <inheritdoc />
    public partial class Authenticator : Form
    {
        /// <summary>
        /// The correct password to open the program
        /// </summary>
        private const string Password = "12345";
        
        /// <summary>
        /// Amount of tries given to guess the password
        /// </summary>
        private const int Tries = 3;
        
        /// <summary>
        /// The current password guess
        /// </summary>
        private string _guess = string.Empty;
        
        /// <summary>
        /// The number of remaining tries to guess the password
        /// </summary>
        private int _tries = Tries;
        
        public Authenticator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when a numeric button is pressed
        /// </summary>
        /// <param name="sender">One of the numeric buttons</param>
        /// <param name="e">The event args</param>
        private void OnNumpadClick(object sender, EventArgs e)
        {
            // Get the number the button is assign to
            var number = ((Control) sender).Text; // No need to cast to Button, Control (the base class) has Text property

            // If this is the first character of the password
            if (_guess.Length == 0)
                lblInfo.Text = string.Empty; // Reset the label
            
            // If we didn't reach the password length yet
            if (_guess.Length < Password.Length)
            {
                // Add the character to the current guess
                _guess += number;
                // Add a password character to the label to keep track of the length
                lblInfo.Text += '*';
                // Make the label black
                lblInfo.ForeColor = Color.Black;
            }

            // If guess reached the password length
            if (_guess.Length == Password.Length)
            {
                // We subtract from _tries even if the password is correct
                // as we won't use it anymore if that were the case
                _tries--;
                
                // Check for password equality
                if (string.Equals(_guess, Password, StringComparison.Ordinal))
                {
                    const string output = "Password corretta.";
                    lblInfo.Text = output;
                    lblInfo.ForeColor = Color.Green;
                    // This checkbox is only to pause the thread while listening for window's event
                    // so that the user can read the lblInfo text and know the outcome of the authentication
                    MessageBox.Show(output, "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnAuthenticated(true);
                }
                else if (_tries > 0)
                {
                    // If we have tries left don't do anything
                    lblInfo.Text = $"Password errata. {_tries} tentativi rimasti.";
                    lblInfo.ForeColor = Color.Red;
                }
                else
                {
                    // else just kill the application
                    lblInfo.Text = "Hai sbagliato troppe volte.";
                    lblInfo.ForeColor = Color.Red;
                    // This checkbox is only to pause the thread while listening for window's event
                    // so that the user can read the lblInfo text and know the outcome of the authentication
                    MessageBox.Show("Troppi tentativi sbagliati. L'applicazione sara' ora terminata.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OnAuthenticated(false);
                }
                
                // Reset the guess
                _guess = string.Empty;
            }
        }

        /// <summary>
        /// Fired when we either ran out of tries or we guess the password
        /// </summary>
        public event EventHandler<AuthEventArgs> Authenticated;
        
        /// <summary>
        /// <see cref="Authenticated"/> event invocator.
        /// </summary>
        /// <param name="successful">The authentication outcome</param>
        private void OnAuthenticated(bool successful)
        {
            Authenticated?.Invoke(this, new AuthEventArgs(successful));
        }
    }
}
