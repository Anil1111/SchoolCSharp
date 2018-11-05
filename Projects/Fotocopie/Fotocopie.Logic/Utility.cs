using System;
using System.Text;

namespace Fotocopie.Logic
{
    public static class Utility
    {
        public static string EuroCentToEuro(int cent) => (cent / 100f).ToString("C");
    }
}