using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Linlin Fan
 * Date: July 13, 2017
 * Description: Lab24 for Lesson 9
 * Version: 0.8 - Modified Driver class to implement SuperHero
 */

namespace COMP123_S2017_Lesson10A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());

            SuperVillain superVillain = new SuperVillain("Super Dude LV2", 20);
            superVillain.AddPower("Spider Climbing LV2", 50);
            superVillain.AddPower("Webcasting LV2", 40);
            Console.WriteLine(superVillain.ToString());

            if (superHero is SuperHero)
            {
                Console.WriteLine("super dude is definitely a superhero!");
            }
            else
            {
                Console.WriteLine("super dude is not a hero!");
            }
        }
    }
}
