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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //lowercase -> 97 to 122
            //uppercase -> 65 to 90
            //numbers ---> 48 to 57
            //symbols ---> 33 to 47

            //generate 4 different strings (if all options are selected) then shuffle them
            //how to manage size? . . .


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
                textPassword.Text = size.ToString();
            }
        }
    }
}
