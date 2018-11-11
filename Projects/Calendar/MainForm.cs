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
        
        // This is the algorithm I would have used if I were to use switch and couldn't use DateTime

        #region Algorithm
        
        /// <summary>
        /// Algorithm to get the day since start of year 2018
        /// </summary>
        /// <param name="day">The current day</param>
        /// <param name="month">The current month</param>
        /// <returns>Number of days between 01/01/2018 and <i><see cref="day"/></i>/<i><see cref="month"/></i>/2018</returns>
        // ReSharper disable once UnusedMember.Local
        private static int DayOfYear(int day, Month month)
        {
            while (month > Month.January) // While the month is higher than January
            {
                // This makes so that the current month is not added to the days count but instead the day parameter is used
                month--; // Substract 1 to month 
                switch (month)
                {
                    // 31 days months
                    case Month.January: 
                    case Month.March:
                    case Month.May:
                    case Month.July:
                    case Month.August:
                    case Month.October:
                    case Month.December:
                        day += 31;
                        break;
                    
                    // 30 days months 
                    case Month.April:
                    case Month.June:
                    case Month.September:
                    case Month.November:
                        day += 30;
                        break;
                    
                    // 28/9 days month
                    case Month.February:
                        // Year is fixed hence there's no need to check for leap year
                        day += 28;
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException(nameof(month), month, null);
                }
            }
            return day;
        }

        /// <summary>
        /// Gets the day of the week
        /// </summary>
        /// <param name="dayOfYear">Day since year start</param>
        /// <returns>Day of the weak</returns>
        private static string DayOfWeek(int dayOfYear)
        {
            const int firstDayOfYear = 0; // First day of year is monday
            
            switch (dayOfYear % 7 + firstDayOfYear)
            {
                default:
                    return "Domenica";
                case 1:
                    return "Lunedi";
                case 2:
                    return "Martedi";
                case 3:
                    return "Mercoledi";
                case 4:
                    return "Giovedi";
                case 5:
                    return "Venerdi";
                case 6:
                    return "Sabato";
            }
        }

        /// <summary>
        /// Represent a month, from 1 to 12
        /// </summary>
        /// <remarks>Used only for read-ability, same as using integers</remarks>
        private enum Month 
        {
            // Ensures it's one based
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        
        #endregion
    }
}
