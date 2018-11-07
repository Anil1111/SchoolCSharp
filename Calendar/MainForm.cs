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
            
            DateTime time;
            switch (sender)
            {
                case DateTimePicker picker: // If the user changed the date through the date picker
                    // Date cannot be wrong, no check needed
                    time = picker.Value; 
                    
                    // Updates the fields value
                    fieldMonth.Value = time.Month; 
                    fieldDay.Value = time.Day;
                    
                    // Updates the max day of the month (so that the user won't select an improper date later)
                    fieldDay.Maximum = DateTime.DaysInMonth(fixedYear, time.Month);
                    
                    // Updates labels
                    lblElapsedDays.Text = string.Format(elapsedDays, time.DayOfYear);
                    lblWeekDay.Text = GetWeekDay(time.DayOfWeek);
                    break;
                case NumericUpDown field:
                    // Gets the month and makes the max day value the last day of that month
                    var month = (int) fieldMonth.Value;
                    if (field.Name == "fieldMonth")
                        fieldDay.Maximum = DateTime.DaysInMonth(fixedYear, month);
                    
                    // Gets the day
                    var day = (int) fieldDay.Value;
                    
                    // Creates an instance of DateTime
                    time = new DateTime(fixedYear, month, day);
                    
                    // Updates date picker value
                    datePicker.Value = time;
                    
                    // Updates labels
                    lblElapsedDays.Text = string.Format(elapsedDays, time.DayOfYear);
                    lblWeekDay.Text = GetWeekDay(time.DayOfWeek);
                    break;
            }
        }

        /// <summary>
        /// Translates the <see cref="DayOfWeek"/> enum to an italian string representation.
        /// </summary>
        /// <param name="weekDay">Day of the week</param>
        /// <returns><see cref="String"/> representing the week day</returns>
        /// <exception cref="ArgumentOutOfRangeException">Invalid <see cref="weekDay"/> parameter. [</exception>
        private string GetWeekDay(DayOfWeek weekDay)
        {
            switch (weekDay)
            {
                case DayOfWeek.Sunday:
                    return "Domenica";
                case DayOfWeek.Monday:
                    return "Lunedì";
                case DayOfWeek.Tuesday:
                    return "Martedì";
                case DayOfWeek.Wednesday:
                    return "Mercoledì";
                case DayOfWeek.Thursday:
                    return "Giovedì";
                case DayOfWeek.Friday:
                    return "Venerdì";
                case DayOfWeek.Saturday:
                    return "Sabato";
                default:
                    throw new ArgumentOutOfRangeException(nameof(weekDay), weekDay, null);
            }
        }
    }
}
