using System;
using System.Windows.Forms;

namespace Merende
{
    public class Merende : ApplicationContext
    {
        /// <summary>
        /// The <see cref="Authenticator"/> instance
        /// </summary>
        private readonly Authenticator _auth;
        
        /// <summary>
        /// Called on program start
        /// </summary>
        /// <inheritdoc />
        public Merende()
        {
            // Create the Authenticator form
            _auth = new Authenticator();
            // Bind events
            _auth.Authenticated += OnAuthenticated;
            _auth.Closed += OnExit;
            // Show the form
            _auth.Show();
        }

        /// <summary>
        /// Called when the user authenticated though the <see cref="Authenticator"/> form
        /// </summary>
        /// <param name="sender">The <see cref="Authenticator"/> form</param>
        /// <param name="e">The event args</param>
        private void OnAuthenticated(object sender, AuthEventArgs e)
        {
            // If we failed authentication just kill the application
            if (!e.Successful)
                Environment.Exit(-1);

            // Unbind the closed event and close the authentication form
            _auth.Closed -= OnExit;
            _auth.Close();
            
            // Create the main form and show it
            MainForm form = new MainForm();
            form.Closed += OnExit;
            form.Show();
        }

        /// <summary>
        /// Called when a form is closed
        /// </summary>
        /// <param name="sender">One of the <see cref="Form"/>s</param>
        /// <param name="e">The event args</param>
        private static void OnExit(object sender, EventArgs e)
        {
            // Kills the current thread and closes the application
            Application.Exit();
        }
    }
}