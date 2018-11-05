using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Temperature
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OnCompute(object sender, EventArgs e)
        {
            lblMaxTemp.Visible = lblAverage.Visible = lblAboveAverage.Visible = true;

            var temps = new[] 
            {
                tempCityAField.Value,
                tempCityBField.Value,
                tempCityCField.Value
            }; 

            var max = Max(temps);
            var avg = Average(temps);
            var aboveAvg = AboveNumber(temps, avg);

            lblMaxTemp.Text = $"Temperatura massima: {max:F2}";
            lblAverage.Text = $"Temperatura media: {avg:F2}";

            StringBuilder builder = null;
            if (aboveAvg.Length > 0)
            {
                builder = new StringBuilder();
                builder.Append(aboveAvg.Length > 1 ? "Temperature" : "Temperatura");
                builder.Append(" sopra la media: ");
                foreach (var temp in aboveAvg)
                    builder.AppendFormat("{0:F2}, ", temp);
                builder.Remove(builder.Length - 2, 2);
            }

            lblAboveAverage.Text = builder?.ToString() ?? "Non ci sono temperature sopra la media.";
        }

        private static decimal Max(decimal[] floats)
        {
            if (floats.Length <= 0)
                throw new ArgumentException($"{nameof(floats)} non puo' essere una collezione vuota.");

            var max = floats[0];
            for (int i = 1; i < floats.Length; i++)
                max = Math.Max(max, floats[i]);
            return max;
        }

        private static decimal Average(decimal[] floats)
        {
            if (floats.Length <= 0)
                throw new ArgumentException($"{nameof(floats)} non puo' essere una collezione vuota.");

            var sum = 0m;
            for (int i = 0; i < floats.Length; i++)
                sum += floats[i];
            return sum / floats.Length;
        }

        private static decimal[] AboveNumber(decimal[] floats, decimal number)
        {
            return floats.Where(x => x > number).ToArray();
        }
    }
}
