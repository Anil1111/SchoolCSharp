﻿using System;
using System.Windows.Forms;

namespace Merende
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Merende());
        }
    }
}
