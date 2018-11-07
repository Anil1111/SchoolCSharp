using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now; // Automatically makes the selected date the day the program was launched.
        }

        private void OnDateChange(object sender, EventArgs e)
        {
            const string elapsedDays = @"Sono passati {0} giorni dall'inizio dell'anno."; // Would have made it a field but we didn't do that yet
            const int fixedYear = 2018;
            
            switch (sender)
            {
                case DateTimePicker picker: // If the user changed the date through the date picker
                {
                    // Date cannot be wrong, no check needed
                    var time = picker.Value;

                    // Updates the fields value
                    fieldMonth.Value = time.Month;
                    fieldDay.Value = time.Day;

                    // Updates the max day of the month (so that the user won't select an improper date later)
                    fieldDay.Maximum = DateTime.DaysInMonth(fixedYear, time.Month);

                    // Obtains DayOfWeek with correct culture
                    var colture = CultureInfo.CurrentCulture;
                    var dayName = colture.DateTimeFormat.GetDayName(time.DayOfWeek);
                    dayName = colture.TextInfo.ToTitleCase(dayName); // Makes first letter uppercase

                    // Updates labels
                    lblElapsedDays.Text = string.Format(elapsedDays, time.DayOfYear);
                    lblWeekDay.Text = dayName;
                    break;
                }

                case NumericUpDown field:
                {
                    // Gets the month and makes the max day value the last day of that month
                    var month = (int) fieldMonth.Value;
                    if (field.Name == "fieldMonth")
                        fieldDay.Maximum = DateTime.DaysInMonth(fixedYear, month);

                    // Gets the day
                    var day = (int) fieldDay.Value;

                    // Creates an instance of DateTime
                    var time = new DateTime(fixedYear, month, day);

                    // Updates date picker value
                    datePicker.Value = time;

                    // Obtains DayOfWeek with correct culture
                    var colture = CultureInfo.CurrentCulture;
                    var dayName = colture.DateTimeFormat.GetDayName(time.DayOfWeek);
                    dayName = colture.TextInfo.ToTitleCase(dayName); // Makes first letter uppercase

                    // Updates labels
                    lblElapsedDays.Text = string.Format(elapsedDays, time.DayOfYear);
                    lblWeekDay.Text = dayName;
                    break;
                }
            }
        }
    }
}
