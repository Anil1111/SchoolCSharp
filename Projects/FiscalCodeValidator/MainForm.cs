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

        private void OnCompute(object sender, EventArgs e)
        {
            var code = txtFiscalCode.Text;
            if (!FiscalCode.TryParse(code, out FiscalCode fiscalCode))
            {
                MessageBox.Show("Could not parse the fiscal code.", "Invalid Fiscal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Height = 130;
            lblDateOfBirth.Text = $"Data di nascita: {fiscalCode.DateOfBirth:dd/MM/yyyy}";
            lblPlaceOfBirth.Text = $"Codice catastale: {fiscalCode.PlaceOfBirth}";
            lblSex.Text = $"Sesso: {fiscalCode.Sex}";
        }
    }

    public struct FiscalCode
    {
        private const int FISCAL_CODE_LENGTH = 16;
        
        private readonly string _code;
        
        private readonly string _name;
        private readonly string _surname;
        private readonly DateTime _dateOfBirth;
        private readonly Sex _sex;
        private readonly string _placeOfBirth;
        private readonly int _crc;

        public FiscalCode(string code, string name, string surname, DateTime dateOfBirth, Sex sex, string placeOfBirth, int crc)
        {
            _code = code;
            _name = name;
            _surname = surname;
            _dateOfBirth = dateOfBirth;
            _sex = sex;
            _placeOfBirth = placeOfBirth;
            _crc = crc;
        }
        
        public static bool TryParse(string code, out FiscalCode fiscalCode)
        {
            fiscalCode = default(FiscalCode); 
            
            if (code.Length != FISCAL_CODE_LENGTH)
                return false;
            
            StringBuilder str = new StringBuilder(code.ToUpperInvariant());
            
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


            var year = int.Parse(str.ToString(6, 2)) + 2000;
            var month = FiscalCode.MonthToNumber(str[8]);
            var day = int.Parse(str.ToString(9, 2));
            var sex = Sex.Male;
            if (day >= 40)
            {
                day -= 40;
                sex = Sex.Female;
            }

            var daysInMonth = DateTime.DaysInMonth(year, month);
            if (day > daysInMonth)
                return false;
            
            DateTime dateOfBirth = new DateTime(year, month, day);

            fiscalCode = new FiscalCode(
                code,
                str.ToString(0, 3),
                str.ToString(3, 3),
                dateOfBirth, 
                sex,
                str.ToString(11, 4),
                str[15] - 'A');
            return true;
        }

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
