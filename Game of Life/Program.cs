using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena a = new Arena();
            //choose character
            Console.WriteLine("Please choose your character ");
            Console.WriteLine("1.Swordsman");
            Console.WriteLine("2.Archer");


            bool ip = true;
            while (ip)
            {
                Console.Write("\nYour choose here :");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    a.Bertarung(c);
                    ip = false;
                }
                if (c == 2)
                {
                    a.Bertarung(c);
                    ip = false;

                }
                if (c <= 0 || c > 2)
                {
                    Console.WriteLine("Input not included. please choose again.");

                }
            }

            Console.ReadKey();
        }
    }
}
