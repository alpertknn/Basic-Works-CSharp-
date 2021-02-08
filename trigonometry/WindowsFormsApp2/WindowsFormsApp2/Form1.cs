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
            this.AutoSize=true;
        }
        Random randobj = new Random();
        int sum = 180;
        int anga, angb, angc;
        string output = "";
        private void generate_Click(object sender, EventArgs e)
        {
            anga =randnum(178);
            angb = randnum(sum-(anga+1));
            angc = 180 - anga - angb;
            angA.Text = anga.ToString();
            angB.Text = angb.ToString();
            angC.Text = angc.ToString();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (int.TryParse(angA.Text, out anga) && int.TryParse(angB.Text, out angb) && int.TryParse(angC.Text, out angc) && anga + angb + angc == 180&&anga>0 && angb > 0 && angc > 0)
            {
                resultlabel.Text = "Sina=" + Math.Round(Math.Sin(anga), 2) + "  Cosa=" + Math.Round(Math.Cos(anga), 2) + "  Tana=" + Math.Round(Math.Tan(anga), 2) +
                    "   Cota=" + Math.Round(1 / Math.Tan(anga), 2)+ "\nSinb=" + Math.Round(Math.Sin(angb), 2)+ 
                    "  Cosb=" + Math.Round(Math.Cos(angb), 2)+ "  Tanb=" + Math.Round(Math.Tan(angb), 2) + "  Cotb=" + Math.Round(1 / Math.Tan(angb), 2)+
                    "\nSinc=" + Math.Round(Math.Sin(angc), 2) + "  Cosc=" + Math.Round(Math.Sin(angc), 2) + "  Tanc=" + Math.Round(Math.Sin(angc), 2) + "   Cotc=" + Math.Round(1 / Math.Sin(angc), 2);
                    
                   
                    




            }
            else
            {
                resultlabel.Text = "Invalid Triangle";
            }
            
        }


        private void resultlabel_Click(object sender, EventArgs e)
        {

        }
        public int randnum(int max)
        {
            
            return randobj.Next(1,max);

        }
    }
}



