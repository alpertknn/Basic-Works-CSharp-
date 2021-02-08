using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Money money;
        public Form1()
        {
            InitializeComponent();
            CurrencycomboBox.Items.Clear();
            CurrencycomboBox.Items.Add("TL");
            CurrencycomboBox.Items.Add("EURO");
            CurrencycomboBox.Items.Add("USD");

        }

        private void CurrencycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BalancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmounttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {

            
            
                if (String.IsNullOrWhiteSpace(BalancetextBox.Text)|| CurrencycomboBox.SelectedIndex <= -1)
                {
                    MessageBox.Show("One of the box is empty!!!");

                }
                else
                {


                    string cur = CurrencycomboBox.SelectedItem.ToString();
                    int bal = int.Parse(BalancetextBox.Text);
                    money = new Money(bal, cur);
                    CurrencycomboBox.Enabled = false;
                    BalancetextBox.Enabled = false;
                    Createbutton.Enabled = false;
                    resultlabel.Text = "Balance:" + money.show();
                }
            
   
            
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(AmounttextBox.Text);
            int newbal = money.depositMoney(amount);
            resultlabel.Text = "Balance:" + money.show();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(AmounttextBox.Text);
            int newbal = money.withdrawMoney(amount);
            resultlabel.Text = "Balance:" + money.show();

        }

        private void resultlabel_Click(object sender, EventArgs e)
        {

        }
    }
}



