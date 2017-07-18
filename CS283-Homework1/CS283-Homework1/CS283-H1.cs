using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLib;

namespace CS283H1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon aPokemon = new Pokemon()
            {
                pname = "妙娃種子",
                gender = "Male",
                hp_now = 60,
                hp_max = 60,
                pweight = 5.94f,
                pheight = 0.67f,
                Types = new String[2],
                Types[0] = "草",
                Types[1] = "毒",
                PowerUpstardust = 3000,
                PowerUpCandy = 3
            };
        }
    }
}