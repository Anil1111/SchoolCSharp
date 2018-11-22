using System;

namespace Merende
{
    public class AuthEventArgs : EventArgs
    {
        public bool Successful { get; }

        public AuthEventArgs(bool successful)
        {
            Successful = successful;
        }
    }
}