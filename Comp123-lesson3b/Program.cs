using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: Demo for lesson 9
 * Version: 0.9 - Implemented the AntiHero class
*/

namespace Comp123_lesson3b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine();
            Console.WriteLine("Karma: " + superHero.Karma);
            Console.WriteLine();

            SuperVillain superVillain = new SuperVillain("SuperVillain Dude", 20);
            superVillain.AddPower("Shadow Casting", 50);
            superVillain.AddPower("Mind Control", 40);
            superVillain.AddPower("Combat Senses", 30);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine();
            Console.WriteLine("Malice: " + superVillain.Malice);

            AntiHero batman = new AntiHero("Batman", 20, 20);
            batman.AddPower("Super Intelligence", 50);
            Console.WriteLine(batman.ToString());
            Console.WriteLine();
            Console.WriteLine("Karma: " + batman.Karma);
            Console.WriteLine("Malice: " + batman.Malice);


            if (superHero is SuperHero)
            {
                Console.WriteLine("SuperHero is a SuperHuman");
            }
            if (superHero is Human)
            {
                Console.WriteLine("SuperHero is a Human");
            }
            if (superHero is object)
            {
                Console.WriteLine("SuperHero is a object");
            }
            if (superHero is IHasKarma)
            {
                Console.WriteLine("SuperHero has Karma");
            }
        }
    }
}
