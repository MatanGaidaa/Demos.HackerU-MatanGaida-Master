using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.ZooProgram
{
    public abstract class Animal
    {


        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal()
        {
            Name = string.Empty;
            Age = 0;
            Weight = 0;
        }

        protected Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Name :{Name}, Age :{Age},Weight :{Weight}";
        }
    }
}