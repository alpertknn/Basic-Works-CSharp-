using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i ;
            string nstr = "";
            string str = "There is a cat";
            string[] strr = str.Split(' ');
            for (i = 0; i < strr.Length; i++)
            {
                nstr += strr[i] + "\n";
            }
            MessageBox.Show(nstr);
         
        }
    }
}
