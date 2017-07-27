using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Arena
    {
        Monster e = new Monster();
        Swordsman s = new Swordsman();
        Archer a = new Archer();

        public void Bertarung(int i)
        {
                     
            if (i == 1)
            {
                Console.WriteLine("\nYour character is : ");
                Console.WriteLine("Swordsman.");

                int round = 1;

                while (s.health > 0 && e.Healt > 0)
                {
                    Console.WriteLine("\n======CURRENT STATUS=====");
                    Console.WriteLine("---------Swordsman---------");
                    Console.WriteLine("HP   : {0}", s.health);
                    Console.WriteLine("Mana : {0}", s.mana);
                    Console.WriteLine("----------Monster----------");
                    Console.WriteLine("HP   : {0}", e.Healt);
                    Console.WriteLine("Mana : {0}", e.Manna);
                    Console.WriteLine("\n BATTLE START : ROUND {0}", round);
                    Console.WriteLine("\n Swordsman Turn.");
                    Console.WriteLine("1.Attack");
                    Console.WriteLine("2.CrossSword");
                    Console.WriteLine("3.Heal");
                    Console.WriteLine("4.Charged Mana");
                    Console.WriteLine("Choose : ");
                    int pilih = int.Parse(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Swordsman : Attack ");
                        s.Attack(e);
                    }
                    if (pilih == 2)
                    {
                        Console.WriteLine("Swordsman : CrossSword ");
                        s.CrossSword(e);
                    }
                    if (pilih == 3)
                    {
                        Console.WriteLine("Swordsman : Heal");
                        s.Heal();
                    }
                    if (pilih == 4)
                    {
                        Console.WriteLine("Mana charged success.");
                        s.ChargedMana();
                    }
                    Console.WriteLine("\n Monster Turn.");
                    e.Attack(s);
                    round++;
                }
                if (s.health <= 0 && e.Healt > 0)
                {
                    Console.WriteLine("You Lose..:'(");
                    Console.ReadKey();
                }
                else if (s.health > 0 && e.Healt <= 0)
                {
                    Console.WriteLine("You Win");
                    Console.ReadKey();
                }
                else if (s.health <= 0 && e.Healt <= 0)
                {
                    Console.WriteLine("Draw");
                    Console.ReadKey();
                }

                round++;
            }
            else
            {
                Console.WriteLine("\nYour character is : ");
                Console.WriteLine("Archer.");
                int round = 1;

                while (a.health > 0 && e.Healt > 0)
                {
                    Console.WriteLine("\n======CURRENT STATUS=====");
                    Console.WriteLine("-----------Archer----------");
                    Console.WriteLine("HP   : {0}", a.health);
                    Console.WriteLine("Mana : {0}", a.mana);
                    Console.WriteLine("----------Monster----------");
                    Console.WriteLine("HP   : {0}", e.Healt);
                    Console.WriteLine("Mana : {0}", e.Manna);
                    Console.WriteLine("\n BATTLE START : ROUND {0}", round);
                    Console.WriteLine("\n Archer Turn.");
                    Console.WriteLine("1.Attack");
                    Console.WriteLine("2.Attcak Range");
                    Console.WriteLine("3.Heal");
                    Console.WriteLine("4.Charged Mana");
                    Console.WriteLine("Choose : ");
                    int pilih = int.Parse(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Archer : Attack ");
                        a.Attack(e);
                    }
                    if (pilih == 2)
                    {
                        Console.WriteLine("Archer : Attack Range ");
                        a.AttackRange(e);
                    }
                    if (pilih == 3)
                    {
                        Console.WriteLine("Archer : Heal");
                        a.Heal();
                    }
                    if (pilih == 4)
                    {
                        Console.WriteLine("Mana charged success");
                        a.ChargedMana();
                    }
                    Console.WriteLine("\n Monster Turn.");
                    e.Attack(a);
                    round++;
                }
                if (a.health <= 0 && e.Healt > 0)
                {
                    Console.WriteLine("You Lose..:'(");
                    Console.ReadKey();
                }
                else if (a.health > 0 && e.Healt <= 0)
                {
                    Console.WriteLine("You Win");
                    Console.ReadKey();
                }
                else if (a.health <= 0 && e.Healt <= 0)
                {
                    Console.WriteLine("Draw");
                    Console.ReadKey();
                }

                round++;
            }
        }
        }
    }

