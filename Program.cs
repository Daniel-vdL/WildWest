using System;

namespace WildWest
{
    internal class Program
    {

        public static Player currentPlayer = new Player();

        public static List<Enemies> EnemyList = new List<Enemies>
        {
            new Enemies("One shot Bill", 15, 100, 5),
            new Enemies("George", 15, 150, 5),
        };

        public static List<Npc> NpcList = new List<Npc>()
        {
            new Npc("Jason", 50, 100, 10),
            new Npc("Dead Eye Jake", 15, 150, 5),
            new Npc("Joe Rudeboy", 500, 5, 999),
        };

        static void Main(string[] args)
        {
            Start();
            
            //Starts Encounter1
            var encounter1 = new Encounters();
            encounter1.Name = "Battle";
            encounter1.EnemyName = Program.EnemyList[0].Name;
            encounter1.EnemyHealth = Program.EnemyList[0].Health;
            encounter1.EnemyPower = Program.EnemyList[0].Damage;
            encounter1.DidPlayerRun = "";
            Console.WriteLine("Encounter!");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            encounter1.Combat();

            if (currentPlayer.Health > 0 && encounter1.DidPlayerRun == "")
            {
                //Starts Scene1
                Scenes.Scene1();
            }
            else if (encounter1.DidPlayerRun == "yes")
            {
                Scenes.Scene1Fled();
            }
            else
            {

                Console.WriteLine("You died!");
                return;
            }
        }

        static void Start()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("~~WildWest Adventure~~");
            Console.ResetColor();
            Console.WriteLine("Please enter a Name:");
            currentPlayer.Name = Console.ReadLine();
            Console.Clear();
            
            if (currentPlayer.Name == "")
            {
                Console.WriteLine("You don't have a name? Strange...");
                Console.WriteLine("I guess we will name you Nameless Noob");
                currentPlayer.Name = "Nameless Noob";
            }
            else
            {
                Console.WriteLine($"Your name is {currentPlayer.Name}");
            }
            
            Console.ReadKey();

        }
    }
}