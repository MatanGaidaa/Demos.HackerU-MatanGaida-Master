using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.ZooProgram
{
    public class Bird : Animal, IAnimalBehavior
    {
        public double Wingspan { get; set; }
        public Bird() : base()
        {
            Wingspan = 0;
        }

        public Bird(double wingspan, string name, int age, double weight) : base(name, age, weight)
        {
            Wingspan = wingspan;
        }

        public string Fly()
        {
            return "flying...";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird making sound");
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
            return $"{base.ToString()}, Wingspan :{Wingspan}";
        }
    }
}
