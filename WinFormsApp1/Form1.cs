using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class nomatter : Form
    {
        public nomatter()
        {
            InitializeComponent();
        }


        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBoxWord.Text; // input TextBox
                if (string.IsNullOrWhiteSpace(input) || input.Any(char.IsDigit))
                {
                    MessageBox.Show("Invalid input! No digits or empty input allowed.");
                    return;
                }

                string slideText = textBoxSlide.Text; // slide TextBox
                if (!int.TryParse(slideText, out int slide))
                {
                    MessageBox.Show("The input should be a number!");
                    return;
                }

                string result = Caesar(input, slide);
                labelResult.Text = result; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private string Caesar(string text, int slide)
        {
            string result = "";
            foreach (char ch in text)
            {
                int value = (int)ch;

                if (char.IsUpper(ch))
                {
                    value += slide;
                    if (value > 'Z') value -= 26;
                    result += (char)value;
                }
                else if (char.IsLower(ch))
                {
                    value += slide;
                    if (value > 'z') value -= 26;
                    result += (char)value;
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }

       
        private void ShowMenu()
        {
            MessageBox.Show("Hello, you are welcome to Caesar encryption!\nPlease enter the words:");
        }

        
    }
}
