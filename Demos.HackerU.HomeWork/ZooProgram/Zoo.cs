using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.ZooProgram
{
    public class Zoo
    {
        public Animal[] Animals { get; set; }
        private int Count { get; set; }

        public Zoo()
        {
            Animals = new Animal[100];
            Count = 0;
        }

        public void AddAnimal(Animal animal)
        {
            if (Count < 100)
            {
                Animals[Count] = animal;
                Count++;
            }
        }
    }
}
