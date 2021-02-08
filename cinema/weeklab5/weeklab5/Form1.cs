using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weeklab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           string[] movie = {"Avengers","Kurt","Çakal","Aslan"};
           string[] day = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
           string[] session = new string[6];
            int counter = 10;
        for(int i = 0; i < session.Length; i++)
            {
                session[i] = counter + ":00";
                counter += 2;
            }

            moviecombobox.Items.AddRange(movie);
            daycombobox.Items.AddRange(day);
            sessioncombobox.Items.AddRange(session);


        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            
            string output = "";
            string name = nametextbox.Text.ToString();
            int age=int.TryParse(agetextbox.Text, out age) ? 0 : age;
            string phone = phonetextbox.Text.ToString();
            
            int price = 20;
            if (age < 20)
            {
                price = 15;
            }
            
            if (moviecombobox.SelectedIndex>-1&& daycombobox.SelectedIndex > -1 && sessioncombobox.SelectedIndex > -1)
            {
                string chosenmovie = moviecombobox.SelectedItem.ToString();
                string chosenday = daycombobox.SelectedItem.ToString();
                string chosensession = sessioncombobox.SelectedItem.ToString();
                output = "Hello" + name + "\nMovie" + chosenmovie + "\nDay:" + chosenday + "\nSession:" + chosensession + "\nPrice:"+price;
                DialogResult result = MessageBox.Show(output, "Do You Confirm?",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank You!!");
            }

            else
            {
                MessageBox.Show("Cancelled!!");
            }
            }

            
            

            
           
                
            


        }

        private void moviecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}






