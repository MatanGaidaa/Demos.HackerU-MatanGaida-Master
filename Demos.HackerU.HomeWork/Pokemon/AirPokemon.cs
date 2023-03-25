using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class AirPokemon : Pokemon
    {

        public int StormPower = 25;

        public AirPokemon() : base()
        {
            StormPower = 25;
        }

        public AirPokemon(int stormPower, string id, string name, int lifePower, int ammunitionPower) : base(id, name, lifePower, ammunitionPower)
        {
            StormPower = stormPower;
        }

        public void StormAttackHit(Pokemon otherPokemon)
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
                otherPokemon.LifePower -= 10;
                StormPower -= 5;
                LifePower -= 3;
                Console.WriteLine($"AirPokemon\nName :{Name}\nLifePower :{LifePower}\nAmmunitionPower :{AmmunitionPower}\n");
            }


        }


    }
}

