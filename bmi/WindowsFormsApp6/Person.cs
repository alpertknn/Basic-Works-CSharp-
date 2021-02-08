using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    
    class Person
    {
        public double height;
        public double weight;

        public Person()
        {
            height = 65;
            weight = 110;

        }
        public Person(double Height,double Weight)
        {
            this.height = Height;
            this.weight = Weight;

        }


        public double getBmiIndex()
        {
            double value;
            value = weight / (height * height) * 703;
            return value;
        }

    }
}
