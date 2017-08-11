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

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //lowercase -> 97 to 122  (check[0])
            //uppercase -> 65 to 90   (check[1])
            //numbers ---> 48 to 57   (check[2])
            //symbols ---> 33 to 47   (check[3])

            //generate 4 different strings (if all options are selected) then shuffle them
            //how to manage size? . . .

            //bounds for the random char generator:
            //lowercase
            int lowercaseCharacterStart = 97;
            int lowercaseCharacterEnd = 122;
            //uppercase
            int uppercaseCharacterStart = 97;
            int uppercaseCharacterEnd = 122;
            //numbers
            int numbersCharacterStart = 97;
            int numbersCharacterEnd = 122;
            //symbols
            int symbolsCharacterStart = 97;
            int symbolsCharacterEnd = 122;

            Random random = new Random(DateTime.Now.Millisecond);
            char randomChar;


            //size
            int size = 0;
            if(textSize.Text != "")
            {
                int.TryParse(textSize.Text, out size);
            }

            if(size < 6)
            {
                MessageBox.Show("The minimum size is 6");
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    randomChar = random.Next()
                }





                textPassword.Text = "password";
            }
        }

        private void checkboxLowercase_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
