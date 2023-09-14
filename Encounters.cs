using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Encounters
    {
        static Random rand = new Random();

        public static void Encounter1() 
        {
            Console.WriteLine("Encounter!");
            Console.ReadKey();
            Combat(false, "Cowboy", 1, 4);
        }


        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if(random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (health > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)un    (E)eat   |");
                Console.WriteLine("=====================");
                Console.WriteLine("Health: " + Program.currentPlayer.Health +"Whiskey Bottles: " + Program.currentPlayer.WhiskeyBottles);
                string input = Console.ReadLine();
                if(input.ToLower() == "a"|| input.ToLower() == "attack") 
                { 
                    //attack
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                }
                else if(input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                }
                else if(input.ToLower() == "e" || input.ToLower() == "eat")
                {
                    //Eat
                }
            }
        }
    }
}
