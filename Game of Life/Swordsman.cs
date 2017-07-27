using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Swordsman : Novice
    {
        public  Swordsman()
        {
             health = 660;
             mana = 140;
        }
        public override void Attack(Monster enemy)
        {
            mana = mana - 10;
            Random ran = new Random();
            int serang = ran.Next(1, 2);
            if (serang == 1)
            {
                enemy.Healt = enemy.Healt - 45;
                Console.WriteLine("Good!");
            }
            else
            {
                Console.WriteLine("Oops! Miss..:'(");
            }
            
        }
        public void CrossSword(Monster enemy)
        {
            mana = mana - 15;
            Random ran = new Random();
            int serang = ran.Next(1, 2);
            if (serang == 1)
            {
                enemy.Healt = enemy.Healt - 75;
                Console.WriteLine("Good!");
            }
            else
            {
                Console.WriteLine("Oops! Miss..");
            }

        }
        public void Heal()
        {
            health = health + 15;
            mana = mana - 10;
        }
        public void ChargedMana()
        {
            mana = mana + 15;
        }
    }
}
