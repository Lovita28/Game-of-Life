using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Archer : Novice
    {
        public  Archer()
        {
             health = 400;
             mana = 270;
        }
        public override void Attack(Monster enemy)
        {
            mana = mana - 10;
            Random rann = new Random();
            int at = rann.Next(0, 5);
            if (at == 2 || at == 4)
            {
                Console.WriteLine("Oops ..Miss :'(");
            }
            else
            {
                enemy.Healt = enemy.Healt - 20;
                Console.WriteLine("Good!");
            }
           
        }
        public void AttackRange(Monster enemy)
        {
            mana = mana - 15;
            Random rann = new Random();
            int at = rann.Next(0, 5);
            if (at == 2 || at == 4)
            {
                Console.WriteLine("Oops ..Miss :'(");
            }
            else
            {
                enemy.Healt = enemy.Healt - 65;
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
