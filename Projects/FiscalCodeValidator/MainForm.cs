using System;
using System.Text;
using System.Windows.Forms;

namespace FiscalCodeValidator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the compute button is pressed
        /// </summary>
        /// <param name="sender">The <see cref="btnCompute"/> button</param>
        /// <param name="e">Event args</param>
        private void OnCompute(object sender, EventArgs e)
        {
            // Gets the fiscal code from the TextBox
            var code = txtFiscalCode.Text;
            
            // Tries to parse it
            if (!FiscalCode.TryParse(code, out FiscalCode fiscalCode))
            {
                MessageBox.Show("Could not parse the fiscal code.", "Invalid Fiscal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // If it succeeds output the requested informations.
            Height = 130;
            lblDateOfBirth.Text = $"Data di nascita: {fiscalCode.DateOfBirth:dd/MM/yyyy}";
            lblPlaceOfBirth.Text = $"Codice catastale: {fiscalCode.PlaceOfBirth}";
            lblSex.Text = $"Sesso: {fiscalCode.Sex}";
        }
    }

    public struct FiscalCode
    {
        /// <summary>
        /// The length of a normal fiscal code
        /// </summary>
        private const int FISCAL_CODE_LENGTH = 16;
        
        /// <summary>
        /// The fiscal code
        /// </summary>
        private readonly string _code;
        
        /// <summary>
        /// The letters 4-6 of the fiscal code 
        /// </summary>
        private readonly string _name;
        
        /// <summary>
        /// The letters 1-3 of the fiscal code
        /// </summary>
        private readonly string _surname;
        
        /// <summary>
        /// The date of birth of the subject
        /// </summary>
        private readonly DateTime _dateOfBirth;
        
        /// <summary>
        /// The sex of the subject
        /// </summary>
        private readonly Sex _sex;
        
        /// <summary>
        /// The place of birth of the subject, represented as 1 letter and 3 numbers
        /// </summary>
        private readonly string _placeOfBirth;
        
        /// <summary>
        /// The sum of all the characters of the code
        /// </summary>
        private readonly int _crc;

        private FiscalCode(string code, string name, string surname, DateTime dateOfBirth, Sex sex, string placeOfBirth, int crc)
        {
            _code = code;
            _name = name;
            _surname = surname;
            _dateOfBirth = dateOfBirth;
            _sex = sex;
            _placeOfBirth = placeOfBirth;
            _crc = crc;
        }
        
        /// <summary>
        /// Tries to parse <paramref name="code"/> to the <see cref="FiscalCode"/> instance <paramref name="fiscalCode"/>
        /// </summary>
        /// <param name="code">The code to parse</param>
        /// <param name="fiscalCode">The parsed fiscal code</param>
        /// <returns>True if parsing succeeds</returns>
        public static bool TryParse(string code, out FiscalCode fiscalCode)
        {
            // Initialize fiscalCode to the default value (to allow return false)
            fiscalCode = default(FiscalCode); 
            
            // Checks for the right code length
            if (code.Length != FISCAL_CODE_LENGTH)
                return false;
            
            // Creates a StringBuilder containing the fiscal code
            StringBuilder str = new StringBuilder(code);
            
            // Iterates through the string and validates the content
            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                if (i < 6) // First 4 characters are surname and name; they cannot contain numbers
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                else if (i < 8)
                {
                    if (c >= 'L' && c <= 'N')
                        c = (char) ('0' + c - 'L');
                    else if (c >= 'P' && c <= 'V')
                        c = (char) ('0' + c - 'P');
                    else if (!char.IsDigit(c))
                        return false;
                    
                    str[i] = c;
                }
                else if (i < 9)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                else if (i < 11)
                {
                    if (c >= 'L' && c <= 'N')
                        c = (char) ('0' + c - 'L');
                    else if (c >= 'P' && c <= 'V')
                        c = (char) ('0' + c - 'P');
                    else if (!char.IsDigit(c))
                        return false;
                    
                    str[i] = c;
                }
                else if (i < 12)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                else if (i < 15)
                {
                    if (c >= 'L' && c <= 'N')
                        c = (char) ('0' + c - 'L');
                    else if (c >= 'P' && c <= 'V')
                        c = (char) ('0' + c - 'P');
                    else if (!char.IsDigit(c))
                        return false;
                    
                    str[i] = c;
                }
                else if (i < 16)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
            }

            // Parses the year
            // * int.TryParse isn't needed as we verify that the string contains a number above
            var year = int.Parse(str.ToString(6, 2));
            if (year > DateTime.Now.Year - 2000) // If (year + 2000) is in the future
                year += 1000; // use (year + 1000)
            else 
                year += 2000; // otherwise use it
            
            // Parses the month
            var month = MonthToNumber(str[8]);
            
            // Parses the day and the sex of the subject
            var day = int.Parse(str.ToString(9, 2));
            var sex = Sex.Male;
            if (day >= 40)
            {
                day -= 40;
                sex = Sex.Female;
            }

            // Validates the date
            var daysInMonth = DateTime.DaysInMonth(year, month);
            if (day > daysInMonth)
                return false;
            
            // Creates a DateTime instance containing the date of birth of the subject
            DateTime dateOfBirth = new DateTime(year, month, day);

            // Creates the fiscal code instance and returns true
            fiscalCode = new FiscalCode(
                code,
                str.ToString(3, 3),
                str.ToString(0, 3),
                dateOfBirth, 
                sex,
                str.ToString(11, 4),
                str[15] - 'A');
            return true;
        }

        /// <summary>
        /// Parses the fiscal code character into a number representing the month
        /// </summary>
        /// <param name="month">A character representing a month</param>
        /// <returns>The month [1-12]</returns>
        /// <exception cref="ArgumentOutOfRangeException">The character <paramref name="month"/> specified does not represent a month</exception>
        private static int MonthToNumber(char month)
        {
            switch (month)
            {
                case 'A': return 1;
                case 'B': return 2;
                case 'C': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'H': return 6;
                case 'L': return 7;
                case 'M': return 8;
                case 'P': return 9;
                case 'R': return 10;
                case 'S': return 11;
                case 'T': return 12;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(month), $"Invalid fiscal code: {month} is not a valid month.");
            }
        }
        
        // Getters
        
        public string Code => _code;
        
        public string Name => _name;
        public string Surname => _surname;
        public DateTime DateOfBirth => _dateOfBirth;
        public Sex Sex => _sex;
        public string PlaceOfBirth => _placeOfBirth;
        public int CRC => _crc;
    }

    public enum Sex
    {
        Unknown,
        Male,
        Female
    }
}
