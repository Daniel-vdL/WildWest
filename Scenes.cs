using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Scenes
    {
        static Random rand = new Random();

        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("~~WildWest Adventure~~");
            Console.ResetColor();
            Console.WriteLine("Please enter a Name:");
            Program.currentPlayer.Name = Console.ReadLine();
            Console.Clear();

            if (Program.currentPlayer.Name == "")
            {
                Console.WriteLine("You don't have a name? Strange...");
                Console.WriteLine("I guess we will name you Nameless Noob");
                Program.currentPlayer.Name = "Nameless Noob";
                Console.WriteLine("");


            }
            else
            {
                Console.WriteLine($"Your name is {Program.currentPlayer.Name}");
            }

            Console.ReadKey();

        }

        public static void Scene1()
        {
            Console.WriteLine($"You defeated {Program.EnemyList[0].Name}! ");
        }
        public static void Scene1Fled() 
        {
            Console.WriteLine($"You ran away from {Program.EnemyList[0].Name}. ");
        }
    }
}
