using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


#region TO DO
// shuffle the final string
#endregion

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random random = new Random(DateTime.Now.Millisecond);
        bool[] check = { false, false, false, false };

        #region bounds for the random char generator:
        //lowercase -> 97 to 122
        int lowercaseCharacterStart = 97;
        int lowercaseCharacterEnd = 122;
        //uppercase -> 65 to 90
        int uppercaseCharacterStart = 65;
        int uppercaseCharacterEnd = 90;
        //numbers ---> 48 to 57
        int numbersCharacterStart = 48;
        int numbersCharacterEnd = 57;
        //symbols ---> 33 to 47
        int symbolsCharacterStart = 33;
        int symbolsCharacterEnd = 47;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            StringBuilder password = new StringBuilder();
            string finalString;
            int size = 0;

            if(textSize.Text != "")
                int.TryParse(textSize.Text, out size);
            else
                MessageBox.Show("Size is mandatory!");

            if (size < 6)
                MessageBox.Show("The minimum size is 6");
            else if(!checkboxLowercase.Checked && !checkboxUppercase.Checked && !checkboxNumbers.Checked && !checkboxSymbols.Checked)
                MessageBox.Show("Pick at least an option!");
            else
            {
                //generate the string (can become 4 times the right size (should be changed))
                for (int i = 0; i < size; i++)
                {
                    if (checkboxLowercase.Checked)
                        password.Append((char)random.Next(lowercaseCharacterStart, lowercaseCharacterEnd));

                    if (checkboxUppercase.Checked)
                        password.Append((char)random.Next(uppercaseCharacterStart, uppercaseCharacterEnd));

                    if (checkboxNumbers.Checked)
                        password.Append((char)random.Next(numbersCharacterStart, numbersCharacterEnd));

                    if (checkboxSymbols.Checked)
                        password.Append((char)random.Next(symbolsCharacterStart, symbolsCharacterEnd));
                }

                //cut the string so it's actually the right size
                finalString = password.ToString().Substring(password.ToString().Length - size);

                //shuffle the string
                finalString = shuffle(finalString);

                //show the string
                textPassword.Text = finalString;
            }
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textPassword.Text);
            //MessageBox.Show("Password Copied to Clipboard!");
        }

        public string shuffle(string str)
        {
            int size = str.Length;
            char[] shuffled = str.ToCharArray();
            int pos;

            for (int i = 0; i < size; i++)
            {
                pos = random.Next(0, size);

            }


            return shuffled.ToString();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            textPassword.Text = shuffle(textPassword.Text);
        }
    }
}
