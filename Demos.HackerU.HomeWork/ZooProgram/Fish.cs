using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.ZooProgram
{
    public class Fish : Animal, IAnimalBehavior
    {
        public string TypeOfWater;
        public Fish() : base()
        {
            TypeOfWater = "No Type";
        }
        public Fish(string typeOfWater, string name, int age, double weight) : base(name, age, weight)
        {
            TypeOfWater = typeOfWater;
        }

        public string Swim()
        {
            return "swimming...";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fish making sound");
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
            return $"{base.ToString()}, TypeOfWater :{TypeOfWater}";
        }

    }
}
