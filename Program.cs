using System;

namespace WildWest
{
    internal class Program
    {

        public static Player currentPlayer = new Player();

        //Create List of Enemies
        public static List<Enemies> enemyList = new List<Enemies>
        {
            new Enemies("One shot Bill", 15, 100, 5),
            new Enemies("George", 15, 150, 5),
        };

        //Create List of Npcs
        public static List<Npc> npcList = new List<Npc>()
        {
            new Npc("Jason", 50, 100, 10),
            new Npc("Dead Eye Jake", 15, 150, 5),
            new Npc("Joe Rudeboy", 500, 5, 999),
        };

        static void Main(string[] args)
        {
            Scenes.Start();

            while (currentPlayer.Health > 0)
            {
                //Starts Encounter1
                var encounter1 = new Encounters();
                encounter1.Name = $"Battle Against {Program.enemyList[0].Name}";
                encounter1.EnemyName = Program.enemyList[0].Name;
                encounter1.EnemyHealth = Program.enemyList[0].Health;
                encounter1.EnemyPower = Program.enemyList[0].Damage;
                encounter1.DidPlayerRun = "";
                Console.WriteLine($"{encounter1.Name} Started!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();
                encounter1.Combat();

                if (encounter1.DidPlayerRun == "")
                {
                    //Starts Scene1
                    Scenes.Scene1();
                }
                else if (encounter1.DidPlayerRun == "yes")
                {
                    Scenes.Scene1Fled();
                }
            }
            Console.WriteLine("You died!");
            return;
        }
    }
}