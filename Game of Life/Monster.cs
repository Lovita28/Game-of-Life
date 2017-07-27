using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Monster
    {
        private int _hp;
        private int _mp;

        public int Healt
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public int Manna
        {
            get { return _mp; }
            set { _mp = value; }
        }
        public Monster()
        {
            _hp = 740;
            _mp = 140;
        }

        public void Attack(Novice enemy)
        {
            _mp = _mp - 10;
            if (_mp <= 0)
            {
                _mp = 0;
            }
            Random rand = new Random();
            int ser = rand.Next(0, 5);
            if (ser == 1 || ser == 3)
            {
                Console.WriteLine("Monster Miss!");
            }
            else
            {
                enemy.health = enemy.health - 35;
                Console.WriteLine("Monster Hit!");
            }
            
        }

     }

}
    

