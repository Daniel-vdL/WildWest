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

            string choice = "";

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
                Console.WriteLine($"Welcome to the WildWest {Program.currentPlayer.Name}!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Your name is {Program.currentPlayer.Name}");
                Console.WriteLine("Not the name I would have picked but... it will do.");
                Console.WriteLine("");
                Console.WriteLine($"Welcome to the WildWest {Program.currentPlayer.Name}!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("You are a cowboy that just woke up in a busy saloon.");
            Console.WriteLine("The bar tender looks at you.");
            Console.WriteLine($"Bar tender: 'Are you alright {Program.currentPlayer.Name}?'");
            Console.WriteLine("Bar tender: 'You look like you drank too much.'");
            Console.WriteLine("");
            Console.WriteLine("As you slowly get up you notice that a bandit walked in and is looking straight at you.");
            Console.WriteLine($"???: 'I will kill you for kissing my wife {Program.currentPlayer.Name}!'");
            Console.WriteLine("");
            Console.WriteLine("[A] 'What is your name pal?' [B] 'Get out of my face you weirdo' [C] Give him a hug ");
            Console.WriteLine("Please choose an option:");
            choice = Console.ReadLine();
            if (choice.ToLower() == "a")
            {
                Console.Clear();
                Console.WriteLine($"{Program.currentPlayer.Name}: 'What is your name pal?'");
                Console.WriteLine($"???: 'The name is {Program.enemyList[0].Name}.'");
                Console.WriteLine($"{Program.enemyList[0].Name}: 'Now lets fight.'");

            }
            else if (choice.ToLower() == "b")
            {
                Console.Clear();
                Console.WriteLine($"{Program.currentPlayer.Name}: 'Get out of my face you weirdo'");
                Console.WriteLine("The bandit looks confused and a little hurt.");
                Console.WriteLine("The bandit takes 5 points of emotional damage.");
                Program.enemyList[0].Health -= 5;
                Console.WriteLine($"{Program.enemyList[0].Name}: 'Emotional damage?!'");
                Console.WriteLine($"{Program.enemyList[0].Name}: 'Whatever, I will still end you!'");
            }
            else if (choice.ToLower() == "c")
            {
                Console.Clear();
                Console.WriteLine("You walk up to the bandit and give him a hug.");
                Console.WriteLine("The bandit gets angry and stabs you.");
                Console.WriteLine("You fall down and everything slowly starts to fade away...");
                Program.currentPlayer.Health = 0;
            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();

        }

        public static void Scene1()
        {
            Console.WriteLine($"You defeated {Program.enemyList[0].Name}! ");
            
        }
        public static void Scene1Fled() 
        {
            Console.WriteLine($"You ran away from {Program.enemyList[0].Name}. ");
        }
    }
}
