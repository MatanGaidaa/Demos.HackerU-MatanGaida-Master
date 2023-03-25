using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.ZooProgram
{
    public class Mammal : Animal, IAnimalBehavior
    {
        public int NumberOfLegs { get; set; }

        public Mammal() : base()
        {
            NumberOfLegs = 0;
        }
        public Mammal(int numberOfLegs, string name, int age, double weight) : base(name, age, weight)
        {
            NumberOfLegs = numberOfLegs;
        }

        public string Nurse()
        {
            return "Nursing...";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mammal making sound");
        }

        public string Eat()
        {
            return "Eating...";
        }

        public string Sleep()
        {
            return "Sleeping...";
        }

        public string Play()
        {
            return "Playing...";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, NumberOfLegs :{NumberOfLegs}";
        }
    }
}
