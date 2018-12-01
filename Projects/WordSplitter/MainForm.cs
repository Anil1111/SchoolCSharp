using System;
using System.Globalization;
using System.Windows.Forms;

namespace WordSplitter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fetches all the words on the input text and adds to them to a list
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">The event arguments</param>
        private void OnCompute(object sender, EventArgs e)
        {
            // Clears the elements already present in the list
            lsbWords.Items.Clear();
            
            // Gets the input text
            var text = txtInputText.Text;
            
            // Creates a variable that will hold the current word we are currently in
            string word = string.Empty; // Would have used StringBuilder
            // Counts the number of words in the list
            int counter = 0; 
            // Cycles though every character in the text
            for (int i = 0; i < text.Length; i++)
            {
                // Gets the lowercase variant of the current character 
                var c = char.ToLower(text[i], CultureInfo.CurrentCulture); // We use current culture because we want to keep every language-specific data

                // If it's a letter and it's last, add the letter to word and print word
                if (i + 1 == text.Length && char.IsLetter(c))
                {
                    // Adds the letter to the current word
                    word += c;
                    
                    // We add the word to the list
                    lsbWords.Items.Add($"{++counter}) {word}");
                }
                // If it's just a letter add the letter to word
                else if (char.IsLetter(c))
                {
                    // Adds the letter to the current word
                    word += c;
                }
                // If it not a letter print the current word
                else if (word.Length > 0)
                {
                    // We add the word to the list
                    lsbWords.Items.Add($"{++counter}) {word}");
                    // We setup the variable for the next word
                    word = string.Empty;
                }
            }
        }
    }
}
