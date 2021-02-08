using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alpernew
{
    class Animals
    {
        string Name;
        string Species;
        int Age;
        string Gender;


        public Animals()
        {
            this.name="";
            this.gender = "";
            this.age = 0;
            this.species = "";
        }
        public Animals(string name,string gender,int age,string species)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.species = species;


        }
        public string name
        {

            get
            {
                return Name;
            }
            set
            {
                this.Name = value;
            }

        }
        public string gender
        {
            get
            {
                return Gender;
            }
            set
            {
                this.Gender = value;
            }
        }
        public string species
        {

            get
            {
                return Species;
            }
            set
            {
                this.Species = value;
            }

        }

        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                if (age < 0)
                {
                    Age = -1;
                }
                else { 
                this.Age= value;
                }
            }
        }

        public string Sound()
        {
            string sound = "";
            if (this.species == "Cat")
            {
          
                return sound = "Meow";
                
            }
            if(this.species == "Dog")
            {
                return sound = "Hav";

            }
            if (this.species == "Alper")
            {
              return  sound = "Hav";

            }
            if (this.species == "Sheep")
            {
                return sound = "Meeeeee";
            }
            else
            {

                return sound = "Not Found!";

            }
            

        }



    }
}
