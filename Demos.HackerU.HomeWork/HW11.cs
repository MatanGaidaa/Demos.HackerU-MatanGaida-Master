using Demos.HackerU.HomeWork.ZooProgram;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork
{
    public class HW11
    {

        public static void Run()
        {
            Zoo zoo = new Zoo();

            Mammal mammal1 = new Mammal(4, "Elephant", 10, 2000);
            Mammal mammal2 = new Mammal(4, "Lion", 5, 500);
            Bird bird1 = new Bird(2.5, "Eagle", 3, 5);
            Fish fish1 = new Fish("Freshwater", "Salmon", 1, 0.5);

            zoo.AddAnimal(mammal1);
            zoo.AddAnimal(mammal2);
            zoo.AddAnimal(bird1);
            zoo.AddAnimal(fish1);

            Console.WriteLine(Zookeeper.FeedAnimals(zoo.Animals));
            foreach (Animal animal in zoo.Animals)
            {
                if (animal != null)
                {
                    Console.WriteLine(animal);
                }

            }

            //Console.WriteLine(mammal1.Eat());
        }
    }
}
