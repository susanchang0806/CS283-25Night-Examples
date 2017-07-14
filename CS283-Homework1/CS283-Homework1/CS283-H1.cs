using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLib;

namespace CS283H1{
    class Program    {
        static void Main(string[] args){
            Pokemon aPokemon = new Pokemon()
            {
                pname = "妙娃種子",
                gender = "Male",
                hp_now = 60,
                hp_max = 60,
                pweight = 5.94f,                
                pheight = 0.67f,
                pattribute = "草/毒",
                stardust = 2467813,
                candy = 12,
                skill1 = "藤鞭",
                skill1_power = 7,
                skill2 = "污泥炸彈",
                skill2_power = 80
            };
            Console.WriteLine(
                "名稱:{0}," +
                "性別:{1}," +
                "血量:{2}," +
                "總血量:{3}" +
                "體重:{4}," +
                "身高:{5}," +
                "屬性:{6}," +
                "星塵:{7}," +
                "糖果:{8}," +
                "技能1:{9}," +
                "技能1能量:{10}," +
                "技能2:{11}," +
                "技能2能量{12}:"
                , aPokemon.pname
                , aPokemon.gender
                , aPokemon.hp_now
                , aPokemon.hp_max
                , aPokemon.pweight
                , aPokemon.pheight
                , aPokemon.pattribute
                , aPokemon.stardust
                , aPokemon.candy
                , aPokemon.skill1
                , aPokemon.skill1_power
                , aPokemon.skill2
                , aPokemon.skill2_power
                );

        }
    }
}
