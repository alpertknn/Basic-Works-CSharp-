using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(first.Text) + int.Parse(second.Text)).ToString();

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(first.Text) * int.Parse(second.Text)).ToString();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(first.Text) - int.Parse(second.Text)).ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(first.Text) / int.Parse(second.Text)).ToString();
        }
    }
}
