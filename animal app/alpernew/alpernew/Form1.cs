using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alpernew
{
    public partial class Form1 : Form
    {
        string name;
        string gender;
        int age;
        string species;
        int counter;

        Animals[] animal = new Animals[100];
        public Form1()
        {

           
            InitializeComponent();
            gendercomboBox.Items.Add("Female");
            gendercomboBox.Items.Add("Male");
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void speciestextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            name = nametextBox.Text.ToString();
            species = speciestextBox.Text.ToString();
            age = int.Parse(agetextBox.Text);
            gender = gendercomboBox.Text.ToString();
            counter = 0;
            string animalss = "";
            animal[counter] = new Animals(name,gender,age,species);
            animalss = animal[counter].name + " " + animal[counter].species;
            animalscomboBox.Items.Add(animalss);
            nametextBox.Text = "";
            speciestextBox.Text = "";
            agetextBox.Text = "";
            

        }
        private void animalscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            soundlabel.Text = animal[counter].Sound();
            resultlabel.Text = "Name: " + name + "\nSpecies: " + species + "\nGender: " + gender + "\nAge: " + age;
        }
        private void soundlabel_Click(object sender, EventArgs e)
        {

        }

        private void resultlabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
