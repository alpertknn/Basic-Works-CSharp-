using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TimeSpan date2;
            //DateTime date;
            //DateTime date1 = new DateTime(1999,01,29);
            //date = DateTime.Now;
            //date2 = (date - date1);
            //MessageBox.Show(date2.TotalDays.ToString());


            DateTime date = new DateTime(1999, 01, 29);
            double datee = DateTime.Now.Subtract(date).TotalDays;
            MessageBox.Show(datee.ToString());

        }
    }
}
