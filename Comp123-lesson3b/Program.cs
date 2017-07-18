using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: Demo for lesson 9
 * version: 0.4 - Implemented the SuperHero Class
*/

namespace Comp123_lesson3b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperDude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Web Casting", 40);
            superHero.AddPower("Phasing", 50);
            superHero.AddPower("Invisibility", 30);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
            Console.WriteLine();

            SuperVillain superVillain = new SuperVillain("Buff Dude", 34);
            superVillain.AddPower("Fireballs", 10);
            superVillain.AddPower("Stinkbreath", 45);
            superVillain.AddPower("Blinding smoke", 20);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice: " + superVillain.Malice);

        }
    }
}
