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

        /// <summary>
        /// Called when the date gets changed by either the <see cref="DateTimePicker"/> or the <see cref="NumericUpDown"/>s
        /// </summary>
        /// <param name="sender">The object which changed the date</param>
        /// <param name="e">Event parameters</param>
        private void OnDateChange(object sender, EventArgs e)
        {
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
                    lblElapsedDays.Text = $"Sono passati {time.DayOfYear} giorni dall'inizio dell'anno.";
                    lblWeekDay.Text = dayName;
                    break;
                }

                case NumericUpDown field: // If the user changed the date through the fields
                {
                    // Gets the month and makes ensure that the day cannot exceed the month last day
                    var month = (int) fieldMonth.Value;
                    if (field == fieldMonth)
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
                    lblElapsedDays.Text = $"Sono passati {time.DayOfYear} giorni dall'inizio dell'anno.";
                    lblWeekDay.Text = dayName;
                    break;
                }
            }
        }
    }
}
