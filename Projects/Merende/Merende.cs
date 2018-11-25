using System;
using System.Windows.Forms;

namespace Merende
{
    public class Merende : ApplicationContext
    {
        /// <summary>
        /// Number of <see cref="Form"/>s visible
        /// </summary>
        private static int _formsCount;
        
        /// <summary>
        /// Called on program start
        /// </summary>
        /// <inheritdoc />
        public Merende()
        {
            // We are showing the Authenticator Form
            _formsCount++;
            
            // Create the Authenticator form
            var auth = new Authenticator();
            // Bind events
            auth.Authenticated += OnAuthenticated;
            auth.Closed += OnExit;
            // Show the form
            auth.Show();
        }

        /// <summary>
        /// Called when the user authenticated though the <see cref="Authenticator"/> form
        /// </summary>
        /// <param name="sender">The <see cref="Authenticator"/> form</param>
        /// <param name="e">The event args</param>
        private static void OnAuthenticated(object sender, AuthEventArgs e)
        {
            if (!e.Successful)
            {
                // If we failed the authentication
                // Close the application
                Application.Exit();
                // Application.Exit is not instant, the form would created and then disposed
                // We prevent that returning here
                return; 
            }

            // We are showing the MainForm form
            _formsCount++;
            
            // Close the authentication form
            ((Form) sender).Close();
            
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
            // Don't close the application if we have forms visible
            if (--_formsCount > 0)
                return;
            
            // Kills the current thread and closes the application
            Application.Exit();
        }
    }
}