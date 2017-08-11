using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {

        bool[] check = { false, false, false, false };

        //bounds for the random char generator:
        //lowercase -> 97 to 122  (check[0])
        int lowercaseCharacterStart = 97;
        int lowercaseCharacterEnd = 122;
        //uppercase -> 65 to 90   (check[1])
        int uppercaseCharacterStart = 65;
        int uppercaseCharacterEnd = 90;
        //numbers ---> 48 to 57   (check[2])
        int numbersCharacterStart = 48;
        int numbersCharacterEnd = 57;
        //symbols ---> 33 to 47   (check[3])
        int symbolsCharacterStart = 33;
        int symbolsCharacterEnd = 47;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            StringBuilder password = new StringBuilder();
            int countChecked = 0, howManyEach = 0;


            //size
            int size = 0;
            if(textSize.Text != "")
            {
                int.TryParse(textSize.Text, out size);
            }

            if (size < 6)
            {
                MessageBox.Show("The minimum size is 6");
            }
            else
            {
                //check what is checked
                if (checkboxLowercase.Checked)
                {
                    check[0] = true;
                    countChecked++;
                }
                if (checkboxUppercase.Checked)
                {
                    check[1] = true;
                    countChecked++;
                } 
                if (checkboxNumbers.Checked)
                {
                    check[2] = true;
                    countChecked++;
                }
                if (checkboxSymbols.Checked)
                {
                    check[3] = true;
                    countChecked++;
                }

                //  size / countChecked
                howManyEach = size / countChecked;
                // then for (each one lacking)
                // if size = 23 and 4 options selected
                // 3 missing
                //generate lowecase until = size (23)

                for (int i = 0; i < size; i++)
                {
                    random.Next(0, 3);
                    password.Append((char)random.Next(lowercaseCharacterStart, lowercaseCharacterEnd));
                    password.Append((char)random.Next(uppercaseCharacterStart, uppercaseCharacterEnd));
                    password.Append((char)random.Next(numbersCharacterStart, numbersCharacterEnd));
                    password.Append((char)random.Next(symbolsCharacterStart, symbolsCharacterEnd));
                }
                textPassword.Text = howManyEach.ToString();
            }
        }

        private void checkboxLowercase_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
