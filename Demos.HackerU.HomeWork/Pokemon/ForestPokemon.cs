using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Pokemon
{
    public class ForestPokemon : Pokemon
    {
        public int WoodsPower = 30;

        public ForestPokemon() : base()
        {
            WoodsPower = 30;
        }
        public ForestPokemon(int woodsPower, string id, string name, int lifePower, int ammunitionPower) : base(id, name, lifePower, ammunitionPower)
        {
            WoodsPower = woodsPower;
        }
        public void WoodsAttackHit(Pokemon otherPokemon)
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

                otherPokemon.LifePower -= 8;
                WoodsPower -= 3;
                Console.WriteLine($"ForestPokemon\nName :{Name}\nLifePower :{LifePower}\nAmmunitionPower :{AmmunitionPower}\n");
            }

        }



    }
}
