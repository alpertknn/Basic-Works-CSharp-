using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            int count;
            str = comboBox1.SelectedItem.ToString();
            count = int.Parse(textBox1.Text);
            switch (str)
            {
                case "Small":
                    if (MessageBox.Show(5 * count + " TL", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show("Small Afiyet");
                    }
                    break;
                case "Medium":
                    if (MessageBox.Show(10 * count + " TL", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show("Medium Afiyet");
                    }
                    break;
                case "Large":
                    if (MessageBox.Show(15 * count + " TL", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show("Large Afiyet");
                    }
                    break;
                case "Free":
                    if (MessageBox.Show("Free", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show("Free");
                        comboBox1.Items.Remove("Free");
                    }
                    textBox1.Text = "";
                    break;
                default:
                    break;


            }
            


        }

        int counter = 0;
        private void label4_Click(object sender, EventArgs e)
        {
           
            
            if (counter == 5)
            {
                comboBox1.Items.Add("Free");
                MessageBox.Show("You Won Free Drink");
                counter = 0;

            }
            counter++;
        }
    }
}

