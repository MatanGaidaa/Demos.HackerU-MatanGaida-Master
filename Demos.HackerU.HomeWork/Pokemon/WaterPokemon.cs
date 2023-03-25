using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class WaterPokemon : Pokemon
    {
        public int ElectricPower = 20;


        public WaterPokemon() : base()
        {
            ElectricPower = 20;

        }

        public WaterPokemon(int electricPower, string id, string name, int lifePower, int ammunitionPower) : base(id, name, lifePower, ammunitionPower)
        {
            ElectricPower = electricPower;
        }

        public void ElectricAttackHit(Pokemon otherPokemon)
        {
            if (LifePower <= 0)
            {
                Console.WriteLine($"*******{Name} die!*******");
                Console.WriteLine($"LifePower :{LifePower}\n");
            }
            else if (otherPokemon.LifePower <= 0)
            {
                Console.WriteLine($"******{Name} win!*******");
                Console.WriteLine($"LifePower :{LifePower}\n");
            }
            else
            {
                if (AmmunitionPower <= 0)
                {
                    Console.WriteLine("No Ammunition Power");
                }


                otherPokemon.LifePower -= 20;
                ElectricPower -= 8;
                LifePower -= 4;
                Console.WriteLine($"WaterPokemon\nName :{Name}\nLifePower :{LifePower}\nAmmunitionPower :{AmmunitionPower}\n");
            }


        }

    }
}
