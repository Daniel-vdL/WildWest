using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class EncountersTest
    {
        static Random rand = new Random();

        public static void Encounter1() 
        {
            Console.WriteLine("Encounter!");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Bandit", 1, 4);
        }

        public static void Encounter2() 
        {
            Console.WriteLine("Encounter...?");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Jason", 5, 10);
        }

        //Combat Tool
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
            while (h > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine($"Power: {p} | Health: {h}");
                Console.WriteLine("");
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)un    (H)eal   |");
                Console.WriteLine("=====================");
                Console.WriteLine("");
                Console.WriteLine(Program.currentPlayer.Name);
                Console.WriteLine($"Health:  {Program.currentPlayer.Health} | Whiskey Bottles: {Program.currentPlayer.WhiskeyBottles}");
                
                string input = Console.ReadLine();
                if(input.ToLower() == "a"|| input.ToLower() == "attack") 
                {
                    //attack
                    Console.Clear();
                    Console.WriteLine($" You attack the {n} with your Pistol");
                    int damage = p - Program.currentPlayer.Armor;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.Damage) + rand.Next(1,4);
                    Console.WriteLine($"You lost {damage} health and deal {attack} damage!");
                    Program.currentPlayer.Health -= damage;
                    h -= attack;
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.Clear();
                }
                else if(input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    Console.Clear();
                    Console.WriteLine($"You throw a beer bottle in {n} face and you escape!");
                    Console.ReadKey();
                }
                else if(input.ToLower() == "e" || input.ToLower() == "eat")
                {
                    //Eat
                    Console.Clear();
                    Console.WriteLine("");
                    Console.ReadKey();
                }
            }
            while (health < 0) 
            {
            }
        }
    }
}
