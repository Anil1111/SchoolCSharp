using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ProductLister
{
    public partial class MainForm : Form
    {
        private Product[] _products = new Product[0];

        private int _filterCount;
        private Type _filterType;
        private int _filterMachine;
        
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called everytime the content of <see cref="txtProductCode"/> gets changed
        /// </summary>
        /// <param name="sender">The <see cref="txtProductCode"/> instance</param>
        /// <param name="e">The event args</param>
        private void OnValidate(object sender, EventArgs e)
        {
            btnAdd.Enabled = txtProductCode.TextLength == 2;
        }

        /// <summary>
        /// Adds a product to the <see cref="_products"/> array
        /// </summary>
        /// <param name="sender">The <see cref="btnAdd"/> instance</param>
        /// <param name="e">The event args</param>
        private void OnAdd(object sender, EventArgs e)
        {
            // Gets the text from the TextBox
            var text = txtProductCode.Text;

            if (!Product.TryParse(text, out Product product))
            {
                MessageBox.Show("Impossibile convertire il codice in un Prodotto!", "Input Error");
                return;
            }
            
            // Add 1 to the array size and shift right all values index by 1
            var array = _products; // Keeps a reference to the current array
            _products = new Product[array.Length + 1]; // Makes the _product variable point to a new array of increased length
            Array.Copy(array, 0, _products, 1, array.Length); // Copies the former array content to the new one

            // Add (Insert) the product in the array
            _products[0] = product;

            // We add the entry to the current selection without re-computing UpdateSelectionView
            if (product.IsMatch(_filterType, _filterMachine))
            {
                lstProducts.Items.Add($"{++_filterCount}) {product}");
                txtTotal.Text = _filterCount.ToString(CultureInfo.InvariantCulture);
            }
        }
        
        /// <summary>
        /// Empties the array <see cref="_products"/> and the ListBox <see cref="lstProducts"/>
        /// </summary>
        /// <param name="sender">The <see cref="btnEmpty"/> instance</param>
        /// <param name="e">The event args</param>
        private void OnEmpty(object sender, EventArgs e)
        {
            // Empty all variables
            _products = new Product[0];
            _filterCount = 0;
            txtTotal.Text = "0";
            
            // Empty the ListBox
            lstProducts.Items.Clear();
        }

        /// <summary>
        /// Called when a filter is changed
        /// </summary>
        /// <param name="sender">The <see cref="Control"/> whose state was changed</param>
        /// <param name="e">The event args</param>
        private void OnFilterChanged(object sender, EventArgs e)
        {
            // Gets the machine number filter
            _filterMachine = (int) filterMachineNum.Value;
            
            // Gets the product type filter
            _filterType = Type.None;
            if (filterTypeC.Checked)
                _filterType = Type.Compliant;
            else if (filterTypeR.Checked)
                _filterType = Type.Revision;
            else if (filterTypeS.Checked)
                _filterType = Type.Waste;
            
            // Updates the view
            UpdateSelectionView();
        }

        /// <summary>
        /// Updates the ListBox with only the Products that matches the filter
        /// </summary>
        /// <remarks>O(N) algorithm, where N is the length of the array <see cref="_products"/></remarks>
        private void UpdateSelectionView()
        {
            // Clears the list
            lstProducts.Items.Clear();
            
            // Fills the list
            _filterCount = 0;
            foreach (var product in _products)
                if (product.IsMatch(_filterType, _filterMachine))
                    lstProducts.Items.Add($"{++_filterCount}) {product}");

            // Updates the total label
            txtTotal.Text = _filterCount.ToString(CultureInfo.InvariantCulture);
        }
    }

    public struct Product
    {
        public Type Type { get; }
        public int Machine { get; }

        public Product(Type type, int machine)
        {
            Type = type;
            Machine = machine;
        }

        /// <summary>
        /// Verifies whether the product properties matches <paramref name="type"/> and <paramref name="machine"/>
        /// </summary>
        /// <param name="type">The product type to compare to or 0 for no-check</param>
        /// <param name="machine">The machine id to compare to or 0 for no-check</param>
        /// <returns>True, when the product matches the requisites, False otherwise</returns>
        public bool IsMatch(Type type, int machine)
        {
            return (type == Type.None || Type == type) && 
                   (machine == 0 || Machine == machine);
        }

        /// <summary>
        /// Converts the instance to the string representation
        /// </summary>
        /// <returns>The string representation of this Product</returns>
        /// <exception cref="ArgumentOutOfRangeException">The product has an invalid product type</exception>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder(2);
            // Convert the product type to string
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
                    throw new ArgumentOutOfRangeException(nameof(Type), $"Il tipo di prodotto {Type} non e' previsto.");
            }
            // As we know Machine is [1-9] we can convert the integer to char manually to reduce the performance hit
            str.Append((char) ('0' + Machine));
            return str.ToString(); // Return the string content of the StringBuilder
        }

        /// <summary>
        /// Tries to parse the input string to a <see cref="Product"/> instance
        /// </summary>
        /// <param name="str">The string to parse</param>
        /// <param name="product">The output product</param>
        /// <returns>True if the method succeeded, False otherwise</returns>
        public static bool TryParse(string str, out Product product)
        {
            // Make product the default of Product, this allows us to return false
            product = default(Product);
            
            // Check for correct string length
            if (str.Length < 2)
                return false;

            // Tries to parse the product type from the string
            Type type;
            switch (char.ToUpperInvariant(str[0])) // We use ToUpper instead of ToLower because of Microsoft conventions
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
                
                // If we cannot parse the type, exit the method
                default:
                    return false;
            }

            // Parse the machine number
            int machineNumber = str[1] - '0';
            if (machineNumber < 1 || machineNumber > 9) // If the number is not in range, exit the method
                return false;
            
            // Create the Product instance and return true
            product = new Product(type, machineNumber);
            return true;
        }
    }

    /// <summary>
    /// The <see cref="Product"/> type
    /// </summary>
    public enum Type
    {
        None,
        Compliant,
        Waste,
        Revision,
    }
}
