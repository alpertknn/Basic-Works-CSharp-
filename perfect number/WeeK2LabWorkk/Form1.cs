using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeK2LabWorkk
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
            int num1,i;
            int sum = 0;
            num1 = Convert.ToInt32(textBox1.Text);
            for (i = 1; i < num1; i++)
            {
                if (num1%i==0) {
                    sum += i;

                    
                }
            }
            if (sum == num1)
            {
                MessageBox.Show("Entered number is a perfect number","Info",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Entered number is not a perfect number", "Info", MessageBoxButtons.OK);
            }
        }
    }
}
