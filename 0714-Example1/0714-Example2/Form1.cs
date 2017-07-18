using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLib;

namespace _0714_Example2
{
    public partial class Form1 : Form
    {
        public Pokemon aPokemon;
        public int UserStarDust;
        public int UserCandy;

        public Form1()
        {
            InitializeComponent();
            UserStarDust = 100000;
            UserCandy = 1234;
            aPokemon = new Pokemon()
            {
                pname = "妙娃種子",
                gender = "Male",
                hp_max = 60,
                hp_now = 60,
                pheight = 5.94f,
                Types = new string[] { "草", "毒" },
                pweight = 0.76f,
                PowerUpCandy = 3,
                PowerUpstardust = 3000,
                EvolveCandy = 25
            };
            nameLabel.Text = aPokemon.pname;
            HpLabel.Text = aPokemon.hp_now.ToString() + "/" + aPokemon.hp_max + "HP";
            TypesLabel.Text = aPokemon.Types[0] + "/" + aPokemon.Types[1];
            WeightLabel.Text = aPokemon.pweight.ToString();
            HeightLabel.Text = aPokemon.pheight.ToString();
            PowerUpCandyLabel.Text = aPokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = aPokemon.PowerUpstardust.ToString();
            EvolveCandyLabel.Text = aPokemon.EvolveCandy.ToString();
            UserCandyLabel.Text = aPokemon.UserCandy.ToString();
            UserStardustLabel.Text = aPokemon.UserStardust.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - aPokemon.PowerUpCandy;
            UserStarDust = UserStarDust - aPokemon.PowerUpstardust;
            aPokemon.hp_max = aPokemon.hp_max + 10;
            aPokemon.hp_now = aPokemon.hp_now + 10;
            HpLabel.Text = aPokemon.hp_now.ToString() + "/" + aPokemon.Hp + "HP";
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }
    }
}