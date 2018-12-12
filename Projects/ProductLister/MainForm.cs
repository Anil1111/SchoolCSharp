using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductLister
{
    public partial class MainForm : Form
    {
        private readonly List<Product> _products = new List<Product>();

        private Type _filterType = Type.All;
        private int _filterMachine;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            var text = txtProductCode.Text;
            if (text.Length < 2)
                return;

            if (Product.TryParse(text, out Product product))
                _products.Add(product);
            
            UpdateListview();
        }
        
        private void OnEmpty(object sender, EventArgs e)
        {
            _products.Clear();
            lstProducts.Items.Clear();
        }

        private void OnMachineFilterChanged(object sender, EventArgs e)
        {
            _filterMachine = (int) filterMachineNum.Value;
            UpdateListview();
        }

        private void OnTypeFilterChanged(object sender, EventArgs e)
        {
            if (filterTypeC.Checked)
                _filterType = Type.Compliant;
            else if (filterTypeR.Checked)
                _filterType = Type.Revision;
            else if (filterTypeS.Checked)
                _filterType = Type.Waste;
            else
                _filterType = Type.All;
            UpdateListview();
        }

        private void UpdateListview()
        {
            lstProducts.Items.Clear();
            
            lstProducts.Items.AddRange(_products
                .Where(x => 
                    (x.Machine == _filterMachine || _filterMachine == 0) &&
                    (x.Type & _filterType) != 0)
                .Cast<object>()
                .ToArray()
            );

            txtTotal.Text = lstProducts.Items.Count.ToString(CultureInfo.InvariantCulture);
        }
    }

    public struct Product
    {
        public Type Type { get; }
        public int Machine { get; }

        private Product(Type type, int machine)
        {
            Type = type;
            Machine = machine;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(2);
            switch (Type)
            {
                case Type.Compliant:
                    str.Append('C');
                    break;
                case Type.Waste:
                    str.Append('S');
                    break;
                case Type.Revision:
                    str.Append('R');
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Type), "Il tipo del prodotto e' inesistente");
            }
            str.Append(Machine.ToString(CultureInfo.InvariantCulture));
            return str.ToString();
        }

        public static bool TryParse(string str, out Product product)
        {
            product = default(Product);
            
            if (str.Length < 2)
                return false;

            Type type;
            switch (char.ToUpperInvariant(str[0]))
            {
                case 'R':
                    type = Type.Revision;
                    break;
                
                case 'C':
                    type = Type.Compliant;
                    break;
                
                case 'S':
                    type = Type.Waste;
                    break;
                
                default:
                    return false;
            }

            int machineNumber = str[1] - '0';
            if (machineNumber < 1 || machineNumber > 9)
                return false;
            
            product = new Product(type, machineNumber);
            return true;
        }
    }

    [Flags]
    public enum Type
    {
        All = 7,
        Compliant = 1,
        Waste = 2,
        Revision = 4,
    }
}
