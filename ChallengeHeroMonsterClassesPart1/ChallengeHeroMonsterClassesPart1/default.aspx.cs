using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Huey";
            hero.Health = 100;
            hero.DamageMaximum = 10;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Donkey Kong";
            monster.Health = 100;
            monster.DamageMaximum = 10;
            monster.AttackBonus = true;

            Dice dice = new Dice();

            while (hero.Health > 0 & monster.Health > 0)
            {
                if (hero.AttackBonus)
                {
                    monster.Defend(hero.Attack(dice));
                }
                if (monster.AttackBonus)
                {
                    hero.Defend(monster.Attack(dice));
                }

                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                DisplayStats(hero, monster);
            }

        }

        private void DisplayStats(Character opponent1, Character opponent2)
        {
            if (opponent1.Health < 1 & opponent2.Health < 1)
            {
                resultLabel.Text += String.Format("{0} and {1} have both died!!!", opponent1.Name, opponent2.Name);
                return;
            }
            if (opponent1.Health < 1)
            {
                resultLabel.Text += String.Format("{0} defeats {1}", opponent2.Name, opponent1.Name);
                return;
            }
            if (opponent2.Health < 1)
            {
                resultLabel.Text += String.Format("{0} defeats {1}", opponent1.Name, opponent2.Name);
                return;
            }
            resultLabel.Text += String.Format("Name: {0} Health: {1} Maximum Damage: {2} Attack Bonus: {3}<br>", opponent1.Name, opponent1.Health, opponent1.DamageMaximum, opponent1.AttackBonus);
            resultLabel.Text += String.Format("Name: {0} Health: {1} Maximum Damage: {2} Attack Bonus: {3}<br><br>", opponent2.Name, opponent2.Health, opponent2.DamageMaximum, opponent2.AttackBonus);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.DamageMaximum;
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }

    class Dice
    {
        public int Sides { get; set; }
        Random random = new Random();
        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }
}