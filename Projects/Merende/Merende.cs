using System;
using System.Windows.Forms;

namespace Merende
{
    public class Merende : ApplicationContext
    {
        private readonly Authenticator _auth;
        
        public Merende()
        {
            _auth = new Authenticator();
            _auth.Authenticated += OnAuthenticated;
            _auth.Closed += OnExit;
            _auth.Show();
        }

        private void OnAuthenticated(object sender, AuthEventArgs e)
        {
            if (!e.Successful)
                Environment.Exit(-1);

            _auth.Closed -= OnExit;
            _auth.Close();
            
            MainForm form = new MainForm();
            form.Closed += OnExit;
            form.Show();
        }

        private static void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}