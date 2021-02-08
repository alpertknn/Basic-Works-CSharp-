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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] str = new string[4];
            string[] namearr = new string[4];
            string[] surnamearr = new string[4];
            string name;
            string surname;



            for (i = 0; i < 4; i++)
            {
                namearr[i] = listBox1.Items[i].ToString().Split(' ')[0].ToLower();
                surnamearr[i] = listBox1.Items[i].ToString().Split(' ')[1].ToLower();
                surname = surnamearr[i].Substring(0, 1).ToUpper() + surnamearr[i].Substring(1,surnamearr[i].Length-1);
                surnamearr[i] = surname;
                namearr[i] = namearr[i].Substring(0, 1).ToUpper() + ".";
                listBox2.Items.Add(surnamearr[i] + " " + namearr[i]);
                
            }
           
            


        }
    }
}
