using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            int i = 2;
            string output = "";
            num = int.Parse(textBox1.Text);
            for (i = 2; i <= num / 2; i++)

            {
                if (num % i == 0)
                {
                    output = num + " is not prime number\n";
                }
                else

                    output = num + " is a prime number";

            }
            MessageBox.Show(output);

        }
    }
}


